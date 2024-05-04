namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Champion RonnieColeman = new Champion(136.00);
            RonnieColeman.Comp = "Ronnie Coleman";
            RonnieColeman.Lightweight();

            Second JayCutler = new Second(105.00, "Jay Cutler");
            JayCutler.Lift();
        }
    }

    public class Champion
    {
        public string Comp { get; set; }

        private double Weight { get; set; }

        public Champion() { }

        public Champion(double weight)
        {
            Weight = weight;
        }

        public Champion(double weight, string comp):this(weight)
        {
            Comp = comp ;
        }

        public void Lightweight()
        {
            Console.WriteLine($"{Comp} - {Weight} Lightweight!");
        }
    }
    public class Second 
    {
        public string Comp { get; set; }

        private double Weight { get; set; }

        public Second() { }

        public Second(double weight)
        {
            Weight = weight;
        }

        public Second(double weight, string comp) : this(weight)
        {
            Comp = comp;
        }

        public void Lift()
        {
            Console.WriteLine($"{Comp} - {Weight} Lift!");
        }
    }
}