using MySql.Data.MySqlClient;

namespace Individual
{
    public partial class Friend : Form
    {
        private ListBox lsbFriends;
        private Profile profile;
        private ListBox lsbActivity;

        public Friend(Profile profile,ListBox listBox, ListBox listBox1)
        {
            InitializeComponent();
            lsbFriends = listBox;
            lsbActivity = listBox1;
            this.profile = profile;
        }

        private void btnFriend_Click(object sender, EventArgs e)
        {
            //Hide the button after adding friend
            (sender as Button).Visible = false;

            //Add friend and show it in activity
            profile.AddFriend();
            lsbActivity.Items.Add($"Added {profile.Name} as a friend");//send to db
            
            //Refresh friends list
            lsbFriends.Items.Clear();
            lsbFriends.Items.AddRange(FriendList.Friends.ToArray());
        }

        private void Friend_Load(object sender, EventArgs e)
        {
            pbProfilePicture.Image = profile.Image;
            lbFriendName.Text = profile.Name;
            Text = profile.Name;
            lbFriendDesc.Text = profile.Description;

            if (FriendList.Friends == null)
                return;

            foreach (Profile friend in FriendList.Friends)
            {
                if (friend.Name == profile.Name)
                {
                    btnFriend.Visible = false;
                    btnRemoveFriend.Visible = true;
                    break;
                }
                else { btnFriend.Visible = true; btnRemoveFriend.Visible = false; }
            }
        }

        private void Friend_Leave(object sender, EventArgs e)
        {
            (sender as Friend).Close();
        }

        private void btnRemoveFriend_Click(object sender, EventArgs e)
        {
            //Hide the button after removing friend
            (sender as Button).Visible = false;

            //Remove friend
            profile.RemoveFriend();

            //Refresh friends list
            lsbFriends.Items.Clear();
            lsbFriends.Items.AddRange(FriendList.Friends.ToArray());  
        }
    }
}
