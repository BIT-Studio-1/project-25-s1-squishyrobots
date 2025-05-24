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

           ];


        string description =
            "blank"

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
                if (Map.CanIAccess(StoreRoom.name))
                {
                    Player.location = StoreRoom.name;
                }
                break;
            case "greenhouse":
                if (Map.CanIAccess(GreenHouse.name))
                {
                    Player.location = GreenHouse.name;
                }
                break;

            default:
                break;
        }






    }




}





