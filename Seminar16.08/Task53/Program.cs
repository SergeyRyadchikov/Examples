// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
// последнюю строку массива.

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write(array[i, j] + "\t");

        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }
    }
}

void ChangeArray(int[,] array)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
}

Console.WriteLine("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[line, column];

FillMatrix(massive);
PrintMatrix(massive);
ChangeArray(massive);
Console.WriteLine();
PrintMatrix(massive);

