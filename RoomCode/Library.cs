using System;
using Globals;



public static class Library
{
    public static string name = "library";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Library.");

        Player.GetInput();
        








    }




}





