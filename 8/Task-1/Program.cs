namespace Task_1
{
    internal class Program
    {
        struct Aeroflot
        {
            public string destination;
            public int flightNumber;
            public string airplaneType; 
        }
        static void Main(string[] args)
        {
            Aeroflot[] flights = new Aeroflot[7];

            Console.WriteLine("Введите данные о 7 рейсах:");
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Введите название пункта назначения рейса " + (i + 1) + ": ");
                flights[i].destination = Console.ReadLine();

                Console.Write("Введите номер рейса " + (i + 1) + ": ");
                flights[i].flightNumber = int.Parse(Console.ReadLine());

                Console.Write("Введите тип самолета для рейса " + (i + 1) + ": ");
                flights[i].airplaneType = Console.ReadLine();

                Console.WriteLine();
            }

            Array.Sort(flights, (a, b) => a.flightNumber.CompareTo(b.flightNumber));

            Console.Write("Введите название пункта назначения: ");
            string destination = Console.ReadLine();
            bool foundFlights = false;

            Console.WriteLine("Рейсы в " + destination + ":");
            foreach (Aeroflot flight in flights)
            {
                if (flight.destination == destination)
                {
                    Console.WriteLine("Рейс " + flight.flightNumber + ", тип самолета: " + flight.airplaneType);
                    foundFlights = true;
                }
            }

            if (!foundFlights)
            {
                Console.WriteLine("Рейсов в " + destination + " не найдено.");
            }

            Console.ReadKey();
        }
    }
}