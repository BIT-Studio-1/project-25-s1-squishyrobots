using System;
using Globals;



public static class CrewQuarters
{
    public static string name = "crew quarters";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Crew Quarters.");

        Player.GetInput();

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
        Console.WriteLine();








    }




}





