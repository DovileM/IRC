using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace IRC
{
    public partial class LoginWindow : Form
    {
        private bool _keyClicked;
        private TcpClient _server;
        private NetworkStream _dataStream;


        public LoginWindow(TcpClient s_server)
        {
            InitializeComponent();
            _keyClicked = false;
            _server = s_server;
            _dataStream = _server.GetStream();
        }

        private void passCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(passCheckBox.Checked)
            {
                passTextBox.Visible = true;
                passLabel.Visible = true;
                channelTextBox.Location = new Point(135, 147);
                channelLabel.Location = new Point(54, 153);
                keyButton.Location = new Point(268,147);
                keyLabel.Location = new Point(54,183);
                keyTextBox.Location = new Point(135,177);
                channelErrorLabel.Location = new Point(302,155);
            }
            else
            {
                passTextBox.Visible = false;
                passLabel.Visible = false;
                passTextBox.Text = string.Empty;
                channelTextBox.Location = new Point(135, 113);
                channelLabel.Location = new Point(54, 119);
                keyButton.Location = new Point(268, 113);
                keyLabel.Location = new Point(54, 153);
                keyTextBox.Location = new Point(135, 147);
                channelErrorLabel.Location = new Point(302, 118);
            }
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            if (_keyClicked)
            {
                _keyClicked = false;
                keyTextBox.Visible = false;
                keyLabel.Visible = false;
                keyTextBox.Text = string.Empty;
            }
            else
            {
                _keyClicked = true;
                keyTextBox.Visible = true;
                keyLabel.Visible = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            byte[] bytes = new byte[1024];
            NetworkStream writer = _server.GetStream();

            nickErrorLabel.Visible = false;
            channelErrorLabel.Visible = false;
            passErrorLabel.Visible = false;

            if (string.IsNullOrEmpty(nickTextBox.Text) || string.IsNullOrEmpty(channelTextBox.Text))
            {
                if (string.IsNullOrEmpty(nickTextBox.Text))
                {
                    nickErrorLabel.Visible = true;
                    nickErrorLabel.Text = "*No nickname";
                }
                if (string.IsNullOrEmpty(channelTextBox.Text))
                {
                    channelErrorLabel.Text = "*No channel";
                    channelErrorLabel.Visible = true;
                }
            }
            else if (!channelTextBox.Text.Contains("#"))
                {
                    channelErrorLabel.Text = "*Invalid channel";
                    channelErrorLabel.Visible = true;
                }
            else if (nickTextBox.Text.Length > 9)
                {
                    nickErrorLabel.Visible = true;
                    nickErrorLabel.Text = "*Invalid nickname";
                }
            else
            {
                if (passCheckBox.Checked && !string.IsNullOrEmpty(passTextBox.Text) && passTextBox.Text.Length < 9)
                    Writing("PASS " + passTextBox.Text + Environment.NewLine);
                else
                    passErrorLabel.Visible = true;
                Writing("NICK " + nickTextBox.Text + Environment.NewLine);
                Writing("USER guest * * :" + nickTextBox.Text + Environment.NewLine);
                string ping = Reading();
                Console.WriteLine(ping);
                if (ping.Contains("PING :"))
                {
                    string[] data = ping.Split(new string[] { "PING :" }, StringSplitOptions.None);
                    Writing("PONG :" + data[1] + Environment.NewLine);
                    Console.WriteLine(Reading());
                    if (string.IsNullOrEmpty(keyTextBox.Text))
                        Writing("JOIN " + channelTextBox.Text + " " + keyTextBox.Text + Environment.NewLine);
                    else
                        Writing("JOIN " + channelTextBox.Text + Environment.NewLine);

                    using (ChatWindow chat = new ChatWindow(_server, nickTextBox.Text, channelTextBox.Text))
                    {
                        Hide();
                        if (chat.ShowDialog() == DialogResult.OK)
                            Show();
                    }
                }
                if (ping.Contains("433"))
                {
                    nickErrorLabel.Visible = true;
                    nickErrorLabel.Text = "*Nick already in use";
                    Trace.WriteLine(ping);

                }
                if (ping.Contains("461"))
                {
                    passErrorLabel.Visible = true;
                    Trace.WriteLine(ping);
                }
            }
        }
        public string Reading()
        {
            byte[] bytes = new byte[1024];
            StringBuilder data = new StringBuilder();
            do
            {
                int Recvbytes = _dataStream.Read(bytes, 0, bytes.Length);
                data.Append(Encoding.ASCII.GetString(bytes, 0, Recvbytes));
                System.Threading.Thread.Sleep(1000);
            } while (_dataStream.DataAvailable);
            return data.ToString();
        }

        private void Writing(string message)
        {
            _dataStream.Write(Encoding.ASCII.GetBytes(message),0,message.Length);
        }


    }
}
