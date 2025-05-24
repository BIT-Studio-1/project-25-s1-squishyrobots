using System;
using Globals;



public static class RecRoom
{
    public const string name = "rec. room";


    // replaces main
    public static void start()
    {



        Format.PrintSpecial("You are in the *Rec. Room* .");

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
            case "card deck":
                break;

            case "pool case":
                break;

            case "holographic game":
                break;

            case "exercise equipment":
                break;

            case "music player":
                break;


        }









    }




}





