using System;
using Globals;



public static class RecRoom
{
    public static string name = "rec. room";


    // replaces main
    public static void start()
    {



        Console.WriteLine("You are in the Rec. Room.");



        string description =
            "blank"

            ;


        string[] observations =
        {

        };


        Format.PrintConformed(description);

        Console.WriteLine();

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
            Console.WriteLine();
        }




        Player.GetInput();


        switch (Player.input)
        {
            case "card deck":
                break;

            case "pool case":
                break;

            case "holographic game":
                break;

            case "exercise equipment":
                break;

            case "music player":
                break;


        }
        Console.WriteLine();









    }




}





