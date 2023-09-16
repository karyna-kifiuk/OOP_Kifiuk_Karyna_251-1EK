using System;
class Program
{
    static void Main()
    {
        //1 завдання
        string action;

        Console.Write("1. Введiть перше цiле число (День):");
        int numbe1 = int.Parse(Console.ReadLine());

        Console.Write("Введiть перше цiле число (Мiсяць):");
        int numbe2 = int.Parse(Console.ReadLine());


        Console.Write($"Чи можуть числа бути днем та мiсяцем?");

        if (numbe1 >= 32)
        {
            Console.WriteLine("Це число не може бути днем");
        }
        if (numbe2 >= 13)
        {
            Console.WriteLine("Це число не може бути мiсяцем");
        }

        else
            Console.WriteLine("Так, цi числа можуть бути днем та мiсяцем");

        //2 завдання
        double numeric;

        Console.WriteLine("2. Введiть дiйсне число:");
        numeric = double.Parse(Console.ReadLine());

        int firstDigit = (int)((numeric * 10) % 10);
        int secondDigit = (int)((numeric * 100) % 10);

        int sumOfDigits = firstDigit + secondDigit;
        Console.WriteLine($"Результат: {sumOfDigits} ");

        //3 завдання
        Console.WriteLine($"3. Введiть цiле число x:");
        int x =
            Convert.ToInt32(Console.ReadLine());
        string greeting = "";
        if (x >= 0 && x < 6)
            greeting = "Доброї ночi!";
        else if (x < 12)
            greeting = "Доброго ранку!";
        else if (x < 18)
            greeting = "Добрий день!";
        else if (x <= 24)
            greeting = "Добрий вечiр!";
        else
        {
            Console.WriteLine("Доба триває не бiльше 24 годин)");
        }

        Console.WriteLine(greeting);

        //4 завдання
         Console.Write("4. Введiть перше цiле число: ");
        int num1 =
           Convert.ToInt32(Console.ReadLine());
        Console.Write("Введiть друге цiле число: ");
        int num2 =
            Convert.ToInt32(Console.ReadLine());
        Console.Write("Введiть третє цiле число: ");
        int num3 =
            Convert.ToInt32(Console.ReadLine());
        int max = Math.Max(num1, num2, num3);
        int min = Math.Min(num1, num2, num3);
        Console.WriteLine($"Максимальне число: {max}");
        Console.WriteLine($"Мiнiмальне число: {min}");

        //5 завдання
        Console.Write("5. Введiть довжину прямокутника: ");
        double length =
            Convert.ToDouble(Console.ReadLine());
        Console.Write("Введiть ширину прямокутника: ");
        double width =
            Convert.ToDouble(Console.ReadLine());
        double area = length * width;
        Console.WriteLine($"Площа прямокутника: {area}");

        //6 завдання
        Console.Write("6. Введiть цiле число:");
        int inputNumber =
        Convert.ToInt32(Console.ReadLine()) ;
        string parity = (inputNumber % 2 == 0) ? "парне" : "непарне";
        Console.WriteLine($"Число {inputNumber} є {parity}." );

        // Завдання 7
        Console.Write("7. Введiть температуру в градусах Цельсiя:");
        double celsius = 
        Convert.ToDouble(Console.ReadLine()) ;
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit} ");

        // Завдання 8
        Console.Write("8. Введiть значення y: " );
        int y =
        Convert.ToInt32(Console.ReadLine()) ;
        int sumOfNaturalNumbers = (y * (y + 1)) / 2;
        Console.WriteLine( $"Сума перших {y} натуральних чисел: {sumOfNaturalNumbers}");

    }
}
