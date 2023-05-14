namespace Task_1
{
    delegate string GetColorDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            GetColorDelegate getColorDelegate = null;

            getColorDelegate += GetRedColor;
            getColorDelegate += GetGreenColor;
            getColorDelegate += GetBlueColor;

            string redColor = getColorDelegate();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red color: " + redColor);         

            string greenColor = getColorDelegate();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Green color: " + greenColor);
            
            string blueColor = getColorDelegate();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue color: " + blueColor);
            
            Console.ReadKey();
        }

        static string GetRedColor()
        {
            return "";
        }

        static string GetGreenColor()
        {
            return "";
        }

        static string GetBlueColor()
        {
            return "";
        }
    }
}