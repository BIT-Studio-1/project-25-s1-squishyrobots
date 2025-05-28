
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
            Console.WriteLine("********************");
            Console.WriteLine($"   * {title}*      ");
            Console.WriteLine("********************");

            Thread.Sleep(1000);

        }

        string[] robotArt = {
    "     [::]     ",
    "   /------\\   ",
    "  |  .--.  |  ",
    "  | ( () ) |  ",
    "   \\ '--' /   ",
    "    | || |    ",
    "    ||||    ",
};

        foreach (string line in robotArt)
        {
            Console.WriteLine(line);
            Thread.Sleep(150);
        }


    }
    public static void ShowMenu()
    {
        string input = " ";
        //string[] TitleLines = {/*you title lines here*/};

        ConsoleColor[] colors = new ConsoleColor[]
        {
            ConsoleColor.Yellow,
            ConsoleColor.Cyan,
            ConsoleColor.Magenta,
            ConsoleColor.Green,
            
            



        };
        
        string[] title_lines = new string[]
        {
            "********************",
            "*squishy robot game*",
            "********************",
        };
        //print each line with the color and delay(pop up effect)
        for (int i = 0; i < title_lines.Length; i++)
        {
            Console.ForegroundColor = colors[i % colors.Length];

            Console.WriteLine(title_lines[i]);
            Thread.Sleep(1000); // 1000 milisec delay
        }
        // sublitle
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n welcome to the SquishyRobot Game!");


        Console.WriteLine("press enter to continue...\n");
        Console.ReadLine();

        // main menu loop
        while (input != "exit")
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;



            // display the menu

            Console.WriteLine("*********************");
            Console.WriteLine("*                   *");
            Console.WriteLine("*                   *");
            Console.WriteLine("*     main menu     *");
            Console.WriteLine("*                   *");
            Console.WriteLine("*                   *");
            Console.WriteLine("*********************");
            Console.WriteLine("1.write options");
            Console.WriteLine("2.play");
            Console.WriteLine("3.map");
            Console.WriteLine("4.instructions");
            Console.WriteLine("5.credits");
            Console.WriteLine("6.exit");
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

                    Console.WriteLine("you selected: play");
                    Console.WriteLine("Enter to continue.");
                    Console.ReadLine();
                    Player.input = "menu";
                    break;

                case "map":

                    Console.WriteLine("you selected: map");
                    Console.WriteLine("Enter to continue.");
                    Console.ReadLine();
                    Player.input = "menu";
                    break;

                case "instructions":

                    Console.WriteLine("you selected: instructions");
                    Console.WriteLine("Enter to continue.");
                    Console.ReadLine();
                    Player.input = "menu";
                    break;


                case "creadits":

                    Console.WriteLine("you selected: creadits");
                    Console.WriteLine("Enter to continue.");
                    Console.ReadLine();
                    Player.input = "menu";
                    break;


                case "exit":


                    Console.WriteLine("Exiting...");
                    Thread.Sleep(2000);


                    Player.input = "exit"; // to end the loop
                    break;
                default:
                    Console.WriteLine(" Invalid option. please try again. ");
                    Player.input = "menu";
                    
                    break;
            }
        }
    }
}

        
        
            
             
              
               



