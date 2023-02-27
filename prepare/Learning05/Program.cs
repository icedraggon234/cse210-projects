using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Square square = new Square("red", 3);
        Rectangle rectangle = new Rectangle("blue", 5, 7);
        Circle circle = new Circle("purple", 4);

        List<Shape> shapes = new List<Shape> {square, rectangle, circle};

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}