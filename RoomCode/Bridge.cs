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

        Player.GetInput();
        








    }




}





