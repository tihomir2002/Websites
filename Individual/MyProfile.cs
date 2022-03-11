namespace Individual
{
    public class MyProfile : User
    {
        private List<Game> owned_games;

        public List<Game> Owned_Games { get => owned_games; }
        
        public MyProfile(int id, string name, string description, Bitmap image)
        {
            this.id = id;
            this.name = name;
            this.description = description;

            if (image == null)
                this.image = Properties.Resources.DefaultImage;
            else this.image = image;

            owned_games = new();
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
            //send vars to db
        }
    }
}
