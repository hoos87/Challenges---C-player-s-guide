
// The chest begins in this state and can be altered later on
ChestState chestStatus = ChestState.Locked;


// add this line to a method and call when needed
Console.WriteLine($"The chest is curretly {chestStatus}");
Console.WriteLine("\n");


while (true)
{
    // I would like to use a switch here and add an extra option to check the status of the chest
    
    Console.WriteLine("What would you like to do?"
        + "\n" 
        + "- Open" 
        + "\n" 
        + "- Close" 
        + "\n" 
        + "- Unlock" 
        + "\n" 
        + "- Lock"
        + "\n"
        + "- Check");

    // Getting user's input to allow manipulation of chest status
    string userResponse = Console.ReadLine();

    // I would like to implement a switch here to make user selection less clunky

    // Opening the chest
    if (userResponse == "Open" || userResponse == "open")
    {
        if (chestStatus == ChestState.Locked)
        {
            Console.WriteLine($"The chest is {chestStatus} you will need to unlock it first");
        }
        else if (chestStatus == ChestState.Open)
        {
            Console.WriteLine("The chest is already open");
        }
        else
        {
            Console.WriteLine("you open the chest..");
            OpenChest();
        }
    }

    // Closing the chest
    else if (userResponse == "Close" || userResponse == "close")
    {
        if (chestStatus == ChestState.Locked)
        {
            Console.WriteLine("The chest is already closed, it also looks locked..");

        }
        else if (chestStatus == ChestState.Closed)
        {
            Console.WriteLine("The chest if already closed");
        }
        else
        {
            Console.WriteLine("You close the chest");
            CloseChest();
        }
    }

    // Unlocking the chest
    else if (userResponse == "Unlock" || userResponse == "unlock")
    {
        if (chestStatus == ChestState.Open)
        {
            Console.WriteLine("The chest is already open!");
        }
        else if (chestStatus == ChestState.Closed)
        {
            Console.WriteLine("You try to unlock the closed chest but it appears to already be unlocked");
        }
        else
        {
            Console.WriteLine("KerLunk! you unlock the chest!");
            UnlockChest();
        }
    }

    //Locking the chest
    else if (userResponse == "Lock" || userResponse == "lock")
    {
        if (chestStatus == ChestState.Open)
        {
            Console.WriteLine("You will need to close the chest first before locking it");
        }
        else if (chestStatus == ChestState.Locked)
        {
            Console.WriteLine("The chest is already locked");
        }
        else
        {
            Console.WriteLine("KerChing! The chest is now locked!");
            LockChest();
        }
    }

    // Checking chest status
    else if (userResponse == "Check" || userResponse == "check")
    {
        Console.WriteLine($"The chest is currently {chestStatus}");
    }

    // Prompt to retry input if incorrect inputs made
    else
    {
        Console.WriteLine("Please try again");
    }

}

// Methods to manipulate chest status
void OpenChest()
{
    chestStatus = ChestState.Open;
}

void CloseChest()
{
    chestStatus = ChestState.Closed;
}

void UnlockChest()
{
    chestStatus = ChestState.Closed;
}

void LockChest()
{
    chestStatus = ChestState.Locked;
}
    


// Chest states to be used above (enumeration)
enum ChestState
{
    Open,
    Closed,
    Locked,
}