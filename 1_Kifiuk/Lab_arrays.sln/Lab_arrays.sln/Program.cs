﻿using System;

class Program
{
    static void Main()
    {
        // 1 завдання одновимірних масивів
        Console.Write("Введiть розмiр масиву: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введiть число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }

        Console.WriteLine($"Сума всiх чисел у масивi: {sum}");

        // 2 завдання одновимірних масивів
        Console.Write("2. Введiть розмiр масиву: ");
        int k = int.Parse(Console.ReadLine());

        int[] knumbers = new int[n];

        for (int i = 0; i < k; i++)
        {
            Console.Write($"Введiть число {i + 1}: ");
            knumbers[i] = int.Parse(Console.ReadLine());
        }

        bool isPalindrome = IsPalindrome(knumbers);

        if (isPalindrome)
        {
            Console.WriteLine("Масив є палiндромом.");
        }
        else
        {
            Console.WriteLine("Масив не є палiндромом.");
        }

        static bool IsPalindrome(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            {
                if (arr[left] != arr[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
        // 3 завдання одновимірних масивів

        Console.Write("3. Введiть розмiр масиву: ");
        int p = int.Parse(Console.ReadLine());

        int[] pnumbers = new int[p];

        for (int i = 0; i < p; i++)
        {
            Console.Write($"Введiть число {i + 1}: ");
            pnumbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Парнi числа у введеному масивi:");

        for (int i = 0; i < p; i++)
        {
            if (pnumbers[i] % 2 == 0)
            {
                Console.WriteLine(pnumbers[i]);
            }
        }
        // 4 завдання одновимірних масивів
        Console.Write("4. Введiть розмiр масиву: ");
        int a = int.Parse(Console.ReadLine());

        int[] anumbers = new int[a];

        for (int i = 0; i < a; i++)
        {
            Console.Write($"Введiть додатнє число {i + 1}: ");
            anumbers[i] = int.Parse(Console.ReadLine());
        }

        int sumOfPositiveNumbers = SumPositiveNumbers(anumbers);
        Console.WriteLine($"Сума всiх додатних чисел у масивi: {sumOfPositiveNumbers}");


        static int SumPositiveNumbers(int[] arr)
        {
            int sum = 0;

            foreach (int anumber in arr)
            {
                if (anumber > 0)
                {
                    sum += anumber;
                }
            }

            return sum;
        }
        // 5 завдання одновимірних масивів

        Console.Write("5. Введiть розмiр масиву: ");
        int l = int.Parse(Console.ReadLine());

        int[] lnumbers = new int[l];

        for (int i = 0; i < l; i++)
        {
            Console.Write($"Введiть число {i + 1}: ");
            pnumbers[i] = int.Parse(Console.ReadLine());
        }

        int smallestIndex = FindSmallestIndex(numbers);
        Console.WriteLine($"Найменший iндекс елемента у масивi: {smallestIndex}");

    static int FindSmallestIndex(int[] arr)
    {
        if (arr.Length == 0)
        {
            return -1;
            // -1, якщо масив порожній
        }

        int smallestIndex = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[smallestIndex])
            {
                smallestIndex = i;
            }
        }

        return smallestIndex;
    }
        //6 завдання одновимірних масивів
        Console.Write("6. Введiть розмiр масиву: ");
        int b = int.Parse(Console.ReadLine());

        int[] bnumbers = new int[b];

        for (int i = 0; i < b; i++)
        {
            Console.Write($"Введiть вiд'ємнє число {i + 1}: ");
            anumbers[i] = int.Parse(Console.ReadLine());
        }

        int sumOfNegativeNumbers = 0;

        foreach (int bnumber in bnumbers)
        {
            if (bnumber < 0)
            {
                sumOfNegativeNumbers += bnumber;
            }
        }
        Console.WriteLine($"Сума всiх вiд'ємнхи чисел у масивi: {sumOfNegativeNumbers}");


    }
}
