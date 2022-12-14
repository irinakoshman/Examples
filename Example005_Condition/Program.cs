using Internal;
using System;
Console.Write("Введите имя пользователя: ");
string userName = Console.Redline();

if(userName.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(userName);
}