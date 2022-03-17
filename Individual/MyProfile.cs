using MySql.Data.MySqlClient;

namespace Individual
{
    public class MyProfile : User
    {
        private List<Game> ownedGames;

        public List<Game> OwnedGames { get => ownedGames; set => ownedGames = value; }
        
        public MyProfile(int id, string name, string description, Bitmap image)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            ownedGames = new();

            if (image == null)
                this.image = Properties.Resources.DefaultImage;
            else this.image = image;

        }

        public void ChangeProfile(string name, string description, Bitmap image)
        {
            this.name = name;
            this.description = description;
            this.image = image;
        }

        public void ChangeProfile(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void ChangeProfile(string name, Bitmap image)
        {
            this.name = name;
            this.image = image;
        }

        public void ChangeProfile(Bitmap image)
        {
            this.image = image;
        }

        public void ChangeProfile(string name)
        {
            this.name = name;
        }

        public void SaveChanges()
        {
            try 
            {
                using(MySqlConnection con = new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;"))
                {
                    con.Open();
                    MySqlCommand command = new("UPDATE profiles SET name=@name,description=@desc,image=@img WHERE id=@id",con);
                    command.Parameters.AddWithValue("@name",Name);
                    command.Parameters.AddWithValue("@desc",Description);
                    command.Parameters.AddWithValue("@img",null);
                    command.Parameters.AddWithValue("@id",ID);

                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Could not save profile changes");
                }
            }
            catch(AggregateException)
            {
                MessageBox.Show("Connection error, check your vpn connection.");
            }
            catch(Exception)
            {
                MessageBox.Show("Error saving profile changes.");
            }
        }
    }
}
