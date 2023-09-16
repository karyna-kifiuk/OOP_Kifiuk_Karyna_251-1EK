//Calculator

class Program
{
    static void Main(string[] args)
    {
        double firstValue, secondValue;
        string action;

        Console.WriteLine("Введіть число 1");
        firstValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть число 2");
        secondValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Виберіть операцію:'+' '-' '*' '/' ");
        action = Console.ReadLine();

        if (action == "+")
        {
            Console.WriteLine(firstValue + secondValue);
        }
        else if (action == "-")
        {
            Console.WriteLine(firstValue - secondValue);
        }
        else if (action == "*")
        {
            Console.WriteLine(firstValue * secondValue);
        }
        else if (action == "/")
            if (secondValue == 0)
                Console.WriteLine("0");
        else
            Console.WriteLine(firstValue/ secondValue);

       else
        {
            Console.WriteLine("Помилка!");
        }

        Console.ReadLine();
    }
}

