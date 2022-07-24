Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(", ");
        position++;
    }

}

int[] array = new int[N];
array[0] = 0;
array[1] = 1;
int index = 2;
while (index < N)
{
    array[index] = array[index - 1] + array[index - 2];
    index++;
}

PrintArray(array);