using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
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
        private Socket _server;


        public LoginWindow(Socket s_server)
        {
            InitializeComponent();
            _keyClicked = false;
            nick = null;
            channel = null;
            pass = null;
            key = null;
            _server = s_server;
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
            int bytesSent = _server.Send(Encoding.ASCII.GetBytes(nickTextBox.Text));
        }
    }
}
