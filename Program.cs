using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); 

            GreetUser(); 

            while (true)
            {

                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                ////////////////////////////
                int count = 0;
                bool limit = true;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber && limit)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess) && count < 5 )
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        count += 1;
                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber && count < 5)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                        count += 1;

                    }

                    if(count >= 5)
                    {
                        limit = false;
                    }
                }

                if(!limit)
                {
                    PrintColorMessage(ConsoleColor.Magenta, "Oops! You reach to limit of guess!");
                    Console.WriteLine("Play Again? [Y or N]");
                    string a = Console.ReadLine().ToUpper();
                    if (a == "Y")
                    {
                        continue;
                    }
                    else
                    {
                        return;
                    }
                  
                }
                
                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else
                {
                    return;
                }
            }           

        }

        // Get and display app info
        static void GetAppInfo() {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mert Efe";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask users name and greet
        static void GreetUser() {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message) {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();

        }
    }
}









