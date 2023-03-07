// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго
Console.WriteLine("Введите первое число:");

int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число:");

int num2 = int.Parse(Console.ReadLine()!);

        // проверяем, является ли num1 квадратом num2
        if (num2 == num1 * num1)
        {
            Console.WriteLine($"{num1} является квадратом числа {num2}");
        }
        else
        {
            Console.WriteLine($"{num1} не является квадратом числа {num2}");
        }

        Console.ReadLine();