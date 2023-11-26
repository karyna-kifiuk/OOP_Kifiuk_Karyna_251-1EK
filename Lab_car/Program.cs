using System;

class Car
{
    public string Name;
    public string Color;
    public double Price;

    public Car()
    {
    }

    public Car(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }

    public void Input()
    {
        Console.WriteLine($"Enter details for {Name}:");
        Console.Write("Enter color: ");
        Color = Console.ReadLine();
        Console.Write("Enter price: ");
        Price = double.Parse(Console.ReadLine());
    }

    public void Print()
    {
        Console.WriteLine($"Car details - Name: {Name}, Color: {Color}, Price: {Price:C}, Company: {CompanyName}");
    }

    public void ChangePrice(double percentage)
    {
        Price -= Price * (percentage / 100);
    }

    public void ChangeColor(string newColor)
    {
        Color = newColor;
    }

    public string PrintInfo()
    {
        return $"Car details - Name: {Name}, Color: {Color}, Price: {Price:C}, Company: {CompanyName}";
    }
}

class Program
{
    static void Main()
    {
        Car mercedes = new Car("Mercedes", "White", 50000);
        Car audi = new Car("Audi", "Black", 45000);
        Car bmw = new Car("BMW", "Red", 55000);


        mercedes.Input();
        audi.Input();
        bmw.Input();

        mercedes.ChangePrice(10);
        audi.ChangePrice(10);
        bmw.ChangePrice(10);

        Console.WriteLine("Details after price reduction:");
        mercedes.Print();
        audi.Print();
        bmw.Print();

        Console.Write("Enter the new color for White cars: ");
        string newColor = Console.ReadLine();
        if (mercedes.Color.ToLower() == "white") mercedes.ChangeColor(newColor);
        if (audi.Color.ToLower() == "white") audi.ChangeColor(newColor);
        if (bmw.Color.ToLower() == "white") bmw.ChangeColor(newColor);

        Console.WriteLine("Car details as strings:");
        Console.WriteLine(mercedes.PrintInfo());
        Console.WriteLine(audi.PrintInfo());
        Console.WriteLine(bmw.PrintInfo());
    }
}
