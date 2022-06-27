// testing:
// string password = "Hello";
// Console.WriteLine(password.Length);

//useful information:
// foreach with a string lets you get its characters!
// > foreach (char letter in word) {...}

//char has static methods to catagorise letters!
// > char.IsUpper('A'), char.IsLower('a'), char.IsDigit('0')

// char.IsUpper('A') - method IsUpper in the char class and takes parameter 'A' (literal) or a variable
// method evaluates if the paramter is an upper case and returns a boolean value (true of false)


//main start here

PasswordValidator MyPassword = new PasswordValidator();

MyPassword.PasswordValidatorMethod();






// classes
public class PasswordValidator
{
    //fields
    private string password;

    //parameter constructor
    public PasswordValidator(string userPassword)
    {
        password = userPassword;
    }

    //parameterless constructor
    public PasswordValidator()
    {
        password = "h";
    }

    //setter
    public string setPassword
    {
        set { password = value; }
    }

    //class methods
    public void PasswordValidatorMethod()
    {

        Console.WriteLine("Hello, please enter a valid password.");
        Console.WriteLine("The password must: \n" +
            "Be at least 6 letters long and no more than 13 letters long \n" +
            "Passwords must contain at least one uppercase letter, one lowercase letter, and one number \n" +
            "Passwords cannot contain a capital T or an ampersand (&)");
        
        while(true)
        {
            Console.WriteLine("Please enter your password");
            string userInput = Console.ReadLine();
            bool lowerPass = false;
            bool upperPass = false;
            bool numPass = false;


            foreach (char letter in userInput)
            {
                


                bool numCheck = char.IsDigit(letter);
                bool upperCheck = char.IsUpper(letter);
                bool lowerCheck = char.IsLower(letter);
                bool check = char.IsUpper(letter);

                if (check && letter == 'T')
                    Console.WriteLine("No uppercase 'T' allowed in password, please try again");
                else if (letter == '&')
                    Console.WriteLine("No '&' symbol allowed in password, please try again");
                else if (lowerCheck)
                {
                    upperPass = true;
                    continue;
                }
                else if (upperCheck)
                {
                    lowerPass = true;
                    continue;
                }
                else if (numCheck)
                { numPass = true;
                    continue;
                }
                else
                    Console.WriteLine("The password is not valid, please try again");
                

            }

            if (userInput.Length < 6)
                Console.WriteLine("Password length too short, it must be a minimum of 6 letters long");
            else if (userInput.Length > 13)
                Console.WriteLine("Password is too long, it must be a maximum of 13 letter long");
            else if (!numPass)
                Console.WriteLine("The password must include at least 1 number");
            else if (!upperPass)
                Console.WriteLine("The password must include at least 1 upper case letter");
            else if (!lowerPass)
                Console.WriteLine("The password must include at least 1 lower case leter");
            else if (numPass && upperPass && lowerPass)
                // call method to proceed
                Console.WriteLine("password accepted!");


        }

    }



}