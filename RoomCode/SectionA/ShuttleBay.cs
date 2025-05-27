using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using Globals;
using static System.Runtime.InteropServices.JavaScript.JSType;



public static class ShuttleBay
{

    public const string name = "shuttle bay";
    public static bool hasFuel = false;



    // replaces main
    public static void start()
    {

        Format.PrintSpecial("You are in the *shuttle bay* .");

        Map.SurroundingRooms = 
            [
            StoreRoom.name,
            EscapePods.name,
            EngineRoom.name,
            SouthHallway.name
            ];


        
        // switch on room state? - inspection of items, documentation and main?
        // switch includes rules and inventory methods found in global? possible separation into interaction file?



        string description =
            "The shuttle bay is much like the ones you have seen before, " +
            "though this one is noticeably more cluttered than most. " +
            "The ship you arrived on sits idle on one of the many gravity " +
            "locks this for of landing pad is still pretty new but is still " +
            "common place among the space stations in the system. " +
            "The lights in the bay seem to be flickering, must be something " +
            "to do with the power, or lack there of. " +
            "The walls are white with subtle red accents, a common paint " +
            "theme when it comes to {Name of company}."
            ;


        string[] observations =
        {
            "In the corner of the room you notice a *steel crate* , it looks like many of the " +
            "others in the room but this one seems to be the only one lacking a lock on it",
            "A *desk* sits near the door too what you can only assume to be the rest of the ship",
            "On the side of the landing pad sits a large cylindrical structure, made entirely out " +
            "of steel and painted in a vibrant red. Looks like a *silo* .",
        };




        Format.PrintSpecial(description, Format.lineWidthDefault, ConsoleColor.DarkGray, ConsoleColor.DarkBlue, ConsoleColor.DarkRed, ConsoleColor.DarkGreen);


        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
        }


        Player.GetInput();


        // Interactions
        switch (Player.input)
        {
            case "steel crate":
                Format.PrintSpecial("It takes some effort but you finally get the steel crate open, " +
                    "Inside sits a *fuel cell* , these are typically used for powering space stations " +
                    "much like this one, this might come in handy");

                Format.PrintSpecial("Use %'back'% to exit.");
                Player.GetInput();
                switch (Player.input)
                {
                    case "fuel cell":
                        Format.PrintSpecial("You pick up the *fuel cell* !");
                        Player.hasFuelCell = true;
                        Format.PrintSpecial("Press %'enter'% to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                        Player.GetInput();
                        break;
                    default:
                        break;
                }
                break;
            case "desk":
                Format.PrintSpecial("Upon looking a little closer at the desk you notice a *boarding pass* .");
                Format.PrintSpecial("Press %'enter'% to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                Player.GetInput();
                switch (Player.input)
                {
                    case "boarding pass":
                        Format.PrintSpecial("It's a tattered boarding pass with small burn marks " +
                            "around the edges. The first name is burned through but you can just " +
                            "make out the last name %'Collins'% . They seemed to be traveling beyond " +
                            "the station and just stopped for a refuel.");
                        Format.PrintSpecial("Press %'enter'% to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                        Player.GetInput();
                        break;
                    case "back":
                        break;
                    default:
                        Format.PrintSpecial("^unknown command^");
                        break;
                }
                break;
            case "silo":
                if (!hasFuel)
                {
                    Format.PrintSpecial("Upon closer inspection you notice a little gauge with a " +
                        "needle pointing to the ^red^ section. You surmise that this must be the " +
                        "canister that holds the fuel for the shuttles that land here, but at this " +
                        "present moment it seems to be ^empty^ and of little use.");
                    if (Player.hasFuelCell)
                    {
                        Format.PrintSpecial("You have an item in your inventory that might help.");
                    }
                    if (Player.hasFuelCell)
                    {
                        Format.PrintSpecial("Type 'back' to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                        while (Player.input != "back")
                        {
                            Player.GetInput();
                            switch (Player.input)
                            {
                                case "fuel cell":
                                    hasFuel = true;
                                    Format.PrintSpecial("You pull out the fuel cell and top up the " +
                                        "silo with the glowing blue energy.");
                                    Format.PrintSpecial("Press %'enter'% to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                    Player.GetInput();
                                    Player.input = "back";
                                    break;
                                case "back":
                                    break;
                                default:
                                    Format.PrintSpecial("^unknown command^");
                                    Player.GetInput();
                                    break;

                            }
                        }

                    }
                    else
                    {
                        Format.PrintSpecial("Press %'enter'% to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                        Player.GetInput();
                    }
                }
                else
                {
                    Format.PrintSpecial("It's a full fuel silo");
                    Format.PrintSpecial("Press %'enter'% to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    Player.GetInput();
                }

                break;
            case "cargo":

                break;
            default:
                break;

        }  


        // Locations
        switch (Player.input)
        {
            case "escape pods":
                if (Map.CanIAccess(EscapePods.name))
                {
                    Player.location = EscapePods.name;
                }
                break;
            case "engine room":
                if (Map.CanIAccess(EngineRoom.name))
                {
                    Player.location = EngineRoom.name;
                }
                break;
            case "store room":
                if (Map.CanIAccess(StoreRoom.name))
                {
                    Player.location = StoreRoom.name;
                }
                break;
            default:
                break;
        }



    }



}

