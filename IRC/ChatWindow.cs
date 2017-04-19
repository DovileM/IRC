using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC
{
    public partial class ChatWindow : Form
    {
        private string _nickname;
        private TcpClient _server;
        private List<string> users;
        private NetworkStream _dataStream;
        private Thread chatThread;


        public ChatWindow(TcpClient server, string nick, string channel)
        {
            InitializeComponent();
            _server = server;
            _nickname = nick;
            _dataStream = _server.GetStream();
            UserList();
            channelButton.Text = channel;
            nickButton.Text = nick;
            chatThread = new Thread(new ThreadStart(ChatThread));
            chatThread.Start();

        }

        private void infoLabel_Click(object sender, EventArgs e)
        {
            UserList();
            Thread.Sleep(3000);
        }

        private void channelButton_Click(object sender, EventArgs e)
        {

        }

        private void leaveLabel_Click(object sender, EventArgs e)
        {
            Writing("QUIT :" + channelButton.Text + Environment.NewLine);
            _nickname = string.Empty;
            _server = null;
            users = null;
            _dataStream = null;
            DialogResult = DialogResult.OK;
            Close();

        }

        public string Reading()
        {
            byte[] bytes = new byte[1024];
            StringBuilder data = new StringBuilder();
            Console.WriteLine("GALI SKAITYT: " + _dataStream.DataAvailable);
            if (_dataStream.DataAvailable)
            {
                do
                {
                    int Recvbytes = _dataStream.Read(bytes, 0, bytes.Length);
                    data.Append(Encoding.ASCII.GetString(bytes, 0, Recvbytes));
                    Thread.Sleep(1000);
                } while (_dataStream.DataAvailable);
                Console.WriteLine(data.ToString()+ Environment.NewLine);
                return data.ToString();
            }
            else
            {
                Console.WriteLine("NE");
                return string.Empty;
            }
        }

        private void Writing(string message)
        {
            _dataStream.Write(Encoding.ASCII.GetBytes(message), 0, message.Length);
            Thread.Sleep(1000);
        }

        private void UserList()
        {
            Writing("NAMES :" + channelButton.Text + Environment.NewLine);
            string line = Reading();
            Console.WriteLine(line);
            if (!string.IsNullOrEmpty(line))
            {
                usersList.Items.Clear();

                string[] data = line.Split(new string[] { "353", "366" }, StringSplitOptions.None);
                data = data[1].Split(':');
                data = data[1].Split(' ');
                users = new List<string>();
                for (int i = 0; i < data.Length; i++)
                {
                    users.Add(data[i]);
                    usersList.Items.Add(data[i]);
                }
                usersLabel.Text = string.Format("{0} Users", users.Count - 1);
            }
        }

        private void message_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                message_ClickedEnter(this, new EventArgs());
            }
        }

        private void message_ClickedEnter(object sender, EventArgs e)
        {
            Writing("PRIVMSG " + channelButton.Text + " :" + message.Text + Environment.NewLine);
            string line = Reading();
            Console.WriteLine(line);
            chatList.Items.Add(DateTime.Now.ToLongTimeString() + string.Format("{0,15}", nickButton.Text) + ":    " + message.Text);
            message.Text = string.Empty;
        }

        private void ChatThread()
        {
            while (true)
            {
                Thread.Sleep(1000);
                string line = Reading();
                if (line.Contains("PRIVMSG"))
                {
                    string str = "PRIVMSG " + channelButton.Text + " :";
                    string[] data = line.Split(new string[] { str }, StringSplitOptions.None);
                    Console.WriteLine("DATA1: " + data[0]);
                    Console.WriteLine("DATA2: " + data[1]);
                    string senderNick = data[0].Split(new string[] { ":", "!" }, StringSplitOptions.None)[1];

                    if (chatList.InvokeRequired)
                    {
                        chatList.Invoke(new Action(() => chatList.Items.Add(DateTime.Now.ToLongTimeString() +
                                                        string.Format("{0,15}", senderNick) + ":    " + data[1])));

                        Thread.Sleep(1000);

                    }
                }
                else if(line.Contains("JOIN"))
                {
                    string str = "JOIN " + " :"+ channelButton.Text;
                    //string[] data = line.Split(new string[] { str }, StringSplitOptions.None);
                    //Console.WriteLine("DATA1: " + data[0]);
                    //Console.WriteLine("DATA2: " + data[1]);
                    string senderNick = line.Split(new string[] { ":", "!" }, StringSplitOptions.None)[1];

                    if (chatList.InvokeRequired)
                    {
                        chatList.Invoke(new Action(() => chatList.Items.Add(DateTime.Now.ToLongTimeString() +
                                                        string.Format("{0,15}", senderNick) + ": has joined to chat.")));

                        Thread.Sleep(1000);

                    }
                }
                else if (line.Contains("PART"))
                {

                }
            }
        }

    }
}

