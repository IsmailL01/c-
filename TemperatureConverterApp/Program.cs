using System;

// Задание 2: Перевод температуры Фаренгейта в Цельсий

class Program1
{
    static void Main(string[] args)
    {
        Console.Write("Введите температуру в градусах Фаренгейта (TF): ");
        double TF = Convert.ToDouble(Console.ReadLine());

        // Преобразование в цельсий
        double TC = (TF - 32) * 5 / 9;
        Console.WriteLine($"Температура в градусах Цельсия (TC): {TC}");
    }
}
