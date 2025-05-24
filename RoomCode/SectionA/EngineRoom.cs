using System;
using Globals;



public static class EngineRoom
{
    public const string name = "engine room";


    // replaces main
    public static void start()
    {



        Format.PrintSpecial("You are in the Engine Room.");


        Map.SurroundingRooms =
           [
            EscapePods.name,
            ShuttleBay.name,
            Brig.name
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


        //actions




        // locations
        switch (Player.input)
        {
            case "escape pods":
                if (Map.CanIAccess(EscapePods.name))
                {
                    Player.location = EscapePods.name;
                }
                break;
            case "shuttle bay":
                if (Map.CanIAccess(ShuttleBay.name))
                {
                    Player.location = ShuttleBay.name;
                }
                break;

            default:
                break;
        }
    }




}





