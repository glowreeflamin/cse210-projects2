

public class Square : Shape // inherites the base class
{
    private float _side; //_side attribute as private member varieble

    //constructor for the color, side and base color.
    public Square(string color, float side) : base(color) 
    {
        _side = side;
    }
    public override double GetArea() //Overriden GetArea() method from the base class 
    {
        return _side * _side;
    }
}

