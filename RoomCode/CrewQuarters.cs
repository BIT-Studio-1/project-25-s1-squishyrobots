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
        








    }




}





