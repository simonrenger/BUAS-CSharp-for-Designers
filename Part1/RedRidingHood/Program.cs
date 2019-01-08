using System;



class Program
{
    static void Main(string[] args)
    {
        /**
        * This is a possible implementation based on the constrains given in the Presentation:
        *  ======================================================================================================================================================================
        *  ======================================================================================================================================================================
        *
        * This “Main menu” will contain some questions, which will return a single line of dialog, something like: 
        * “Welcome to *Game* what do you want to do?”	 <===========================================================================||
        * 1. Play Game -> Ask player for the name of the game -> Print “*[Game]* Starting up...” -> Think of something that happens after   ||
        * startup, after the rest of the options are finished                                                                                ||
        * 2. View Credits -> prints “Made by: [Your name]” -> go back to the main menu message ==============================================||
        * 3. Quit Game -> Ask player: “Do you really want to quit?” -> when answer is yes, exit the application
        *
        *  ======================================================================================================================================================================
        *  ======================================================================================================================================================================
        */
        // initial menu print:
        Console.WriteLine("Welcome to *Red Riding Hood* what do you want to do? \n\n");
        Console.WriteLine("1. Play Game");
        Console.WriteLine("2. View Credits");
        Console.WriteLine("3. Quit Game");
        Console.Write("\n>");
        ConsoleKeyInfo key = new ConsoleKeyInfo();
        while (key.Key != ConsoleKey.Escape)
        {
            key = Console.ReadKey();
            Console.WriteLine("\n");
            if (key.Key == ConsoleKey.D1)
            {
                Console.Clear();
                Console.WriteLine("What shall be the game name?");
                Console.Write("\n>");
                string name = Console.In.ReadLine();
                Console.WriteLine("The name of the game is {0}",name);
                Console.WriteLine("\n\n1. Play Game");
                Console.WriteLine("2. View Credits");
                Console.WriteLine("3. Quit Game");
                Console.Write("\n>");
            }
            else if (key.Key == ConsoleKey.D2)
            {
                Console.Clear();
                Console.WriteLine("~~~~~~~~~ Credits ~~~~~~~~~~");
                Console.WriteLine("Programmers:");
                Console.WriteLine("Simon ");
                Console.WriteLine("Maiko");
                Console.WriteLine("\n\n1. Play Game");
                Console.WriteLine("2. View Credits");
                Console.WriteLine("3. Quit Game");
                Console.Write("\n>");
            }
            else if (key.Key == ConsoleKey.D3)
            {
                Console.Clear();
                Console.WriteLine("Do you want to quit the game?");
                Console.WriteLine("(Y/N)");
                Console.Write("\n>");
                int decision = Console.Read();
                if (decision == 'Y')
                {
                    Environment.Exit(1);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("1. Play Game");
                    Console.WriteLine("2. View Credits");
                    Console.WriteLine("3. Quit Game");
                    Console.Write("\n>");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Your entry was not correct at all!");
                Console.WriteLine("1. Play Game");
                Console.WriteLine("2. View Credits");
                Console.WriteLine("3. Quit Game");
                Console.Write("\n>");
            }
        }

    }
}
