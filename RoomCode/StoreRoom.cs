using System;
using Globals;



public static class StoreRoom
{
    public static string name = "store room";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Store Room.");

        Player.GetInput();
        








    }




}





