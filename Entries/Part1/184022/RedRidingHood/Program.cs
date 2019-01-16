using System;


/**
 * Can we improve this class further?
 * Maybe by using classes (see workshop Part 2) to encapsulate
 * The meaning of this class.
 *
 */
class Program
{
    static void Main(string[] args)
    {
        MainMenu();
  
        Console.ReadKey();
    }

    private static void MainMenu()
    {
        string startMessage = "Welcome to 'GAME' what do you cant to do? Play (p), view (v) or exit (e)?";
        string dash = "---------------------------------------------------------";

        Console.WriteLine(dash);
        Console.WriteLine(startMessage);
        Console.WriteLine(dash);

        /**
         * This could be improved with using: the enum ConsoleKey
         * https://docs.microsoft.com/en-us/dotnet/api/system.consolekey?view=netframework-4.7.2
         * --> It makes working with the code easier and solves them issues and clears up the intend
         * switch(Console.ReadKey().Key){
         * case ConsoleKey.P:
         * ...
         * break;
         * }
         */
        switch (Console.ReadKey().KeyChar)
        {
            case 'p':
                PlayGame();//Good that you have used a function for this!
                break;

            case 'v':
                ViewCredits();
                break;

            case 'e':
                Environment.Exit(0);
                break;
        }
    }

    private static void ViewCredits()
    {
        Console.Write("Made by ");
        string playerName = Console.ReadLine();
        Console.WriteLine("Press 'm' to go back to main menu");

        if (Console.ReadKey().KeyChar == 'm') MainMenu();
        Console.WriteLine("---------------------------------------------------------");
    }

    private static void PlayGame()
    {
        Console.Write("Enter name of game: ");
        string gameName = Console.ReadLine();
        Console.WriteLine("'{0}' is starting up...", gameName);
        Console.WriteLine("---------------------------------------------------------");
    }
}
