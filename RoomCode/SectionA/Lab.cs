using System;
using Globals;



public static class Lab
{
    public const string name = "lab";


    // replaces main
    public static void start()
    {

        Format.PrintSpecial("You are in the Lab.");


        Map.SurroundingRooms =
           [
            PrimaryHallway.name,
            StoreRoom.name,
            GreenHouse.name
           ];


        string description =
            "blank"

            ;


        string[] observations =
        {

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
            case "test tube":
                break;

            case "microscope":
                break;

            case "experiment log":
                break;

            case "chemical flask":
                break;

            case "data pad":
                break;


        }

        // locations
        switch (Player.input)
        {
            case "store room":
                if (Map.CheckAccess(StoreRoom.name))
                {
                    Player.location = StoreRoom.name;
                }
                break;
            case "greenhouse":
                if (Map.CheckAccess(GreenHouse.name))
                {
                    Player.location = GreenHouse.name;
                }
                break;
            case "hallway":
                if (Map.CheckAccess(PrimaryHallway.name))
                {
                    Player.location = PrimaryHallway.name;
                    Player.currentHallway = 1;
                }
                break;

            default:
                break;
        }






    }




}





