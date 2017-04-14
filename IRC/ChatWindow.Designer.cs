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
            this.userList = new System.Windows.Forms.ListBox();
            this.message = new System.Windows.Forms.TextBox();
            this.chatList = new System.Windows.Forms.ListBox();
            this.nickButton = new System.Windows.Forms.Button();
            this.usersLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.leaveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 18;
            this.userList.Location = new System.Drawing.Point(737, 81);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(120, 310);
            this.userList.TabIndex = 0;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(108, 399);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(749, 25);
            this.message.TabIndex = 1;
            this.message.Text = "Send message...";
            // 
            // chatList
            // 
            this.chatList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatList.FormattingEnabled = true;
            this.chatList.ItemHeight = 18;
            this.chatList.Location = new System.Drawing.Point(12, 9);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(719, 382);
            this.chatList.TabIndex = 2;
            // 
            // nickButton
            // 
            this.nickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickButton.Location = new System.Drawing.Point(12, 399);
            this.nickButton.Name = "nickButton";
            this.nickButton.Size = new System.Drawing.Size(90, 25);
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
            this.usersLabel.Size = new System.Drawing.Size(120, 23);
            this.usersLabel.TabIndex = 4;
            this.usersLabel.Text = "XX Users";
            this.usersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.infoLabel.Image = ((System.Drawing.Image)(resources.GetObject("infoLabel.Image")));
            this.infoLabel.Location = new System.Drawing.Point(738, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(50, 41);
            this.infoLabel.TabIndex = 5;
            // 
            // leaveLabel
            // 
            this.leaveLabel.BackColor = System.Drawing.SystemColors.Control;
            this.leaveLabel.Image = ((System.Drawing.Image)(resources.GetObject("leaveLabel.Image")));
            this.leaveLabel.Location = new System.Drawing.Point(803, 9);
            this.leaveLabel.Name = "leaveLabel";
            this.leaveLabel.Size = new System.Drawing.Size(54, 41);
            this.leaveLabel.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(869, 432);
            this.Controls.Add(this.leaveLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.nickButton);
            this.Controls.Add(this.chatList);
            this.Controls.Add(this.message);
            this.Controls.Add(this.userList);
            this.Name = "MainWindow";
            this.Text = "Internet Relay Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.ListBox chatList;
        private System.Windows.Forms.Button nickButton;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label leaveLabel;
    }
}

