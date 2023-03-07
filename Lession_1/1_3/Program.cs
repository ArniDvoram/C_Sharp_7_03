Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine()!);

        for (int i = -n; i <= n; i++)
        {
            Console.Write(i + " ");
        }

        Console.ReadLine();
