using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

namespace WebApplication
{
    public class User
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public User()
        {
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
                            return true;
                    }
                }
                return false;
            }
            catch { return false; }
        }
    }
}
