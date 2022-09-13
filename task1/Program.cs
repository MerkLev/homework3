internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        string number = Console.ReadLine();

        if ((number[0] == number[4]) && number[1]==number[3])
        {
            Console.Write("число палиндром");
        }
        else
        {
            Console.Write("число не палиндром");
        }
    }
}