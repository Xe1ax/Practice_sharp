namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderName = "New_folder";
            string pathString = Path.Combine(Environment.CurrentDirectory, folderName);

            if (!Directory.Exists(pathString))
            {
                Directory.CreateDirectory(pathString);
                Console.WriteLine($"Папка {pathString} успешно создана.");
            }
            else
            {
                Console.WriteLine($"Папка {pathString} уже существует.");
            }
        }
    }
}