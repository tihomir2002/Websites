using MySql.Data.MySqlClient;

namespace WebApplication
{
    public class GamesTable
    {
        public static List<Game> Games { get; set; }
        public static List<Game> OwnedGames { get; set; }

        public static void GetGames()
        {
            try
            {
                using(MySqlConnection connection = new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002"))
                {
                    connection.Open();
                    MySqlCommand command = new("SELECT * FROM games", connection);
                    MySqlDataReader reader = command.ExecuteReader();
                    Games = new();

                    while(reader.Read())
                    {
                        Games.Add(new Game(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetDecimal(3)));
                    }
                    reader.Close();
                }
            }
            catch
            {
                Games = new();
                Games.Add(new Game(-1, "Error loading games", "", 0.00m));
            }
        }

        public static void GetOwnedGames()
        {
            try
            {
                using (MySqlConnection connection = new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002"))
                {
                    connection.Open();
                    MySqlCommand command = new("SELECT * FROM games WHERE id IN(SELECT id FROM owned_games " +
                        "WHERE owner_id=@ownerID)", connection);
                    command.Parameters.AddWithValue("ownerID", User.ID);
                    MySqlDataReader reader = command.ExecuteReader();
                    OwnedGames = new();

                    while (reader.Read())
                    {
                        OwnedGames.Add(new Game(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDecimal(3)));
                    }
                    reader.Close();
                }
            }
            catch
            {
                OwnedGames = new();
                OwnedGames.Add(new Game(-1, "Error loading games", "", 0.00m));
            }
        }
    }

    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Game(int id,string name, string desc, decimal price)
        {
            ID = id;
            Name = name;
            Description = desc;
            Price = price;
        }
    }
}
