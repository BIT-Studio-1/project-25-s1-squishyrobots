using System;
using Globals;



public static class CaptQuarters
{
    public const string name = "captains quarters";


    // replaces main
    public static void start()
    {



        Format.PrintSpecial("You are in the Captain's Quarters.");


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
            case "personal diaery":
                break;

            case "captain's uniform":
                break;

            case "holographic display":
                break;

            case "safe box":
                break;

            case "decorative sword":
                break;


        }


        // locations







    }




}





