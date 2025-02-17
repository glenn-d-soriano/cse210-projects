using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        // Create a list to store shapes
        List<Shape> shapes = new List<Shape>();

        
        shapes.Add(new Square("Red", 5));  // Square with side 5
        shapes.Add(new Rectangle("Blue", 4, 6)); // Rectangle with length 4 and width 6
        shapes.Add(new Circle("Green", 3));  // Circle with radius 3

        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea()}");
        }
    }
}