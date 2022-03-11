namespace Individual
{
    public partial class Friend : Form
    {
        private ListBox listBox;
        private Profile profile;
        private ListBox listBox1;

        public Friend(Profile profile,ListBox listBox, ListBox listBox1)
        {
            InitializeComponent();
            this.profile = profile;
            this.listBox = listBox;
            this.listBox1 = listBox1;
        }

        private void btnFriend_Click(object sender, EventArgs e)
        {
            profile.AddFriend();
            listBox1.Items.Add($"Added {profile.Name} as a friend");
            (sender as Button).Visible= false;
            listBox.Items.Clear();
            listBox.Items.AddRange(FriendList.friends.ToArray());
        }

        private void Friend_Load(object sender, EventArgs e)
        {
            pbProfilePicture.Image = profile.Image;
            lbFriendName.Text = profile.Name;
            Text = profile.Name;
            lbFriendDesc.Text = profile.Description;

            if (FriendList.friends == null)
                return;

            foreach (Profile friend in FriendList.friends)
            {
                if (friend.Name == profile.Name)
                {
                    btnFriend.Visible = false;
                    break;
                }
                else { btnFriend.Visible = true; }
            }
        }

        private void Friend_Leave(object sender, EventArgs e)
        {
            (sender as Friend).Close();
        }
    }
}
