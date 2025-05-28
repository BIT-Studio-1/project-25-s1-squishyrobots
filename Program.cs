using Globals;



namespace SquishyRobotGame
{
    internal class Program
    {
        static void Main(string[] args)
        {



            MainMenu.Title();

            Format.PrintSpecial("Press %'enter'% to continue.", 15, ConsoleColor.DarkGray);
            Player.GetInput();

            MainMenu.ShowMenu(); //goes here.
            //Utility.Check();


            Player.location = "shuttle bay"; 

            do
            {

                switch (Player.location)
                {

                        // Section A
                    case "brig":
                        Brig.start();
                        break;

                    case "engine room":
                        EngineRoom.start();
                        break;

                    case "escape pods":
                        EscapePods.start();
                        break;

                    case "greenhouse":
                        GreenHouse.start();
                        break;

                    case "lab":
                        Lab.start();
                        break;

                    case "shuttle bay":
                        ShuttleBay.start();
                        break;

                    case "store room":
                        StoreRoom.start();
                        break;


                        // Section B
                    case "library":
                        Library.start();
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


                        // Section C
                    case "bridge":
                        Bridge.start();
                        break;

                    case "captains quarters":
                        CaptQuarters.start();
                        break;

                    case "crew quarters":
                        CrewQuarters.start();
                        break;


                        // switch on hallway selection due to ease of player input & consistency
                    case "hallway":
                        switch (Player.currentHallway)
                        {
                            case 1:
                                PrimaryHallway.start(); // Section A
                                break;
                            case 2:
                                IntermediateHallway.start(); // Section B
                                break;
                            case 3:
                                TerminalHallway.start(); // Section C
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                    }

                // do while !exit:
                //      query player
                // if exit, then leave room loop.

            } while (Player.input != "exit");

            Format.PrintSpecial("Thank you for playing!\nGame is now closing.");
            Thread.Sleep(1000);


        }

    }
}
