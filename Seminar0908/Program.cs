void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else
        {
            Console.Write(array[i]);
            Console.WriteLine();
        }
    }
}

void FillArray(int[] num)
{
    int lenght = num.Length;
    int index = 0;
    while (index < lenght)
    {
        num[index] = new Random().Next(1, 100);
        index++;
    }
}

// // Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Console.WriteLine("Enter the massive size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] massive = new int[size];

// FillArray(massive);
// PrintArray(massive);
// Console.WriteLine();
// int count = size/2;
// int bath = 0;
// for (int i = 0; i < count; i++ )
// {
//     bath = massive[i];
//     massive[i] = massive[size-1 - i];
//     massive[size-1-i] = bath;
// }
// PrintArray(massive);


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

// Console.Write("Введите длину первой стороны: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длину второй стороны: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длину третьей стороны: ");
// int z = Convert.ToInt32(Console.ReadLine());

// if (x<(y+z)&&y<(x+z)&&z<(y+x)) Console.Write("Да, это треугольник");
// else Console.Write("Нет, это не треугольник");



// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string res = string.Empty;

// while(num > 0)
// {
//     res = (num % 2) + res;
//     num = num/2;
// }

// Console.WriteLine(res);


void Fill2Array(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = new Random().Next(0, 10);
        }
    }

}

void Print2Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write(array[i, j] + "; ");
            else
            {
                Console.Write(array[i, j]);
                Console.WriteLine();
            }
        }
    }
}


// c клавиатуры задается размерность двумерного массива, найти максимум и его индекс, найти минимум и его индекс,
// найти среднее арифметическое

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] massive = new int[row, col];

Fill2Array(massive);
Print2Array(massive);

int max = massive[0, 0];
int min = massive[0, 0];

int indMaxI = 0;
int indMaxJ = 0;
int indMinI = 0;
int indMinJ = 0;

double res = 0;
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
    {
        res = res + massive[i, j];
        if (massive[i, j] < min)
    {
        min = massive[i, j];
        indMinI = i;
        indMinJ = j;
    }
    if (massive[i, j] > max)
    {
        max = massive[i, j];
        indMaxI = i;
        indMaxJ = j;
    }
    }
    

}
res = res / (row * col);
Console.Write($"Min = {min}; indexMin: ({indMinI}; {indMinJ}); Max = {max}; indexMax: ({indMaxI}; {indMaxJ}); Среднее арифметическое: {Math.Round(res, 2)}");
                            