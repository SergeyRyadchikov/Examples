// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.

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

void ChangeMatrix(int[,] array, int[,] newArray)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            newArray[j, i] = array[i, j];
        }
    }
}

Console.WriteLine("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[line, column];

FillMatrix(massive);
PrintMatrix(massive);
Console.WriteLine();
int[,] newMass = new int[line, column];
try
{
    ChangeMatrix(massive, newMass);
    PrintMatrix(newMass);
}
catch
{
    Console.WriteLine("Количество строк не соответствует количеству столбцов");
}


