using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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
            StatusLabel.Text = "Nici o conexiune !";
            IPTextBox.KeyDown += TextBox_KeyDown;
            LoginTextBox.KeyDown += TextBox_KeyDown;
            PasswordTextBox.KeyDown += TextBox_KeyDown;
            IPTextBox.TextChanged += TextBox_TextChanged;
            LoginTextBox.TextChanged += TextBox_TextChanged;
            PasswordTextBox.TextChanged += TextBox_TextChanged;
            LoginButton.Enabled = false;
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

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            //If all of them are filled in, show the login button, else make it unclickable
            if (IPTextBox.Text != "" && LoginTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                LoginButton.Enabled = true;
            }
            else
            {
                LoginButton.Enabled = false;
            }
        }

        private Stack<string> directoryStack = new Stack<string>();


        private void ConnectionLabelHandler()
        {
            try
            {
                string ConnState = connection.CheckConnectionState();
                {
                    if (ConnState.ToString().StartsWith("150"))
                    {
                        StatusLabel.Text = "Conectat!";
                        StatusLabel.ForeColor = Color.Green;
                    }
                    else
                    {
                        StatusLabel.Text = "Deconectat!";
                        StatusLabel.ForeColor = Color.Red;
                    }
                    RefreshFileList();
                }
            }
            catch
            {
                MessageBox.Show("Conexiunea a esuat!");
                StatusLabel.Text = "Eroare la conectare!";
                StatusLabel.ForeColor = Color.Red;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            currentDirectory = "/";
            //This button will take the data from text boxes and send it to the server
            //The server will then check the data and send back a response
            string Username = LoginTextBox.Text;
            string Password = PasswordTextBox.Text;
            string ServerIP = IPTextBox.Text;
            //Start a thread to connect to the server
            connection = new FTPConnection(ServerIP, Username, Password);
            ConnectionLabelHandler();

            directoryStack.Clear(); // Clear the directory stack
            directoryStack.Push(currentDirectory); // Push the initial directory

            RefreshFileList();
        }

        private void RefreshFileList()
        {
            FileListBox.Items.Clear();
            FileListBox.Items.Add("/Back");

            if (IsConnected() == 0)
            {
                return;
            }

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
                    DialogResult result = MessageBox.Show("Vreti sa descarcati file-ul ?", "File Download", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Download the file to a temporary location
                        string remoteFilePath = currentDirectory + selectedFileName;

                        remoteFilePath = remoteFilePath.Remove(remoteFilePath.LastIndexOf('(') - 1);

                        // Prompt the user to select a folder to save the file
                        using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                        {
                            DialogResult folderResult = folderBrowserDialog.ShowDialog();

                            if (folderResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                            {
                                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                                string localFilePath = Path.Combine(selectedFolderPath, selectedFileName);
                                localFilePath = localFilePath.Remove(localFilePath.LastIndexOf('(') - 1);

                                // Download the file to the selected folder asynchronously
                                Task.Run(() => connection.DownloadFile(remoteFilePath, localFilePath));
                            }
                        }
                    }
                }
                catch (WebException ex)
                {
                    // Handle the exception and display an error message
                    MessageBox.Show("Eroare la accesarea file-ului: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException ex)
                {
                    // Handle the exception and display an error message
                    MessageBox.Show("Eroare la deschiderea file-ului: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    // Handle any other exceptions and display an error message
                    MessageBox.Show("Eroare: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DemoButton_Click(object sender, EventArgs e)
        {
            //Set the text boxes to the demo values
            LoginTextBox.Text = "demo";
            PasswordTextBox.Text = "demo";
            IPTextBox.Text = "demo.wftpserver.com";
        }

        private int IsConnected()
        {
            // Check if there is an active connection
            if (connection == null)
            {
                MessageBox.Show("Nu sunteti conectat la nici un server\nConectati-va inainte de a realiza careva operatiuni !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else return 1;
        }

        private async void Uploadbutton_Click(object sender, EventArgs e)
        {

            if (IsConnected() == 0)
                return;

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
                            MessageBox.Show("A aparut o eroare la incarcarea file-ului: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                });

                // Refresh the file list after the upload completes
                RefreshFileList();
            }
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {

            //If there is a connection, close it and reset the UI
            if (connection != null)
            {
                connection.Disconnect();
                connection = null;
                StatusLabel.Text = "Ati rupt conexiunea !";
                StatusLabel.ForeColor = Color.Gold;
                FileListBox.Items.Clear();

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //When clicked, delele the selected file. Ask for confirmation first.
            if (IsConnected() == 0)
                return;

            string selectedItem = FileListBox.SelectedItem as string;
            if (selectedItem != null && !IsDirectory(selectedItem))
            {
                string selectedFileName = selectedItem.Remove(selectedItem.LastIndexOf('(') - 1);


                DialogResult result = MessageBox.Show("Sunteti sigur ca doriti sa stergeti file-ul " + selectedFileName + " ?", "Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Delete the file using the FTP connection
                        connection.DeleteFile(currentDirectory + selectedFileName);

                        // Refresh the file list after the delete completes
                        RefreshFileList();
                    }
                    catch (WebException ex)
                    {
                        // Handle the exception and display an error message
                        MessageBox.Show("A aparut o eroare la stergerea file-ului: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DownloadAllButton_Click(object sender, EventArgs e)
        {
            if (IsConnected() == 0)
                return;

            // Prompt the user to select a destination folder
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult folderResult = folderBrowserDialog.ShowDialog();

                if (folderResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;

                    // Download all selected files to the destination folder asynchronously
                    Task.Run(() =>
                    {
                        foreach (string selectedItem in FileListBox.SelectedItems)
                        {
                            if (!IsDirectory(selectedItem))
                            {
                                string selectedFileName = selectedItem.Remove(selectedItem.LastIndexOf('(') - 1);

                                // Construct the remote file path
                                string remoteFilePath = currentDirectory + selectedFileName;

                                try
                                {
                                    // Construct the local file path
                                    string localFilePath = Path.Combine(selectedFolderPath, selectedFileName);

                                    // Download the file using the FTP connection
                                    connection.DownloadFile(remoteFilePath, localFilePath);
                                }
                                catch (WebException ex)
                                {
                                    // Handle the exception and display an error message
                                    MessageBox.Show("A aparut o eroare la descarcarea file-ului: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    });
                }
            }
        }
    }
}
