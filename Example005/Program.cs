﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!!!");
}
else
{
    Console.Write("Здравствуй, ");
    Console.WriteLine(username);
}