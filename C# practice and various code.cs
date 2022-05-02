// See https://aka.ms/new-console-template for more information


// Practice



/* int[] highScore = new int[10]; // created an array named "highScore" that can hold 10 elements.

// If we wish to assign a value to one of the elements within the array do the following:
highScore[0] = 5; // the number inside the square brackets is the position of the element within the array
highScore[1] = 6;
highScore[2] = 7;
highScore[3] = 8;
highScore[4] = 9;
highScore[5] = 10;
highScore[6] = 11;
highScore[7] = 12;
highScore[8] = 13;
highScore[9] = 14;


Console.WriteLine(highScore[0]);
Console.WriteLine(highScore[1]);
Console.WriteLine(highScore[2]);    
Console.WriteLine(highScore[3]); 
Console.WriteLine(highScore[4]);
Console.WriteLine(highScore[5]);
Console.WriteLine(highScore[6]);
Console.WriteLine(highScore[7]);
Console.WriteLine(highScore[8]);
Console.WriteLine(highScore[9]); 


int[] firstThreeScores = highScore[0..6]; // when creating a new array and copying in a range, the size / number of elements will match the size of the range being copied in
Console.WriteLine(firstThreeScores[0]);
Console.WriteLine(firstThreeScores[1]);
Console.WriteLine(highScore.Length);
Console.WriteLine(firstThreeScores.Length);
*/


/*
int userSizeArray = Convert.ToInt32(Console.ReadLine());


int[] array = new int[userSizeArray];
Console.WriteLine("array length is equal to {0}",array.Length);

for (int index = 0; index < array.Length; index++) // Initialisation is int index variable set to 0; condition index < array.Length which is set by user input, this will stop the loop before exceeding array limit; increment index number +1 per loop
{
    array[index] = 3;                              // This is the same as saying array[0] = 1
    Console.WriteLine(array[index]);
    Console.WriteLine("I'm the value assigned to index {0}", index);
}

*/

/*
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue;
for (int index = 0; index < array.Length; index++)
{
    if (array[index] < currentSmallest)
    {
        currentSmallest = array[index]; // currentSmallest value is being replaced by the value stored in each index IF the value is smaller than currentSmallest's value
    }

}

Console.WriteLine(currentSmallest); 
*/
/*
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int total = 0;
for (int index = 0; index < array.Length; index++)
{
    total += array[index];
}

float avarage = total / array.Length;
Console.WriteLine(avarage);
*/

/*
Console.WriteLine("Hero! Please create an array that can hold 5 elements!!");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[arraySize];
int numberOne = 1;

for (int index = 0; index < arraySize; index++)
{
    Console.WriteLine($"Please enter a value for number {numberOne++}");
    int userValue = Convert.ToInt32(Console.ReadLine());
    myArray[index] = userValue;
}


int[] arrayCopy = new int[5];

for (int indexCopy = 0; indexCopy < 5; indexCopy++)
{
    arrayCopy[indexCopy] = myArray[indexCopy];
}

for (int indexReview = 0; indexReview < 5; indexReview++)
{
    Console.WriteLine($"{myArray[indexReview]} and {arrayCopy[indexReview]}");

}
*/
/*
Console.WriteLine("Hero! Please create an array that can hold 5 elements!!");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[arraySize];
int numberOne = 1;


for (int index = 0; index < arraySize; index++)
{
    Console.WriteLine($"Please enter a value for number {numberOne++}");
    int userValue = Convert.ToInt32(Console.ReadLine());
    myArray[index] = userValue;
}

int[] arrayCopy = myArray[0..5];
// int[] arrayCopy = new int[5];

/*for (int indexCopy = 0; indexCopy < 5; indexCopy++)
{
    arrayCopy[indexCopy] = myArray[indexCopy];
}


for (int indexReview = 0; indexReview < 5; indexReview++)
{
    Console.WriteLine($"{myArray[indexReview]} and {arrayCopy[indexReview]}");

}
*/
/*int UserNumber = AskForNumber("Hello, please give me a number");
Console.WriteLine(UserNumber);  



int AskForNumber(string question)
{
    Console.WriteLine(question);
    int numberToReturn = Convert.ToInt32(Console.ReadLine());
    
    
    return (numberToReturn);

}


int min = 4;
int max = 500;
Console.WriteLine("Enter a number between {0} and {1}", min, max);
int userInput = Convert.ToInt32(Console.ReadLine());
AskNumberInRange(userInput, min, max);







int AskNumberInRange(int userNumber, int min, int max)
{
    while (userNumber < min && userNumber > max)
    {

        if (userNumber >= min && userNumber <= max)
        {
            return userNumber;
        }

        else
        {
            Console.WriteLine("please enter a number between {0} and {1}", min, max);
            userNumber = Convert.ToInt32(Console.ReadLine());
        }
        
    }


}
*/


