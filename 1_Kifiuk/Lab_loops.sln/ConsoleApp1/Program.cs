using System;
class Program
{
    static void Main()
    {
        // 1 завдання
        Console.WriteLine("1. Парнi числа вiд 1 до 20");
        for (int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }

        // 2 завдання
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine("2. Сума чисел вiд 1 до 100: " + sum);

        // 3 завдання
        Console.WriteLine("3. Введiть число для таблицi множення: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }

        // 4 завдання
        Console.Write("4. Введiть число для обчислення факторiала: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Факторiал числа {n} дорiвнює {factorial}");

        // 5 завдання
        int sumOfPrimes = 0;

        for (int numb = 2; numb <= 50; numb++)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(numb); i++)
            {
                if (numb % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                sumOfPrimes += numb;
            }
        }

        Console.WriteLine("5. Сума простих чисел вiд 1 до 50: " + sumOfPrimes);

        // 6 завдання
        Console.Write("6. Введiть число: ");
        int decimalNumber = Convert.ToInt32(Console.ReadLine());
        string binaryNumber = Convert.ToString(decimalNumber, 2);
        Console.WriteLine($"Двiйкове представлення числа: {binaryNumber}");

        // 7 завдання
        Console.Write("7. Введiть максимальне число для суми Фiбоначчi: ");
        int maxNumber = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1, count = 0;

        while (sum < maxNumber)
        {
            sum = a + b;
            if (sum < maxNumber)
            {
                count++;
            }
            a = b;
            b = sum;
        }

        Console.WriteLine($"Сума чисел Фiбоначчi менше {maxNumber} дорiвнює {sum}");
        Console.WriteLine($"Кiлькiсть елементiв: {count}");

        // 8 завдання
        Console.Write("8. Введiть перше число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введiть друге число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = 1;

        for (int i = 1; i <= num1 && i <= num2; i++)
        {
            if (num1 % i == 0 && num2 % i == 0)
            {
                gcd = i;
            }
        }

        Console.WriteLine($"НСД чисел {num1} i {num2} дорiвнює {gcd}");
        Console.ReadLine();

    }
}