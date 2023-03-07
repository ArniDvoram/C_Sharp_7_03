using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер дня недели (1-7):");

        int dayNum = int.Parse(Console.ReadLine());

        string dayName = "";

        switch (dayNum)
        {
            case 1:
                dayName = "Понедельник";
                break;
            case 2:
                dayName = "Вторник";
                break;
            case 3:
                dayName = "Среда";
                break;
            case 4:
                dayName = "Четверг";
                break;
            case 5:
                dayName = "Пятница";
                break;
            case 6:
                dayName = "Суббота";
                break;
            case 7:
                dayName = "Воскресенье";
                break;
            default:
                Console.WriteLine("Неверный номер дня недели.");
                break;
        }

        if (!string.IsNullOrEmpty(dayName))
        {
            Console.WriteLine($"День недели под номером {dayNum} - это {dayName}.");
        }

        Console.ReadLine();
    }
}

