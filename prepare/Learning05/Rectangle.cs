public class Rectangle : Shape
{
    // Attributes.
    float _side1;
    float _side2;

    // Constructors.
    public Rectangle(string color, float side1, float side2) : base(color)
    {
        _color = color;
        _side1 = side1;
        _side2 = side2;
    }

    // Methods.
    public override double GetArea()
    {
        double area = _side1 * _side2;
        return area;
    }
}
