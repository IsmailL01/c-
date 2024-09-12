
using System;

// Задание 3: Вычисление значения функции

class Program2
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Вычисление значения функции
        double y = 4 * Math.Pow((x - 3), 6) - 7 * Math.Pow((x - 3), 3) + 2;
        Console.WriteLine($"Значение функции y для x = {x}: {y}");
    }
}