public class Rectangle : Shape // inherites the base class
{
    private float _length; //_side attribute as private member varieble
    private float _width;

    //constructor for the color, side and base color.
    public Rectangle(string color, float length, float width) : base(color) 
    {
        _length = length;
        _width = width;
    }
    public override double GetArea() //Overriden GetArea() method from the base class 
    {
        return _length * _width;
    }
}