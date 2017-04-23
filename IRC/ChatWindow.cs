using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace IRC
{
    public partial class ChatWindow : Form
    {
        private string _nickname;
        private TcpClient _server;
        private NetworkStream _dataStream;
        private Thread chatThread;
        private bool runningChat;


        public ChatWindow(TcpClient server, string nick, string channel)
        {
            InitializeComponent();
            _server = server;
            _nickname = nick;
            _dataStream = _server.GetStream();
            channelButton.Text = channel;
            nickButton.Text = nick;
            runningChat = true;
            chatThread = new Thread(new ThreadStart(ChatThread));
            chatThread.Start();

        }

        private void infoLabel_Click(object sender, EventArgs e)
        {

        }

        private void leaveLabel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public string Reading()
        {
            byte[] bytes = new byte[1024];
            StringBuilder data = new StringBuilder();
            try
            {
                Console.WriteLine("GALI SKAITYT: " + _dataStream.DataAvailable);
                if (_dataStream.DataAvailable)
                {
                    try
                    {
                        do
                        {
                            int Recvbytes = _dataStream.Read(bytes, 0, bytes.Length);
                            data.Append(Encoding.ASCII.GetString(bytes, 0, Recvbytes));
                            Thread.Sleep(750);
                        } while (_dataStream.DataAvailable);
                        return data.ToString();
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine("EXCEPTION: " + ex.Message);
                        return string.Empty;
                    }
                }
                else
                {
                    Console.WriteLine("NE");
                    return string.Empty;
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("EXCEPTION: " + ex.Message);
                return string.Empty;
            }
        }

        private void Writing(string message)
        {
            _dataStream.Write(Encoding.ASCII.GetBytes(message), 0, message.Length);
            Thread.Sleep(500);
        }

        private void UserList()
        {
            Writing("NAMES :" + channelButton.Text + Environment.NewLine);
            Thread.Sleep(500);
            string line = Reading();
            if (!string.IsNullOrEmpty(line))
            {
                if (usersList.InvokeRequired)
                {
                    usersList.Invoke(new Action(() => usersList.Items.Clear()));

                    string[] data = line.Split(new string[] { "353", "366" }, StringSplitOptions.None);
                    data = data[1].Split(':')[1].Split(' ');
                    for (int i = 0; i < data.Length-1; i++)
                    {
                        usersList.Invoke(new Action(() => usersList.Items.Add(data[i])));
                    }
                    if (usersLabel.InvokeRequired)
                        usersLabel.Invoke(new Action(() => usersLabel.Text = string.Format("{0} Users", (data.Length - 1))));
                }
            }
        }

        private void message_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                message_ClickedEnter(this, new EventArgs());
        }

        private void message_ClickedEnter(object sender, EventArgs e)
        {
            if (message.Text.Contains(Environment.NewLine))
                message.Text = message.Text.Remove(0, 2);
            Writing("PRIVMSG " + channelButton.Text + " :" + message.Text + Environment.NewLine);
            string line = Reading();
            chatList.Items.Add(DateTime.Now.ToLongTimeString() + string.Format("      {0}", nickButton.Text) + ":    " + message.Text);
            chatList.TopIndex = chatList.Items.Count - 1;
            message.Text = string.Empty;
        }

        private void ChatThread()
        {
            UserList();
            while (runningChat)
            {
                string[] lines = Reading().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines)
                {
                    if (line.Contains("PRIVMSG"))
                    {
                        if (line.Contains("PRIVMSG " + channelButton.Text + " :"))
                        {
                            string[] data = line.Split(new string[] { "PRIVMSG " + channelButton.Text + " :" }, StringSplitOptions.None);
                            string senderNick = line.Split(new string[] { ":", "!" }, StringSplitOptions.None)[1];
                            AddItemToList(string.Format("      {0}:  {1}", senderNick, data[1]));
                        }
                        else
                        {
                            string senderNick = line.Split(new string[] { ":", "!" }, StringSplitOptions.None)[1];
                            string receiverNick = line.Split(new string[] { "PRIVMSG ", " :" }, StringSplitOptions.None)[1];
                            string message = line.Split(new string[] { "PRIVMSG " + receiverNick + " :" }, StringSplitOptions.None)[1];
                            if (receiverNick.Equals(nickButton.Text))
                                AddItemToList(string.Format("      PM send from {0} to {1}: {2}", senderNick, receiverNick, message));
                        }
                    }
                    else if (line.Contains("JOIN"))
                    {
                        string senderNick = line.Split(new string[] { ":", "!" }, StringSplitOptions.None)[1];
                        UserList();
                        AddItemToList(string.Format("    ← {0} has joined.", senderNick));
                    }
                    else if (line.Contains("PART") || line.Contains("QUIT"))
                    {
                        string senderNick = line.Split(new string[] { ":", "!" }, StringSplitOptions.None)[1];
                        UserList();
                        AddItemToList(string.Format("    → {0} has quit.", senderNick));
                    }
                    else if (line.Contains("NICK"))
                    {
                        string[] data = line.Split(new string[] { "NICK :" }, StringSplitOptions.None);
                        string senderNick = line.Split(new string[] { ":", "!" }, StringSplitOptions.None)[1];
                        AddItemToList(string.Format("      {0} is known as {1}", senderNick, data[1]));
                        UserList();
                    }
                    else if (line.Contains("353"))
                    {
                        string[] data = line.Split(new string[] { channelButton.Text + " :" }, StringSplitOptions.None);
                        data = data[1].Split(' ');
                        if (usersComboBox.InvokeRequired)
                            if (usersComboBox.Visible)
                                for (int i = 0; i < data.Length - 1; i++)
                                    usersComboBox.Invoke(new Action(() => usersComboBox.Items.Add(data[i])));
                    }
                    else if (line.Contains("PING"))
                    {
                        string[] data = line.Split(':');
                        Writing("PONG :" + data[1] + Environment.NewLine);
                    }
                    else if (line.Contains("421") || line.Contains("366"))
                        continue;
                    else
                        Trace.WriteLine(line);
                }
            }
        }

        private void AddItemToList(string line)
        {
            if (chatList.InvokeRequired)
                chatList.Invoke(new Action(() => { chatList.Items.Add(DateTime.Now.ToLongTimeString() + line); chatList.TopIndex = chatList.Items.Count - 1; }));
        }

        private void nickButton_Click(object sender, EventArgs e)
        {
            cancelLabel_Click(sender, e);
            msgCancelLabel_Click(sender, e);
            newNickTextBox.Visible = true;
            nickLabel.Visible = true;
            cancelLabel.Visible = true;
            changeButton.Visible = true;
            nickBorder.Visible = true;
        }

        private void cancelLabel_Click(object sender, EventArgs e)
        {
            newNickTextBox.Text = string.Empty;
            newNickTextBox.Visible = false;
            nickBorder.Visible = false;
            nickLabel.Visible = false;
            cancelLabel.Visible = false;
            changeButton.Visible = false;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newNickTextBox.Text) && newNickTextBox.Text.Length < 9)
            {
                message.Text = string.Empty;
                nickButton.Text = newNickTextBox.Text;
                Writing("NICK " + newNickTextBox.Text + Environment.NewLine);
                cancelLabel_Click(sender, e);
            }
        }

        private void privateMsgButton_Click(object sender, EventArgs e)
        {
            cancelLabel_Click(sender, e);
            msgCancelLabel_Click(sender, e);
            msgCancelLabel.Visible = true;
            msgLabel.Visible = true;
            sendButton.Visible = true;
            usersComboBox.Visible = true;
            msgBorder.Visible = true;
            Writing("NAMES :" + channelButton.Text + Environment.NewLine);
        }

        private void msgCancelLabel_Click(object sender, EventArgs e)
        {
            usersComboBox.Items.Clear();
            msgCancelLabel.Visible = false;
            msgLabel.Visible = false;
            sendButton.Visible = false;
            usersComboBox.Visible = false;
            msgBorder.Visible = false;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (message.Text.Contains(Environment.NewLine))
                message.Text = message.Text.Remove(0, 2);
            chatList.Items.Add(string.Format(DateTime.Now.ToLongTimeString() + "      PM send from {0} to {1}: {2}", 
                                nickButton.Text, usersComboBox.SelectedItem.ToString(), message.Text));
            Writing("PRIVMSG " + usersComboBox.SelectedItem.ToString() + " :" + message.Text + Environment.NewLine);
            message.Text = string.Empty;
        }

        private void ChatWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Writing("QUIT :" + channelButton.Text + Environment.NewLine);
            runningChat = false;
            chatThread.Join();
            _nickname = string.Empty;
            _server = null;
            _dataStream = null;
        }
    }
}

