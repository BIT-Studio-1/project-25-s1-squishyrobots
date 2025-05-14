using System;
using Globals;



public static class CaptQuarters
{
    public static string name = "captain quarters";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Captain's Quarters.");

        Player.GetInput();


        switch (Player.input)
        {
            case "personal diaery":
                break;

            case "captain's uniform":
                break;

            case "holographic display":
                break;

            case "safe box":
                break;

            case "decorative sword":
                break;


        }
        Console.WriteLine();









    }




}





