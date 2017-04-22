namespace IRC
{
    partial class ChatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatWindow));
            this.usersList = new System.Windows.Forms.ListBox();
            this.message = new System.Windows.Forms.TextBox();
            this.chatList = new System.Windows.Forms.ListBox();
            this.nickButton = new System.Windows.Forms.Button();
            this.usersLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.leaveLabel = new System.Windows.Forms.Label();
            this.channelButton = new System.Windows.Forms.Button();
            this.nickBorder = new System.Windows.Forms.Label();
            this.nickLabel = new System.Windows.Forms.Label();
            this.newNickTextBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.cancelLabel = new System.Windows.Forms.Label();
            this.privateMsgButton = new System.Windows.Forms.Button();
            this.msgBorder = new System.Windows.Forms.Label();
            this.msgCancelLabel = new System.Windows.Forms.Label();
            this.msgLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // usersList
            // 
            this.usersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersList.FormattingEnabled = true;
            this.usersList.ItemHeight = 18;
            this.usersList.Location = new System.Drawing.Point(737, 91);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(120, 292);
            this.usersList.Sorted = true;
            this.usersList.TabIndex = 0;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(117, 399);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(614, 29);
            this.message.TabIndex = 1;
            this.message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.message_TextChanged);
            // 
            // chatList
            // 
            this.chatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatList.FormattingEnabled = true;
            this.chatList.ItemHeight = 18;
            this.chatList.Location = new System.Drawing.Point(12, 55);
            this.chatList.Name = "chatList";
            this.chatList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.chatList.Size = new System.Drawing.Size(719, 328);
            this.chatList.TabIndex = 2;
            // 
            // nickButton
            // 
            this.nickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickButton.Location = new System.Drawing.Point(12, 399);
            this.nickButton.Name = "nickButton";
            this.nickButton.Size = new System.Drawing.Size(99, 29);
            this.nickButton.TabIndex = 3;
            this.nickButton.Text = "Nick";
            this.nickButton.UseVisualStyleBackColor = true;
            this.nickButton.Click += new System.EventHandler(this.nickButton_Click);
            // 
            // usersLabel
            // 
            this.usersLabel.BackColor = System.Drawing.SystemColors.Control;
            this.usersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.usersLabel.Location = new System.Drawing.Point(737, 55);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(120, 33);
            this.usersLabel.TabIndex = 4;
            this.usersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.infoLabel.Image = ((System.Drawing.Image)(resources.GetObject("infoLabel.Image")));
            this.infoLabel.Location = new System.Drawing.Point(738, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(50, 38);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // leaveLabel
            // 
            this.leaveLabel.BackColor = System.Drawing.SystemColors.Control;
            this.leaveLabel.Image = ((System.Drawing.Image)(resources.GetObject("leaveLabel.Image")));
            this.leaveLabel.Location = new System.Drawing.Point(803, 9);
            this.leaveLabel.Name = "leaveLabel";
            this.leaveLabel.Size = new System.Drawing.Size(54, 38);
            this.leaveLabel.TabIndex = 6;
            this.leaveLabel.Click += new System.EventHandler(this.leaveLabel_Click);
            // 
            // channelButton
            // 
            this.channelButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.channelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelButton.Location = new System.Drawing.Point(12, 12);
            this.channelButton.Name = "channelButton";
            this.channelButton.Size = new System.Drawing.Size(153, 37);
            this.channelButton.TabIndex = 8;
            this.channelButton.Text = "#channel";
            this.channelButton.UseVisualStyleBackColor = false;
            // 
            // nickBorder
            // 
            this.nickBorder.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nickBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nickBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickBorder.Location = new System.Drawing.Point(13, 352);
            this.nickBorder.Name = "nickBorder";
            this.nickBorder.Size = new System.Drawing.Size(401, 44);
            this.nickBorder.TabIndex = 9;
            this.nickBorder.Visible = false;
            // 
            // nickLabel
            // 
            this.nickLabel.AutoSize = true;
            this.nickLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.nickLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nickLabel.Location = new System.Drawing.Point(22, 365);
            this.nickLabel.Name = "nickLabel";
            this.nickLabel.Size = new System.Drawing.Size(73, 18);
            this.nickLabel.TabIndex = 10;
            this.nickLabel.Text = "New nick:";
            this.nickLabel.Visible = false;
            // 
            // newNickTextBox
            // 
            this.newNickTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNickTextBox.Location = new System.Drawing.Point(101, 362);
            this.newNickTextBox.Name = "newNickTextBox";
            this.newNickTextBox.Size = new System.Drawing.Size(152, 24);
            this.newNickTextBox.TabIndex = 11;
            this.newNickTextBox.Visible = false;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.IndianRed;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(259, 359);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(79, 31);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Visible = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // cancelLabel
            // 
            this.cancelLabel.AutoSize = true;
            this.cancelLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cancelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.cancelLabel.Location = new System.Drawing.Point(344, 365);
            this.cancelLabel.Name = "cancelLabel";
            this.cancelLabel.Size = new System.Drawing.Size(58, 20);
            this.cancelLabel.TabIndex = 13;
            this.cancelLabel.Text = "Cancel";
            this.cancelLabel.Visible = false;
            this.cancelLabel.Click += new System.EventHandler(this.cancelLabel_Click);
            // 
            // privateMsgButton
            // 
            this.privateMsgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateMsgButton.Location = new System.Drawing.Point(737, 399);
            this.privateMsgButton.Name = "privateMsgButton";
            this.privateMsgButton.Size = new System.Drawing.Size(116, 29);
            this.privateMsgButton.TabIndex = 14;
            this.privateMsgButton.Text = "Private msg";
            this.privateMsgButton.UseVisualStyleBackColor = true;
            this.privateMsgButton.Click += new System.EventHandler(this.privateMsgButton_Click);
            // 
            // msgBorder
            // 
            this.msgBorder.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.msgBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.msgBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBorder.Location = new System.Drawing.Point(13, 352);
            this.msgBorder.Name = "msgBorder";
            this.msgBorder.Size = new System.Drawing.Size(401, 44);
            this.msgBorder.TabIndex = 17;
            this.msgBorder.Visible = false;
            // 
            // msgCancelLabel
            // 
            this.msgCancelLabel.AutoSize = true;
            this.msgCancelLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.msgCancelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgCancelLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.msgCancelLabel.Location = new System.Drawing.Point(344, 363);
            this.msgCancelLabel.Name = "msgCancelLabel";
            this.msgCancelLabel.Size = new System.Drawing.Size(58, 20);
            this.msgCancelLabel.TabIndex = 18;
            this.msgCancelLabel.Text = "Cancel";
            this.msgCancelLabel.Visible = false;
            this.msgCancelLabel.Click += new System.EventHandler(this.msgCancelLabel_Click);
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.msgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.msgLabel.Location = new System.Drawing.Point(22, 365);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(63, 18);
            this.msgLabel.TabIndex = 19;
            this.msgLabel.Text = "Send to:";
            this.msgLabel.Visible = false;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.IndianRed;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(259, 359);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(79, 31);
            this.sendButton.TabIndex = 20;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Visible = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // usersComboBox
            // 
            this.usersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(102, 363);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(151, 26);
            this.usersComboBox.Sorted = true;
            this.usersComboBox.TabIndex = 21;
            this.usersComboBox.Visible = false;
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 446);
            this.Controls.Add(this.usersComboBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.msgCancelLabel);
            this.Controls.Add(this.msgBorder);
            this.Controls.Add(this.privateMsgButton);
            this.Controls.Add(this.cancelLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.newNickTextBox);
            this.Controls.Add(this.nickLabel);
            this.Controls.Add(this.nickBorder);
            this.Controls.Add(this.channelButton);
            this.Controls.Add(this.leaveLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.nickButton);
            this.Controls.Add(this.chatList);
            this.Controls.Add(this.message);
            this.Controls.Add(this.usersList);
            this.Name = "ChatWindow";
            this.Text = "Internet Relay Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.ListBox chatList;
        private System.Windows.Forms.Button nickButton;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label leaveLabel;
        private System.Windows.Forms.Button channelButton;
        private System.Windows.Forms.Label nickBorder;
        private System.Windows.Forms.Label nickLabel;
        private System.Windows.Forms.TextBox newNickTextBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label cancelLabel;
        private System.Windows.Forms.Button privateMsgButton;
        private System.Windows.Forms.Label msgBorder;
        private System.Windows.Forms.Label msgCancelLabel;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox usersComboBox;
    }
}

