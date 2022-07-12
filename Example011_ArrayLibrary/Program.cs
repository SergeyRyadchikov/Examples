void FillArray(int[] collection)       // метод заполнения массива      
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

// void это метод, который не возвращает значение 


void PrintArray(int[] col)            // метод печати массива на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)       // метод, который возвращает значение
{
    int count = collection.Length;
    int index = 0;
    int position = -1;            // Прием, который позволит понять, что если вышло значение -1, то такого элемента в массиве нет

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;                            // Оператор, который возвращает значение
}

int[] array = new int[10];      // означает: "Создай новый массив, в котором будет 10 элементов
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 46);
Console.WriteLine(pos);