using System;
using Globals;



public static class MedBay
{
    public static string name = "medical bay";


    // replaces main
    public static void start()
    {
        Map.enter(name);

        Console.WriteLine("You are in the Medical Bay.");

        Player.GetInput();
        








    }




}





