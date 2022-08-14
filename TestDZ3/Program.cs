
// int[] CreatingArrayFromString(string EnteringArray, char value)
// {
//     int count = 1;
//     for (int iStr = 0; iStr < EnteringArray.Length; iStr++)
//     {
//         if (EnteringArray[iStr] == value)
//         {
//             count++;
//         }
//     }

//     Console.Write("Размерность массива: \t" + (count));
//     Console.WriteLine();

//     int[] arr = new int[count];
//     int iArr = 0;
//     string save = string.Empty;

//     for (int iStr = 0; iStr < EnteringArray.Length; iStr++)
//     {
//         if (iStr != EnteringArray.Length - 1)
//         {
//             while (EnteringArray[iStr] != value)
//             {
//                 save = save + $"{EnteringArray[iStr]}";
//                 iStr++;
//                 if (iStr == EnteringArray.Length) break;
//             }
//             arr[iArr] = int.Parse(save);
//             iArr++;
//             save = string.Empty;
//         }
//         else
//         {
//             save = save + $"{EnteringArray[iStr]}";
//             arr[iArr] = int.Parse(save);
//         }
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write(array[i] + "; ");
//         else
//         {
//             Console.Write(array[i]);
//             Console.WriteLine();
//         }
//     }
// }

// int CountPositive(int[] array)
// {
//     int count = 0;
//     for(int i=0; i<array.Length; i++)
//     {
//         if (array[i]>0) count ++;
//         else continue;
//     }
//     return count;
// }


// Console.Write("Введите массив через запятую: ");
// string Entering = Console.ReadLine();
// int[] mass = CreatingArrayFromString(Entering, ',');
// PrintArray(mass);
// Console.WriteLine();
// Console.Write($"Количество положительных чисел = {CountPositive(mass)}");



// Console.WriteLine("введите k1, b1, k2, b2 через запятую");
// string values = Console.ReadLine();
// string[] array = values.Split(',');
// double[] arr = new double[] { Convert.ToInt32(array[0]), Convert.ToInt32(array[1]),
//                              Convert.ToInt32(array[2]), Convert.ToInt32(array[3]) };
// double x;
// double y;

// if (arr[0] == arr[2]) Console.WriteLine("Прямые параллельны и точки пересечения не имеют");
// else
// {
//     x = (arr[3] - arr[1]) / (arr[0] - arr[2]);
//     y = (arr[2] * x) + arr[3];
//     Console.Write($"Прямые пересекаются в точке с координатами x = {Math.Round(x, 2)}; y = {Math.Round(y, 2)}");
// }
