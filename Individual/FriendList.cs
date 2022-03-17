using MySql.Data.MySqlClient;

namespace Individual
{
    public static class FriendList
    {
        private static List<Profile> friends;
        private static List<Profile> profiles;

        public static List<Profile> Profiles { get => profiles; }
        public static List<Profile> Friends { get => friends; }

        public static void Init(MyProfile _myProfile)
        {
            Database database = new();
            profiles = database.GetUsers(_myProfile);
            friends = database.GetFriends(_myProfile);
        }
    }
}
