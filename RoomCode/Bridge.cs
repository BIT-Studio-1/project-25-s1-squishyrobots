using System;
using Globals;



public static class Bridge
{
    public static string name = "bridge";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Bridge.");


        string description =
            "blank"

            ;


        string[] observations =
        {

        };



        Format.PrintConformed(description);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
            Console.WriteLine();
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
        Console.WriteLine();





    }

    


    
        
}

      











