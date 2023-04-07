namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину окружность");
            int diametr = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь круга,ограниченного этой окружностью равна : {0}", (Math.Pow(2, diametr)) / (4 * Math.PI));
        }
    }
}