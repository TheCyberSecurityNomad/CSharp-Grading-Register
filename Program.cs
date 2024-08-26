
using System;

namespace Assessment1
{
    class Task02
    {
        public static void Main(String[] args)
        {
            int Grade;
            string Menu = "y";
            do
            {
                //Ask the user to enter their first number
                Console.Write("Welcome to the grading register! \n" +
                                "What is your grade? ");
                while (!int.TryParse(Console.ReadLine(), out Grade) || Grade < 0 || Grade > 100)
                {
                    Console.Write("Invalid, Try again! \n");
                }

                if (Grade >= 85 && Grade <= 100)
                    Console.WriteLine("You got High Distinction! Well done!");
                else if (Grade >= 75 && Grade <= 84)
                    Console.WriteLine("You got Distinction! Well done!");
                else if (Grade >= 65 && Grade <= 74)
                    Console.WriteLine("You got Credit! Good job!");
                else if (Grade >= 55 && Grade <= 64)
                    Console.WriteLine("You got a Pass");
                else if (Grade >= 0 && Grade <= 54)
                    Console.WriteLine("Sorry, you failed. Better luck next time!");

                //Ask user if they want to continue or quit
                Console.Write("\n Press 'Y' to input your grade again, or 'Q' to quit the program: ");
                Menu = Console.ReadLine().ToLower();

                //Check user input to either continue or quit
                switch (Menu)
                {
                    case "Y" or "y": // Pressing Y or y will continue the program
                        continue;
                    case "Q" or "q": // Pressing Q will quit the program
                        Console.WriteLine("Exiting the program.");
                        //Exit the do-while loop and end the program
                        break;
                }
            }
            while (Menu != "q"); // While loop continues till the user quits.
        }
    }

}
