
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
                Format.PrintSpecial();

            Console.ForegroundColor = colors[bounce % colors.Length];
            Format.PrintSpecial("********************");
            Format.PrintSpecial($"   * {title}*      ");
            Format.PrintSpecial("********************");

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
            Format.PrintSpecial(line);
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

            Format.PrintSpecial("*********************");
            Format.PrintSpecial("*                   *");
            Format.PrintSpecial("*                   *");
            Format.PrintSpecial("*     main menu     *");
            Format.PrintSpecial("*                   *");
            Format.PrintSpecial("*                   *");
            Format.PrintSpecial("*********************");
            Format.PrintSpecial("*play*");
            //Format.PrintSpecial("options");
            Format.PrintSpecial("map");
            Format.PrintSpecial("help");
            //Format.PrintSpecial("credits");
            Format.PrintSpecial("exit");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nselect an option:  ");
            

            

            Player.GetInput();

            switch (Player.input)
            {
                case "options":

                    Format.PrintSpecial("you selected: write options");
                    Format.PrintSpecial("Enter to continue.");
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

                    Format.PrintSpecial("you selected: creadits");
                    Format.PrintSpecial("Enter to continue.");
                    Console.ReadLine();
                    Player.input = "menu";
                    break;


                case "exit":
                    Format.PrintSpecial("Exiting...");
                    Thread.Sleep(1000);

                    break;
                default:
                    Format.PrintSpecial(" Invalid option. please try again. ");
                    Player.input = "menu";
                    
                    break;
            }
        }
    }
}

        
        
            
             
              
               



