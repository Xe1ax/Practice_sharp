namespace Task_1
{
    class Settlement
    {
        protected string name;

        public Settlement(string name)
        {
            this.name = name;
        }

        public virtual double PopulationDensity()
        {
            return 0;
        }

        public virtual void PrintResults()
        {
            Console.WriteLine("Settlement: {0}", name);
        }
    }

    class Village : Settlement
    {
        private int numHouses;
        private int numResidentsPerHouse;
        private double area;

        public Village(string name, int numHouses, int numResidentsPerHouse, double area)
            : base(name)
        {
            this.numHouses = numHouses;
            this.numResidentsPerHouse = numResidentsPerHouse;
            this.area = area;
        }

        public override double PopulationDensity()
        {
            return (double)(numHouses * numResidentsPerHouse) / area;
        }

        public override void PrintResults()
        {
            base.PrintResults();
            Console.WriteLine("Population density: {0} people per sq. km", PopulationDensity());
        }
    }

    class City : Settlement
    {
        private int numResidents;
        private double area;

        public City(string name, int numResidents, double area)
            : base(name)
        {
            this.numResidents = numResidents;
            this.area = area;
        }

        public override double PopulationDensity()
        {
            return (double)numResidents / area;
        }

        public override void PrintResults()
        {
            base.PrintResults();
            Console.WriteLine("Population density: {0} people per sq. km", PopulationDensity());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Settlement[] settlements = new Settlement[5];
            settlements[0] = new Village("Village 1", 50, 5, 10);
            settlements[1] = new Village("Village 2", 70, 6, 15);
            settlements[2] = new City("City 1", 1000, 50);
            settlements[3] = new City("City 2", 1500, 70);
            settlements[4] = new City("City 3", 2000, 100);

            foreach (Settlement settlement in settlements)
            {
                settlement.PrintResults();
            }

            Console.ReadLine();
        }
    }
}