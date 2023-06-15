using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square("Red", 2);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("Blue", 2, 3);
        shapes.Add(rectangle);
        Circle circle = new Circle("Purple", 4);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        };
        
    }
}
