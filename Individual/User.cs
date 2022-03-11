namespace Individual
{
    public abstract class User
    {
        protected int id;
        protected string name = "";
        protected string description = "";
        protected Bitmap image = null;
        //protected Status status = Status.ONLINE;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public Bitmap Image { get => image; set => image = value; }
        //public Status Status { get => status; set => status = value; }
    }
}
