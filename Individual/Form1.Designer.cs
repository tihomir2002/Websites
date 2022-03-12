namespace Individual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangeProfile = new System.Windows.Forms.Button();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.pbProfilePicture = new System.Windows.Forms.PictureBox();
            this.lbActivity = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.pnProfile = new System.Windows.Forms.Panel();
            this.pnLibrary = new System.Windows.Forms.Panel();
            this.lbFriendsGame = new System.Windows.Forms.ListBox();
            this.pnLibraryInfo = new System.Windows.Forms.Panel();
            this.lbGameDesc = new System.Windows.Forms.Label();
            this.lbGameName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbLibrary = new System.Windows.Forms.ListBox();
            this.pnFriends = new System.Windows.Forms.Panel();
            this.lsbFoundFriends = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsers = new System.Windows.Forms.TextBox();
            this.lsbFriends = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnStore = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lbStoreGameDesc = new System.Windows.Forms.Label();
            this.lbStoreGameName = new System.Windows.Forms.Label();
            this.lbFoundGames = new System.Windows.Forms.ListBox();
            this.tbSearchGame = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFriends = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnProfile.SuspendLayout();
            this.pnLibrary.SuspendLayout();
            this.pnLibraryInfo.SuspendLayout();
            this.pnFriends.SuspendLayout();
            this.pnStore.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChangeProfile);
            this.panel1.Controls.Add(this.lbDesc);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.pbProfilePicture);
            this.panel1.Location = new System.Drawing.Point(18, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 136);
            this.panel1.TabIndex = 0;
            // 
            // btnChangeProfile
            // 
            this.btnChangeProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnChangeProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeProfile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnChangeProfile.Location = new System.Drawing.Point(137, 110);
            this.btnChangeProfile.Name = "btnChangeProfile";
            this.btnChangeProfile.Size = new System.Drawing.Size(104, 23);
            this.btnChangeProfile.TabIndex = 3;
            this.btnChangeProfile.Text = "Change Profile";
            this.btnChangeProfile.UseVisualStyleBackColor = false;
            this.btnChangeProfile.Click += new System.EventHandler(this.btnChangeProfile_Click);
            // 
            // lbDesc
            // 
            this.lbDesc.AutoEllipsis = true;
            this.lbDesc.AutoSize = true;
            this.lbDesc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbDesc.Location = new System.Drawing.Point(137, 30);
            this.lbDesc.MaximumSize = new System.Drawing.Size(225, 75);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(104, 15);
            this.lbDesc.TabIndex = 2;
            this.lbDesc.Text = "Profile Description";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbName.Location = new System.Drawing.Point(137, 3);
            this.lbName.MaximumSize = new System.Drawing.Size(225, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(73, 15);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "ProfileName";
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
            // lbActivity
            // 
            this.lbActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbActivity.FormattingEnabled = true;
            this.lbActivity.ItemHeight = 15;
            this.lbActivity.Items.AddRange(new object[] {
            "Played Game1 ",
            "Played Game1",
            "Added Friend1 as a friend"});
            this.lbActivity.Location = new System.Drawing.Point(18, 145);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbActivity.Size = new System.Drawing.Size(369, 285);
            this.lbActivity.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnFriends);
            this.panel2.Controls.Add(this.btnLibrary);
            this.panel2.Controls.Add(this.btnStore);
            this.panel2.Location = new System.Drawing.Point(192, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 27);
            this.panel2.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSettings.Location = new System.Drawing.Point(327, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnProfile.Location = new System.Drawing.Point(246, 3);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnFriends.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFriends.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFriends.Location = new System.Drawing.Point(165, 3);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(75, 23);
            this.btnFriends.TabIndex = 4;
            this.btnFriends.Text = "Friends";
            this.btnFriends.UseVisualStyleBackColor = false;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLibrary.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLibrary.Location = new System.Drawing.Point(84, 3);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(75, 23);
            this.btnLibrary.TabIndex = 1;
            this.btnLibrary.Text = "Library";
            this.btnLibrary.UseVisualStyleBackColor = false;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStore.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnStore.Location = new System.Drawing.Point(3, 3);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 23);
            this.btnStore.TabIndex = 0;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // pnProfile
            // 
            this.pnProfile.Controls.Add(this.panel1);
            this.pnProfile.Controls.Add(this.lbActivity);
            this.pnProfile.Location = new System.Drawing.Point(215, 36);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(416, 451);
            this.pnProfile.TabIndex = 4;
            // 
            // pnLibrary
            // 
            this.pnLibrary.Controls.Add(this.lbFriendsGame);
            this.pnLibrary.Controls.Add(this.pnLibraryInfo);
            this.pnLibrary.Controls.Add(this.label3);
            this.pnLibrary.Controls.Add(this.lbTitle);
            this.pnLibrary.Controls.Add(this.lbLibrary);
            this.pnLibrary.Location = new System.Drawing.Point(12, 33);
            this.pnLibrary.Name = "pnLibrary";
            this.pnLibrary.Size = new System.Drawing.Size(779, 460);
            this.pnLibrary.TabIndex = 7;
            // 
            // lbFriendsGame
            // 
            this.lbFriendsGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.lbFriendsGame.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbFriendsGame.FormattingEnabled = true;
            this.lbFriendsGame.ItemHeight = 15;
            this.lbFriendsGame.Location = new System.Drawing.Point(618, 40);
            this.lbFriendsGame.Name = "lbFriendsGame";
            this.lbFriendsGame.Size = new System.Drawing.Size(141, 214);
            this.lbFriendsGame.TabIndex = 5;
            this.lbFriendsGame.Visible = false;
            this.lbFriendsGame.SelectedIndexChanged += new System.EventHandler(this.lbFriendsGame_SelectedIndexChanged);
            // 
            // pnLibraryInfo
            // 
            this.pnLibraryInfo.Controls.Add(this.lbGameDesc);
            this.pnLibraryInfo.Controls.Add(this.lbGameName);
            this.pnLibraryInfo.Location = new System.Drawing.Point(140, 19);
            this.pnLibraryInfo.Name = "pnLibraryInfo";
            this.pnLibraryInfo.Size = new System.Drawing.Size(471, 301);
            this.pnLibraryInfo.TabIndex = 4;
            this.pnLibraryInfo.Visible = false;
            // 
            // lbGameDesc
            // 
            this.lbGameDesc.AutoEllipsis = true;
            this.lbGameDesc.AutoSize = true;
            this.lbGameDesc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbGameDesc.Location = new System.Drawing.Point(5, 45);
            this.lbGameDesc.MaximumSize = new System.Drawing.Size(500, 75);
            this.lbGameDesc.Name = "lbGameDesc";
            this.lbGameDesc.Size = new System.Drawing.Size(417, 30);
            this.lbGameDesc.TabIndex = 3;
            this.lbGameDesc.Text = "Game DescriptionGame DescriptionGame DescriptionGame DescriptionGame DescriptionG" +
    "ame DescriptionGame DescriptionGame Description";
            this.lbGameDesc.Visible = false;
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbGameName.Location = new System.Drawing.Point(5, 9);
            this.lbGameName.MaximumSize = new System.Drawing.Size(400, 0);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(70, 15);
            this.lbGameName.TabIndex = 2;
            this.lbGameName.Text = "GameName";
            this.lbGameName.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(617, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Friends owning the game";
            this.label3.Visible = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(183, 22);
            this.lbTitle.MaximumSize = new System.Drawing.Size(400, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(0, 15);
            this.lbTitle.TabIndex = 1;
            // 
            // lbLibrary
            // 
            this.lbLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.lbLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLibrary.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbLibrary.FormattingEnabled = true;
            this.lbLibrary.ItemHeight = 15;
            this.lbLibrary.Location = new System.Drawing.Point(14, 19);
            this.lbLibrary.Name = "lbLibrary";
            this.lbLibrary.Size = new System.Drawing.Size(120, 420);
            this.lbLibrary.TabIndex = 0;
            this.lbLibrary.SelectedIndexChanged += new System.EventHandler(this.lbLibrary_SelectedIndexChanged);
            // 
            // pnFriends
            // 
            this.pnFriends.Controls.Add(this.tbFriends);
            this.pnFriends.Controls.Add(this.label2);
            this.pnFriends.Controls.Add(this.lsbFoundFriends);
            this.pnFriends.Controls.Add(this.label1);
            this.pnFriends.Controls.Add(this.tbUsers);
            this.pnFriends.Controls.Add(this.lsbFriends);
            this.pnFriends.Controls.Add(this.label5);
            this.pnFriends.Location = new System.Drawing.Point(12, 33);
            this.pnFriends.Name = "pnFriends";
            this.pnFriends.Size = new System.Drawing.Size(773, 439);
            this.pnFriends.TabIndex = 8;
            // 
            // lsbFoundFriends
            // 
            this.lsbFoundFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.lsbFoundFriends.ForeColor = System.Drawing.SystemColors.Window;
            this.lsbFoundFriends.FormattingEnabled = true;
            this.lsbFoundFriends.ItemHeight = 15;
            this.lsbFoundFriends.Location = new System.Drawing.Point(477, 49);
            this.lsbFoundFriends.Name = "lsbFoundFriends";
            this.lsbFoundFriends.Size = new System.Drawing.Size(282, 364);
            this.lsbFoundFriends.TabIndex = 8;
            this.lsbFoundFriends.SelectedIndexChanged += new System.EventHandler(this.lsbFoundFriends_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(480, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Find user";
            // 
            // tbUsers
            // 
            this.tbUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsers.Location = new System.Drawing.Point(477, 27);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.Size = new System.Drawing.Size(282, 16);
            this.tbUsers.TabIndex = 6;
            this.tbUsers.TextChanged += new System.EventHandler(this.tbFriend_TextChanged);
            // 
            // lsbFriends
            // 
            this.lsbFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.lsbFriends.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lsbFriends.FormattingEnabled = true;
            this.lsbFriends.ItemHeight = 15;
            this.lsbFriends.Location = new System.Drawing.Point(14, 54);
            this.lsbFriends.Name = "lsbFriends";
            this.lsbFriends.Size = new System.Drawing.Size(183, 364);
            this.lsbFriends.TabIndex = 5;
            this.lsbFriends.SelectedIndexChanged += new System.EventHandler(this.lsbFriends_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 22);
            this.label5.MaximumSize = new System.Drawing.Size(400, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 1;
            // 
            // pnStore
            // 
            this.pnStore.Controls.Add(this.btnBuy);
            this.pnStore.Controls.Add(this.lbStoreGameDesc);
            this.pnStore.Controls.Add(this.lbStoreGameName);
            this.pnStore.Controls.Add(this.lbFoundGames);
            this.pnStore.Controls.Add(this.tbSearchGame);
            this.pnStore.Location = new System.Drawing.Point(12, 32);
            this.pnStore.Name = "pnStore";
            this.pnStore.Size = new System.Drawing.Size(779, 458);
            this.pnStore.TabIndex = 10;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuy.Location = new System.Drawing.Point(311, 298);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(134, 23);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Visible = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lbStoreGameDesc
            // 
            this.lbStoreGameDesc.AutoEllipsis = true;
            this.lbStoreGameDesc.AutoSize = true;
            this.lbStoreGameDesc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbStoreGameDesc.Location = new System.Drawing.Point(154, 56);
            this.lbStoreGameDesc.MaximumSize = new System.Drawing.Size(500, 75);
            this.lbStoreGameDesc.Name = "lbStoreGameDesc";
            this.lbStoreGameDesc.Size = new System.Drawing.Size(417, 30);
            this.lbStoreGameDesc.TabIndex = 5;
            this.lbStoreGameDesc.Text = "Game DescriptionGame DescriptionGame DescriptionGame DescriptionGame DescriptionG" +
    "ame DescriptionGame DescriptionGame Description";
            this.lbStoreGameDesc.Visible = false;
            // 
            // lbStoreGameName
            // 
            this.lbStoreGameName.AutoSize = true;
            this.lbStoreGameName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbStoreGameName.Location = new System.Drawing.Point(154, 20);
            this.lbStoreGameName.MaximumSize = new System.Drawing.Size(400, 0);
            this.lbStoreGameName.Name = "lbStoreGameName";
            this.lbStoreGameName.Size = new System.Drawing.Size(70, 15);
            this.lbStoreGameName.TabIndex = 4;
            this.lbStoreGameName.Text = "GameName";
            this.lbStoreGameName.Visible = false;
            // 
            // lbFoundGames
            // 
            this.lbFoundGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.lbFoundGames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFoundGames.ForeColor = System.Drawing.SystemColors.Window;
            this.lbFoundGames.FormattingEnabled = true;
            this.lbFoundGames.ItemHeight = 15;
            this.lbFoundGames.Location = new System.Drawing.Point(585, 41);
            this.lbFoundGames.Name = "lbFoundGames";
            this.lbFoundGames.Size = new System.Drawing.Size(182, 180);
            this.lbFoundGames.TabIndex = 1;
            this.lbFoundGames.SelectedIndexChanged += new System.EventHandler(this.lbFoundGames_SelectedIndexChanged);
            // 
            // tbSearchGame
            // 
            this.tbSearchGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.tbSearchGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearchGame.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSearchGame.Location = new System.Drawing.Point(585, 10);
            this.tbSearchGame.Name = "tbSearchGame";
            this.tbSearchGame.Size = new System.Drawing.Size(182, 23);
            this.tbSearchGame.TabIndex = 0;
            this.tbSearchGame.Text = "Enter game name";
            this.tbSearchGame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSearchGame.Click += new System.EventHandler(this.tbSearchGame_Click);
            this.tbSearchGame.TextChanged += new System.EventHandler(this.tbSearchGame_TextChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogout.Location = new System.Drawing.Point(646, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Friends";
            // 
            // tbFriends
            // 
            this.tbFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFriends.Location = new System.Drawing.Point(14, 28);
            this.tbFriends.Name = "tbFriends";
            this.tbFriends.Size = new System.Drawing.Size(183, 16);
            this.tbFriends.TabIndex = 10;
            this.tbFriends.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnStore);
            this.Controls.Add(this.pnFriends);
            this.Controls.Add(this.pnLibrary);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnProfile.ResumeLayout(false);
            this.pnLibrary.ResumeLayout(false);
            this.pnLibrary.PerformLayout();
            this.pnLibraryInfo.ResumeLayout(false);
            this.pnLibraryInfo.PerformLayout();
            this.pnFriends.ResumeLayout(false);
            this.pnFriends.PerformLayout();
            this.pnStore.ResumeLayout(false);
            this.pnStore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pbProfilePicture;
        private Label lbDesc;
        private Label lbName;
        private ListBox lbActivity;
        private Button btnChangeProfile;
        private Panel panel2;
        private Button btnFriends;
        private Button btnLibrary;
        private Button btnStore;
        private Button btnProfile;
        private Panel pnProfile;
        private Button btnSettings;
        private Panel pnLibrary;
        private ListBox lbFriendsGame;
        private Panel pnLibraryInfo;
        private Label lbGameDesc;
        private Label lbGameName;
        private Label label3;
        private Label lbTitle;
        private ListBox lbLibrary;
        private Panel pnFriends;
        private ListBox lsbFriends;
        private Label label5;
        private Label label1;
        private TextBox tbUsers;
        private ListBox lsbFoundFriends;
        private Panel pnStore;
        private Button btnBuy;
        private Label lbStoreGameDesc;
        private Label lbStoreGameName;
        private ListBox lbFoundGames;
        private TextBox tbSearchGame;
        private Button btnLogout;
        private Label label2;
        private TextBox tbFriends;
    }
}