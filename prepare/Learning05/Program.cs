using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 5
        Square square = new Square("Blue", 4);
        Console.WriteLine($"Area: {square.GetArea()} Colour: {square.GetColor()}");

        // Step 6
        Rectangle rectangle = new Rectangle("Red", 5, 3);
        Console.WriteLine($"Area: {rectangle.GetArea()} Colour: {rectangle.GetColor()}");

        Circle circle = new Circle("Purple", 2.5);
        Console.WriteLine($"Area: {circle.GetArea()} Colour: {circle.GetColor()}\n");

        // Step 7
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());;
        }
    }
}