// The Locked Door


// Main

Console.WriteLine("Hello! Before I can allow you to proceed, you must create a new passcode for the door");
Door door1 = Door.createNewDoor();

door1.CommandList();

Console.WriteLine("I worked!");

class Door
{
    // == Fields 
    private int numericalCode;
    private DoorStates currentState = DoorStates.Closed;
    private DoorLockStates lockState = DoorLockStates.Locked;


    // == Constructors
    // constructor that takes parameters
    public Door(int passcode)
    {
        numericalCode = passcode;
        currentState = DoorStates.Closed;
        lockState = DoorLockStates.Locked;
    }

    // parameterless constructor
    public Door()
    {
        numericalCode = 1234;
        currentState = DoorStates.Closed;
        lockState = DoorLockStates.Locked;
    }


    // == Setter and Getter
    // getter and setter for door state (closed or open)
    public DoorStates alterDoorState
    {
        get { return currentState; }
        set { currentState = value; }
    }

    // getter and setter for door lock state (locked or unlocked)
    public DoorLockStates alterLockState
    {
        get { return lockState; }
        set { lockState = value; }
    }

    // getter and setter for door code
    public int alterDoorCode
    {
        get { return numericalCode; }
        set { numericalCode = value; }
    }


    // == Methods
    // method for initial creation of door instance + setting initial door code
    public static Door createNewDoor()
    {
        Console.WriteLine("Please enter a 4 digit numerical code, this will be your passcode for this particular door");
        while (true)
        {
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput < 1000 || userInput > 9999)
                Console.WriteLine("Please enter a valid 4 digit number code");
            else
                return new Door(userInput);
        }
    }

    // Initial command list for user to make a selection
    public void CommandList()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1: Check door");
        Console.WriteLine("2: Open door");
        Console.WriteLine("3: Close door");
        Console.WriteLine("4: Lock door");
        Console.WriteLine("5: Unlock door");
        Console.WriteLine("6: Change passcode");

        string userSelection = Console.ReadLine();
        Console.Clear();

        switch (userSelection)
        {
            case "1":
                Console.WriteLine("The door is " + alterDoorState + " and " + alterLockState);
                CommandList();
                break;
            case "2":
                OpenDoor();
                break;
            case "3":
                CloseDoor();
                break;
            case "4":
                LockDoor();
                break;
            case "5":
                UnlockDoor();
                break;
            case "6":
                SetPasscode();
                break;
        }
    }




    // completed
    public void OpenDoor()
    {
        Console.WriteLine("You attempt to open the door");
        if (currentState == DoorStates.Open)
        {
            Console.WriteLine("The door is already open");
            CommandList();
        }


        else if (currentState == DoorStates.Closed && lockState == DoorLockStates.Unlocked )
        {
            Console.WriteLine("The door opens!");
            alterDoorState = DoorStates.Open;
            CommandList();
        }

        else if (currentState == DoorStates.Closed && lockState == DoorLockStates.Locked)
        {
            Console.WriteLine("The door is locked, you will need to unlock it first using a passcode");
            CommandList();
        }

        else if (lockState == DoorLockStates.Unlocked && currentState == DoorStates.Closed)
        {
            Console.WriteLine("The door is already unlocked, you proceed to open it");
            CommandList();
        }

    }

    //
    public void CloseDoor()
    {
        Console.WriteLine("You attempt to close the door");

        if (currentState == DoorStates.Open)
        {
            Console.WriteLine("You close the door");
            alterDoorState = DoorStates.Closed;
            CommandList();
        }
        else if (currentState == DoorStates.Closed)
        {
            Console.WriteLine("The door is already closed");
            CommandList();
        }

        else if (lockState == DoorLockStates.Locked && currentState == DoorStates.Closed)
        {
            Console.WriteLine("The door is closed and locked");
            CommandList();
        }

        else if (lockState == DoorLockStates.Unlocked && currentState == DoorStates.Closed)
        {
            Console.WriteLine("The door is already closed, you observe that it is already locked");
            CommandList();
        }
    }

    //
    public void LockDoor()
    {
        Console.WriteLine("You attempt to lock the door");

        if (currentState == DoorStates.Open)
        {
            Console.WriteLine("The door is open, you must close the door first before you can lock it");
            CommandList();
        }

        else if (currentState == DoorStates.Closed && lockState == DoorLockStates.Unlocked)
        {
            Console.WriteLine("You must input the passcode to lock the door");
            bool codeSuccess = CodeChecker();
            if (codeSuccess)
            {
                alterDoorState = DoorStates.Closed; // redundant?
                alterLockState = DoorLockStates.Locked;
                CommandList();
            }
            else
            {
                Console.WriteLine("You did not know the correct passcode and so have left the door");
                CommandList();
            }
        }

        else if (lockState == DoorLockStates.Locked)
        {
            Console.WriteLine("The door is already locked");
            CommandList();
        }

        /*else if (lockState == DoorLockStates.Unlocked)
        {
            Console.WriteLine("You lock the door");
            alterLockState = DoorLockStates.Locked;
            CommandList();
        }
        */
    }

    //
    public void UnlockDoor()
    {
        Console.WriteLine("You attempt to open the door");
        if (currentState == DoorStates.Open)
        {
            Console.WriteLine("The door is already open");
            CommandList();
        }

        else if (currentState == DoorStates.Closed && lockState == DoorLockStates.Unlocked)
        {
            Console.WriteLine("The door is already unlocked and opens!");
            alterDoorState = DoorStates.Open;
            CommandList();
        }

        else if (lockState == DoorLockStates.Locked)
        {
            Console.WriteLine("The door is locked, you will need to unlock it first using a passcode");
            CodeCheckAndUnlockDoor();
        }

        /*else if (lockState == DoorLockStates.Unlocked)
        {
            Console.WriteLine("The door is already unlocked, you proceed to open it");
            CommandList();
        }
        */
    }



    // set desired passcode
    public void SetPasscode()
    {
        Console.WriteLine("First you must confirm the exisiting passcode before you can change it");
        Console.WriteLine("Please enter the 4 digit numerical passcode now");
        bool passcodeTest = CodeChecker();
        if (passcodeTest == true)
        {
            //pass code condition
            Console.WriteLine("Thank you, that was the correct passcode");
            Console.WriteLine("Please enter a new 4 digit numerical code");

            while (true)
            {
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput < 1000 || userInput > 9999)
                    Console.WriteLine("Please enter a valid 4 digit number code");
                else
                {
                    alterDoorCode = userInput;
                    CommandList();
                    break;
                }
            }

        }
        else if (passcodeTest == false)
        {
            Console.WriteLine("You entered the incorrect code, returning to main command screen");
            CommandList();
        }




    }

    // checks inputted code
    public bool CodeChecker()
    {

        while (true)
        {

            int userInputPasscode = Convert.ToInt32(Console.ReadLine());

            if (userInputPasscode == numericalCode)
            {
                // call function to proceed to next stage
                Console.WriteLine("Passcode accepted.");
                return true;
            }
            else if (userInputPasscode != numericalCode)
            {
                Console.WriteLine("The code entered does not match, please try again");
                Console.WriteLine("Do you want to continue reinputting the passcode or return to the previous menu?");
                string userInput = Console.ReadLine();
                if (userInput == "yes")
                    continue;
                else if (userInput == "no")
                    return false;
            }

        }
    }

    public void CodeCheckAndUnlockDoor()
    {
        while (true)
        {
            Console.WriteLine("Please enter the passcode for this door");
            int userInputPasscode = Convert.ToInt32(Console.ReadLine());

            if (userInputPasscode == numericalCode)
            {
                Console.WriteLine("Passcode accepted, unlocking.....");
                alterLockState = DoorLockStates.Unlocked;
                CommandList();
            }
            else if (userInputPasscode != numericalCode)
            {
                Console.WriteLine("The code entered does not match, please try again");
                Console.WriteLine("Do you want to continue reinputting the passcode or return to the previous menu?");
                string userInput = Console.ReadLine();
                if (userInput == "yes")
                    continue;
                else if (userInput == "no")
                    CommandList();
            }

        }
    }




}

enum DoorStates { Open, Closed }
enum DoorLockStates { Unlocked, Locked }



