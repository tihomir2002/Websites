﻿using MySql.Data.MySqlClient;

namespace Individual
{
    public partial class Friend : Form
    {
        private ListBox lsbFriends;
        private Profile profile;
        private ListBox lsbActivity;
        private MyProfile myProfile;

        public Friend(MyProfile myProfile,Profile profile,ListBox listBox, ListBox listBox1)
        {
            InitializeComponent();
            this.profile = profile;
            this.myProfile = myProfile;
            lsbFriends = listBox;
            lsbActivity = listBox1;
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

            //Add friend in the database
            using (MySqlConnection con =
                new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
            {
                con.Open();
                MySqlCommand cmd = new(
                "INSERT INTO friendship " +
                "SELECT * FROM(SELECT @id AS name, @friend_id AS address) " +
                "AS tmp WHERE NOT EXISTS" +
                "(SELECT friend_id FROM friendship WHERE friend_id = @friend_id) " +
                "LIMIT 1; ", con);

                foreach (Profile profile in FriendList.Friends)
                {
                    cmd.Parameters.AddWithValue("@id", myProfile.ID);
                    cmd.Parameters.AddWithValue("@friend_id", profile.ID);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
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
