Console.Write("Введите кооординату x первой точки: ");
double a_x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кооординату y первой точки: ");
double a_y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кооординату x второй точки: ");
double b_x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кооординату y второй точки: ");
double b_y = Convert.ToDouble(Console.ReadLine());
double points (double a_x, double a_y, double b_x, double b_y)
{
    double num = (b_x - a_x) * (b_x - a_x) + (b_y - a_y) * (b_y - a_y);
    return Math.Sqrt(num);
}

Console.WriteLine(points(a_x, a_y, b_x, b_y));
