// дан массив , найти срзнач, медиану, сравнить их

int Avarage(int[] arr)
{
    int res = 0;
    for (int indexStart = 0; indexStart < arr.Length; indexStart++)
    {
        res = res + arr[indexStart];
    }
    res = res / arr.Length;
    return res;
}

void SelectionSortMin(int[] array)
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

int Median(int[] coll)
{
    int parity = coll.Length % 2;
    int res = 0;
    int med = 0;
    if (parity == 0)
    {
        res = coll.Length / 2;
        med = (coll[res] + coll[res - 1]) / 2;
    }
    else
    {
        res = coll.Length / 2;
        med = coll[res];
    }
    return med;
}


void CompareAvarMed(int avar, int med)
{
    if (avar < med) Console.WriteLine("Медиана больше, чем среднее арифметическое");
    else Console.WriteLine("Среднее арифметическое больше медианы");
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

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
}


int[] collection = new int[3];    // допилить , чтобы массив задавался пользователем через пробел
FillArray(collection);
PrintArray(collection);
Console.WriteLine();
int avar = Avarage(collection);
SelectionSortMin(collection);
int med = Median(collection);
Console.WriteLine((avar)+ ", " + (med));
Console.WriteLine();
CompareAvarMed(avar, med);




// Задача последняя

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int[] create_mas (int x)
    {
        int [] array = new int [x];
        for (int i = 0; i < x; i++)
            {
                array[i] = new Random().Next(0,2);
            }
        return array; 
    } 

void PrintAray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}
PrintAray(create_mas(x));


// Задача вторая


void PrintArrray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int[] factor(int N)
{

    int[] myArray = new int[N];
    int F = 1;
    for (int i = 1; i <= N; i++)
    {
        F = F * i;
        myArray[i - 1] = F;
    }
    return myArray;
}
PrintArrray(factor(N));

