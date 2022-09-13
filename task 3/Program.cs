Console.WriteLine("введите число");
int end = Convert.ToInt32(Console.ReadLine());
for (int start = 1; start <= end; start++)
{
    Console.WriteLine(Math.Pow(start,3));
}
