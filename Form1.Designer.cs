namespace ProtocolCheck
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
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RoomIDLabel = new System.Windows.Forms.Label();
            this.RoomIDTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusShowToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveLoginDetailsCheckBox = new System.Windows.Forms.CheckBox();
            this.ConnectGroupBox = new System.Windows.Forms.GroupBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.ConnectionMessage1ListView = new System.Windows.Forms.ListView();
            this.ConnectionMessage4Label = new System.Windows.Forms.Label();
            this.ConnectionMessage4TextBox = new System.Windows.Forms.TextBox();
            this.ConnectionMessage3Label = new System.Windows.Forms.Label();
            this.ConnectionMessage2Label = new System.Windows.Forms.Label();
            this.ConnectionMessage1Label = new System.Windows.Forms.Label();
            this.ConnectionMessage3ListView = new System.Windows.Forms.ListView();
            this.NumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConnectionMessage2ListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProtocolVersion = new System.Windows.Forms.Label();
            this.CurrentProtocolVersionLabel = new System.Windows.Forms.Label();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.CurrentProtocolEEVersionlabel = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.LoginGroupBox.SuspendLayout();
            this.ConnectGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(13, 23);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(39, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "E-Mail:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(16, 39);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(114, 20);
            this.EmailTextBox.TabIndex = 0;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(13, 62);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(16, 78);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(114, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RoomIDLabel
            // 
            this.RoomIDLabel.AutoSize = true;
            this.RoomIDLabel.Location = new System.Drawing.Point(7, 25);
            this.RoomIDLabel.Name = "RoomIDLabel";
            this.RoomIDLabel.Size = new System.Drawing.Size(49, 13);
            this.RoomIDLabel.TabIndex = 4;
            this.RoomIDLabel.Text = "WorldID:";
            // 
            // RoomIDTextBox
            // 
            this.RoomIDTextBox.Enabled = false;
            this.RoomIDTextBox.Location = new System.Drawing.Point(10, 41);
            this.RoomIDTextBox.Name = "RoomIDTextBox";
            this.RoomIDTextBox.Size = new System.Drawing.Size(114, 20);
            this.RoomIDTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(16, 127);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(81, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Enabled = false;
            this.ConnectButton.Location = new System.Drawing.Point(10, 76);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(81, 23);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusTextToolStripStatusLabel,
            this.StatusShowToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(939, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusTextToolStripStatusLabel
            // 
            this.StatusTextToolStripStatusLabel.Name = "StatusTextToolStripStatusLabel";
            this.StatusTextToolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.StatusTextToolStripStatusLabel.Text = "Status:";
            // 
            // StatusShowToolStripStatusLabel
            // 
            this.StatusShowToolStripStatusLabel.ForeColor = System.Drawing.Color.Navy;
            this.StatusShowToolStripStatusLabel.Name = "StatusShowToolStripStatusLabel";
            this.StatusShowToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.SaveLoginDetailsCheckBox);
            this.LoginGroupBox.Controls.Add(this.EmailTextBox);
            this.LoginGroupBox.Controls.Add(this.EmailLabel);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.LoginButton);
            this.LoginGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginGroupBox.Location = new System.Drawing.Point(12, 36);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(149, 161);
            this.LoginGroupBox.TabIndex = 9;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login";
            // 
            // SaveLoginDetailsCheckBox
            // 
            this.SaveLoginDetailsCheckBox.AutoSize = true;
            this.SaveLoginDetailsCheckBox.Checked = true;
            this.SaveLoginDetailsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveLoginDetailsCheckBox.Location = new System.Drawing.Point(16, 104);
            this.SaveLoginDetailsCheckBox.Name = "SaveLoginDetailsCheckBox";
            this.SaveLoginDetailsCheckBox.Size = new System.Drawing.Size(109, 17);
            this.SaveLoginDetailsCheckBox.TabIndex = 15;
            this.SaveLoginDetailsCheckBox.Text = "Save login details";
            this.SaveLoginDetailsCheckBox.UseVisualStyleBackColor = true;
            this.SaveLoginDetailsCheckBox.CheckedChanged += new System.EventHandler(this.SaveLoginDetailsCheckBox_CheckedChanged);
            // 
            // ConnectGroupBox
            // 
            this.ConnectGroupBox.Controls.Add(this.RoomIDTextBox);
            this.ConnectGroupBox.Controls.Add(this.ConnectButton);
            this.ConnectGroupBox.Controls.Add(this.RoomIDLabel);
            this.ConnectGroupBox.Location = new System.Drawing.Point(18, 207);
            this.ConnectGroupBox.Name = "ConnectGroupBox";
            this.ConnectGroupBox.Size = new System.Drawing.Size(143, 117);
            this.ConnectGroupBox.TabIndex = 11;
            this.ConnectGroupBox.TabStop = false;
            this.ConnectGroupBox.Text = "Connect";
            // 
            // savebutton
            // 
            this.savebutton.Enabled = false;
            this.savebutton.Location = new System.Drawing.Point(513, 375);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 9;
            this.savebutton.Text = "Save Data";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ConnectionMessage1ListView
            // 
            this.ConnectionMessage1ListView.HideSelection = false;
            this.ConnectionMessage1ListView.Location = new System.Drawing.Point(170, 45);
            this.ConnectionMessage1ListView.Name = "ConnectionMessage1ListView";
            this.ConnectionMessage1ListView.Size = new System.Drawing.Size(160, 324);
            this.ConnectionMessage1ListView.TabIndex = 5;
            this.ConnectionMessage1ListView.UseCompatibleStateImageBehavior = false;
            this.ConnectionMessage1ListView.View = System.Windows.Forms.View.List;
            this.ConnectionMessage1ListView.SelectedIndexChanged += new System.EventHandler(this.ConnectionMessage1ListView_SelectedIndexChanged);
            // 
            // ConnectionMessage4Label
            // 
            this.ConnectionMessage4Label.AutoSize = true;
            this.ConnectionMessage4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionMessage4Label.Location = new System.Drawing.Point(663, 24);
            this.ConnectionMessage4Label.Name = "ConnectionMessage4Label";
            this.ConnectionMessage4Label.Size = new System.Drawing.Size(102, 13);
            this.ConnectionMessage4Label.TabIndex = 7;
            this.ConnectionMessage4Label.Text = "Object Contents:";
            // 
            // ConnectionMessage4TextBox
            // 
            this.ConnectionMessage4TextBox.Location = new System.Drawing.Point(666, 40);
            this.ConnectionMessage4TextBox.Multiline = true;
            this.ConnectionMessage4TextBox.Name = "ConnectionMessage4TextBox";
            this.ConnectionMessage4TextBox.ReadOnly = true;
            this.ConnectionMessage4TextBox.Size = new System.Drawing.Size(250, 329);
            this.ConnectionMessage4TextBox.TabIndex = 8;
            // 
            // ConnectionMessage3Label
            // 
            this.ConnectionMessage3Label.AutoSize = true;
            this.ConnectionMessage3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionMessage3Label.Location = new System.Drawing.Point(457, 24);
            this.ConnectionMessage3Label.Name = "ConnectionMessage3Label";
            this.ConnectionMessage3Label.Size = new System.Drawing.Size(115, 13);
            this.ConnectionMessage3Label.TabIndex = 5;
            this.ConnectionMessage3Label.Text = "Message Contents:";
            // 
            // ConnectionMessage2Label
            // 
            this.ConnectionMessage2Label.AutoSize = true;
            this.ConnectionMessage2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionMessage2Label.Location = new System.Drawing.Point(333, 24);
            this.ConnectionMessage2Label.Name = "ConnectionMessage2Label";
            this.ConnectionMessage2Label.Size = new System.Drawing.Size(107, 13);
            this.ConnectionMessage2Label.TabIndex = 4;
            this.ConnectionMessage2Label.Text = "Message Version:";
            // 
            // ConnectionMessage1Label
            // 
            this.ConnectionMessage1Label.AutoSize = true;
            this.ConnectionMessage1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionMessage1Label.Location = new System.Drawing.Point(167, 24);
            this.ConnectionMessage1Label.Name = "ConnectionMessage1Label";
            this.ConnectionMessage1Label.Size = new System.Drawing.Size(93, 13);
            this.ConnectionMessage1Label.TabIndex = 3;
            this.ConnectionMessage1Label.Text = "Message Type:";
            // 
            // ConnectionMessage3ListView
            // 
            this.ConnectionMessage3ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumberColumnHeader,
            this.TypeColumnHeader});
            this.ConnectionMessage3ListView.FullRowSelect = true;
            this.ConnectionMessage3ListView.HideSelection = false;
            this.ConnectionMessage3ListView.Location = new System.Drawing.Point(460, 40);
            this.ConnectionMessage3ListView.MultiSelect = false;
            this.ConnectionMessage3ListView.Name = "ConnectionMessage3ListView";
            this.ConnectionMessage3ListView.Size = new System.Drawing.Size(200, 329);
            this.ConnectionMessage3ListView.TabIndex = 7;
            this.ConnectionMessage3ListView.UseCompatibleStateImageBehavior = false;
            this.ConnectionMessage3ListView.View = System.Windows.Forms.View.Details;
            this.ConnectionMessage3ListView.SelectedIndexChanged += new System.EventHandler(this.ConnectionMessage3ListView_SelectedIndexChanged);
            // 
            // NumberColumnHeader
            // 
            this.NumberColumnHeader.Text = "#";
            this.NumberColumnHeader.Width = 53;
            // 
            // TypeColumnHeader
            // 
            this.TypeColumnHeader.Text = "Type";
            this.TypeColumnHeader.Width = 140;
            // 
            // ConnectionMessage2ListBox
            // 
            this.ConnectionMessage2ListBox.FormattingEnabled = true;
            this.ConnectionMessage2ListBox.Location = new System.Drawing.Point(336, 40);
            this.ConnectionMessage2ListBox.Name = "ConnectionMessage2ListBox";
            this.ConnectionMessage2ListBox.Size = new System.Drawing.Size(118, 329);
            this.ConnectionMessage2ListBox.TabIndex = 6;
            this.ConnectionMessage2ListBox.SelectedIndexChanged += new System.EventHandler(this.ConnectionMessage2ListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // lblProtocolVersion
            // 
            this.lblProtocolVersion.AutoSize = true;
            this.lblProtocolVersion.ForeColor = System.Drawing.Color.Navy;
            this.lblProtocolVersion.Location = new System.Drawing.Point(103, 358);
            this.lblProtocolVersion.Name = "lblProtocolVersion";
            this.lblProtocolVersion.Size = new System.Drawing.Size(13, 13);
            this.lblProtocolVersion.TabIndex = 17;
            this.lblProtocolVersion.Text = "0";
            // 
            // CurrentProtocolVersionLabel
            // 
            this.CurrentProtocolVersionLabel.AutoSize = true;
            this.CurrentProtocolVersionLabel.Location = new System.Drawing.Point(44, 358);
            this.CurrentProtocolVersionLabel.Name = "CurrentProtocolVersionLabel";
            this.CurrentProtocolVersionLabel.Size = new System.Drawing.Size(49, 13);
            this.CurrentProtocolVersionLabel.TabIndex = 16;
            this.CurrentProtocolVersionLabel.Text = "Protocol:";
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.ForeColor = System.Drawing.Color.Navy;
            this.lblCurrentVersion.Location = new System.Drawing.Point(103, 385);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentVersion.TabIndex = 15;
            this.lblCurrentVersion.Text = "0";
            // 
            // CurrentProtocolEEVersionlabel
            // 
            this.CurrentProtocolEEVersionlabel.AutoSize = true;
            this.CurrentProtocolEEVersionlabel.Location = new System.Drawing.Point(44, 385);
            this.CurrentProtocolEEVersionlabel.Name = "CurrentProtocolEEVersionlabel";
            this.CurrentProtocolEEVersionlabel.Size = new System.Drawing.Size(44, 13);
            this.CurrentProtocolEEVersionlabel.TabIndex = 14;
            this.CurrentProtocolEEVersionlabel.Text = "Current:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 457);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.lblProtocolVersion);
            this.Controls.Add(this.ConnectionMessage1ListView);
            this.Controls.Add(this.CurrentProtocolVersionLabel);
            this.Controls.Add(this.ConnectionMessage4Label);
            this.Controls.Add(this.lblCurrentVersion);
            this.Controls.Add(this.ConnectionMessage4TextBox);
            this.Controls.Add(this.CurrentProtocolEEVersionlabel);
            this.Controls.Add(this.ConnectionMessage3Label);
            this.Controls.Add(this.ConnectionMessage2Label);
            this.Controls.Add(this.ConnectGroupBox);
            this.Controls.Add(this.ConnectionMessage1Label);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.ConnectionMessage3ListView);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ConnectionMessage2ListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Protocol Tool v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.ConnectGroupBox.ResumeLayout(false);
            this.ConnectGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label RoomIDLabel;
        private System.Windows.Forms.TextBox RoomIDTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusTextToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusShowToolStripStatusLabel;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.CheckBox SaveLoginDetailsCheckBox;
        private System.Windows.Forms.GroupBox ConnectGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label lblProtocolVersion;
        private System.Windows.Forms.Label CurrentProtocolVersionLabel;
        private System.Windows.Forms.Label lblCurrentVersion;
        private System.Windows.Forms.Label CurrentProtocolEEVersionlabel;
        private System.Windows.Forms.ListBox ConnectionMessage2ListBox;
        private System.Windows.Forms.ListView ConnectionMessage3ListView;
        private System.Windows.Forms.ColumnHeader NumberColumnHeader;
        private System.Windows.Forms.ColumnHeader TypeColumnHeader;
        private System.Windows.Forms.Label ConnectionMessage3Label;
        private System.Windows.Forms.Label ConnectionMessage2Label;
        private System.Windows.Forms.Label ConnectionMessage1Label;
        private System.Windows.Forms.TextBox ConnectionMessage4TextBox;
        private System.Windows.Forms.Label ConnectionMessage4Label;
        private System.Windows.Forms.ListView ConnectionMessage1ListView;
        private System.Windows.Forms.Button savebutton;
    }
}

