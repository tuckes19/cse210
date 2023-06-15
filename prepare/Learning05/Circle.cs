public class Circle : Shape
{
    // Attributes.
    float _radius;

    // Constructors.
    public Circle(string color, float radius) : base(color)
    {
        _color = color;
        _radius = radius;
    }

    // Methods.
    public override double GetArea()
    {
        double area = Math.PI * (_radius * _radius);
        return area;
    }
}