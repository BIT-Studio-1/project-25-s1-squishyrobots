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


        string description =
            "blank"

            ;


        string[] observations =
        {

        };



        Format.printConformed(description);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.printSpecial(observations[i]);
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





