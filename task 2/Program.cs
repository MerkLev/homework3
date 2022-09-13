Console.Write("введите координату X1=");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату Y1=");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату Z1=");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите координату X2=");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату Y2=");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату Z2=");
int Z2 = Convert.ToInt32(Console.ReadLine());

double d=Math.Sqrt(Math.Pow(X2 - X1,2)+Math.Pow(Y2 - Y1,2)+Math.Pow(Z2 - Z1,2));
    
Console.Write($"Расстояние между точками: {(d)}");