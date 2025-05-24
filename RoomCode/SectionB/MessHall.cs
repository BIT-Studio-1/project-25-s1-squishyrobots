using System;
using Globals;



public static class MessHall
{
    public const string name = "mess hall";


    // replaces main
    public static void start()
    {


        Format.PrintSpecial("You are in the Mess Hall.");


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


        switch (Player.input)
        {
            case "food tray":
                break;

            case "cooking pot":
                break;

            case "tableware":
                break;

            case "vednding machine":
                break;

            case "meal":
                break;


        }


        





    }




}





