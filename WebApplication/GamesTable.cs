using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;


namespace WebApplication
{
    public class GamesTable
    {
        public static List<Game> Games { get; set; }
        public static List<Game> OwnedGames { get; set; }

        public static Game FindGameByID(int id)
        {
            return Games.First(game => game.ID == id);
        }

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

        public static void UpdateGame(Game game)
        {
            try
            {
                using (MySqlConnection connection = new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002"))
                {
                    connection.Open();
                    MySqlCommand command = new(
                        "UPDATE games SET id=@gameID " +
                        "name=@gameName," +
                        "description=@gameDesc " +
                        "price=@gamePrice " +
                        "WHERE @gameID=id"
                        , connection);
                    command.Parameters.AddWithValue("@gameID", game.ID);
                    command.Parameters.AddWithValue("@gameName", game.Name);
                    command.Parameters.AddWithValue("@gameDesc", game.Description);
                    command.Parameters.AddWithValue("@gamePrice", game.Price);

                    command.ExecuteNonQuery();
                }
            }
            catch { }
        }
    }

    public class Game
    {
        [Required(ErrorMessage = "You are missing an id")]
        public int ID { get; }
        [Required(ErrorMessage = "You are missing a name")]
        [MinLength(2, ErrorMessage ="Game name cannot be that short")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "You are missing a price")]
        [Range(0,999.99,ErrorMessage = "Price must be between 0 and 999.99")]
        public decimal Price { get; set; }

        public Game()
        {

        }

        public Game(int id,string name, string desc, decimal price)
        {
            ID = id;
            Name = name;
            Description = desc;
            Price = price;
        }
    }
}
