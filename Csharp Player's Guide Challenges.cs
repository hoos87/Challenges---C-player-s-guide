// See https://aka.ms/new-console-template for more information


/*
//-----------------------------------------------
//==The Four Sisters and the DuckBear Challenge==


Console.WriteLine("Hello! Please enter the number of chocolate egss you have harvested today");
string eggHarvestedToday = Console.ReadLine(); 
int eggHarvestedNum = Convert.ToInt32(eggHarvestedToday);

int remainder = eggHarvestedNum % 4;

int eggPerSister = (eggHarvestedNum - remainder) / 4;
Console.WriteLine("Each sister will get {0} eggs today! The number of eggs going to the Duckbear = {1}", eggPerSister, remainder); 

*/




/*
//-----------------------------------
//==The Dominion of Kings Challenge==


int provinceNumber = 0;
int duchiesNumber = 0;
int estatesNumber = 0;

Console.WriteLine("Hello Lord, please enter the number of provinces you hold.");
string provinceCount = Console.ReadLine();
int provinceCountNum = Convert.ToInt32(provinceCount); // Convert from string to int
provinceNumber = provinceCountNum;
Console.WriteLine("Thank you.");

Console.WriteLine("Now please enter the number of duchies you hold.");
string duchiesCount = Console.ReadLine();
int duchiesCountNum = Convert.ToInt32(duchiesCount);
duchiesNumber = duchiesCountNum;
Console.WriteLine("Thank you.");

Console.WriteLine("And finally, please enter the number of estates you hold.");
string estatesCount = Console.ReadLine();
int estatesCountNum = Convert.ToInt32(estatesCount);
estatesNumber = estatesCountNum;
Console.WriteLine("Thank you.");


provinceNumber *= 6;
duchiesNumber *= 3;
estatesNumber *= 1;

int totalScore = provinceNumber + duchiesNumber + estatesNumber;
Console.WriteLine("Lord! your total score is {0}", totalScore); 

*/




/*
//----------------------------
//==Repaiting the Clocktower==
  

string clockInputText = Console.ReadLine();
int clockInput = Convert.ToInt32(clockInputText);

int clockEvenOrN = clockInput % 2;


if (clockEvenOrN == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}

*/




/*
//--------------
//==Watchtower==


Console.WriteLine("Give me the x coordinate!");
string xCoordinate = Console.ReadLine();
Console.WriteLine("Now give me the y coordinate!");
string yCoordinate = Console.ReadLine();

if (xCoordinate == "x<0" && yCoordinate == "y>0")
{
    Console.WriteLine("The enemy is NW!");
}
if (xCoordinate == "x=0" && yCoordinate == "y>0")
{
    Console.WriteLine("The enemy is N!");
}
if (xCoordinate == "x>0" && yCoordinate == "y>0")
{
    Console.WriteLine("The enemy is NE!");
}
if (xCoordinate == "x<0" && yCoordinate == "y=0")
{
    Console.WriteLine("The enemy is W!");
}
if (xCoordinate == "x=0" && yCoordinate == "y=0")
{
    Console.WriteLine("The enemy is HERE!!!");
}
if (xCoordinate == "x>0" && yCoordinate == "y=0")
{
    Console.WriteLine("The enemy is E!");
}
if (xCoordinate == "x<0" && yCoordinate == "y<0")
{
    Console.WriteLine("The enemy is SW!");
}
if (xCoordinate == "x=0" && yCoordinate == "y<0")
{
    Console.WriteLine("The enemy is S!");
}
if (xCoordinate == "x>0" && yCoordinate == "y<0")
{
    Console.WriteLine("The enemy is SE!");
}

*/



/*
//------------------------
//==Watchtower== Ver.2.0==


Console.WriteLine("Please give the x coordinate value");
int xInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now the y coordinate value");
int yInput = Convert.ToInt32(Console.ReadLine());

if(xInput < 0 && yInput > 0) Console.WriteLine("They are NW!!");
if(xInput == 0 && yInput > 0) Console.WriteLine("They are N!!");
if(xInput > 0 && yInput > 0) Console.WriteLine("They are NE!!");
if(xInput < 0 && yInput == 0) Console.WriteLine("They are W!!");
if(xInput == 0 && yInput == 0) Console.WriteLine("They are here!!");
if(xInput > 0 && yInput == 0) Console.WriteLine("They are E!!");
if(xInput < 0 && yInput < 0) Console.WriteLine("They are SW!!");
if(xInput == 0 && yInput < 0) Console.WriteLine("They are S!!");
if(xInput > 0 && yInput < 0) Console.WriteLine("They are SE!!");

*/




/*
//--------------------
//==Buying Inventory==


Console.WriteLine("Here is a list of my inventory");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torch");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supply");
Console.WriteLine("Which number do you want to see the price of?");
int itemNumber = Convert.ToInt32(Console.ReadLine());

string itemName = itemNumber switch
{
    1 => "Rope",
    2 => "Torch",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supply",
};

int itemPrice = itemName switch
{
    "Rope" => 10,
    "Torch" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supply" => 1,
};

Console.WriteLine("the {0} costs {1} gold", itemName, itemPrice);
*/



