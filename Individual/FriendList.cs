using MySql.Data.MySqlClient;

namespace Individual
{
    public static class FriendList
    {
        private static List<Profile> friends;
        private static List<Profile> profiles;
        private static MyProfile myProfile;

        public static List<Profile> Profiles { get => profiles; }
        public static List<Profile> Friends { get => friends; }

        public static void Init(MyProfile _myProfile)
        {
            myProfile = _myProfile;
            friends = new List<Profile>();
            profiles = new List<Profile>();

            using (MySqlConnection con = 
                new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
            {
                con.Open();
                MySqlCommand mySqlCommand = new("SELECT * from profiles where @id!=id", con);
                mySqlCommand.Parameters.AddWithValue("@id", myProfile.ID);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Bitmap image = null;
                    //dataReader.GetString(3); download image from link

                    Profile profile = new(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2) ,image);
                    profiles.Add(profile);
                }
                dataReader.Close();

                mySqlCommand.CommandText = "SELECT * FROM profiles " +
                    "WHERE id IN(SELECT friend_id from friendship WHERE @id=id)";
                mySqlCommand.Parameters.Clear();
                mySqlCommand.Parameters.AddWithValue("@id",myProfile.ID);

                dataReader = mySqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Bitmap image = null;
                    //dataReader.GetString(3); download image from link

                    Profile profile = new(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), image);
                    friends.Add(profile);
                }

                dataReader.Close();
            }
        }
    }
}
