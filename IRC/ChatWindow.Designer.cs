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
            this.serverButton = new System.Windows.Forms.Button();
            this.channelButton = new System.Windows.Forms.Button();
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
            this.usersList.TabIndex = 0;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(117, 399);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(740, 25);
            this.message.TabIndex = 1;
            this.message.Text = "Send message...";
            // 
            // chatList
            // 
            this.chatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatList.FormattingEnabled = true;
            this.chatList.ItemHeight = 18;
            this.chatList.Location = new System.Drawing.Point(12, 55);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(719, 328);
            this.chatList.TabIndex = 2;
            // 
            // nickButton
            // 
            this.nickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickButton.Location = new System.Drawing.Point(12, 399);
            this.nickButton.Name = "nickButton";
            this.nickButton.Size = new System.Drawing.Size(99, 25);
            this.nickButton.TabIndex = 3;
            this.nickButton.Text = "Nick";
            this.nickButton.UseVisualStyleBackColor = true;
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
            // serverButton
            // 
            this.serverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverButton.Location = new System.Drawing.Point(12, 12);
            this.serverButton.Name = "serverButton";
            this.serverButton.Size = new System.Drawing.Size(99, 37);
            this.serverButton.TabIndex = 7;
            this.serverButton.Text = "Server";
            this.serverButton.UseVisualStyleBackColor = true;
            // 
            // channelButton
            // 
            this.channelButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.channelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelButton.Location = new System.Drawing.Point(117, 12);
            this.channelButton.Name = "channelButton";
            this.channelButton.Size = new System.Drawing.Size(103, 37);
            this.channelButton.TabIndex = 8;
            this.channelButton.Text = "#channel";
            this.channelButton.UseVisualStyleBackColor = false;
            this.channelButton.Click += new System.EventHandler(this.channelButton_Click);
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 432);
            this.Controls.Add(this.channelButton);
            this.Controls.Add(this.serverButton);
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
        private System.Windows.Forms.Button serverButton;
        private System.Windows.Forms.Button channelButton;
    }
}

