
// created a new instance of the Point class
Point point1 = new Point(2, 4);
Console.WriteLine("(" + point1.xCoordinate + ", " + point1.yCoordinate + ")");

Point point2 = new Point(-4, 0);
Console.WriteLine("(" + point2.xCoordinate + ", " + point2.yCoordinate + ")");




// classes
class Point
{

    // class fields
    private readonly int _x;
    private readonly int _y;
    

    // constructor (parameterless)
     public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }

    // a second constructor is used here and will be used by the class IF the constructor above is not used,
    // eg: no parameters are fed in to the constructor at instance creation
    public Point()
    {
        _x = 0;
        _y = 0;
    }

    // getter and setter for x coordinate
    public int xCoordinate
    {
        get { return _x; }
    }

    // getter and setter for y coordinate
    public int yCoordinate
    {
        get { return _y; }
    }

}