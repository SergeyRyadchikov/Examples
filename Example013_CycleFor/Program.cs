// Цикл for

string Method4(int count, string text)
{
    string result = string.Empty;   //   string.Empty означает, что в переменную result мы положили пустую строку
    for (int i = 0; i < count; i++)    // Цикл содержит в себе инициализацию счетчика, проверку условия, инкримент
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Sj");     // Вызов метода. Данный метод склеит указанную строку, указанное количество раз
//Console.Write(res);



//Вложеный цикл (цикл в цикле)

// Задача. Вывести в консоль таблицу умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");          // Интерполяция строк
    }
    Console.WriteLine();
}