

// creating new instance via tghe constructor, feeding it parameters
Colour colourSelection1 = new Colour(100, 145, 225);

// created new instance of Colour, its constructor is being called as a static property within the class and will apply that to the new instance.
Colour colourSelection2 = Colour.Orange;

// displaying values of both instances
Console.WriteLine("Using the constructor");
Console.WriteLine("R = " + colourSelection1.SetGetRed + "\n" + "G = " + colourSelection1.SetGetGreen + "\n" + "B = " + colourSelection1.SetGetBlue);
Console.WriteLine("\n");
Console.WriteLine("Using the static property");
Console.WriteLine("R = " + colourSelection2.SetGetRed + "\n" + "G = " + colourSelection2.SetGetGreen + "\n" + "B = " + colourSelection2.SetGetBlue);


class Colour
{
    // class fields
    private int _red;
    private int _green;
    private int _blue;

    // constructor (accepts parameter)
    public Colour(int red, int green, int blue)
    {
        _red = red;
        _green = green;
        _blue = blue;
    }

    // parameterless contructor
    public Colour()
    {
        _red = 0;
        _green = 0;
        _blue = 0;
    }

    public int SetGetRed
    { 
        get { return _red; } 
        set { _red = value; }   
    }

    public int SetGetGreen
    {
        get { return _green; }
        set { _green = value; }
    }
    public int SetGetBlue
    {
        get { return _blue; }
        set { _blue = value; }
    }

    // static property; code is longer here
    // NOTE: you can get and return a new constructor instruction which is passed over to the instance when it is created
    public static Colour White
    {
        get { return new Colour(255, 255, 255); }

    }

    // static property; shorthand
    public static Colour Black { get; } = new Colour(0, 0, 0);

    public static Colour Red { get; } = new Colour(255, 0, 0);

    public static Colour Orange { get; } = new Colour(255, 165, 0);

    public static Colour Yellow { get; } = new Colour (255, 255, 0);

    public static Colour Green { get; } = new Colour(0, 255, 0);

    public static Colour Blue { get; } = new Colour(0, 0, 255);

    public static Colour Purple { get; } = new Colour(128, 0, 128);





}







