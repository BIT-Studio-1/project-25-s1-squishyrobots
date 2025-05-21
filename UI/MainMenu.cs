
using Globals;





public static  class MainMenu
{
    public static void ShowMenu()
    {
        string input = " ";

        while (input != "exit")
        {
            // displsy the menu 
            Console.WriteLine("*********************");
            Console.WriteLine("*                   *");
            Console.WriteLine("*                   *");
            Console.WriteLine("*     main menu     *");
            Console.WriteLine("*                   *");
            Console.WriteLine("*                   *");
            Console.WriteLine("*********************");
            Console.WriteLine("write options");
            Console.WriteLine("play");
            Console.WriteLine("map");
            Console.WriteLine("instructions");
            Console.WriteLine("credits");
            Console.WriteLine("exit");
            Console.Write("select an option (1-5):  ");
            input = Console.ReadLine().ToLower();
            
           


            Player.GetInput();

            switch (Player.input)
            {
                case "1":
                case "play":
                    Console.WriteLine("you are playing");
                    break;


                case "2":
                case "map":
                    Console.WriteLine("map will be display here");
                    break ;

                case "3":
                case "instuctions":
                    Console.WriteLine("use the keyboard to navigate an complete the mission.");
                    break;

                case "4":
                case "credits":
                    Console.WriteLine("game created by yourname");
                    break;


                case "5":
                case "exit":
                    Console.WriteLine("exiting from the game.");
                    break;

                    input = "exit"; // to end the loop
                    break;
                default:
                    Console.WriteLine(" Invalid option. please try again. ");
                    break;
                    
            }
            if (input != "exit")
            {
                Console.WriteLine("\nPress any key to return to menu....");
                Console.ReadLine();
            }
        }
    }
    
}



