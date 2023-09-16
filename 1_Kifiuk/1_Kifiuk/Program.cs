//Calculator

using System.Linq.Expressions;

class Program
        {
    static void Main(string[] args)
        {
        while (true)
        {
            Console.Clear();
            double firstValue, secondValue;
            string action;

            try
            {
                Console.WriteLine("Введiь число 1");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введiть число 2");
                secondValue = double.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Не вдалось опрацювати");
                Console.ReadLine();

                continue;
            }

           
            Console.WriteLine("Виберіть операцію:'+' '-' '*' '/' ");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine("0");
                    }
                    else
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    break;
                default:
                    Console.WriteLine("Помилка!");
                    break;
            }

            Console.ReadLine();
        }
    }
            
}

