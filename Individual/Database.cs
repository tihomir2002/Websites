using MySql.Data.MySqlClient;

namespace Individual
{
    public class Database
    {
        private string connection = "";

        public Database()
        {
            connection = "Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;";
        }
        
        public Database(string connection)
        {
            this.connection = connection;
        }
        
        public List<Game> GetAllGames()
        {
            List<Game> availableGames = new List<Game>();
            try
            {
                using (MySqlConnection con = new(connection))
                {
                    con.Open();
                    MySqlCommand cmd = new("SELECT * FROM games", con);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Game game = new Game(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetDecimal(3));
                        availableGames.Add(game);
                    }

                    dataReader.Close();
                    return availableGames;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading games: " + ex.ToString()); return availableGames; }
        }

        public List<Game> GetOwnedGames(int myProfileID)
        {
            List<Game> ownedGames = new();
            try
            {
                using (MySqlConnection con = new(connection))
                {
                    con.Open();
                    MySqlCommand cmd = new("SELECT * FROM games WHERE id IN" +
                        "(SELECT id from owned_games WHERE owner_id=@id)", con);
                    cmd.Parameters.AddWithValue("@id", myProfileID);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        ownedGames.Add(
                            new Game(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetDecimal(3)));
                    }

                    dataReader.Close();
                    return ownedGames;
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error loading owned games: " + ex.ToString()); 
                return ownedGames; 
            }
        }

        public void AddFriend(int myProfileID, int friendID)
        {
            try
            {
                using (MySqlConnection con = new(connection))
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
                        cmd.Parameters.AddWithValue("@id", myProfileID);
                        cmd.Parameters.AddWithValue("@friend_id", friendID);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
            }
            catch (AggregateException)
            {
                MessageBox.Show("You need a vpn connection.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving friend:" + ex.ToString());
            }
        }

        public void RemoveFriend(int myProfileID,int friendID)
        {
            try
            {
                using (MySqlConnection con = new(connection))
                {
                    con.Open();
                    MySqlCommand cmd = new("DELETE FROM friendship WHERE @id=id AND @friend_id=friend_id", con);

                    cmd.Parameters.AddWithValue("@id", myProfileID);
                    cmd.Parameters.AddWithValue("@friend_id", friendID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (AggregateException)
            {
                MessageBox.Show("You need a vpn connection.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing friend:" + ex.ToString());
            }
        }

        public string GetDefaultPanel(int myProfileID)
        {

            try
            {
                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    con.Open();
                    MySqlCommand mySqlCommand = new("SELECT panel from profiles where id=@id", con);
                    mySqlCommand.Parameters.AddWithValue("@id", myProfileID);
                    string panelName = mySqlCommand.ExecuteScalar().ToString();

                    if (panelName == null)
                        panelName = "pnProfile";

                    return panelName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "pnProfile";
            }
        }

        public List<Profile> GetUsers(MyProfile myProfile)
        {
            List<Profile> profiles = new();
            try
            {
                using (MySqlConnection con = new(connection))
                {
                    con.Open();
                    MySqlCommand mySqlCommand = new("SELECT * from profiles where @id!=id", con);
                    mySqlCommand.Parameters.AddWithValue("@id", myProfile.ID);
                    MySqlDataReader dataReader = mySqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Bitmap image = null;
                        //dataReader.GetString(3); download image from link

                        Profile profile = new(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), image, myProfile);
                        profiles.Add(profile);
                    }
                    dataReader.Close();
                }
            }
            catch (AggregateException) { MessageBox.Show("You vpn need a connection to the database"); }
            catch (Exception ex) { MessageBox.Show("Error loading users:" + ex.ToString()); }
            return profiles;
        }

        public List<Profile> GetFriends(MyProfile myProfile)
        {
            List<Profile> friends = new List<Profile>();
            try
            {
                using (MySqlConnection con = new(connection))
                {
                    con.Open();
                    MySqlCommand mySqlCommand = new("SELECT * FROM profiles " +
                   "WHERE id IN(SELECT friend_id from friendship WHERE @id=id)",con);
                    mySqlCommand.Parameters.AddWithValue("@id", myProfile.ID);

                    MySqlDataReader dataReader = mySqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Bitmap image = null;
                        //dataReader.GetString(3); download image from link

                        Profile profile = new(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), image, myProfile);
                        friends.Add(profile);
                    }

                    dataReader.Close();
                }
            }
            catch (AggregateException) { MessageBox.Show("You vpn need a connection to the database"); }
            catch (Exception ex) { MessageBox.Show("Error loading friends:"+ex.ToString()); }
            return friends;
        }
    }
}
