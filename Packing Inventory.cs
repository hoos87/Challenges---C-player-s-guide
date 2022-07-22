
//----------\\
// **MAIN** \\

// Creating a new instance of the Arrow inherited class


Console.WriteLine("Hello brave adventurer, before you head off on a your journey please take this pack to hold items");
Pack playerPack = new Pack();
Console.WriteLine("\n");

Console.WriteLine("**You have obtained a pack!**");
Console.WriteLine("\n");

Console.WriteLine("I will allow you to take some items for free, take as much as your pack can hold");
Console.WriteLine("\n");

while (true)
{
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine($"Pack max item count: {playerPack._maxItemCount}");
    Console.WriteLine($"Pack current item count: {playerPack._currentItemCount}");
    Console.WriteLine("\n");
    Console.WriteLine($"Pack max item weight: {playerPack._maxWeight}");
    Console.WriteLine($"Pack current weight: {playerPack._currentWeight}");
    Console.WriteLine("\n");
    Console.WriteLine($"Pack max volume: {playerPack._maxVolume}");
    Console.WriteLine($"Pack current volume: {playerPack._currentVolume}");
    Console.WriteLine("\n");
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("\n");
    Console.WriteLine("Here is what I can offer you, what would you like to add?");
    Console.WriteLine("1 - An Arrow");
    Console.WriteLine("2 - A Bow");
    Console.WriteLine("3 - A Rope");
    Console.WriteLine("4 - Bottle of water");
    Console.WriteLine("5 - Food rations");
    Console.WriteLine("6 - A Sword");

    /*
    Console.WriteLine("7 - Check pack current weight");
    Console.WriteLine("8 - Check pack current volume");
    Console.WriteLine("9 - Check pack current items number");
    Console.WriteLine("10 - Check pack max weight");
    Console.WriteLine("11 - Check pack max volume");
    Console.WriteLine("12 - Check pack max items it can hold");
    */


    int playerChoice = Convert.ToInt32(Console.ReadLine());
    if (playerChoice >= 1 && playerChoice <= 6)
    {
    }
    else
    {
        Console.WriteLine("Please choose a selection between 1 and 6");
        continue;
    }

    // very useful way to use a switch
    InventoryItem item = playerChoice switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new FoodRations(),
        6 => new Sword(),
    };

    if (!playerPack.Add(item))
        Console.WriteLine("The item could not be added to the pack");


}



//-----------------------\\
// **INHERITED CLASSES** \\

// The line below is using InventoryItem as a base class and Arrow is derived from it
public class Arrow : InventoryItem

// need to literally type "base" to indictae base class and then supply the new values to be used.
{
    public Arrow() : base(0.1f, 0.05f)
    {
    }
}

// Next is a list of all the items following the same principle.

// Bow inherited class
public class Bow : InventoryItem
{
    public Bow() : base(1f, 4f)
    {
    }
}
// Rope inherited class
public class Rope : InventoryItem
{
    public Rope() : base(1f, 1.5f)
    {
    }
}
// Water inherited class
public class Water : InventoryItem
{
    public Water() : base(2f, 3f)
    {
    }
    //to add detail to this ingerited class I could add water purity for example
}
//Food Rations inherited class
public class FoodRations : InventoryItem
{
    public FoodRations() : base(1f, 0.5f)
    {
    }
}
//NOTE* The below example is formatted to show the blocks of code on one line,
//in this particular case it makes the code less messy
public class Sword : InventoryItem { public Sword() : base(5f, 3f) { } }




//-------------\\
// **CLASSES** \\

public class Pack
{
    // fields
    // max pack capacity
    public float _maxWeight { get; }
    public float _maxVolume { get; }
    public int _maxItemCount { get; }

    // auto properties
    // current pack capacity
    public float _currentWeight { get; private set; }
    public float _currentVolume { get; private set; }
    public int _currentItemCount { get; private set; }

    // declared an array here, but havn't created it?
    InventoryItem[] items;

    // constructors
    // parameterless contructor
    public Pack()
    {
        _maxItemCount = 10;
        _maxWeight = 15f;
        _maxVolume = 15f;

        //created the items array using the new keyword?
        items = new InventoryItem[_maxItemCount];
    }

    // contructor that takes parameters
    public Pack(int maxItemCount, float maxWeight, float maxVolume)
    {
        _maxItemCount = maxItemCount;
        _maxWeight = maxWeight;
        _maxVolume = maxVolume;

        
    }

    public bool Add(InventoryItem item)
    {

        if (item._weight + _currentWeight > _maxWeight)
            return false;
        if (item._volume + _currentVolume > _maxVolume)
            return false;
        if (_currentItemCount >= _maxItemCount)
            return false;
        else
        {
            items[_currentItemCount] = item;
            _currentItemCount++;
            _currentWeight = _currentWeight + item._weight;
            _currentVolume = _currentVolume + item._volume;

            return true;
        }
    }
}




//------------------\\
// **BASE CLASSES** \\

public class InventoryItem
{
    readonly public float _weight = 1f;
    readonly public float _volume = 1f;

    // constructor with parameters to set item weight and volume upon time of creation
    public InventoryItem(float weight, float volume)
    {
        _weight = weight;
        _volume = volume;
    }
}

