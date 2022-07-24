Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 9999 && N < 100000)
{
    if (N / 10000 == N % 10)
    {
        if (N / 1000 % 10 == N % 100 / 10)
        {
            Console.Write("Является палиндромом");
        }
        else Console.Write("Не является палиндромом");
    }
    else Console.Write("Не является палиндромом");
}
else Console.Write("Ваше число не является пятизначным");