// Задача 1. Написать программу, которая создает массив с заданной пользователем размерностью и заполняется рандомно от -9 до 9. 
// Далее вывести в консоль сумму положительных и отрицательных элементов массива.

// Console.WriteLine("Введите размерность массива: ");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] mass = new int[size];
//  int sumPos = 0;
//  int sumNeg = 0;
//  for (int i = 0; i < mass.Length; i++)
//  {
//     mass[i] = new Random().Next(-9, 10);  
//     if (mass[i] < 0) sumNeg = sumNeg + mass[i];
//     else sumPos = sumPos + mass[i];
//  }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else
        {
            Console.Write(array[i]);
            Console.WriteLine();
        }
    }
}

//PrintArray(mass);
//Console.Write("Сумма отрицательных равна: " + sumNeg + "\r\n" + "Сумма положительных чисел равна: " + sumPos);




// Задача 2. Написать программу замены элементов массива. 
// Положительные элементы заменяем на соотвествующие отрицательные и наоборот.

// Console.WriteLine("Введите размерность массива: ");
// int s = Convert.ToInt32(Console.ReadLine());
// int[] massive = new int[s];
// for (int i = 0; i < s; i++) massive[i] = new Random().Next(-9, 10);
// PrintArray(massive);

// for (int i = 0; i < s; i++) massive[i] = massive[i] * -1;
// PrintArray(massive);




// Задача 3. Задайте массив. Напишите программу, которая определяет присутвует ли заданное число в массиве.

// Console.WriteLine("Введите размерность массива: ");
// int s = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число, которое надо найти: ");
// int seachNum = Convert.ToInt32(Console.ReadLine());
// int[] massive = new int[s];
// bool z = false;
// for (int i = 0; i < s; i++) 
// {
//     massive[i] = new Random().Next(-9, 10);
//     if (massive[i] == seachNum) z = true;
// }

// PrintArray(massive);
// if (z) Console.Write ("Да");
// else Console.Write("Нет");



// Задача 4. Задайте одномерный массив из 123 случайных чисел. Надите количество отрезков в массиве,
// значения которых находятся в промежутке от 10 до 99.


// Console.Write("Введите размерность массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] mass = new int[size];
// int count = 0;
// bool z = false;
// bool zOld = false;
// for (int i = 0; i < size; i++)
// {
//     mass[i] = new Random().Next(0, 199);
//     zOld = z;
//     if (mass[i] > 10 && mass[i] < 100) z = true;
//     else z = false;
//     if (zOld == false && z == true) count++;
//     else zOld = true;
// }


// PrintArray(mass);
// Console.Write(count);



// Задача 5. Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и тд. 
// Результат запишите в новом массиве.


Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[size];
string newMass = string.Empty;
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(-9, 10);
}
PrintArray(mass);
for (int j = 0; j < size / 2; j++)
{
    newMass = $"{newMass + (mass[j] * mass[size - j - 1]) + ", "}";
}
if (size % 2 != 0) newMass = $"{newMass + mass[size/2]}";
Console.Write(newMass);