/*
//------------------------
//==Discounted Inventory==


string playerName = "hoos";

Console.WriteLine("Here is a list of my inventory");
if (playerName == "hoos")
{
    Console.WriteLine("Ah! {0}! It is good to see you! Please accept a 50% discount on all items as thanks for helping me earlier!", playerName);
}

Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torch");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supply");
Console.WriteLine("Which number do you want to see the price of?");

int itemNumber = Convert.ToInt32(Console.ReadLine());

string itemName = itemNumber switch
{
    1 => "Rope",
    2 => "Torch",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supply",
};

int itemPrice = itemName switch
{
    "Rope" => 10,
    "Torch" => 15,
    "Climbing Equipment" => 25,
    "Clean Water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food Supply" => 1,
};

if (playerName == "hoos")
{
    float discountItem = itemPrice / 2;
    Console.WriteLine("For you the {0} costs {1} gold", itemName, discountItem); // Option one for displaying variable inside a Console.WriteLine
    Console.WriteLine($"For you the {itemName} costs {discountItem} gold");      // Option two for displaying variable inside a Console.WriteLine
}
else
Console.WriteLine("the {0} costs {1} gold", itemName, itemPrice);

*/






/*
//-----------------
//==The Prototype==


int pilotNumber; // This variable has been set now so that it is accessible in the "do"

do
{
    Console.WriteLine("Hello Pilot, please choose a number between 1 and 100");
    pilotNumber = Convert.ToInt32(Console.ReadLine());
    if (pilotNumber < 0 || pilotNumber > 100)
    {
        Console.WriteLine("The given number is out of range, please try again");
    }
    else if( pilotNumber >= 0 || pilotNumber <= 100)
    {
        Console.WriteLine("Thank you");
    }
}

while (pilotNumber < 0 || pilotNumber > 100) ;

Console.Clear(); // Clears screen for next user to now input guess

int hunterGuess; // This variable has been set now so that it is accessible in the "do"

do
{
    Console.WriteLine("Hello Hunter! Try and guess a number between 0 and 100");
    hunterGuess = Convert.ToInt32(Console.ReadLine());

    if (hunterGuess > pilotNumber)
        Console.WriteLine("You guessed too high! Please try again.");

    if (hunterGuess < pilotNumber)
        Console.WriteLine("You guessed too low! Please try again.");

    if (hunterGuess == pilotNumber)
        Console.WriteLine("Yes! You got em!");

}
while (hunterGuess > pilotNumber || hunterGuess < pilotNumber);

*/



/*
//--------------------
//==The Magic Cannon==


for (int cannonNumber = 1; cannonNumber <= 100; cannonNumber++)
{

    if (cannonNumber % 5 == 0 && cannonNumber % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{cannonNumber}: Electric and Fire");
    } 
    else if (cannonNumber % 5 == 0)
    { 
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{cannonNumber}: Electric");
    }
    else if (cannonNumber % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{cannonNumber}: Fire");
    }   
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"{cannonNumber}: Normal");
    }


}

*/




/*
//--------------------------
//==The Replicator of D'To==


int[] score = new int[5];

score[0] = 4;
score[1] = 6;
score[2] = 7;
score[3] = 8;
score[4] = 9;


int numCounter = 1;


for (int index = 0; index < score.Length; index++)
{
    Console.WriteLine("Please enter number {0}", numCounter++);
    score[index] = Convert.ToInt32(Console.ReadLine());
}

Console.Clear();

for (int index = 0; index < score.Length; index++)
{
    Console.WriteLine(score[index]);    
}

Console.WriteLine("\n");
Console.WriteLine("successfully passed through loop");


int[] copyOfScore = new int[5];

Console.WriteLine("\n");
Console.WriteLine("Printing out contents of CopyOfScore array");
Console.WriteLine("\n");
for (int index = 0; index < score.Length; index++)
{
    copyOfScore[index] = score[index];
    Console.WriteLine(copyOfScore[index]);
}

Console.WriteLine("\n");
Console.WriteLine("printing out contents of score array");
Console.WriteLine("\n");
for (int index = 0; index < score.Length; index++)
{
    
    Console.WriteLine(score[index]);
}

*/




/*
//----------------------
//==The Laws of Freach==


int[] array = new int[] { 4, 51, -7, 13, -5, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue;
Console.WriteLine("The smallest value an int can hold is " + currentSmallest);

  foreach (int i in array)
  {
    if (i < currentSmallest)
    {
        currentSmallest = i;
    }

  }

Console.WriteLine($"The smallest value inside array is {currentSmallest}");

*/





//--------------------
// ==Taking a Number==

int userNumRange = AskForNumberInRange("Please enter a value between", 0, 50);
Console.Clear();    
Console.WriteLine($"You entered the number {userNumRange}");


int AskForNumberInRange(string questionToAskUser, int min, int max)
    {
        Console.WriteLine(questionToAskUser + " " + min + " and " + max);

        while (true)
        {
            
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput < 0 || userInput > 50)
            {
                Console.WriteLine("Please enter a value between {0} and {1}", min, max);
            }
            else
            { 
                return userInput;
            }
        }
        
    }



