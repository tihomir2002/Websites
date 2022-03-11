namespace Individual
{
    public class Game
    {
        private int id;
        private string name;
        private string desc;
        private decimal price;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => desc; set => desc = value; }
        public decimal Price { get => price; set => price = value; }

        public Game(string name)
        {
            this.name = name;
        }

        public Game(string name,string desc)
        {
            this.name = name;
            this.desc = desc;
        }

        public Game(string name,decimal price)
        {
            this.name = name;
            this.price = price;
        }
        public Game(int id,string name,string desc, decimal price)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{name} - {price}$";
        }
    }
}
