namespace ProtocolCheck
{
    partial class Settings
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
            System.Windows.Forms.GroupBox GameGroupBox;
            this.protverlabel = new System.Windows.Forms.Label();
            this.nupdProtocolVersion = new System.Windows.Forms.NumericUpDown();
            this.GameIDSaveButton = new System.Windows.Forms.Button();
            this.GameIDTextBox = new System.Windows.Forms.TextBox();
            this.GameIDLabel = new System.Windows.Forms.Label();
            this.ProtocolGroupBox = new System.Windows.Forms.GroupBox();
            this.btnResetProtocolFile = new System.Windows.Forms.Button();
            this.txtbProtocolPath = new System.Windows.Forms.TextBox();
            this.FileConnectionLoadButton = new System.Windows.Forms.Button();
            this.FileProtocolLabel = new System.Windows.Forms.Label();
            GameGroupBox = new System.Windows.Forms.GroupBox();
            GameGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdProtocolVersion)).BeginInit();
            this.ProtocolGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameGroupBox
            // 
            GameGroupBox.Controls.Add(this.protverlabel);
            GameGroupBox.Controls.Add(this.nupdProtocolVersion);
            GameGroupBox.Controls.Add(this.GameIDSaveButton);
            GameGroupBox.Controls.Add(this.GameIDTextBox);
            GameGroupBox.Controls.Add(this.GameIDLabel);
            GameGroupBox.Location = new System.Drawing.Point(12, 12);
            GameGroupBox.Name = "GameGroupBox";
            GameGroupBox.Size = new System.Drawing.Size(202, 141);
            GameGroupBox.TabIndex = 12;
            GameGroupBox.TabStop = false;
            GameGroupBox.Text = "Game";
            // 
            // protverlabel
            // 
            this.protverlabel.AutoSize = true;
            this.protverlabel.Location = new System.Drawing.Point(16, 62);
            this.protverlabel.Name = "protverlabel";
            this.protverlabel.Size = new System.Drawing.Size(87, 13);
            this.protverlabel.TabIndex = 13;
            this.protverlabel.Text = "Protocol Version:";
            // 
            // nupdProtocolVersion
            // 
            this.nupdProtocolVersion.Location = new System.Drawing.Point(19, 79);
            this.nupdProtocolVersion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupdProtocolVersion.Name = "nupdProtocolVersion";
            this.nupdProtocolVersion.Size = new System.Drawing.Size(85, 20);
            this.nupdProtocolVersion.TabIndex = 14;
            this.nupdProtocolVersion.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // GameIDSaveButton
            // 
            this.GameIDSaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.GameIDSaveButton.Location = new System.Drawing.Point(19, 105);
            this.GameIDSaveButton.Name = "GameIDSaveButton";
            this.GameIDSaveButton.Size = new System.Drawing.Size(75, 23);
            this.GameIDSaveButton.TabIndex = 2;
            this.GameIDSaveButton.Text = "Save";
            this.GameIDSaveButton.UseVisualStyleBackColor = true;
            this.GameIDSaveButton.Click += new System.EventHandler(this.GameIDSaveButton_Click);
            // 
            // GameIDTextBox
            // 
            this.GameIDTextBox.Location = new System.Drawing.Point(19, 35);
            this.GameIDTextBox.Name = "GameIDTextBox";
            this.GameIDTextBox.Size = new System.Drawing.Size(164, 20);
            this.GameIDTextBox.TabIndex = 1;
            // 
            // GameIDLabel
            // 
            this.GameIDLabel.AutoSize = true;
            this.GameIDLabel.Location = new System.Drawing.Point(16, 19);
            this.GameIDLabel.Name = "GameIDLabel";
            this.GameIDLabel.Size = new System.Drawing.Size(49, 13);
            this.GameIDLabel.TabIndex = 0;
            this.GameIDLabel.Text = "GameID:";
            // 
            // ProtocolGroupBox
            // 
            this.ProtocolGroupBox.Controls.Add(this.btnResetProtocolFile);
            this.ProtocolGroupBox.Controls.Add(this.txtbProtocolPath);
            this.ProtocolGroupBox.Controls.Add(this.FileConnectionLoadButton);
            this.ProtocolGroupBox.Controls.Add(this.FileProtocolLabel);
            this.ProtocolGroupBox.Location = new System.Drawing.Point(220, 12);
            this.ProtocolGroupBox.Name = "ProtocolGroupBox";
            this.ProtocolGroupBox.Size = new System.Drawing.Size(149, 117);
            this.ProtocolGroupBox.TabIndex = 11;
            this.ProtocolGroupBox.TabStop = false;
            this.ProtocolGroupBox.Text = "Protocol";
            // 
            // btnResetProtocolFile
            // 
            this.btnResetProtocolFile.Location = new System.Drawing.Point(16, 88);
            this.btnResetProtocolFile.Name = "btnResetProtocolFile";
            this.btnResetProtocolFile.Size = new System.Drawing.Size(75, 23);
            this.btnResetProtocolFile.TabIndex = 3;
            this.btnResetProtocolFile.Text = "Reset";
            this.btnResetProtocolFile.UseVisualStyleBackColor = true;
            this.btnResetProtocolFile.Click += new System.EventHandler(this.btnResetProtocolFile_Click);
            // 
            // txtbProtocolPath
            // 
            this.txtbProtocolPath.Location = new System.Drawing.Point(16, 36);
            this.txtbProtocolPath.Name = "txtbProtocolPath";
            this.txtbProtocolPath.Size = new System.Drawing.Size(127, 20);
            this.txtbProtocolPath.TabIndex = 1;
            // 
            // FileConnectionLoadButton
            // 
            this.FileConnectionLoadButton.Location = new System.Drawing.Point(16, 62);
            this.FileConnectionLoadButton.Name = "FileConnectionLoadButton";
            this.FileConnectionLoadButton.Size = new System.Drawing.Size(75, 23);
            this.FileConnectionLoadButton.TabIndex = 2;
            this.FileConnectionLoadButton.Text = "Load...";
            this.FileConnectionLoadButton.UseVisualStyleBackColor = true;
            this.FileConnectionLoadButton.Click += new System.EventHandler(this.FileConnectionLoadButton_Click);
            // 
            // FileProtocolLabel
            // 
            this.FileProtocolLabel.AutoSize = true;
            this.FileProtocolLabel.Location = new System.Drawing.Point(13, 20);
            this.FileProtocolLabel.Name = "FileProtocolLabel";
            this.FileProtocolLabel.Size = new System.Drawing.Size(68, 13);
            this.FileProtocolLabel.TabIndex = 0;
            this.FileProtocolLabel.Text = "Protocol File:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 220);
            this.Controls.Add(GameGroupBox);
            this.Controls.Add(this.ProtocolGroupBox);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            GameGroupBox.ResumeLayout(false);
            GameGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdProtocolVersion)).EndInit();
            this.ProtocolGroupBox.ResumeLayout(false);
            this.ProtocolGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GameIDLabel;
        private System.Windows.Forms.TextBox GameIDTextBox;
        private System.Windows.Forms.GroupBox ProtocolGroupBox;
        private System.Windows.Forms.Button FileConnectionLoadButton;
        private System.Windows.Forms.TextBox txtbProtocolPath;
        private System.Windows.Forms.Label FileProtocolLabel;
        private System.Windows.Forms.Button GameIDSaveButton;
        private System.Windows.Forms.Label protverlabel;
        private System.Windows.Forms.NumericUpDown nupdProtocolVersion;
        private System.Windows.Forms.Button btnResetProtocolFile;
    }
}