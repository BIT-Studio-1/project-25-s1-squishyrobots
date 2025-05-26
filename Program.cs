using Globals;



namespace SquishyRobotGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Player.location = "shuttle bay";


            Player.input = "menu";

            do
            {

                // print out instructions:
                Format.PrintSpecial("" +
                "\tWelcome to the Squishy Robot Game\n" +
                "\t- ^menu^ \n" +
                "\t- *inventory* \n" +
                "\t- %help% \n" +
                "\t- ^map^ \n", 50);


                Console.ForegroundColor = ConsoleColor.Gray;

                if (Player.input == "menu")
                {
                    MainMenu.ShowMenu();
                }
                else if (Player.input == "map")
                {
                    Map.ShowMap();
                }
                else if (Player.input == "inventory")
                {
                    Player.ShowInventory();
                }
                else if (Player.input == "help")
                {
                    Format.PrintSpecial("%Instructions% : \n" +
                        "1. You are a robot, and you need to escape the ship.\n" +
                        "2. You can interact with objects in the environment.\n" +
                        "3. Use the *'inventory'* command to check your items.\n" +
                        "4. Use the ^'exit'^ command to leave the game.\n", 17);
                    Format.PrintSpecial("Press %'enter'% to continue...");
                    Player.GetInput();
                }
                else
                {
                    switch (Player.location)
                    {
                        case "shuttle bay":
                            ShuttleBay.start();
                            break;
                        case "escape pods":
                            EscapePods.start();
                            break;
                        case "engine room":
                            EngineRoom.start();
                            break;
                        case "store room":
                            StoreRoom.start();
                            break;
                        case "bridge":
                            Bridge.start();
                            break;
                        case "brig":
                            Brig.start();
                            break;
                        case "captains quarters":
                            CaptQuarters.start();
                            break;
                        case "crew quarters":
                            CrewQuarters.start();
                            break;
                        case "greenhouse":
                            GreenHouse.start();
                            break;
                        case "med bay":
                            MedBay.start();
                            break;
                        case "mess hall":
                            MessHall.start();
                            break;
                        case "rec room":
                            RecRoom.start();
                            break;

                    }
                }









                // do while !exit:
                //      query player
                // if exit, then leave room loop.







            } while (Player.input != "exit") ;












        }
    }
}
