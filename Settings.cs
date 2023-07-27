using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtocolCheck
{
    public partial class Settings : Form
    {
        public TextBox gameid { get { return GameIDTextBox; } set { GameIDTextBox = value; } }
        public NumericUpDown protver { get { return nupdProtocolVersion; } set { nupdProtocolVersion = value; } }

        public string protocolFile { get; set; }
        public Settings()
        {
            InitializeComponent();
        }

        private void GameIDSaveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(GameIDTextBox.Text))
            {
                Form1.data.gameid = GameIDTextBox.Text;

            }

            if (Convert.ToInt32(nupdProtocolVersion.Value) >= 251 && Convert.ToInt32(nupdProtocolVersion.Value) <= 999)
            {
                Form1.data.protocolVersion = Convert.ToInt32(nupdProtocolVersion.Value);

            }
            if (!string.IsNullOrEmpty(protocolFile))
            {
                Form1.data.pathToProtocol = protocolFile;
            }
            if (string.IsNullOrEmpty(protocolFile))
            {
                Form1.data.pathToProtocol = null;
            }
        
        Form1.save();
            this.Close();
        }

    private void Settings_FormClosing(object sender, FormClosingEventArgs e)
    {
        this.DialogResult = DialogResult.OK;
    }

    private void Settings_Load(object sender, EventArgs e)
    {
        GameIDTextBox.Text = Form1.data.gameid;
        nupdProtocolVersion.Value = Form1.data.protocolVersion;
        txtbProtocolPath.Text = Form1.data.pathToProtocol;
            this.BackColor = Color.FromArgb(75, 75, 75);
            foreach (Control cntrl in this.Controls)
            {
                if (cntrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)cntrl).ForeColor = Color.White;
                    ((TextBox)cntrl).BackColor = Color.FromArgb(100, 100, 100);
                }
                if (cntrl.GetType() == typeof(Button))
                {
                    ((Button)cntrl).ForeColor = Color.White;
                    ((Button)cntrl).BackColor = Color.FromArgb(100, 100, 100);
                    ((Button)cntrl).FlatStyle = FlatStyle.Flat;
                }
                if (cntrl.GetType() == typeof(GroupBox))
                {
                    cntrl.ForeColor = Color.Orange;
                    foreach (Control cntrl1 in cntrl.Controls)
                    {
                        if (cntrl1.GetType() == typeof(Label))
                        {
                            ((Label)cntrl1).ForeColor = Color.White;
                        }
                        else if (cntrl1.GetType() == typeof(TextBox))
                        {
                            ((TextBox)cntrl1).ForeColor = Color.White;
                            ((TextBox)cntrl1).BackColor = Color.FromArgb(100, 100, 100);
                        }
                        else if (cntrl1.GetType() == typeof(Button))
                        {
                            ((Button)cntrl1).ForeColor = Color.White;
                            ((Button)cntrl1).BackColor = Color.FromArgb(90, 90, 90);
                            ((Button)cntrl1).FlatStyle = FlatStyle.Flat;

                        }
                        else if (cntrl1.GetType() == typeof(NumericUpDown))
                        {
                            ((NumericUpDown)cntrl1).ForeColor = Color.White;
                            ((NumericUpDown)cntrl1).BackColor = Color.FromArgb(100, 100, 100);
                        }
                        }
                }
                if (cntrl.GetType() == typeof(Label))
                {
                        ((Label)cntrl).ForeColor = Color.White;
                    

                }
            }

        }

        private void FileConnectionLoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "JSON Files (Json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog.FileName))
                {
                    protocolFile = openFileDialog.FileName;
                }
                
            }
        }

        private void btnResetProtocolFile_Click(object sender, EventArgs e)
        {
            protocolFile = null;
        }
    }
}
