
using Globals;
using System;
using System.Threading;





public static class MainMenu
{
   public  static void Title()
    {
        Console.Clear();
        Console.CursorVisible = false;

        string title = "SQUISHY ROBOT GAME";
        ConsoleColor[] colors = new ConsoleColor[]
        {
            ConsoleColor.Magenta,
            ConsoleColor.Cyan,
            ConsoleColor.Red,
            ConsoleColor.Green,
            ConsoleColor.Yellow
        };
        // Animation Bouncing title
        for (int bounce = 0; bounce < 3; bounce++)
        {
            Console.Clear();
            int padding = (bounce % 2 == 0) ? 4 : 6;
            for (int i = 0; i < padding; i++)
                Console.WriteLine();

            Console.ForegroundColor = colors[bounce % colors.Length];
            Console.WriteLine("********************" );
            Console.WriteLine($"   * {title}*      ");
            Console.WriteLine("********************");

            Thread.Sleep(400);

        }

        string[] robotArt = {
    "     [::]     ",
    "   /------\\   ",
    "  |  .--.  |  ",
    "  | ( () ) |  ",
    "   \\ '--' /   ",
    "    | || |    ",
    "    ||||||  ",
};

        foreach (string line in robotArt)
        {
            Console.WriteLine(line);
            Thread.Sleep(400);
        }


    }
    public static void ShowMenu()
    {
        

        // main menu loop
        while (Player.input != "back" && Player.input != "exit")
        {
            

            Console.ForegroundColor = ConsoleColor.Green;

            // display the menu
            

            Console.WriteLine("*********************");
            Console.WriteLine("*********************");
            Console.WriteLine("*                   *");
            Console.WriteLine("*     main menu     *");
            Console.WriteLine("*                   *");
            Console.WriteLine("*********************");
            Console.WriteLine("*********************");
            Format.PrintSpecial("*play*");
            //Console.WriteLine("options");
            Console.WriteLine("map");
            Console.WriteLine("help");
            //Console.WriteLine("credits");
            Console.WriteLine("exit");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nselect an option:  ");
            

            

            Player.GetInput();

            switch (Player.input)
            {
                case "options":

                    Console.WriteLine("you selected: write options");
                    Console.WriteLine("Enter to continue.");
                    Console.ReadLine();
                    Player.input = "menu";
                    break;


                case "play":
                    Player.input = "back";
                    break;

                case "map":
                    break;

                case "help":
                    break;


                case "credits":

                    Console.WriteLine("you selected: creadits");
                    Console.WriteLine("Enter to continue.");
                    Console.ReadLine();
                    Player.input = "menu";
                    break;


                case "exit":
                    Console.WriteLine("Exiting...");
                    Thread.Sleep(1000);

                    break;
                default:
                    Console.WriteLine(" Invalid option. please try again. ");
                    Player.input = "menu";
                    
                    break;
            }
        }
    }
}

        
        
            
             
              
               



