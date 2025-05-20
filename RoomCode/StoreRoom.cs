using System;
using Globals;



public static class StoreRoom
{

    public static string name = "store room";


    public static bool test = false;





    // replaces main
    public static void start()
    {



        Console.WriteLine("You are in the Store Room.");



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



        Format.PrintConformed(description);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
            Console.WriteLine();
        }










        Player.GetInput();

        switch (Player.input)
        {
            case "spare parts kits":
                break;

            case "emergecy rations":
                break;

            case "tool boxs":
                break;

            case "oxygen canisters":
                break;

            case "storage create":
                break;
            case "boxes":
                break;



        }
        Console.WriteLine();


        switch (Player.input.ToLower())
        {
            case "shuttlue bay":
                Console.WriteLine("You choose the shuttlue bay");
                EscapePods.start();
                break;
            case "lab":
                Console.WriteLine("You choose the lab");
                ShuttleBay.start();
                break;

            default:
                Console.WriteLine("Invalid option");
                break;
        }







    }




}





