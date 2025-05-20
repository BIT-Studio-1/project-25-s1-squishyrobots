using System;
using Globals;



public static class CaptQuarters
{
    public static string name = "captains quarters";


    // replaces main
    public static void start()
    {



        Console.WriteLine("You are in the Captain's Quarters.");


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





