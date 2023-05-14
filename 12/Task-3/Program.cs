namespace Task_3
{
delegate string StringOperation(string str);

class Program
{
    static string ToUpper(string str)
    {
        return str.ToUpper();
    }

    static string ToLower(string str)
    {
        return str.ToLower();
    }

    static string Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main(string[] args)
    {
        StringOperation strOp = new StringOperation(ToUpper);
        string result = strOp("Hello Pawl!");
        Console.WriteLine(result);

        strOp = new StringOperation(ToLower);
        result = strOp("Hello Pawl!");
        Console.WriteLine(result);

        strOp = new StringOperation(Reverse);
        result = strOp("Hello Pawl!");
        Console.WriteLine(result);
        }
    }
}