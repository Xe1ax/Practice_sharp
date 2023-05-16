namespace Task_4
{
    public sealed class ChocolateBoiler
    {
        private static volatile ChocolateBoiler instance;
        private static readonly object syncRoot = new object();

        private bool empty;
        private bool boiled;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new ChocolateBoiler();
                        }
                    }
                }
                return instance;
            }
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                boiled = true;
            }
        }

        public bool IsEmpty()
        {
            return empty;
        }

        public bool IsBoiled()
        {
            return boiled;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.Instance;
            boiler1.Fill();
            Console.WriteLine("Бойлер 1 пустой: " + boiler1.IsEmpty()); 
            Console.WriteLine("Бойлер 1 нагрет: " + boiler1.IsBoiled()); 

            ChocolateBoiler boiler2 = ChocolateBoiler.Instance;
            boiler2.Fill();
            Console.WriteLine("Бойлер 2 пустой: " + boiler2.IsEmpty()); 
            Console.WriteLine("Бойлер 2 нагрет: " + boiler2.IsBoiled()); 

            Console.WriteLine("Бойлер 1 и бойлер 2 имеют одинаковое состояние: " + (boiler1 == boiler2));

            boiler1.Boil();
            Console.WriteLine("Бойлер 1 нагрет: " + boiler1.IsBoiled());
            Console.WriteLine("Бойлер 2 нагрет: " + boiler2.IsBoiled());

            boiler1.Drain();
            Console.WriteLine("Бойлер 1 заполнен: " + boiler1.IsEmpty());
            Console.WriteLine("Бойлер 2 заполнен: " + boiler2.IsEmpty());

            Console.ReadLine();
        }

    }
}