/*
int number = AskForNumberInRange("User 1, enter a number between 0 and 100:", 0, 100);

Console.Clear();

Console.WriteLine("User 2, guess the number.");

while (true)
{
    int guess = AskForNumber("What is your next guess?");
    if (guess > number) Console.WriteLine($"{guess} is too high.");
    else if (guess < number) Console.WriteLine($"{guess} is too low.");
    else break;
}

Console.WriteLine("You guessed the number!");


int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number <= max)
            return number;
    }
}

*/


/*

int[] scores = new int[10];
int numberToAssign = 1;

 foreach (int score in scores)
{
    Console.WriteLine(score);

}

Console.WriteLine("Reinitialising values in scores.......");

 foreach (int score in scores)
{
    scores[score] = numberToAssign++;
    Console.WriteLine(scores[score]);

}

*/

/*

int[] array = new int[] { 4, 51, -7, 13, -5, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue;
Console.WriteLine("The smallest value an int can hold is " + currentSmallest);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < currentSmallest)
    {
        currentSmallest = array[i];
    }

}

Console.WriteLine($"The smallest value inside array is {currentSmallest}");

*/



/*
// ------------------------
//   ==The Laws of Freach==


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

// ---------------------------------------------------------------
/* ==Find the average of the values or elements stored in an array


int[] array = new int[] { 4, 51, -7, 13, -5, 15, -8, 45, 90 };

int total = 0;
foreach (int index in array)
{
    Console.WriteLine(index);
    total += index;
}

float average = (float)total / array.Length;
Console.WriteLine($"the avarage of the values contained within array is {average}");

*/


/*

// -----------
// ==Methods==


// defining a new method - it has a return type in this case "void" which doesn;t return anything.
// A name using UpperCamelCase
// And it has curly brackets at the end
// Finally a pair of perenthesis are included below the method to include a code block for the method to run

Console.WriteLine("start here");
Console.WriteLine("We are now going to call the CountToTen method");
CountToTen();
Console.WriteLine("resume here");


void CountToTen()
{
    for (int num = 0; num <= 10; num++)
    {
        Console.WriteLine(num);
    }

}


*/

//Just because we defined a method doesn't mean it will run, we need to call it.
// CountToTen();   


/*

CountToTen();

CountToTwenty();


void CountToTen()
{
    for (int num = 0; num <= 10; num++)
    {
        Console.Write(num);
    }    
}



void CountToTwenty()
{
    for (int num = 0; num <= 20; num++)
    {
        Console.Write(num);
    }
}

*/


/*

// Returning a value from a method

Console.WriteLine("Please enter the first number to be added together");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number to be added together");
int y = Convert.ToInt32(Console.ReadLine());

// Clear the screen to make things tidier
Console.Clear();

int numbersAdded = AddNumbersTogether(x,y);
Console.WriteLine($"{x} + {y} = {numbersAdded}");


// Method needed to do the calculation
int AddNumbersTogether(int x, int y)
    {
        return x + y;
    }

*/

/*
string usersName = GetUserName();
Console.WriteLine(usersName);


string GetUserName()
{
    while(true)
    {
        Console.WriteLine("Hello, what is your name?");
        string name = Console.ReadLine();
        if (name != "") // not sure what this does....
        {
            return name;
            Console.WriteLine("Let's try that again");
        }
        return name;
    }
}

*/

/*

int userInput = AskForNumber("Hello there! Please enter a number");

Console.Clear();

Console.WriteLine(userInput);

int AskForNumber(string questionToAskUser)
{

    Console.WriteLine(questionToAskUser);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;

}

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


