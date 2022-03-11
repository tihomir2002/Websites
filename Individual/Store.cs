using MySql.Data.MySqlClient;

namespace Individual
{
    internal class Store
    {
        private MyProfile myProfile;
        private List<Game> available_games;

        public List<Game> Games { get => available_games; }

        public Store(MyProfile profile)
        {
            myProfile = profile;
            available_games = new();

            LoadGames();
            LoadOwnedGames();
        }

        private void LoadGames()
        {
            try
            {
                using (MySqlConnection con =
                    new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
                {
                    con.Open();
                    MySqlCommand cmd = new("SELECT * FROM games", con);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Game game = new Game(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetDecimal(3));
                        available_games.Add(game);
                    }

                    dataReader.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading games: " + ex.ToString()); }
        }

        private void LoadOwnedGames()
        {
            try
            {
                using (MySqlConnection con =
                    new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
                {
                    con.Open();
                    MySqlCommand cmd = new("SELECT * FROM games WHERE id IN" +
                        "(SELECT id from owned_games WHERE owner_id=@id)", con);
                    cmd.Parameters.AddWithValue("@id",myProfile.ID);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while(dataReader.Read())
                    {
                        myProfile.Owned_Games.Add(
                            new Game(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetDecimal(3)));
                    }

                    dataReader.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading owned games: " + ex.ToString()); }
        }

        public Game SearchGame(string name)
        {
            return available_games.First(game=>game.Name==name);
        }

        public void BuyGame(Game game)
        {
            myProfile.Owned_Games.Add(game);
        }

        public void SaveChanges()
        {
            try
            {
                using (MySqlConnection con =
                    new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
                {
                    con.Open();
                    MySqlCommand cmd = new("INSERT INTO owned_games VALUES(@id,@owner_id)", con);
                    
                    foreach(Game game in myProfile.Owned_Games)
                    {
                        cmd.Parameters.AddWithValue("@id",game.ID);
                        cmd.Parameters.AddWithValue("@owner_id", myProfile.ID);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error saving games: " + ex.ToString()); }
        }
    }
}
