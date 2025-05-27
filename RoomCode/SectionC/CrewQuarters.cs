using System;
using Globals;



public static class CrewQuarters
{
    public const string name = "crew quarters";


    // replaces main
    public static void start()
    {



        Format.PrintSpecial("You are in the Crew Quarters.");


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
            case "bunk bed":
                break;

            case "personal locker":
                break;

            case "crew uniform":
                break;

            case "alarm clock":
                break;

            case "other things like photo frame":
                break;


        }

        // locations






    }




}





