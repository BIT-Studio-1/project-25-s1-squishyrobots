
using Globals;





public static  class MainMenu
{
    public static void ShowMenu()
    {
      
        {
            // displsy the menu 
            Console.WriteLine("----main menu----");
            Console.WriteLine("write options");
            Console.WriteLine("play");
            Console.WriteLine("map");


            Player.GetInput();

            switch (Player.input)
            {
                case "play":
                    Console.WriteLine("you are playing");
                    break;

                case "map":
                    Console.WriteLine("");
                    break ;
            }
        }
    }
    
}



