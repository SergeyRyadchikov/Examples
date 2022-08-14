//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Enter the size fo massive");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int[,] massive = new int[m,n];


void PrintMatrix(int[,] matrix)
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
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = new Random().Next(-20, 20);
        }
    }
}

int sumD1 = 0;
int sumD2 = 0;

void FindSumDiagonal(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == j) sumD1 = sumD1 + massive[i,j];
            if(i + j == m - 1) sumD2 = sumD2 + massive[i,j];
        }
    }
    Console.WriteLine($"Sum D1 = {sumD1}");
    Console.WriteLine($"Sum D2 = {sumD2}");
}

try
{
    FillMatrix(massive);
    PrintMatrix(massive);
    FindSumDiagonal(massive);
}
catch 
{
    
    Console.Write("Надо что бы n = m");
}

