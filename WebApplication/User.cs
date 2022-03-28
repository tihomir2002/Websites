using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

namespace WebApplication
{
    public class User
    {
        public static int ID { get; set; }
        [Required(ErrorMessage = "You need to type an username")]
        [MinLength(2, ErrorMessage = "Username can't be less than 2 characters")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "You need to type a password")]
        [MinLength(5, ErrorMessage = "Password needs at least 5 characters")]
        public string Password { get; set; }
        public static string Name { get; set; }
        public static string Description { get; set; }

        public User()
        {
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public bool TryLogin()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002"))
                {
                    conn.Open();
                    MySqlCommand command = new("SELECT * FROM profiles", conn);

                    MySqlDataReader mySqlDataReader = command.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        if (mySqlDataReader["username"].ToString() == Username && mySqlDataReader["password"].ToString() == Password)
                        {
                            ID = mySqlDataReader.GetInt32(0);
                            Name = mySqlDataReader.GetString(1);
                            Description = mySqlDataReader.GetString(2);
                            return true;
                        }
                    }
                }
                return false;
            }
            catch {  return false; }
        }
    }
}
