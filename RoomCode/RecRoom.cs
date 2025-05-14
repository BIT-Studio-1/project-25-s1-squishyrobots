using System;
using Globals;



public static class RecRoom
{
    public static string name = "rec. room";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Rec. Room.");

        Player.GetInput();
        








    }




}





