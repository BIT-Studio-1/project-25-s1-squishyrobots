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
            case "lighting":
                break;

            case "temperature control ":
                break;

            case "humidity control":
                break;

            default:
                break;

        }

        // locations
        switch (Player.input)
        {
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





