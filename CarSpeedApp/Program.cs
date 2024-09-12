// Задание 1: Скорость автомобилей

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите скорость первого автомобиля (V1) в км/ч: ");
        double V1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите скорость второго автомобиля (V2) в км/ч: ");
        double V2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите расстояние между автомобилями (S) в км: ");
        double S = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите время (T) в часах: ");
        double T = Convert.ToDouble(Console.ReadLine());

        // Определяем новое расстояние
        double newDistance = S + (V1 + V2) * T;
        Console.WriteLine($"Расстояние между автомобилями через {T} часов: {newDistance} км");
    }
}

