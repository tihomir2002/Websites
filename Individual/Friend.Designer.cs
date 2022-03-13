namespace Individual
{
    partial class Friend
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveFriend = new System.Windows.Forms.Button();
            this.btnFriend = new System.Windows.Forms.Button();
            this.lbFriendDesc = new System.Windows.Forms.Label();
            this.lbFriendName = new System.Windows.Forms.Label();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoveFriend);
            this.panel1.Controls.Add(this.btnFriend);
            this.panel1.Controls.Add(this.lbFriendDesc);
            this.panel1.Controls.Add(this.lbFriendName);
            this.panel1.Controls.Add(this.pbProfilePicture);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 136);
            this.panel1.TabIndex = 1;
            // 
            // btnRemoveFriend
            // 
            this.btnRemoveFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnRemoveFriend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveFriend.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemoveFriend.Location = new System.Drawing.Point(137, 108);
            this.btnRemoveFriend.Name = "btnRemoveFriend";
            this.btnRemoveFriend.Size = new System.Drawing.Size(104, 23);
            this.btnRemoveFriend.TabIndex = 4;
            this.btnRemoveFriend.Text = "Remove friend";
            this.btnRemoveFriend.UseVisualStyleBackColor = false;
            this.btnRemoveFriend.Visible = false;
            this.btnRemoveFriend.Click += new System.EventHandler(this.btnRemoveFriend_Click);
            // 
            // btnFriend
            // 
            this.btnFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnFriend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFriend.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFriend.Location = new System.Drawing.Point(137, 110);
            this.btnFriend.Name = "btnFriend";
            this.btnFriend.Size = new System.Drawing.Size(104, 23);
            this.btnFriend.TabIndex = 3;
            this.btnFriend.Text = "Add friend";
            this.btnFriend.UseVisualStyleBackColor = false;
            this.btnFriend.Click += new System.EventHandler(this.btnFriend_Click);
            // 
            // lbFriendDesc
            // 
            this.lbFriendDesc.AutoEllipsis = true;
            this.lbFriendDesc.AutoSize = true;
            this.lbFriendDesc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbFriendDesc.Location = new System.Drawing.Point(137, 30);
            this.lbFriendDesc.MaximumSize = new System.Drawing.Size(225, 75);
            this.lbFriendDesc.Name = "lbFriendDesc";
            this.lbFriendDesc.Size = new System.Drawing.Size(104, 15);
            this.lbFriendDesc.TabIndex = 2;
            this.lbFriendDesc.Text = "Profile Description";
            // 
            // lbFriendName
            // 
            this.lbFriendName.AutoSize = true;
            this.lbFriendName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbFriendName.Location = new System.Drawing.Point(137, 3);
            this.lbFriendName.MaximumSize = new System.Drawing.Size(225, 0);
            this.lbFriendName.Name = "lbFriendName";
            this.lbFriendName.Size = new System.Drawing.Size(73, 15);
            this.lbFriendName.TabIndex = 1;
            this.lbFriendName.Text = "ProfileName";
            // 
            // pbProfilePicture
            // 
            this.pbProfilePicture.ErrorImage = global::Individual.Properties.Resources.DefaultImage;
            this.pbProfilePicture.InitialImage = global::Individual.Properties.Resources.DefaultImage;
            this.pbProfilePicture.Location = new System.Drawing.Point(3, 3);
            this.pbProfilePicture.Name = "pbProfilePicture";
            this.pbProfilePicture.Size = new System.Drawing.Size(128, 128);
            this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePicture.TabIndex = 0;
            this.pbProfilePicture.TabStop = false;
            // 
            // Friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(388, 163);
            this.Controls.Add(this.panel1);
            this.Name = "Friend";
            this.Text = "Friend";
            this.Deactivate += new System.EventHandler(this.Friend_Leave);
            this.Load += new System.EventHandler(this.Friend_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbFriendDesc;
        private Label lbFriendName;
        private PictureBox pbProfilePicture;
        private Button btnFriend;
        private Button btnRemoveFriend;
    }
}