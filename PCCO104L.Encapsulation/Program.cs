namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Champion RonnieColeman = new Champion(136.00, "8 times");
            RonnieColeman.Comp = "Ronnie Coleman";
            RonnieColeman.Lightweight();

            Second JayCutler = new Second(105.00, "4 times");
            JayCutler.Comp = "Jay Cutler";
            JayCutler.Lift();

            Third FrancoColumbu = new Third(84.00, "3 times");
            FrancoColumbu.Comp = "FrancoColumbu";
            FrancoColumbu.Last();
        }
    }

    public class Champion
    {
        private string Won {  get; set; }

        public string Comp { get; set; }

        private double Weight { get; set; }

        public Champion() { }

        public Champion(double weight)
        {
            Weight = weight;
        }
        public Champion(double weight, string won) : this(weight)
        {
            Won = won;
        }
        public Champion(double weight, string won, string comp): this(weight,won)
        {
            Comp = comp ;
        }

        public void Lightweight()
        {
            Console.WriteLine($"{Comp} - {Won} - {Weight} Lightweight!");
        }
    }
    public class Second 
    {
        private string Won { get; set; }

        public string Comp { get; set; }

        private double Weight { get; set; }

        public Second() { }

        public Second(double weight)
        {
            Weight = weight;
        }
        public Second(double weight, string won) : this(weight)
        {
            Won = won;
        }
        public Second(double weight, string won, string comp) : this(weight, won)
        {
            Comp = comp;
        }

        public void Lift()
        {
            Console.WriteLine($"{Comp} - {Won} - {Weight} Lift!");
        }
    }
    public class Third
    {
        private string Won { get; set; }

        public string Comp { get; set; }

        private double Weight { get; set; }

        public Third() { }

        public Third(double weight)
        {
            Weight = weight;
        }
        public Third(double weight, string won) : this(weight)
        {
            Won = won;
        }
        public Third(double weight, string won, string comp) : this(weight, won)
        {
            Comp = comp;
        }

        public void Last()
        {
            Console.WriteLine($"{Comp} - {Won} - {Weight} LIFFTT!");
        }
    }
}