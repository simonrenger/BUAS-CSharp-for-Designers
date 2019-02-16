using System;
using System.Collections.Generic;

enum Scene
{
    Kitchen,
    Bedroom,
    NeighborsHouse,
    Bakery,
    InsideBakery
}

public class RedRidingHoodGame
{
    private int currentPosition;
    private string[] environmentDescriptions;

    public RedRidingHoodGame()
    {
        currentPosition = (int)Scene.Bedroom;

        environmentDescriptions = new string[5];
        environmentDescriptions[(int)Scene.Kitchen] = "You are in the kitchen, you notice there is some wine on the table";
        environmentDescriptions[(int)Scene.Bedroom] = "You are in the bedroom, you seem to have drank to much yesterday and feel hungover";
        environmentDescriptions[(int)Scene.NeighborsHouse] = "You are in front of the neighbors house, they have a basket with a sleeping baby in it";
        environmentDescriptions[(int)Scene.Bakery] = "You are at the bakery, you can look through the glass window to the inside";
        environmentDescriptions[(int)Scene.InsideBakery] = "You are inside of the bakery there is a lot of food here";
    }

    public void Play()
    {
        Console.WriteLine("Booting up game... ");

        ConsoleKey key = ConsoleKey.NoName;
        while (key != ConsoleKey.B)
        {
            DescribeCurrentEnvironment();

            if (currentPosition != 0)
            {
                Scene leftScene = (Scene) (currentPosition - 1);
                Console.WriteLine("To move to the {0}, type 'A'", leftScene.ToString());
            }

            if (currentPosition != 4)
            {
                Scene rightScene = (Scene) (currentPosition + 1);
                Console.WriteLine("To move to the {0}, type 'D'", rightScene.ToString());
            }
            Console.WriteLine("To go back to the main menu, press 'B'");

            key = Console.ReadKey().Key;

            Console.Clear();

            if (key == ConsoleKey.A && currentPosition != 0)
            {
                currentPosition--;
            }
            else if (key == ConsoleKey.D && currentPosition != 4)
            {
                currentPosition++;
            }
            else if (key == ConsoleKey.B)
            {
                //Because of the check in the while loop,
                //The game will end and go back to the main menu
            }
            else
            {
                Console.WriteLine("Invalid Key!");
            }
        }
    }

    private void DescribeCurrentEnvironment()
    {
        string description = environmentDescriptions[currentPosition];
        Console.WriteLine(description);
    }
}

class Program
{
    static void Main(string[] args)
    {
        /**
        * This is a possible implementation based on the constrains given in the Presentation #2:
        *  =====================================================================================================================================
        *  =====================================================================================================================================
        *
        * This “Main menu” will contain some questions, which will return a single line of dialog, something like: 
        * “Welcome to *Game* what do you want to do?”	 <===================================================================================||
        * 1. Play Game -> Ask player for the name of the game -> Print “*[Game]* Starting up...” -> go to new instruction #4                 ||
        * 2. View Credits -> prints “Made by: [Your name]” -> go back to the main menu message ==============================================||
        * 3. Quit Game -> Ask player: “Do you really want to quit?” -> when answer is yes, exit the application
        *
        * 4. From the MainMenu’s StartGame option:
        *    5. Set the current position of the player to the starting point in the Scene. (as described in the image).
        *    6. Describe the current environment by printing a description to the console.
        *    7. Then give options to explore the scene:
        *       8. You should have the movement options described in the image below. Set the current position  Then go back to #4
        *       9. Or to go back to the MainMenu.
        *   
        *  =====================================================================================================================================
        *  =====================================================================================================================================
        */

        //Initial print
        Console.WriteLine("Welcome to *Red Riding Hood* what do you want to do? \n\n");

        //Save last key press in a variable
        ConsoleKeyInfo key = new ConsoleKeyInfo();
        while (key.Key != ConsoleKey.Escape)
        {
            //Ask player for which option they want
            Console.WriteLine("1. Play Game");
            Console.WriteLine("2. View Credits");
            Console.WriteLine("3. Quit Game");
            Console.Write("\n>");

            key = Console.ReadKey();
            Console.WriteLine("\n");

            if (key.Key == ConsoleKey.D1) //When "Key 1" has been pressed
            {
                Console.Clear();
                Console.WriteLine("What shall be the game name?");
                Console.Write("\n>");
                string name = Console.ReadLine();
                Console.WriteLine("The name of the game is {0}\n",name);

                RedRidingHoodGame game = new RedRidingHoodGame();
                game.Play();
            }
            else if (key.Key == ConsoleKey.D2) //When "Key 2" has been pressed
            {
                Console.Clear();
                Console.WriteLine("~~~~~~~~~ Credits ~~~~~~~~~~");
                Console.WriteLine("Programmers:");
                Console.WriteLine("Simon ");
                Console.WriteLine("Maiko");
                Console.WriteLine("\n\n");
            }
            else if (key.Key == ConsoleKey.D3) //When "Key 3" has been pressed
            {
                Console.Clear();
                Console.WriteLine("Do you want to quit the game?");
                Console.WriteLine("(Y/N)");
                Console.Write("\n>");
                ConsoleKey decision = Console.ReadKey().Key;
                if (decision == ConsoleKey.Y)
                {
                    Environment.Exit(1);
                }
                else
                {
                    //We decided not to quit, so clear console and go back up again
                    Console.Clear();
                }
            }
            else //When you pressed anything else than key 1, 2 or 3
            {
                Console.Clear();
                Console.WriteLine("Your entry was not correct at all!\n");
            }
        }

    }
}
