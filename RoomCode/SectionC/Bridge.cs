using System;
using Globals;



public static class Bridge
{
    public const string name = "bridge";


    // replaces main
    public static void start()
    {



        Format.PrintSpecial("You are in the Bridge.");


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
            case " captain's log":
                break;

            case "navigation console":
                break;

            case "communication device - phone":
                break;

            case "star chart":
                break;

            case " helm control":
                break;

             
        }

       


       





    }

    


    
        
}

      











