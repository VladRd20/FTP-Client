﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FTP_Client
{
    public partial class Form1 : Form
    {
        private FTPConnection connection;
        private string currentDirectory;

        public Form1()
        {
            InitializeComponent();
            StatusLabel.Text = "Not Connected";
            IPTextBox.KeyDown += TextBox_KeyDown;
            LoginTextBox.KeyDown += TextBox_KeyDown;
            PasswordTextBox.KeyDown += TextBox_KeyDown;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the pressed key is the Enter key
            if (e.KeyCode == Keys.Enter)
            {
                // Attempt login
                LoginButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private Stack<string> directoryStack = new Stack<string>();
        private void LoginButton_Click(object sender, EventArgs e)
        {

            currentDirectory = "/";
            //This button will take the data from text boxes and send it to the server
            //The server will then check the data and send back a response
            string Username = LoginTextBox.Text;
            string Password = PasswordTextBox.Text;
            string ServerIP = IPTextBox.Text;

            connection = new FTPConnection(ServerIP, Username, Password);
            StatusLabel.Text = connection.CheckConnectionState();

            directoryStack.Clear(); // Clear the directory stack
            directoryStack.Push(currentDirectory); // Push the initial directory

            RefreshFileList();
        }

        private void RefreshFileList()
        {
            FileListBox.Items.Clear();
            FileListBox.Items.Add("/Back");

            string[] files = connection.GetDirectoryList(currentDirectory);

            Array.Sort(files, (a, b) =>
            {
                bool isAFolder = IsDirectory(a);
                bool isBFolder = IsDirectory(b);

                if (isAFolder && !isBFolder)
                    return -1;
                if (!isAFolder && isBFolder)
                    return 1;

                return String.Compare(a, b, StringComparison.OrdinalIgnoreCase);
            });

            foreach (string file in files)
            {
                if (file == "/Back")
                    continue;

                string prefix = IsDirectory(file) ? "/" : "";
                string displayText = $"{prefix}{file}";

                if (!IsDirectory(file))
                {
                    string filePath = Path.Combine(currentDirectory, file);
                    long fileSize = connection.GetFileSize(filePath);
                    string formattedSize = FormatFileSize(fileSize); // Use the local FormatFileSize method
                    displayText += $" ({formattedSize})";
                }

                FileListBox.Items.Add(displayText);
            }
        }

        private string FormatFileSize(long size)
        {
            if (size < 1024)
                return $"{size} B";
            if (size < 1024 * 1024)
                return $"{size / 1024} KB";
            if (size < 1024 * 1024 * 1024)
                return $"{size / (1024 * 1024)} MB";

            return $"{size / (1024 * 1024 * 1024)} GB";
        }




        private bool IsDirectory(string item)
        {

            if (Path.GetExtension(item) != string.Empty)
            {
                // The item has a file extension, consider it a file
                return false;
            }

            // The item doesn't have a file extension, consider it a directory
            return true;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (currentDirectory.Length > 1) // Ensure it's not the root directory
            {
                // Remove the last directory from the current path
                currentDirectory = currentDirectory.Substring(0, currentDirectory.TrimEnd('/').LastIndexOf('/') + 1);

                RefreshFileList();
            }
        }

        private void FileListBox_DoubleClick(object sender, EventArgs e)
        {
            string selectedItem = FileListBox.SelectedItem as string;
            if (selectedItem != null && IsDirectory(selectedItem))
            {
                if (selectedItem == "/Back")
                {
                    // Handle the back button click
                    BackButton_Click(sender, e);
                }
                else
                {
                    string selectedDirectoryName = selectedItem;
                    currentDirectory = currentDirectory + selectedDirectoryName + "/";
                    RefreshFileList();
                }
            }
            else
            {
                try
                {
                    // Get the selected file name
                    string selectedFileName = selectedItem;

                    // Prompt the user to download and open the file
                    DialogResult result = MessageBox.Show("Do you want to download and open the file?", "File Download", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Download the file to a temporary location
                        string remoteFilePath = currentDirectory + selectedFileName;

                        remoteFilePath = remoteFilePath.Remove(remoteFilePath.LastIndexOf('(') - 1);
                        string localFilePath = Path.GetTempFileName();
                        connection.DownloadFile(remoteFilePath, localFilePath);

                        // Open the downloaded file
                        Process.Start(localFilePath);
                    }
                }
                catch (WebException ex)
                {
                    // Handle the exception and display an error message
                    MessageBox.Show("An error occurred while accessing the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException ex)
                {
                    // Handle the exception and display an error message
                    MessageBox.Show("An error occurred while opening the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Handle any other exceptions and display an error message
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DemoButton_Click(object sender, EventArgs e)
        {
            //Set the text boxes to the demo values
            LoginTextBox.Text = "admin";
            PasswordTextBox.Text = "vlad123123";
            IPTextBox.Text = "127.0.0.1";

        }

        private async void Uploadbutton_Click(object sender, EventArgs e)
        {

            // Check if there is an active connection

            if (connection == null )
            {
                MessageBox.Show("No active connection. Please connect first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                // Upload files asynchronously
                await Task.Run(() =>
                {
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        // Get the file name from the file path
                        string fileName = Path.GetFileName(filePath);

                        try
                        {
                            // Upload the file using the FTP connection
                            connection.UploadFile(filePath, currentDirectory + fileName);
                        }
                        catch (WebException ex)
                        {
                            // Handle the exception and display an error message
                            MessageBox.Show("An error occurred while uploading the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                });

                // Refresh the file list after the upload completes
                RefreshFileList();
            }
        }


    }
}
    
