// Вид 1     Ничего не принимает, ничего не возвращает

void Method1()
{
    Console.WriteLine("Автор: Рядчиков Сергей");
}

//Method1();


//Вид 2    Что-то принимает, ничего не возвращает

void Method2(string msg)                      //Принимает один аргумент
{
    Console.WriteLine(msg);
}

//Method2("Любой текст");




void Method21(string msg, int count)        // Принимает несколько аргументов
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21("Текст", 5);               //Первый вариант вызова функции

//Method21(count: 7, msg: "Текст");     //Вызов функции с явным указанием какое значение к какому аргументу относится. В этом случае порядок указания аргументов не важен.




//Вид 3                               // Ничего не принимает, что-то возвращает

int Method3()           //обязательно указываем тип данных, который метод будет возвращать
{
    return DateTime.Now.Year;             // обязательно изпользовать оператор return
}

//int year = Method3();           // Вызов метода, который возвращает значение (Через оператор присваивания кладем нужное значение)
//Console.WriteLine(year);        // И выводим в консоль уже значение переменной year




// Вид 4                  Что-то принимает, что-то возвращает

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;   //   string.Empty означает, что в переменную result мы положили пустую строку
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "Sj");     // Вызов метода. Данный метод склеит указанную строку, указанное количество раз
Console.Write(res);