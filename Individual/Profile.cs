namespace Individual
{
    public class Profile : User
    {
        private Database database;
        private MyProfile myProfile;

        public Profile(int id, string name, string description, Bitmap image, MyProfile myProfile)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.myProfile = myProfile;

            if (image == null)
                this.image = Properties.Resources.DefaultImage;
            else this.image = image;

            database = new("Server=studmysql01.fhict.local;Uid=dbi486983;Database=dbi486983;Pwd=21092002;");
        }

        public void AddFriend()
        {
            FriendList.Friends.Add(this);
            database.AddFriend(myProfile.ID,ID);
        }

        public void RemoveFriend()
        {
            FriendList.Friends.Remove(this);
            database.RemoveFriend(myProfile.ID,ID);
        }

        public void ChangeNickname(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"{name}";
        }
    }
}
