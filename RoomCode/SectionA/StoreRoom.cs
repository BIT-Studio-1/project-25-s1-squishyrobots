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


        string description =
            "This store room seems, small, too small, you can barely turn around less you knock something off the shelves" +
            "The size of the room explains why there is so much still left out in the bay" +
            "The room is tall however, the shelves lining the walls go from floor to ceiling" +
            "And against the back wall there is a set of *lockers* probably used too store the belongings of the crew that worked in this room" +
            "The shelves are lined with many useful items but a few of them jump out at you" +
            "those being the abundance of *tool kits* and *extra parts* as well as the emergency supplies that every space station comes with" +
            "*emergency rations* in case the greenhouse fails, and plenty of *oxygen canisters* as well." +
            "Given that none of the emergency supplies have been touched the crew must have left in a hurry, or maybe not at all."
            ;


        string[] observations =
        {

        };


        Format.PrintSpecial(description);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
        }










        Player.GetInput();

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

            case "storage create":
                break;
            case "boxes":
                break;



        }
        Console.WriteLine();


        switch (Player.input)
        {
            case "shuttle bay":
                if (Map.CanIAccess(ShuttleBay.name))
                {
                    Player.location = ShuttleBay.name;
                }
                break;
            case "lab":
                if (Map.CanIAccess(Lab.name))
                {
                    Player.location = Lab.name;
                }
                break;
            default:
                break;
        }







    }




}





