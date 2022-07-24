//=======Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// Маленькие буквы "к" заменить большими "К",
// Большие буквы "С" заменить маленькими "с".

// обращение к элементам строки
// string s = "qwerty"
//             012345  индексы
// s[3] будет соответствовать значение r


string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Венценгероде, "
            + " вы бы взяли приступом Согласие пруСского короля. "
            + " Вы так красноречивы. Вы дадите мне чаю?";


string Replace(string text, char OldValue, char NewValue)
{
    int length = text.Length;
    string result = string.Empty;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;

}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);



//Упорядочить (отсортировать) массив

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)                      //Данный метод печатает в консоль массив
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortMin(int[] array)                        // Данный метод сортирует массив от мин до макс
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporarray = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporarray;

    }
}


void SelectionSortMax(int[] array)                        // Данный метод сортирует массив от макс до мин
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporarray = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporarray;

    }
}


PrintArray(arr);
SelectionSortMin(arr);
PrintArray(arr);
SelectionSortMax(arr);
PrintArray(arr);