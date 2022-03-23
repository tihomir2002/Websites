namespace Individual
{
    public partial class Form1 : Form
    {
        private MyProfile profile;
        private Store store;
        private Settings settings;
        private Login loginForm;

        public Form1(Login loginForm,MyProfile profile)
        {
            InitializeComponent();

            this.loginForm= loginForm;
            this.profile = profile;
            settings = new(this,profile);
            store = new(profile);
            FriendList.Init(profile);
            lsbFriends.Items.Clear();

            if (FriendList.Friends == null)
                return;

            foreach (var friend in FriendList.Friends)
            {
                lsbFriends.Items.Add(friend);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbProfilePicture.Image = profile.Image;
            lbName.Text = $"{profile.Name}";
            lbDesc.Text = profile.Description;
            
            if (store.AvailableGames != null)
            {
                foreach(Game game in profile.OwnedGames)
                {
                    lbLibrary.Items.Add(game.Name);
                }
            }
            else lbLibrary.Text = "No games owned";
            
            lsbFoundFriends.Items.AddRange(FriendList.Profiles.ToArray());
        }

        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            ChangeProfile form = new ChangeProfile();
            form.FormClosing += Form_FormClosing;
            form.Show();
        }

        private void Form_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ChangeProfile form = (ChangeProfile)sender;
            foreach(Control control in form.Controls)
            {
                if(control is PictureBox)
                {
                    PictureBox box = control as PictureBox;
                    profile.Image = (Bitmap)box.Image;
                    pbProfilePicture.Image = box.Image;
                }
                if (control is TextBox && !string.IsNullOrWhiteSpace(control.Text))
                {
                    TextBox box = control as TextBox;
                    profile.Name = box.Text;
                    lbName.Text = box.Text;
                }
                if (control is RichTextBox && !string.IsNullOrWhiteSpace(control.Text))
                {
                    RichTextBox box = control as RichTextBox;
                    profile.Description = box.Text;
                    lbDesc.Text = box.Text;
                }
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            pnLibrary.Visible = false;
            pnProfile.Visible = false;
            pnStore.Visible = true;
            pnFriends.Visible = false;
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            pnLibrary.Visible = true;
            pnProfile.Visible = false;
            pnFriends.Visible = false;
            pnStore.Visible = false;
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            pnLibrary.Visible = false;
            pnProfile.Visible = false;
            pnFriends.Visible = true;
            pnStore.Visible = false;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnLibrary.Visible = false;
            pnFriends.Visible = false;
            pnProfile.Visible = true;
            pnStore.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            Label label = new Label();
            ComboBox comboBox = new ComboBox();
            FlowLayoutPanel panel = new FlowLayoutPanel();

            form.BackColor = Color.FromArgb(27, 48, 54);
            label.ForeColor = Color.White;
            comboBox.Text = settings.DefaultPanel.Name.Substring(2);
            label.Text = "Default view";
            panel.Controls.Add(label);
            panel.Controls.Add(comboBox);
            form.Controls.Add(panel);

            comboBox.Items.AddRange(new string[] 
                {
                    pnProfile.Name.Substring(2),
                    pnLibrary.Name.Substring(2),
                    pnFriends.Name.Substring(2),
                    pnStore.Name.Substring(2)
                }
            );
            comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            form.Text = "Settings";
            form.FormClosing += Settings_Closing;
            form.Show();
        }

        private void Settings_Closing(object? sender, FormClosingEventArgs e)
        {
            settings.SaveChanges();
        }

        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.SelectedIndex >= 0)
            {
                foreach (Control control in Controls)
                {
                    if (control.Name == "pn"+comboBox.SelectedItem.ToString())
                        settings.ChangeDefaultPanel((Panel)control);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {   
            profile.SaveChanges();
            //check for others

            if (!loginForm.Visible)
                Application.Exit();            
        }

        private void lsbFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsbFriends.SelectedIndex>=0)
            {
                Friend friend = 
                    new Friend(FriendList.Friends.First(friend=>friend.Name==lsbFriends.SelectedItem.ToString()),lsbFriends,lbActivity);
                friend.Show();
            }
        }

        private void lbLibrary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbLibrary.SelectedIndex >= 0)
            {
                pnLibraryInfo.Visible = true;
                lbGameName.Visible = true;
                lbGameDesc.Visible = true;
                lbGameName.Text = profile.OwnedGames[lbLibrary.SelectedIndex].Name;
                lbGameDesc.Text = profile.OwnedGames[lbLibrary.SelectedIndex].Description;
            }
            else { lbGameDesc.Text = ""; lbGameName.Text = ""; }
        }

        private void lbFriendsGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbFriends.SelectedIndex >= 0)
            {
                Friend friend = 
                    new Friend(FriendList.Friends.First(friend => friend.Name == lsbFriends.SelectedItem.ToString()), lsbFriends, lbActivity);
                friend.Show();
            }
        }

        private void tbSearchGame_TextChanged(object sender, EventArgs e)
        {
            lbFoundGames.Items.Clear();
            if(store.AvailableGames == null)
            {
                lbLibrary.Items.Add("No games available");
                return;
            }

            if(string.IsNullOrWhiteSpace(tbSearchGame.Text))
            {
                lbStoreGameDesc.Text = "";
                lbStoreGameName.Text = "";
                btnBuy.Visible = false;
            }

            foreach (Game game in store.AvailableGames)
            {
                if(game.Name.StartsWith(tbSearchGame.Text))
                    lbFoundGames.Items.Add(game);
            }
        }

        private void lbFoundGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbFoundGames.SelectedIndex>=0)
            {
                lbStoreGameDesc.Visible = true;
                lbStoreGameName.Visible = true;
                btnBuy.Visible = true;
                lbStoreGameName.Text = store.AvailableGames[lbFoundGames.SelectedIndex].Name;
                lbStoreGameDesc.Text = store.AvailableGames[lbFoundGames.SelectedIndex].Description;
                if (profile.OwnedGames.FirstOrDefault(game => game.Name == store.AvailableGames[lbFoundGames.SelectedIndex].Name) != null)
                {
                    btnBuy.Text = "Owned";
                    btnBuy.Enabled = false;
                }
                else
                {
                    btnBuy.Text = $"Buy - {store.AvailableGames[lbFoundGames.SelectedIndex].Price}$";
                    btnBuy.Enabled = true;
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            btnBuy.Text = "Owned";
            btnBuy.Enabled = false;
            store.BuyGame(store.SearchGame(lbStoreGameName.Text));
            lbLibrary.Items.Clear();
            foreach(Game game in profile.OwnedGames)
            {
                lbLibrary.Items.Add(game.Name);
            }
        }

        private void tbSearchGame_Click(object sender, EventArgs e)
        {
            tbSearchGame.Text = string.Empty;
        }

        private void tbFriend_TextChanged(object sender, EventArgs e)
        {
            lsbFoundFriends.Items.Clear();
            if (tbUsers.Text.Length >= 1 && FriendList.Profiles.FirstOrDefault(friend => friend.Name.StartsWith(tbUsers.Text)) != null)
                lsbFoundFriends.Items.AddRange(FriendList.Profiles.FindAll(friend => friend.Name.StartsWith(tbUsers.Text)).ToArray());

            if (tbUsers.Text.Length < 1)
                lsbFoundFriends.Items.AddRange(FriendList.Profiles.ToArray());
        }

        private void lsbFoundFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbFoundFriends.SelectedIndex >= 0)
            {
                Friend friend = 
                    new(FriendList.Profiles.First(user => user.Name == lsbFoundFriends.SelectedItem.ToString()), lsbFriends, lbActivity);
                friend.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lsbFriends.Items.Clear();
            if (tbFriends.Text.Length >= 1 && FriendList.Friends.FirstOrDefault(friend => friend.Name.StartsWith(tbFriends.Text)) != null)
                lsbFriends.Items.AddRange(FriendList.Friends.FindAll(friend => friend.Name.StartsWith(tbFriends.Text)).ToArray());

            if (tbFriends.Text.Length < 1)
                lsbFriends.Items.AddRange(FriendList.Friends.ToArray());
        }
    }
}