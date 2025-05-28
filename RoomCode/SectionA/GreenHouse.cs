using System;
using System.Security.Cryptography;
using Globals;



public static class GreenHouse
{
    public const string name = "greenhouse";


    // replaces main
    public static void start()
    {


        Format.PrintSpecial("You are in the Green House.");


        Map.SurroundingRooms =
           [
            Lab.name
           ];


        string description =
            "The green house is hot a humid, well it would kinda have to be. Rooms like these are typically installed so " +
            "stations can be 'Self Sustaining' But its common knowledge that most stations buy food stuffs from passing " +
            "vessels And the green room is just used as a backup incase something goes wrong. Lines of troughs filled with " +
            "soil and plants can be see everywhere in this room, the harsh lights beaming down on them trying to emulate " +
            "the light from the star produced in humanities home system."

            ;


        string[] observations =
        {
            "A small *panel* is imbedded in the wall, its screen fogged up due to the humidity in the room",
            "There is a small work *bench* with pots and loose soil scattered across its top."
        };


        Format.PrintSpecial(description, Format.lineWidthDefault, ConsoleColor.DarkGray, ConsoleColor.DarkBlue, ConsoleColor.DarkRed, ConsoleColor.DarkGreen);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
        }




        Player.GetInput();

        // actions
        switch (Player.input)
        {
            case "panel":
                Format.PrintSpecial("Wiping off the droplets of water you are able to see two bars, both turned up to the " +
                    "maximum that they can go too. The temperature and humidity controls you can't think of a reason to " +
                    "mess with these, you should just leave them as they are for now.");
                Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                Player.GetInput();
                break;

            case "bench":
                if (!Items.hasBlueKey)
                {
                    while (Player.input != "back")
                    {
                        if (!Items.hasBlueKey)
                        {
                            Format.PrintSpecial("As you approach the bench, you spot more items scattered across its surface. Some gardening " +
                                    "tools and seeds lay at one end with a tall, pristine watering can. At the other end, a small blue *keycard* " +
                                    "rests atop a dirty lab coat.");
                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();

                            switch (Player.input)
                            {
                                case "keycard":
                                    Format.PrintSpecial("You pick up the *blue keycard* .");
                                    Items.hasBlueKey = true;
                                    Format.PrintSpecial("Press %'enter'% to return or type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                    Player.GetInput();
                                    break;
                                case "back":
                                    break;
                                default:
                                    Format.PrintSpecial("^unknown command^");
                                    Format.PrintSpecial("Press %'enter'% to return or type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                    Player.GetInput();
                                    break;
                            }
                        }
                        else
                        {
                            Format.PrintSpecial("As you approach the bench, you spot more items scattered across its surface. Some gardening " +
                                    "tools and seeds lay at one end with a tall, pristine watering can. At the other end lies a dirty lab coat.");
                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                        }
                    }
                    
                } else
                {
                    Format.PrintSpecial("As you approach the bench, you spot more items scattered across its surface. Some gardening " +
                                    "tools and seeds lay at one end with a tall, pristine watering can. At the other end lies a dirty lab coat.");
                    Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    Player.GetInput();
                }
                break;

        }

        // locations
        switch (Player.input)
        {
            case "lab":
                Map.MoveTo(Lab.name);
                break;
            default:
                break;
        }

    }

}





