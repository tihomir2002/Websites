using MySql.Data.MySqlClient;

namespace Individual
{
    public class FriendList
    {
        private List<Profile> friends;
        private List<Profile> profiles;
        private MyProfile myProfile;

        public List<Profile> Profiles { get => profiles; }
        public List<Profile> Friends { get => friends; }

        public FriendList(MyProfile myProfile)
        {
            this.myProfile = myProfile;
            friends = new List<Profile>();
            profiles = new List<Profile>();

            using (MySqlConnection con = 
                new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
            {
                con.Open();
                MySqlCommand mySqlCommand = new("SELECT * from profiles", con);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Bitmap image = null;
                    //dataReader.GetString(3); download image from link

                    Profile profile = new(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2) ,image);
                    profiles.Add(profile);
                }

                mySqlCommand.CommandText = "SELECT * from friendship";
                dataReader = mySqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    if(dataReader.GetInt32(0) == myProfile.ID)
                    {
                        Bitmap image = null;
                        //dataReader.GetString(3); download image from link

                        Profile profile = new(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), image);
                        friends.Add(profile);
                    }
                }

                dataReader.Close();
            }
        }

        public void SaveChanges()
        {
            using(MySqlConnection con = 
                new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
            {
                con.Open();
                MySqlCommand cmd = new(
                "INSERT INTO friendship(id,friend_id)" +
                " VALUES(@id,@friend_id)", con);

                foreach(Profile profile in friends)
                {
                    cmd.Parameters.AddWithValue("@id", myProfile.ID);
                    cmd.Parameters.AddWithValue("@name", profile.ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
