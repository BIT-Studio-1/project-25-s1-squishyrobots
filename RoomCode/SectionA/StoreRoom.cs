using System;
using Globals;



public static class StoreRoom
{

    public const string name = "store room";


    public static bool test = false;





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
            "The *shelves* have a few different items that could be useful",
            "Against the back wall you notice a set of 3 *lockers* , painted in a dark blue the add and nice splash of colour too the otherwise dull room"
        };


        Format.PrintSpecial(description, Format.lineWidthDefault, ConsoleColor.DarkGray, ConsoleColor.DarkBlue, ConsoleColor.DarkRed, ConsoleColor.DarkGreen);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
        }




        //lockers
        //shelves


        Player.GetInput();




        // actions
        switch (Player.input)
        {
            case "spare parts kits":
                break;

            case "emergency rations":
                break;

            case "tool boxes":
                break;

            case "oxygen canisters":
                break;

            case "storage crate":
                break;
            case "boxes":
                break;

        }


        Utility.Check();



        // locations
        switch (Player.input)
        {
            case "shuttle bay":
                if (Map.CheckAccess(ShuttleBay.name))
                {
                    Player.location = ShuttleBay.name;
                }
                break;

            case "lab":
                if (Map.CheckAccess(Lab.name))
                {
                    Player.location = Lab.name;
                }
                break;
            
            default:
                break;
        }







    }




}





