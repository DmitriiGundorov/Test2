﻿// Группы методов
// Первая группа методов — не принимает никаких аргументов и ничего не возвращают
void Metod1() //Metod1 - идентификатор метода
{
    Console.WriteLine("Автор …");
}

//Вторая группа методов — принимает какие-то аргументы, но ничего не возвращают
void Metod2(string msg) //void ключевое слово, дальше идентификатор, в скобках указаны какие-то аргументы.
{
    Console.WriteLine(msg); // оператор, в скобках указан принятый аргумент.
}
Metod2(“Текст сообщения”); // Metod2 является идентификатором, а в скобках указан текст, выводимый в консоли.

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg); // где переменная count отображает на экране определённое количество сообщений msg.
        i++;
    }
}
Metod21(“Текст”, 4); // метод вызывает Текст, после запятой указано количество вызовов, в нашем случае 4.

// Третья группа методов — может что-то возвращать, но не принимает никаких аргументов. Например, может служить для генерации случайных данных.
