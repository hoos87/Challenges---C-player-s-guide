
// Instances of Classes

/*

Score playerA = new Score("hoos", 4500, 5); // This has chosen to use the second contructor

Console.WriteLine(playerA.name); // I've had to state the class instance name then accessed the variable for name inside

if (playerA.EarnedStar())
    Console.WriteLine("You have earned a points badge {0}!", playerA.name);
if (!playerA.EarnedStar())
    Console.WriteLine("Better luck next time {0}!", playerA.name);

Score playerB = new Score(); // This has used the first constructor

playerB.name = "rach";
playerB.points = 8000;
playerB.level = 5;

if (playerB.EarnedStar())
    Console.WriteLine("You have earned a points badge {0}!", playerB.name);
if (!playerB.EarnedStar())
    Console.WriteLine("Better luck next time {0}!", playerB.name);





// Defining a Class
class Score
{
    public string name; // these variables are not the same as local 
    public int points;  // variables or parameters, they are another catagory of variables called "fields"
    public int level;   // or "instance variables"

    
    public Score()
    {
        name = "Unknown";
        points = 0;
        level = 0;
    }
    
    public Score(string n, int p, int l)  // Using a constructor when object comes to life to ensure it begins in a good state.
                                          // You can also pass parameters to be used from external methods to set it.
    {
        name = n;
        points = p;
        level = l;
    }
    

    public bool EarnedStar()
    {
        return points / level > 1000;
    }
    // The above method is the same as the one below, (Expression bodied functions and properties) 
    // A new feature in C# 6.0 called an expression body
    // It is shorthand to write a single line of code with a return value.
    // public bool EarnedStar() => (points / level) > 1000;
}

*/


// ==Vin Fletcher's Arrow==


// Opening statement from shop
Console.WriteLine("Hello there! Who might you be?");
string customer = CustomerName();
Console.Clear();
Console.WriteLine(customer);

// variables for each part of arrow made by user
ArrowheadType finalArrowSelection;
FletchingType finalFletchingType;
int finalShaftLength;



string CustomerName()
{
  string customerName = Console.ReadLine();
  return customerName;
}


Console.WriteLine("Hello {0}, Let's make you a custom arrow shall we?", customer);


// This is currently pointless unless I can think of a way to use it as intended (Use the name to create an instance with)
ArrowCreation(customer);



// The main method for arrow creation
void ArrowCreation(string customerName)
{
    // Arrowhead selection
    Console.WriteLine("First let us decide the arrowhead type");
    Console.WriteLine("1 - Steel arrowhead");
    Console.WriteLine("2 - Wooden arrowhead");
    Console.WriteLine("3 - Obsidian arrowhead");
    int arrowheadSelection = Convert.ToInt32(Console.ReadLine()); // storing users input as an int

    finalArrowSelection = arrowheadSelection switch       // The user input will select the appropriate    
    {                                                     // option in the switch and assign it to the userArrowhead
        1 => ArrowheadType.Steel,
        2 => ArrowheadType.Wood,
        3 => ArrowheadType.Obsidian
    };
    

     
    // Fletching selection
    Console.WriteLine("Now we will select the fletching");
    Console.WriteLine("1 - Plastic");
    Console.WriteLine("2 - Turkey feathers");
    Console.WriteLine("3 - Goose feathers");
    int fletchingSelection = Convert.ToInt32(Console.ReadLine());

    finalFletchingType = fletchingSelection switch
    {
        1 => FletchingType.Plastic,
        2 => FletchingType.TurkeyFeathers,
        3 => FletchingType.GooseFeathers
    };
    


    // Arrow shaft length selection
    Console.WriteLine("Finally, how long do you require the arrow to be? I can craft a shaft between 60 and 100cm long");
    finalShaftLength = ShaftLengthSelection();
      
}



// Method for selecting arrow shaft length with prompts to reenter input if incorrect
int ShaftLengthSelection()
{
   
    while(true)
    {
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput < 60 || userInput > 100)
            Console.WriteLine("Please enter a length between 60 and 100");

        else
            return userInput;
    }

}



// Method that generates a new instance of the class Arrow and inputs user data in to it ?? **Is this possible?**


// Instance of Arrow class for this shop
Arrow customerOrder1 = new Arrow(finalFletchingType, finalArrowSelection, finalShaftLength);



// Summary of your order - can tidy this up when presented at end
Console.WriteLine("Here is you arrow with the current specifications!");
Console.WriteLine($"An arrow head made of {customerOrder1.arrowHead}");
Console.WriteLine($"Fletching made of {customerOrder1.fletching}");
Console.WriteLine($"{customerOrder1.arrowShaftLength}cm");


// Final calculations for cost of arrow
float finalCost = GetCostFletchArrowhead(finalFletchingType, finalArrowSelection, finalShaftLength);
Console.WriteLine($"This arrow will cost you{finalCost}");

Convert.ToSingle(finalShaft);
float shaftCost = (finalShaft * 0.05f);

// Method to calculate cost of order and return value **This can be placed within the class !
void GetCostFletchArrowhead(FletchingType costFletching, ArrowheadType costArrowhead
{

    // Converted int to float and calculated cost of arrowshaft
    

    if (costFletching == FletchingType.Plastic)
    {

    }

}

float CostCalculator(float fletchingGold, float arrowheadGold, float shaftGold)
{

}


class Arrow
{

    public FletchingType fletching;
    public ArrowheadType arrowHead;
    public int arrowShaftLength;             

    // Constructor used by instance to set its fields
    public Arrow(FletchingType userFletching, ArrowheadType userArrow, int userLength)
    {
        fletching = userFletching;
        arrowHead = userArrow;
        arrowShaftLength = userLength;
    }

    public float CostArrow()
    {

        Console.WriteLine("Hello!");


    }

}

// Enumeration for arrowhead and fletching types below
enum ArrowheadType 
{ 
    Steel, 
    Wood, 
    Obsidian
}

enum FletchingType
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}


