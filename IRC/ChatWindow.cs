using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRC
{
    /*struct Channel
    {
        public string name;
        public int number;
        public List<string> users;
        public TextBox text;

        public Channel(string name, int number, List<string> users, TextBox text)
        {
            this.name = name;
            this.number = number;
            this.users = users;
            this.text = text;
        }
    }*/

    public partial class ChatWindow : Form
    {
        private string _nickname;
        private TcpClient _server;
        private List<string> users;
        private NetworkStream _dataStream;
        //private List<Channel> _channel;
        //private string _channel;


        public ChatWindow(TcpClient server, string nick, string channel, string userList)
        {
            InitializeComponent();
            _server = server;
            _nickname = nick;
            _dataStream = _server.GetStream();
            //_channel = new List<Channel>();
            //_channel = channel;
            string[] list = userList.Split(' ');
            users = new List<string>();
            for (int i = 0; i < list.Length; i++)
            {
                users.Add(list[i]);
                usersList.Items.Add(list[i]);
            }
            //_channel.Add(new Channel() { name = channel, number = list.Length, users = usersList });
            channelButton.Text = channel;
            nickButton.Text = nick;
            usersLabel.Text = string.Format("{0} Users",users.Count-1);
            Console.WriteLine(Reading());

        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }

        private void channelButton_Click(object sender, EventArgs e)
        {

        }

        private void leaveLabel_Click(object sender, EventArgs e)
        {
            //Writing("/partall" + Environment.NewLine);
            //Console.WriteLine(Reading());

            //DialogResult = DialogResult.OK;
            Close();

        }

        public string Reading()
        {
            byte[] bytes = new byte[1024];
            StringBuilder data = new StringBuilder();
            do
            {
                int Recvbytes = _dataStream.Read(bytes, 0, bytes.Length);
                data.Append(Encoding.ASCII.GetString(bytes, 0, Recvbytes));
                System.Threading.Thread.Sleep(2000);
            } while (_dataStream.DataAvailable);
            return data.ToString();
        }

        private void Writing(string message)
        {
            _dataStream.Write(Encoding.ASCII.GetBytes(message), 0, message.Length);
        }
    }
}
