namespace Individual
{
    public class Profile : User
    {

        public Profile(int id, string name, string description, Bitmap image)
        {
            this.id = id;
            this.name = name;
            this.description = description;

            if (image == null)
                this.image = Properties.Resources.DefaultImage;
            else this.image = image;
        }

        public void AddFriend()
        {
            FriendList.friends.Add(this);
        }

        public void RemoveFriend()
        {
            FriendList.friends.Remove(this);
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
