using MySql.Data.MySqlClient;

namespace Individual
{
    internal class Store
    {
        private MyProfile myProfile;
        private List<Game> availableGames;
        private Database database;

        public List<Game> AvailableGames { get => availableGames; }

        public Store(MyProfile profile)
        {
            myProfile = profile;
            database = new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;");
            availableGames = database.GetAllGames();
            myProfile.OwnedGames = database.GetOwnedGames(myProfile.ID);
        }

        public Game SearchGame(string name)
        {
            return availableGames.First(game=>game.Name==name);
        }

        public void BuyGame(Game game)
        {
            myProfile.OwnedGames.Add(game);
            SaveChanges();
        }

        public void SaveChanges()
        {
            try
            {
                using (MySqlConnection con =
                    new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
                {
                    con.Open();
                    MySqlCommand cmd = new(
                                        "INSERT INTO owned_games " +
                                        "SELECT * FROM(SELECT @id AS game_id, @owner_id AS owner) " +
                                        "AS tmp WHERE NOT EXISTS" +
                                        "(SELECT id FROM owned_games WHERE id = @id) " +
                                        "LIMIT 1; ", con);

                    foreach (Game game in myProfile.OwnedGames)
                    {
                        cmd.Parameters.AddWithValue("@id",game.ID);
                        cmd.Parameters.AddWithValue("@owner_id", myProfile.ID);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                }
            }
            catch (AggregateException) { MessageBox.Show("You need a vpn connection."); }
            catch (Exception ex) { MessageBox.Show("Error saving games: " + ex.ToString()); }
        }
    }
}
