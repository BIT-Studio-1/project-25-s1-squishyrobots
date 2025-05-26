
using Globals;
using System;
using System.Threading;





public static class MainMenu
{
    public static void ShowMenu()
    {
        string input = " ";
        string[] TitleLines = {/*you title lines here*/};

        while (input != "exit")
        {
            Console.Clear();
            // ASII lines for the title
            string[] titleLines = new string[15];
        }

        {
            Console.WriteLine(@"   _____                      _     _          _____       _           _   ");
            Console.WriteLine(@"  / ___|                    | |   ()        |  __ \     | |         | |  ");
            Console.WriteLine(@" | (___   ___  _   _ _ __ __| |_  _ _ __    | |) |   | |_   ___ | |_ ");
            Console.WriteLine(@"  \___ \ / _ \| | | | '/ _| ' \| | '_ \   |  _  / | | | '_ \ / _ \| __|");
            Console.WriteLine(@"  ___) | () | || | | | (| | | | | | | |  | | \ \ || | |) | () | |_ ");
            Console.WriteLine(@" |/ \/ \,||  \|| |||| ||  ||  \\,|./ \/ \_|");
        }
        ;
        //color array for fun effect
        ConsoleColor[] colors = new ConsoleColor[]
        {
            ConsoleColor.Yellow,
            ConsoleColor.Cyan,
             ConsoleColor.Magenta,
                 ConsoleColor.Green,
                 ConsoleColor.Blue,
                ConsoleColor.Red



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
            Thread.Sleep(150); // 150 milisec delay
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
            Console.Write("\nselect an option (1-6):  ");
            input = Console.ReadLine().ToLower();

            Console.ResetColor();

            Player.GetInput();

            switch (Player.input)
            {
                case "1":

                    Console.WriteLine("you selected: write Options");
                    break;


                case "2":

                    Console.WriteLine("you selected: play");
                    break;

                case "3":

                    Console.WriteLine("you selected: map");
                    break;

                case "4":

                    Console.WriteLine("you selected: instructions");
                    break;


                case "5":

                    Console.WriteLine("you selected: creadits");
                    break;


                case "6":


                    Console.WriteLine("Exiting...");


                    input = "exit"; // to end the loop
                    break;
                default:
                    Console.WriteLine(" Invalid option. please try again. ");
                    Console.WriteLine("\n Press enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }
    }
}

        
        
            
             
              
               



