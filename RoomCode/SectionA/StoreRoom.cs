using System;
using Globals;



public static class StoreRoom
{

    public const string name = "store room";




    // replaces main
    public static void start()
    {

        Format.PrintSpecial("You are in the *Store Room* .");

        
        Map.SurroundingRooms =
           [
            Lab.name,
            ShuttleBay.name
           ];


        string description = "" +
            "This store room seems, small, too small, you can barely turn around less you knock something off the shelves." +
            "The size of the room explains why there is so much still left out in the bay." +
            "The room is tall however, the shelves lining the walls go from floor to ceiling." +
            "The walls in this room lacks the vibrant paint that the shuttle bay had is noticeably absent from this room." +
            "On second thought that makes sense as only crew would typically see this space." +
            "You scan the room for anything useful its rather hard to find anything with all the mess but a few things jump out at you"
            ;


        string[] observations =
        {
            "Against the back wall you notice a set of 3 *lockers* , painted in a dark blue the add and nice splash of colour too the otherwise dull room",
            "A *tool box* peeks out from under a shelf, its lid slightly open, you can see a few tools inside"
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
   

            case "lockers":
                if (!Items.hasBlueKey)
                {
                    while (Player.input != "back")
                    {
                        if (!Items.hasBlueKey)
                        {
                            Format.PrintSpecial("You open the lockers and see a few items inside like a flashlight and an empty first aid kit, a blue *keycard* is tucked away in the corner of one of them. ");
                            Format.PrintSpecial("Press %'enter'% to return or type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                            switch (Player.input)
                            {
                                case "keycard":
                                    Format.PrintSpecial("You take the *blue keycard*, it looks like it could be used to open a door somewhere on the station.");
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
                            Format.PrintSpecial("You open the lockers and see a few items inside, the flashlight and the empty first aid kit are still there.");
                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                        }
                    }
                }
                else
                {
                    Format.PrintSpecial("You open the lockers and see a few items inside, the flashlight and the empty first aid kit are still there.");
                    Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    Player.GetInput();
                }

                break;


            case "tool box":
                if (!Items.hasRedKey)
                {
                    while (Player.input != "back")
                    {
                        if (!Items.hasRedKey)
                        {
                            Format.PrintSpecial("You open the tool box and see a few tools inside, a screwdriver and a hammer are the most useful looking ones. " +
                                "You also spot a small *red keycard* tucked away in the corner of the box.");

                            Format.PrintSpecial("Press %'enter'% to return or type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                            switch (Player.input)
                            {
                                case "keycard":
                                    Format.PrintSpecial("You take the red keycard, it looks like it could be used to open a door somewhere on the station.");
                                    Items.hasRedKey = true;
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
                            Format.PrintSpecial("You open the tool box and see a few tools inside, a screwdriver and a hammer are the most useful looking ones.");

                            Format.PrintSpecial("Press %'enter'% to return or type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                        }
                    }
                }
                else
                {
                    Format.PrintSpecial("You open the tool box and see a few tools inside, a screwdriver and a hammer are the most useful looking ones.");
                    Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    Player.GetInput();
                }
                break;
        }




        // locations
        switch (Player.input)
        {
            case "shuttle bay":
                Map.MoveTo(ShuttleBay.name);
                break;

            case "lab":
                Map.MoveTo(Lab.name);
                break;
            
            default:
                break;
        }







    }




}





