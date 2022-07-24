Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 6 || a == 7)
{
    Console.WriteLine("Выходной день");
}
else if (a >= 1 && a <= 5)
{
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}