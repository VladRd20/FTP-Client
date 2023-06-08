namespace FTP_Client
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IPTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.ServerPortTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StatusLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FileListBox = new System.Windows.Forms.ListBox();
            this.DemoButton = new Guna.UI2.WinForms.Guna2Button();
            this.Uploadbutton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // IPTextBox
            // 
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
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.White;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.LoginButton.Location = new System.Drawing.Point(682, 12);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(106, 45);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServerPortTextBox.DefaultText = "21";
            this.ServerPortTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServerPortTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServerPortTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerPortTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServerPortTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerPortTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ServerPortTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerPortTextBox.Location = new System.Drawing.Point(429, 12);
            this.ServerPortTextBox.MaxLength = 5;
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.PasswordChar = '\0';
            this.ServerPortTextBox.PlaceholderText = "Port";
            this.ServerPortTextBox.SelectedText = "";
            this.ServerPortTextBox.Size = new System.Drawing.Size(139, 26);
            this.ServerPortTextBox.TabIndex = 6;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Location = new System.Drawing.Point(429, 44);
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
            this.FileListBox.Size = new System.Drawing.Size(800, 134);
            this.FileListBox.TabIndex = 8;
            this.FileListBox.DoubleClick += new System.EventHandler(this.FileListBox_DoubleClick);
            // 
            // DemoButton
            // 
            this.DemoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DemoButton.BackColor = System.Drawing.Color.Transparent;
            this.DemoButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DemoButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DemoButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DemoButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DemoButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DemoButton.FillColor = System.Drawing.Color.White;
            this.DemoButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DemoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DemoButton.Location = new System.Drawing.Point(682, 265);
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
            this.Uploadbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Uploadbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Uploadbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Uploadbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Uploadbutton.FillColor = System.Drawing.Color.White;
            this.Uploadbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Uploadbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Uploadbutton.Location = new System.Drawing.Point(682, 63);
            this.Uploadbutton.Name = "Uploadbutton";
            this.Uploadbutton.Size = new System.Drawing.Size(106, 45);
            this.Uploadbutton.TabIndex = 10;
            this.Uploadbutton.Text = "Upload";
            this.Uploadbutton.Click += new System.EventHandler(this.Uploadbutton_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Uploadbutton);
            this.Controls.Add(this.DemoButton);
            this.Controls.Add(this.FileListBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ServerPortTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.IPTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Client FTP local";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox IPTextBox;
        private Guna.UI2.WinForms.Guna2TextBox LoginTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextBox;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2TextBox ServerPortTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel StatusLabel;
        private System.Windows.Forms.ListBox FileListBox;
        private Guna.UI2.WinForms.Guna2Button DemoButton;
        private Guna.UI2.WinForms.Guna2Button Uploadbutton;
    }
}

