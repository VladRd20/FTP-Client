﻿namespace FTP_Client
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.IPTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.StatusLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.DemoButton = new Guna.UI2.WinForms.Guna2Button();
            this.Uploadbutton = new Guna.UI2.WinForms.Guna2Button();
            this.Logoutbutton = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.DownloadAllButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // IPTextBox
            // 
            this.IPTextBox.Animated = true;
            this.IPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IPTextBox.DefaultText = "";
            this.IPTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IPTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IPTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IPTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IPTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IPTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IPTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IPTextBox.Location = new System.Drawing.Point(12, 12);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.PasswordChar = '\0';
            this.IPTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.IPTextBox.PlaceholderText = "IP/Host";
            this.IPTextBox.SelectedText = "";
            this.IPTextBox.Size = new System.Drawing.Size(411, 26);
            this.IPTextBox.TabIndex = 0;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginTextBox.DefaultText = "";
            this.LoginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginTextBox.Location = new System.Drawing.Point(12, 44);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PasswordChar = '\0';
            this.LoginTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.LoginTextBox.PlaceholderText = "Login";
            this.LoginTextBox.SelectedText = "";
            this.LoginTextBox.Size = new System.Drawing.Size(188, 26);
            this.LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(235, 44);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(188, 26);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.LoginButton.BorderRadius = 1;
            this.LoginButton.BorderThickness = 2;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.White;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.DimGray;
            this.LoginButton.Location = new System.Drawing.Point(682, 12);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(106, 45);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Location = new System.Drawing.Point(427, 49);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(90, 15);
            this.StatusLabel.TabIndex = 7;
            this.StatusLabel.Text = "Connection Status";
            // 
            // FileListBox
            // 
            this.FileListBox.AllowDrop = true;
            this.FileListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FileListBox.FormattingEnabled = true;
            this.FileListBox.Location = new System.Drawing.Point(0, 316);
            this.FileListBox.Name = "FileListBox";
            this.FileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.FileListBox.Size = new System.Drawing.Size(800, 134);
            this.FileListBox.TabIndex = 8;
            this.FileListBox.DoubleClick += new System.EventHandler(this.FileListBox_DoubleClick);
            // 
            // DemoButton
            // 
            this.DemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DemoButton.BackColor = System.Drawing.Color.Transparent;
            this.DemoButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DemoButton.BorderRadius = 1;
            this.DemoButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.DemoButton.BorderThickness = 2;
            this.DemoButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DemoButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DemoButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DemoButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DemoButton.FillColor = System.Drawing.Color.White;
            this.DemoButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DemoButton.ForeColor = System.Drawing.Color.DimGray;
            this.DemoButton.Location = new System.Drawing.Point(570, 265);
            this.DemoButton.Name = "DemoButton";
            this.DemoButton.Size = new System.Drawing.Size(106, 45);
            this.DemoButton.TabIndex = 9;
            this.DemoButton.Text = "Demo";
            this.DemoButton.Click += new System.EventHandler(this.DemoButton_Click);
            // 
            // Uploadbutton
            // 
            this.Uploadbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Uploadbutton.BackColor = System.Drawing.Color.Transparent;
            this.Uploadbutton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Uploadbutton.BorderRadius = 1;
            this.Uploadbutton.BorderThickness = 2;
            this.Uploadbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Uploadbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Uploadbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Uploadbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Uploadbutton.FillColor = System.Drawing.Color.White;
            this.Uploadbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Uploadbutton.ForeColor = System.Drawing.Color.DimGray;
            this.Uploadbutton.Location = new System.Drawing.Point(682, 63);
            this.Uploadbutton.Name = "Uploadbutton";
            this.Uploadbutton.Size = new System.Drawing.Size(106, 45);
            this.Uploadbutton.TabIndex = 10;
            this.Uploadbutton.Text = "Upload";
            this.Uploadbutton.Click += new System.EventHandler(this.Uploadbutton_Click);
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logoutbutton.BackColor = System.Drawing.Color.Transparent;
            this.Logoutbutton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Logoutbutton.BorderRadius = 1;
            this.Logoutbutton.BorderThickness = 2;
            this.Logoutbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Logoutbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Logoutbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Logoutbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Logoutbutton.FillColor = System.Drawing.Color.White;
            this.Logoutbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Logoutbutton.ForeColor = System.Drawing.Color.DimGray;
            this.Logoutbutton.Location = new System.Drawing.Point(682, 265);
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.Size = new System.Drawing.Size(106, 45);
            this.Logoutbutton.TabIndex = 11;
            this.Logoutbutton.Text = "Logout";
            this.Logoutbutton.Click += new System.EventHandler(this.Logoutbutton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DeleteButton.BorderRadius = 1;
            this.DeleteButton.BorderThickness = 2;
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.FillColor = System.Drawing.Color.White;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.DimGray;
            this.DeleteButton.Location = new System.Drawing.Point(682, 114);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(106, 45);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DownloadAllButton
            // 
            this.DownloadAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadAllButton.BackColor = System.Drawing.Color.Transparent;
            this.DownloadAllButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DownloadAllButton.BorderRadius = 1;
            this.DownloadAllButton.BorderThickness = 2;
            this.DownloadAllButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DownloadAllButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DownloadAllButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DownloadAllButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DownloadAllButton.FillColor = System.Drawing.Color.White;
            this.DownloadAllButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DownloadAllButton.ForeColor = System.Drawing.Color.DimGray;
            this.DownloadAllButton.Location = new System.Drawing.Point(682, 214);
            this.DownloadAllButton.Name = "DownloadAllButton";
            this.DownloadAllButton.Size = new System.Drawing.Size(106, 45);
            this.DownloadAllButton.TabIndex = 13;
            this.DownloadAllButton.Text = "Download All Selected";
            this.DownloadAllButton.Click += new System.EventHandler(this.DownloadAllButton_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DownloadAllButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Logoutbutton);
            this.Controls.Add(this.Uploadbutton);
            this.Controls.Add(this.DemoButton);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.IPTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Client FTP (Local)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox IPTextBox;
        private Guna.UI2.WinForms.Guna2TextBox LoginTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel StatusLabel;
        private System.Windows.Forms.ListBox FileListBox;
        private Guna.UI2.WinForms.Guna2Button DemoButton;
        private Guna.UI2.WinForms.Guna2Button Uploadbutton;
        private Guna.UI2.WinForms.Guna2Button Logoutbutton;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private Guna.UI2.WinForms.Guna2Button DownloadAllButton;
    }
}

