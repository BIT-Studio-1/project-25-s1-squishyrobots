using System;
using Globals;



public static class Brig
{
    public const string name = "brig";


    // replaces main
    public static void start()
    {


        Format.PrintSpecial("You are in the Brig.");


        Map.SurroundingRooms =
           [
            EngineRoom.name
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
            case "handcuffs":
                break;

            case "cell key":
                break;

            case "security monitor":
                break;

            case "perioner ledger":
                break;

            case "restraint chair":
                break;


        }

        // locations
        switch (Player.input.ToLower())
        {
            case "engine room":
                if (Map.CanIAccess(EngineRoom.name))
                {
                    Player.location = EngineRoom.name;
                }
                break;

            default:
                break;
        }





    }




}





