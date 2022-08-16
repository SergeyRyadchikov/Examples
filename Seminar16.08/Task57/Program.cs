// Задача 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

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

void FindElement(int[,] array, int find, List<int> numList)  // в качестве аргумента передаем множество numList
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == find)
            {
                count++;
            }
        }
    }
    numList.Add(find);                                                      //Добавляем элемент в множество
    Console.WriteLine($"Число {find} встречается {count} раз");
}


Console.WriteLine("Введите количество строк: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] massive = new int[line, column];

FillMatrix(massive);
PrintMatrix(massive);
Console.WriteLine();
List<int> numsList = new List<int>();    // создали множество (набор уникальных элементов), на данный момент пустой
for (int i = 0; i < line; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (numsList.Contains(massive[i, j]) == false)    // Если елемента в множестве нет, то вызывается функция
            FindElement(massive, massive[i, j], numsList);
    }
}

