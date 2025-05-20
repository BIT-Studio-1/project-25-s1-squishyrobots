using System;
using Globals;



public static class Brig
{
    public static string name = "brig";


    // replaces main
    public static void start()
    {


        Console.WriteLine("You are in the Brig.");


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
            case "handcuffs":
                break;

            case "cell key":
                break;

            case "security monitor":
                break;

            case "perioner ledger":
                break;

            case "restraint chair":
                break;


        }
        Console.WriteLine();


        switch (Player.input.ToLower())
        {
            case "engine room":
                Console.WriteLine("You choose the engine room");
                EscapePods.start();
                break;
           

            default:
                Console.WriteLine("Invalid option");
                break;
        }





    }




}





