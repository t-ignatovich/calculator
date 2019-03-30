using System;

public static class AppEntry
{
    // главная точка входа для приложения
    private static void Main()
    {
        string command = "";

        while (true)
        {
            Console.Write("> ");
            command = Console.ReadLine();

            switch (command)
            {
                case "sum":
                    Calculator.Sum();
                    break;
                case "sub":
                    Calculator.Subtraction();
                    break;
                case "mult":
                    Calculator.Multiplication();
                    break;
                case "div":
                    Calculator.Division();
                    break;
                case "exit":
                    return;

                default:
                    Console.WriteLine(Environment.NewLine +
                                      "ОШИБКА: Команда не распознана." +
                                      Environment.NewLine);
                    break;
            }
        }
    }
}
