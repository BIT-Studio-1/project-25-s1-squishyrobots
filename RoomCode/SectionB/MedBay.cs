using System;
using Globals;



public static class MedBay
{
    public const string name = "medical bay";


    // replaces main
    public static void start()
    {

        Format.PrintSpecial("You are in the Medical Bay.");

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
            case "first aid kit":
                break;

            case "surgical tools":
                break;

            case "medical scanner":
                break;

            case "medical bottle":
                break;

            case "stretcher":
                break;


        }

        // locations




    }




}





