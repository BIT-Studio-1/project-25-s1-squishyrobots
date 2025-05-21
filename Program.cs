using Globals;




namespace SquishyRobotGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Player.location = "shuttle bay";

            // print out instructions:
            Format.PrintSpecial("" +
            "\nWelcome to the Squishy Robot Game\n" +
            "\t - *inventory* \n" +
            "\t - rules\n\n");



            //Player.input = "menu";

            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;

                if (Player.input == "menu")
                {
                    MainMenu.ShowMenu();
                    Player.GetInput();
                }
                else if (Player.input == "inventory")
                {
                    Player.ShowInventory();
                }
                else if (Player.input == "rules")
                {
                    Format.PrintSpecial("Rules: \n" +
                        "1. You are a robot, and you need to escape the ship.\n" +
                        "2. You can interact with objects in the environment.\n" +
                        "3. Use the 'inventory' command to check your items.\n" +
                        "4. Use the 'exit' command to leave the game.\n");
                    Format.PrintSpecial("Press &'enter'& to continue...");
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
