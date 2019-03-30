using System;

public static class Calculator
{
    // выводит на консоль результат сложения двух целых чисел
    public static void Sum()
    {
        Console.WriteLine();

        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");

        Console.WriteLine();
    }

    // выводит на консоль результат вычитания двух целых чисел
    public static void Subtraction()
    {
        Console.WriteLine();
    }

    // выводит на консоль результат произведения двух целых чисел
    public static void Multiplication()
    {
        Console.WriteLine();
    }

    // выводит на консоль результат деления двух целых чисел
    public static void Division()
    {
        Console.WriteLine();
    }
}
