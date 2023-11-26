using System;

abstract class Shape
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Shape(string name)
    {
        Name = name;
    }

    public abstract double Area();
    public abstract double Perimeter();
}

class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Square : Shape
{
    private double side;

    public double Side
    {
        get { return side; }
        set { side = value; }
    }

    public Square(string name, double side) : base(name)
    {
        Side = side;
    }

    public override double Area()
    {
        return Math.Pow(Side, 2);
    }

    public override double Perimeter()
    {
        return 4 * Side;
    }
}

class Program
{
    static void Main()
    {
        Circle circle1 = new Circle("Circle 1", 5);
        Circle circle2 = new Circle("Circle 2", 7);

        Square square1 = new Square("Square 1", 4);
        Square square2 = new Square("Square 2", 6);

        Shape[] shapes = { circle1, circle2, square1, square2 };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Name: {shape.Name}, Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
        }

        Square largestSquare = shapes.OfType<Square>().OrderByDescending(s => s.Area()).First();
        Circle largestCircle = shapes.OfType<Circle>().OrderByDescending(c => c.Area()).First();

        Console.WriteLine($"Largest Square - Name: {largestSquare.Name}, Area: {largestSquare.Area()}");
        Console.WriteLine($"Largest Circle - Name: {largestCircle.Name}, Area: {largestCircle.Area()}");
    }
}
