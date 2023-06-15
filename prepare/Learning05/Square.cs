public class Square : Shape
{
    // Attributes.
    float _side;

    // Constructors.
    public Square(string color, float side) : base(color)
    {
        _color = color;
        _side = side;
    }

    // Methods.
    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}