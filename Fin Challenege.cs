
// Instances of a class

Arrow playerArrow = new Arrow();

// ==== Program start ==== \\


// opening sequence from shop owner
Console.WriteLine("Hello traveller, let me know what kind of arrow you would like me to build you");
Console.WriteLine("\n");

// method for arrow head selection for later use
ArrowHeadSelector();

// method for fletching selection for later use
FletchingSelector();

// method for shaft selection for later use
ArrowShaftLengthSelector();


// a summary of the players arrow choice
Console.WriteLine("To summarise:");
Console.WriteLine("Arrowhead: " + playerArrow.Arrowhead);
Console.WriteLine("Fletching: " + playerArrow.Fletching);
Console.WriteLine("Arrow shaft length: " + playerArrow.ArrowShaftLength + " cm");


// collecting the needed parameters to calculate complete arrow cost
float retrievedPriceHead = playerArrow.ArrowHeadPrice();
float retrievedPriceFletching = playerArrow.FletchingPrice();

// calculating the final cost of the arrow
float TotalCostArrow = playerArrow.TotalCostArrow(retrievedPriceHead, retrievedPriceFletching);

// displaying the final cost of the arrow selected by the player
Console.WriteLine("\n");
Console.WriteLine("The total cost of the arrow will be: " + TotalCostArrow + "gold");

// ==== Program end ==== \\




// ==== Methods ==== \\

void ArrowHeadSelector()
{

    // asking about the first component
    Console.WriteLine("tell me, what material do you want to arrow head to be?");
    Console.WriteLine("\n");
    Console.WriteLine("a - Steel?");
    Console.WriteLine("b - Wood?");
    Console.WriteLine("c - Obsidian?");
    Console.WriteLine("\n");

    char choiceArrowHead;

    while (true)
    {
        Console.WriteLine("Make your selection, a, b or c");
        choiceArrowHead = Convert.ToChar(Console.ReadLine());

        ArrowHead arrowHeadSelection = choiceArrowHead switch
        {
            'a' => ArrowHead.steel,
            'b' => ArrowHead.wood,
            'c' => ArrowHead.obsidian,
        };

        if (choiceArrowHead == 'a' || choiceArrowHead == 'b' || choiceArrowHead == 'c')
        {
            playerArrow.Arrowhead = arrowHeadSelection;
            break;
        }

        else
            Console.WriteLine("Incorrect selection, please try again");
    }

    Console.WriteLine("\n");
    Console.WriteLine("A great choice");
}


void FletchingSelector()
{
    Console.WriteLine("Next, tell me what material you want to fletching to be?");
    Console.WriteLine("\n");
    Console.WriteLine("a - Plastic?");
    Console.WriteLine("b - Turkey feathers?");
    Console.WriteLine("c - Goose feathers?");
    Console.WriteLine("\n");

    char choiceFletching;

    while (true)
    {
        Console.WriteLine("Make your selection, a, b or c");
        choiceFletching = Convert.ToChar(Console.ReadLine());

        Fletching fletchingSelection = choiceFletching switch
        {
            'a' => Fletching.plastic,
            'b' => Fletching.turkeyFeathers,
            'c' => Fletching.gooseFeathers,
        };

        if (choiceFletching == 'a' || choiceFletching == 'b' || choiceFletching == 'c')
        {
            playerArrow.Fletching = fletchingSelection;
            break;
        }
        else
            Console.WriteLine("Incorrect selection, please try again");
    }

    Console.WriteLine("\n");
    Console.WriteLine("Another great choice");
}


void ArrowShaftLengthSelector()
{
    Console.WriteLine("Right, how long do yo want these arrows to be? I suggest a length between 60cm and 100cm");

    while (true)
    {
        float arrowShaftLength = Convert.ToSingle(Console.ReadLine());
        if (arrowShaftLength >= 60 || arrowShaftLength >= 100)
        {
            Console.WriteLine("Excellent, I have all I need to get working.");
            playerArrow.ArrowShaftLength = arrowShaftLength;
            break;
        }

        else
            Console.WriteLine("Please select a length between 60 and 100cm");
    }

}


// ==== Classes ==== \\

class Arrow
{
    private ArrowHead _arrowHead;
    private Fletching _fletching;
    private float _arrowShaftLength;

    // Constructor for this class - setting beginning values
    public Arrow()
    {
        _arrowHead = ArrowHead.wood;
        _fletching = Fletching.plastic;
        _arrowShaftLength = 60;
    }


    // A getter and setter property for Arrowhead
    public ArrowHead Arrowhead
    {
        get => _arrowHead;
        set => _arrowHead = value;
    }

    public Fletching Fletching
    {
        get => _fletching;
        set => _fletching = value;
    }

    public float ArrowShaftLength
    {
        get => _arrowShaftLength;
        set => _arrowShaftLength = value;
    }


    // Methods to acquire costs of arrow components
    public float ArrowHeadPrice()
    {

        float arrowHeadPrice = _arrowHead switch
        {
            ArrowHead.wood => 3,
            ArrowHead.steel => 10,
            ArrowHead.obsidian => 5,
        };

        return arrowHeadPrice;

    }

    public float FletchingPrice()
    {

        float fletchingPrice = _fletching switch
        {
            Fletching.plastic => 10,
            Fletching.turkeyFeathers => 5,
            Fletching.gooseFeathers => 3,
        };

        return fletchingPrice;

    }

    public float TotalCostArrow(float head, float fletching)
    {
        float shaftCost = _arrowShaftLength * 0.05f;

        return shaftCost + head * fletching;

    }

    // Static methods for created predefined arrows

    public static Arrow CreateEliteArrow()
    {
        

       

    }

    public static void CreateBeginnerArrow()
    {


    }

    public static void CreateMarksmanArrow()
    {


    }

}

// ==== Enums ==== \\

enum ArrowHead { steel, wood, obsidian }
enum Fletching { plastic, turkeyFeathers, gooseFeathers }



