﻿//string[,] table = new string[2, 5];  запись означает, создай новый двухмерных массив из 2х строчек и 5ти столбцов

// такой массив по умолчанию заполнен пустой строкой (string.Empty)
// индексы такого массива считаются следующим образом:
// table[0, 0]; table[0, 1]; table[0, 2]; table[0, 3]; table[0, 4];
// table[1, 0]; table[1, 1]; table[1, 2]; table[1, 3]; table[1, 4];
// table[1, 2] = "word";  обратились к элементу с индексом строки 1 и столбца 2, записали значение "word"

// ВЫВОД МАССИВА В КОНСОЛЬ
// for (int rows = 0; rows < 2; rows++)
// {                                                              
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }




void PrintMatrix(int[,] matrix)                                  //метод печати двухмерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

// .GetLength() функционал который определяет количество строк и столбцов,
// в скобочках () необзодимо указать индекс , например в массиве int[,] matr = new int[i, j]
// под индексом 0 хранится размерность строк (i), под индексом 1 - столбцов (j)

// int[,] matr = new int[3, 4];
// PrintMatrix(matr);
// Console.WriteLine();
// FillMatrix(matr);
// PrintMatrix(matr);




int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
    {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};


// Метод который закрашивает (заполняет) картинку внутри контура плюсиками. Аргументами должна быть точка внутри рисунка
void FillImage(int i, int j)
{
    if (pic[i, j] == 0)
    {
        pic[i, j] = 1;
        FillImage(i - 1, j);
        FillImage(i, j - 1);
        FillImage(i + 1, j);
        FillImage(i, j + 1);
    }
}


//метод печати двухмерного массива в виде изображения
// А именно, + напечатаются значения не равные 0, те что равны нулю отобразятся в виде пробела
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");

        }
        Console.WriteLine();
    }
}


PrintImage(pic);
Console.WriteLine();
FillImage(9, 10);
PrintImage(pic);




// БОЛЕЕ ПРОСТОЙ ПРИМЕР РЕКУРСИИ (Рекурсия - это функция, кторая вызывает сама себя)

int Factorial(int n)
{
    // 0! == 1;  это запомнить
    // 1! == 1;  это запомнить
    if (n == 0) return 1;
    else return n * Factorial(n - 1);
}

for (int i = 0; i < 40; i++)
{
    //Console.WriteLine($"{i}! = {Factorial(i)}");
}

// Начиная с 17! результат отобрадается неверно, так как тип данных int не может хранить такие большие значения.
// Выход: использовать тип данных double, в котором могут храниться такие большие значения.


// Рекурсия с ичслами фибоначи
// мы помним, что: Первое число == 1, второе число == 1, пожтому в функции прописываем это условие
// int Fibonacci(int i)
// {
//     if (i == 1 || i == 2) return 1;
//     else return Fibonacci(i - 1) + Fibonacci(i - 2);
// }

// for (int n = 1; n < 40; n++)
// {
//     Console.WriteLine($"f({n}) = {Fibonacci(n)}");
// }