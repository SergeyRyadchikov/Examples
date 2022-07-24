
void fillArray (int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1,10);
       
        Console.Write(collection[index]);
        Console.Write(" , ");
        index++;
    }
}

void Max (int [] array)

{   
    int length = array.Length;
    int index = 0;
    int maxIndex = 0;
    int result = array[0];
   while (index<length)
   {
        if(array[index]>result)   
         {
            result = array[index];
            maxIndex = index;
        }
        index++;
   }
// return result;
Console.WriteLine("максимальное значение " + result);
Console.WriteLine("максимальное значение index " + maxIndex);
}
void Min (int [] array)

{   
    int length = array.Length;
    int index = 0;
    int minIndex = 0;
    int result = array[0];
   while (index<length)
   {
        if(array[index]<result)    {
            result = array[index];
            minIndex = index;
        }
        index++;
   }
// return result;
Console.WriteLine("минимальное значение " + result);
Console.WriteLine("минимальное значение index " + minIndex);
}

int [] array = new int[10];

fillArray(array);
Max(array);
Min(array);
//Console.WriteLine(Max(array));