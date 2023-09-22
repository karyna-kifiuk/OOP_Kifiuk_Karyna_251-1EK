using System;
class Program
{
    static void Main()
    {
        double number;

        Console.WriteLine("1. Введiть число:");
        number = double.Parse(Console.ReadLine());

        if (number == 0)
        {
            Console.WriteLine("Число рiвне нулю");
        }
        else if (number > 0)
        {
            Console.WriteLine("Число є додатним");
        }
        else 
        { 
            Console.WriteLine("Число вiд'ємним");
        }

        //2 завдання

        double year;

        Console.WriteLine("2. Введiть рiк:");
        year = double.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("Цей рiк є висoкосним");
        }
        else
        {
            Console.WriteLine("Цей рiк не є висoкосним");
        }

        //3 завдання

        double profit, rate, costs, tax;

        Console.WriteLine("3. Вкажiть ваш мiсячний дохiд:");
        profit = double.Parse(Console.ReadLine());

        Console.WriteLine("Вкажiть вашi мiсячнi витрати:");
        costs = double.Parse(Console.ReadLine());

        Console.WriteLine("Вкажiть вiдсоткову ставку:");
        rate = double.Parse(Console.ReadLine());

        tax = ((profit * 12) - (costs * 12)) / (rate *100);
        Console.WriteLine($"Ваш рiчний податок на прибуток:{tax}");

        //4 завдання

        double symbol;

        Console.WriteLine("4. Введiть англiйську букву:");
        symbol = char.Parse(Console.ReadLine());

        if ((symbol == 'A') || (symbol == 'E') || (symbol == 'I') || (symbol == 'O') || (symbol == 'U'))
        {
            Console.WriteLine("Буква є голосною");
        }
        else
        {
            Console.WriteLine("Буква є приголосною");
        }

        //5 завдання

        double maxNumber;

        Console.Write("5. Введiть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введiть третє число: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        maxNumber = Math.Max(num1, Math.Max(num2, num3));

        Console.WriteLine($"Найбiльше число: {maxNumber}");

        //6 завдання
        Console.WriteLine($"6. Введiть вiк");
        int x = Convert.ToInt32(Console.ReadLine());
        string greeting = "";
        if (x >= 12 && x < 18)
            greeting = "Ви пiдлiток!";
        else if (x < 12)
            greeting = "Ти ще малюк";
        else
        {
            Console.WriteLine("Вiтаю, Вам, або на роботу, або в унiверситет, або в армiю");
        }

        Console.WriteLine(greeting);

        //7 завдання

        Console.Write("7. Введiть число:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0 && num % 3 == 0)
        {
            Console.WriteLine("Число є парним та дiлиться на 3");
        }
        if (num % 2 != 0 && num % 3 == 0)
        {
            Console.WriteLine("Число є непарним, але дiлиться на 3");
        }
        if (num % 2 == 0 && num % 3 != 0)
        {
            Console.WriteLine("Число є парним, але не дiлиться на 3");
        }
        else
        {
            Console.WriteLine("Число є непарним та не дiлиться на 3");
        }

        //8 завдання

        Console.WriteLine("8. Введiть довжини трьох сторiн трикутника:");

        Console.Write("Сторона a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("a");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("b");
        }
        else if (c > a && c > b)
        {
            Console.WriteLine("c");
        }
        else if (a == b && b > c)
        {
            Console.WriteLine("a i b є одинаковими i довшими за сторону c");
        }
        else if (a==c && c>b)
        {
            Console.WriteLine("a i c є одинаковими i довшими за сторону b");
        }
        else if (b == c && c > a)
        {
            Console.WriteLine("b i c є одинаковими i довшими за сторону a");
        }
        else
        {
            Console.WriteLine("Трикутник є рiвностороннiм");
        }
    }
}
