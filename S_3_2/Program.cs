Console.Write("Введите четверть: ");
int aa = Convert.ToInt32(Console.ReadLine());

void check_(int x)
{
    if (x == 1) Console.WriteLine("x > 0 и y > 0");
    else if (x == 4) Console.WriteLine("x > 0 и y < 0");
    else if (x == 3) Console.WriteLine("x < 0 и y < 0");
    else if (x == 2) Console.WriteLine("x < 0 и y > 0");
    else Console.WriteLine("Такой четверти не существует");
}
check_(aa);
