using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerIOClient;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Threading;
using System.Diagnostics.Eventing.Reader;

namespace ProtocolCheck
{
    public partial class Form1 : Form
    {
        private Client client;
        private Connection con;
        public static string pathtosettings = $"{Directory.GetCurrentDirectory()}\\settings.json";
        private string pathtoacc = $"{Directory.GetCurrentDirectory()}\\account.json";
        private Dictionary<string, Protocol> protocol = new Dictionary<string, Protocol>();
        Dictionary<string, List<Tuple<string, PlayerIOClient.Message>>> messages = new Dictionary<string, List<Tuple<string, PlayerIOClient.Message>>>();
        public static settings data = new settings();
        public static account acc = new account();
        public static Protocol prtc = new Protocol();
        public static Semaphore s1 = new Semaphore(0, 1);
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginButton.Text == "Login")
            {
                if (!string.IsNullOrEmpty(EmailTextBox.Text))
                {
                    if (!string.IsNullOrEmpty(PasswordTextBox.Text))
                    {
                        if (SaveLoginDetailsCheckBox.Checked)
                        {
                            acc.email = EmailTextBox.Text;
                            acc.password = PasswordTextBox.Text;
                            File.WriteAllText(pathtoacc, JsonConvert.SerializeObject(acc, Newtonsoft.Json.Formatting.Indented));
                        }
                        PlayerIO.QuickConnect.SimpleConnect(data.gameid, EmailTextBox.Text, PasswordTextBox.Text, null, (Client cl) =>
                        {
                            client = cl;
                            this.Invoke((MethodInvoker)delegate
                            {
                                LoginButton.Text = "Logout";
                            });
                            int version = Convert.ToInt32(cl.BigDB.Load("config", "config")["version"]);
                            if (lblCurrentVersion.InvokeRequired) { this.Invoke((MethodInvoker)delegate { lblCurrentVersion.Text = version.ToString(); }); }
                            if (data.protocolVersion < version)
                            {
                                if (lblProtocolVersion.InvokeRequired) { this.Invoke((MethodInvoker)delegate { lblProtocolVersion.ForeColor = ColorTranslator.FromHtml("#FF5656"); }); }
                            }
                            else if (data.protocolVersion > version)
                            {
                                if (lblProtocolVersion.InvokeRequired) { this.Invoke((MethodInvoker)delegate { lblProtocolVersion.ForeColor = ColorTranslator.FromHtml("#FF57C1"); }); }
                            }
                            else
                            {
                                if (lblProtocolVersion.InvokeRequired) { this.Invoke((MethodInvoker)delegate { lblProtocolVersion.ForeColor = ColorTranslator.FromHtml("#57FF68"); }); }
                            }
                            if (statusStrip.InvokeRequired)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    StatusShowToolStripStatusLabel.Text = "Logged in";
                                    StatusShowToolStripStatusLabel.ForeColor = ColorTranslator.FromHtml("#57FF68");
                                });
                            }
                            if (RoomIDTextBox.InvokeRequired)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    RoomIDTextBox.Enabled = true;
                                    ConnectButton.Enabled = true;
                                });
                            }

                        }, (PlayerIOError error) =>
                        {
                            if (statusStrip.InvokeRequired) { this.Invoke((MethodInvoker)delegate { StatusShowToolStripStatusLabel.Text = "Login: " + error.Message; StatusShowToolStripStatusLabel.ForeColor = ColorTranslator.FromHtml("#FF5656"); ; }); }
                            if (RoomIDTextBox.InvokeRequired)
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    RoomIDTextBox.Enabled = false;
                                    ConnectButton.Enabled = false;
                                });
                            }
                        });
                    }
                    else
                    {
                        StatusShowToolStripStatusLabel.Text = "You must enter your Password.";
                        StatusShowToolStripStatusLabel.ForeColor = ColorTranslator.FromHtml("#FF5656");
                    }
                }
                else
                {
                    StatusShowToolStripStatusLabel.Text = "You must enter your E-mail address.";
                    StatusShowToolStripStatusLabel.ForeColor = ColorTranslator.FromHtml("#FF5656");
                }
            }
            else
            {
                if (con != null && con.Connected) con.Disconnect();
                ConnectButton.Text = "Connect";
                LoginButton.Text = "Login";
                RoomIDTextBox.Enabled = false;
                ConnectButton.Enabled = false;
                lblProtocolVersion.Text = data.protocolVersion.ToString();
                lblProtocolVersion.ForeColor = ColorTranslator.FromHtml("#57BCFF");
                lblCurrentVersion.Text = "0";
                lblCurrentVersion.ForeColor = ColorTranslator.FromHtml("#57BCFF");
                if (client != null) client = null;
                StatusShowToolStripStatusLabel.Text = "Logged out";
                StatusShowToolStripStatusLabel.ForeColor = ColorTranslator.FromHtml("#57BCFF");
                ConnectionMessage3ListView.Items.Clear();
                ConnectionMessage1ListView.Items.Clear();
                ConnectionMessage2ListBox.Items.Clear();
                ConnectionMessage3ListView.Items.Clear();
                ConnectionMessage4TextBox.Clear();
                messages.Clear();
            }
        }

        private void SaveLoginDetailsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            data.saveLoginData = ((CheckBox)sender).Checked;
            if (!((CheckBox)sender).Checked)
            {
                if (File.Exists(pathtoacc)) File.Delete(pathtoacc);
                EmailTextBox.Clear();
                PasswordTextBox.Clear();
                data.saveLoginData = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists(data.pathToProtocol))
            {

                var output = JObject.Parse(File.ReadAllText(data.pathToProtocol));
                foreach (var property in output)
                {
                    if (property.Value["Data"].Count() > 0)
                    {
                        Protocol prtc1 = new Protocol()
                        {
                            Data = property.Value["Data"].ToObject<Dictionary<int, JToken>>()
                        };

                        if (!protocol.ContainsKey(property.Key)) protocol.Add(property.Key, prtc1);
                    }
                }

            }
            if (File.Exists(pathtosettings))
            {
                //var output = JObject.Parse(File.ReadAllText(pathSettings));
                data = JsonConvert.DeserializeObject<settings>(File.ReadAllText(pathtosettings));
                SaveLoginDetailsCheckBox.Checked = data.saveLoginData;

            }
            if (File.Exists(pathtoacc))
            {
                //var output = JObject.Parse(File.ReadAllText(pathSettings));
                acc = JsonConvert.DeserializeObject<account>(File.ReadAllText(pathtoacc));
                if (SaveLoginDetailsCheckBox.Checked)
                {
                    EmailTextBox.Text = acc.email;
                    PasswordTextBox.Text = acc.password;
                }
                else
                {
                    File.Delete(pathtoacc);
                }
            }
            lblProtocolVersion.Text = data.protocolVersion.ToString();
            this.BackColor = Color.FromArgb(71, 71, 71);
            foreach (Control cntrl in this.Controls)
            {
                if (cntrl.GetType() == typeof(MenuStrip))
                {
                    cntrl.BackColor = Color.FromArgb(100,100,100);
                    cntrl.ForeColor = Color.Orange;
                }
                if (cntrl.GetType() == typeof(ListBox))
                {
                    ((ListBox)cntrl).ForeColor = Color.White;
                    ((ListBox)cntrl).BackColor = Color.FromArgb(100, 100, 100);
                }
                if (cntrl.GetType() == typeof(ListView))
                {
                    ((ListView)cntrl).ForeColor = Color.White;
                    ((ListView)cntrl).BackColor = Color.FromArgb(100, 100, 100);
                }
                if (cntrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)cntrl).ForeColor = Color.White;
                    ((TextBox)cntrl).BackColor = Color.FromArgb(100, 100, 100);
                }
                if (cntrl.GetType() == typeof(StatusStrip))
                {
                    cntrl.BackColor = Color.FromArgb(100,100, 100);
                    cntrl.ForeColor = Color.Orange;
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
                        else if (cntrl1.GetType() == typeof(CheckBox))
                        {
                            ((CheckBox)cntrl1).ForeColor = Color.White;
                        }
                        else if (cntrl1.GetType() == typeof(Button))
                        {
                            ((Button)cntrl1).ForeColor = Color.White;
                            ((Button)cntrl1).BackColor = Color.FromArgb(90, 90, 90);
                            ((Button)cntrl1).FlatStyle = FlatStyle.Flat;
                        }
                    }
                }
               if (cntrl.GetType() == typeof(Label))
                {
                    if (((Label)cntrl).Name.StartsWith("lbl"))
                    {
                        ((Label)cntrl).ForeColor = Color.LightBlue;
                    }
                    else if (((Label)cntrl).Name.StartsWith("ConnectionMessage"))
                    {
                        ((Label)cntrl).ForeColor = Color.Orange;
                    }
                    else
                    {
                        ((Label)cntrl).ForeColor = Color.White;
                    }
                    
                }
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();
            frm.gameid.Text = data.gameid;
            frm.protver.Value = data.protocolVersion;
            frm.protocolFile = data.pathToProtocol;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                data.gameid = frm.gameid.Text;
                data.protocolVersion = Convert.ToInt32(frm.protver.Value);
                lblProtocolVersion.Text = data.protocolVersion.ToString();
                lblProtocolVersion.ForeColor = Color.LightBlue;

                if (data.pathToProtocol != null && File.Exists(data.pathToProtocol))
                {

                    var output = JObject.Parse(File.ReadAllText(data.pathToProtocol));
                    foreach (var property in output)
                    {
                        if (property.Value["Data"].Count() > 0)
                        {
                            Protocol prtc1 = new Protocol()
                            {

                                Data = property.Value["Data"].ToObject<Dictionary<int, JToken>>()
                            };

                            if (!protocol.ContainsKey(property.Key)) protocol.Add(property.Key, prtc1);
                        }
                    }

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(pathtosettings, JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented));
            if (SaveLoginDetailsCheckBox.Checked && !string.IsNullOrEmpty(EmailTextBox.Text) && !string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                File.WriteAllText(pathtoacc, JsonConvert.SerializeObject(acc, Newtonsoft.Json.Formatting.Indented));
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ConnectButton.Text == "Connect")
            {
                if (!string.IsNullOrEmpty(RoomIDTextBox.Text))
                {
                    if (checkRoomid(RoomIDTextBox.Text))
                    {

                        client.Multiplayer.CreateJoinRoom(RoomIDTextBox.Text, RoomIDTextBox.Text.Substring(0, 2) == "BW" ? "Beta" : "Everybodyedits" + data.protocolVersion, true, null, null, (Connection conn) =>
                                {
                                    con = conn;

                                    if (statusStrip.InvokeRequired)
                                    {
                                        this.Invoke((MethodInvoker)delegate
                                        {
                                            StatusShowToolStripStatusLabel.Text = "Connection: Connected to the room.";
                                            StatusShowToolStripStatusLabel.ForeColor = ColorTranslator.FromHtml("#57FF86");
                                        });
                                    }
                                    if (RoomIDTextBox.InvokeRequired)
                                    {
                                        this.Invoke((MethodInvoker)delegate
                                        {
                                            ConnectButton.Text = "Disconnect";
                                        });
                                    }
                                    conn.Send("init");
                                    conn.OnMessage += (s, m) =>
                                    {
                                        if (m.Type == "init") con.Send("init2");
                                        if (m.Type == "init2")
                                        {
                                            this.Invoke((MethodInvoker)delegate
                                            {
                                                savebutton.Enabled = true;
                                            });
                                        }
                                        try
                                        {
                                            base.Invoke(new MethodInvoker(delegate ()
                                            {
                                                if (protocol.ContainsKey(m.Type))
                                                {
                                                    //var item = ConnectionMessage1ListView.FindItemWithText(m.Type);
                                                    //ConnectionMessage1ListView.Items[ConnectionMessage1ListView.Items.IndexOf(item)].ForeColor = Color.Green;

                                                }
                                                if (messages.ContainsKey(m.Type))
                                                {
                                                    messages[m.Type].Add(new Tuple<string, PlayerIOClient.Message>(string.Concat(new object[] { "[", messages[m.Type].Count, "] ", DateTime.Now.ToString("hh:mm:ss") }), m));


                                                    if (ConnectionMessage1ListView.SelectedIndices.Count != 0 && ConnectionMessage1ListView.SelectedItems[0].Text != null && ConnectionMessage1ListView.SelectedItems[0].Text == m.Type.ToString())
                                                    {

                                                        ConnectionMessage2ListBox.Items.Add(this.messages[m.Type].Last<Tuple<string, PlayerIOClient.Message>>().Item1);

                                                    }


                                                }
                                                else
                                                {
                                                    List<Tuple<string, PlayerIOClient.Message>> list = new List<Tuple<string, PlayerIOClient.Message>>();
                                                    list.Add(new Tuple<string, PlayerIOClient.Message>("[0] " + DateTime.Now.ToString("hh:mm:ss"), m));
                                                    messages.Add(m.Type, list);
                                                    ConnectionMessage1ListView.Items.Add(m.Type);

                                                }
                                            }));
                                        }
                                        catch { }
                                    };
                                    conn.OnDisconnect += (s1, m1) =>
                                    {
                                        if (statusStrip.InvokeRequired)
                                        {
                                            this.Invoke((MethodInvoker)delegate
                                            {
                                                StatusShowToolStripStatusLabel.Text = "Connection: " + m1.ToString();
                                                StatusShowToolStripStatusLabel.ForeColor = ColorTranslator.FromHtml("#FF5757");
                                            });
                                        }
                                        if (RoomIDTextBox.InvokeRequired)
                                        {
                                            this.Invoke((MethodInvoker)delegate
                                            {
                                                ConnectButton.Text = "Connect";
                                            });
                                        }
                                        this.Invoke((MethodInvoker)delegate
                                        {
                                            savebutton.Enabled = false;
                                        });
                                    };

                                }, (PlayerIOError error) =>
                             {
                                 if (statusStrip.InvokeRequired) { this.Invoke((MethodInvoker)delegate { StatusShowToolStripStatusLabel.Text = "Connection: " + error.Message; StatusShowToolStripStatusLabel.ForeColor = Color.DarkRed; }); }
                             });
                    }
                    else
                    {
                        StatusShowToolStripStatusLabel.Text = "Unknown WorldID";
                        StatusShowToolStripStatusLabel.ForeColor = ColorTranslator.FromHtml("#FF5757");
                    }
                }
                else
                {
                    StatusShowToolStripStatusLabel.Text = "You must enter the WorldID";
                    StatusShowToolStripStatusLabel.ForeColor = ColorTranslator.FromHtml("#FF5757");
                }
            }
            else
            {
                con.Disconnect();
                ConnectButton.Text = "Connect";
                StatusShowToolStripStatusLabel.Text = "Connection: Disconnected";
                StatusShowToolStripStatusLabel.ForeColor = ColorTranslator.FromHtml("#FF5757");
                ConnectionMessage3ListView.Items.Clear();
                ConnectionMessage1ListView.Items.Clear();
                ConnectionMessage2ListBox.Items.Clear();
                ConnectionMessage3ListView.Items.Clear();
                ConnectionMessage4TextBox.Clear();
                savebutton.Enabled = false;
                messages.Clear();
            }
        }


        private bool checkRoomid(string roomid)
        {
            bool ismatch = Regex.IsMatch(roomid.Substring(0, 2), "OW|PW|BW");
            return ismatch;
        }

        private void ConnectionMessage1ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionMessage2ListBox.Items.Clear();
            ConnectionMessage2ListBox.Items.Clear();
            ConnectionMessage3ListView.Items.Clear();
            ConnectionMessage4TextBox.Clear();
            if (ConnectionMessage1ListView.SelectedItems.Count == 1)
            {
                foreach (Tuple<string, PlayerIOClient.Message> tuple in this.messages[ConnectionMessage1ListView.SelectedItems[0].Text])
                {
                    ConnectionMessage2ListBox.Items.Add(tuple.Item1);
                }
            }
        }

        private void ConnectionMessage2ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionMessage3ListView.Items.Clear();
            ConnectionMessage4TextBox.Clear();
            ConnectionMessage1ListView.Select();
            if (ConnectionMessage2ListBox.SelectedIndex != -1)
            {
                PlayerIOClient.Message item = this.messages[ConnectionMessage1ListView.SelectedItems[0].Text][ConnectionMessage2ListBox.SelectedIndex].Item2;
                for (int num = 0; num < item.Count; num += 1)
                {

                    ConnectionMessage3ListView.Items.Add("[" + num + "]").SubItems.Add(item[(uint)num].GetType().ToString());
                    if (protocol.ContainsKey(ConnectionMessage1ListView.SelectedItems[0].Text))
                    {
                        if (protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data.ContainsKey(num))
                        {
                            JToken line = protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data[num];
                            if (line.ToString() == item[(uint)num].GetType().ToString())
                            {
                                ConnectionMessage3ListView.Items[num].ForeColor = ColorTranslator.FromHtml("#81FF57");
                            }
                            else
                            {
                                ConnectionMessage3ListView.Items[num].ForeColor = ColorTranslator.FromHtml("#FF5757");
                            }

                        }
                        else
                        {
                            ConnectionMessage3ListView.Items[num].ForeColor = ColorTranslator.FromHtml("#57A0FF");
                        }
                        /*if (item.Count == protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data.Count)
                        {
                            JToken line = protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data[num];

                            if (line.ToString() == item[(uint)num].GetType().ToString() && protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data.ContainsKey(num))
                            {
                                ConnectionMessage3ListView.Items[num].ForeColor = Color.Green;
                            }
                            else
                            {
                                ConnectionMessage3ListView.Items[num].ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            if (item.Count > protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data.Count)
                            {
                                if (num < protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data.Count)
                                {
                                    JToken line = protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data.Values[num];
                                    if (line.ToString() == item[(uint)num].GetType().ToString() && protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data.ContainsKey(num))
                                    {
                                        ConnectionMessage3ListView.Items[num].ForeColor = Color.Green;
                                    }
                                    else
                                    {
                                        ConnectionMessage3ListView.Items[num].ForeColor = Color.Red;
                                    }
                                }

                                else
                                {
                                    ConnectionMessage3ListView.Items[num].ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                    /*if (protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data.IndexOf(num))
                    {
                        JToken line = protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data[num];

                        if (line.ToString() == item[(uint)num].GetType().ToString())
                        {
                            ConnectionMessage3ListView.Items[num].ForeColor = Color.Green;
                        }
                        else
                        {
                            ConnectionMessage3ListView.Items[num].ForeColor = Color.Red;
                        }

                        ConnectionMessage3ListView.Items[num].ForeColor = Color.Red;
                    }
                    //JToken[] arr = protocol[ConnectionMessage1ListView.SelectedItems[0].Text].Data.ToArray();
                    /*for (int a = 0; a < arr.Count(); a++)
                    {
                        if (arr[a].ToString() == item[(uint)a].GetType().ToString())
                        {
                            Console.WriteLine(item[(uint)a].GetType());
                        }
                    }*/
                    }
                }
            }

        }

        private void ConnectionMessage3ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionMessage1ListView.Select();
            ConnectionMessage1ListView.SelectedItems[0].Selected = true;

            if (ConnectionMessage3ListView.SelectedIndices.Count == 0)
            {
                ConnectionMessage4TextBox.Clear();

            }
            else
            {
                PlayerIOClient.Message item = this.messages[ConnectionMessage1ListView.SelectedItems[0].Text][ConnectionMessage2ListBox.SelectedIndex].Item2;
                uint index = (uint)ConnectionMessage3ListView.SelectedIndices[0];
                if (item[index].GetType().ToString() == "System.Byte[]")
                {
                    ConnectionMessage4TextBox.Text = "Byte found, can't convert";
                    ConnectionMessage4TextBox.ForeColor = ColorTranslator.FromHtml("#FF5757");
                }
                else
                {
                    ConnectionMessage4TextBox.Text = item[index].ToString();
                    ConnectionMessage4TextBox.ForeColor = Color.White;
                }
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (ConnectionMessage1ListView.SelectedItems.Count > 0)
            {
                if (!protocol.ContainsKey(ConnectionMessage1ListView.SelectedItems[0].Text))
                {
                    if (ConnectionMessage2ListBox.SelectedIndex != -1)
                    {
                        Protocol prtc1 = new Protocol()
                        {
                            Data = new Dictionary<int, JToken>()
                        };
                        prtc1.Data.Clear();
                        PlayerIOClient.Message item = this.messages[ConnectionMessage1ListView.SelectedItems[0].Text][ConnectionMessage2ListBox.SelectedIndex].Item2;
                        for (int i = 0; i < item.Count; i++)
                        {

                            prtc1.Data.Add(i, item[(uint)i].GetType().ToString());
                        }
                        protocol.Add(ConnectionMessage1ListView.SelectedItems[0].Text, prtc1);
                    }
                    string name = $"{Directory.GetCurrentDirectory()}\\{data.gameid}_{data.protocolVersion}.json";
                    File.WriteAllText(name, JsonConvert.SerializeObject(protocol, Newtonsoft.Json.Formatting.Indented));
                }
            }

        }

        private void ConnectionMessage1ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionMessage2ListBox.Items.Clear();
            ConnectionMessage2ListBox.Items.Clear();
            ConnectionMessage3ListView.Items.Clear();
            ConnectionMessage4TextBox.Clear();
            if (ConnectionMessage1ListView.SelectedItems.Count == 1)
            {
                foreach (Tuple<string, PlayerIOClient.Message> tuple in this.messages[ConnectionMessage1ListView.SelectedItems[0].Text])
                {
                    ConnectionMessage2ListBox.Items.Add(tuple.Item1);
                }
            }
        }
        public static void save()
        {

            File.WriteAllText(pathtosettings, JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented));
        }
    }
    public class account
    {
        public string email { get; set; }
        public string password { get; set; }
    }
    public class settings
    {
        public bool saveLoginData { get; set; }
        public string gameid { get; set; }

        public int protocolVersion { get; set; }

        public string pathToProtocol { get; set; }
    }
    public class Protocol
    {
        public Dictionary<int, JToken> Data { get; set; }
    }

}
