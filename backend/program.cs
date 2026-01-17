
using System;
using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Hello, World!");
string a = "y";

while (a == "y")
{
    Console.Write("Введи имя: ");
    string name = Console.ReadLine();

    DateTime today = DateTime.Now;
    string dayRussian = today.ToString("dddd", new CultureInfo("ru-RU"));

    Console.WriteLine($"Привет, {name}!");
    Console.WriteLine(dayRussian);
    Console.Write("Хотите продолжить (y/n): ");
    a = Console.ReadLine().ToLower();
}