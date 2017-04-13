using System;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IRC
{
    public partial class LoginWindow : Form
    {
        public string nick;
        public string channel;
        public string pass;
        public string key;
        private bool _keyClicked;
        private TcpClient _server;
        private NetworkStream _dataStream;


        public LoginWindow(TcpClient s_server)
        {
            InitializeComponent();
            _keyClicked = false;
            nick = null;
            channel = null;
            pass = null;
            key = null;
            _server = s_server;
            _dataStream = _server.GetStream();
        }

        private void nickTextBox_TextChanged(object sender, EventArgs e)
        {
            nick = nickTextBox.Text;
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            pass = passTextBox.Text;
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
            }
            else
            {
                passTextBox.Visible = false;
                passLabel.Visible = false;
                channelTextBox.Location = new Point(135, 113);
                channelLabel.Location = new Point(54, 119);
                keyButton.Location = new Point(268, 113);
                keyLabel.Location = new Point(54, 153);
                keyTextBox.Location = new Point(135, 147);
                pass = null;
            }
        }

        private void keyTextBox_TextChanged(object sender, EventArgs e)
        {
            key = keyTextBox.Text;
        }

        private void channelTextBox_TextChanged(object sender, EventArgs e)
        {
            channel = channelTextBox.Text;
        }

        private void keyButton_Click(object sender, EventArgs e)
        {
            if (_keyClicked)
            {
                _keyClicked = false;
                keyTextBox.Visible = false;
                keyLabel.Visible = false;
                key = null;
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

            Console.WriteLine(Reading());
            //Writing("PASS " + passTextBox.Text + Environment.NewLine);
            Writing("NICK "+ nickTextBox.Text + Environment.NewLine);
            Writing("USER guest 0: * " + nickTextBox.Text + Environment.NewLine);
            string ping = Reading();
            Console.WriteLine(ping);
            if (ping.Contains("PING :"))
            {
                string[] data = ping.Split(':');
                Writing("PONG :" + data[1] + Environment.NewLine);
                Console.WriteLine(Reading());
            }
            else
                Console.WriteLine(Reading());
        }
        public string Reading()
        {
            byte[] bytes = new byte[1024];
            StringBuilder data = new StringBuilder();
            do
            {
                int Recvbytes = _dataStream.Read(bytes, 0, bytes.Length);
                data.Append(Encoding.ASCII.GetString(bytes, 0, Recvbytes));
            } while (_dataStream.DataAvailable);
            return data.ToString();
        }

        private void Writing(string message)
        {
            _dataStream.Write(Encoding.ASCII.GetBytes(message),0,message.Length);
        }
    }
}
