using System;
using Globals;



public static class EscapePods
{
    public static string name = "escape pods";

    // replaces main
    public static void start()
    {
        Map.enter(name);

        Console.WriteLine("You are in the Escape Pod room.");


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




        switch (Player.input.ToLower())
        {

            case "shuttle bay":
                Console.WriteLine("You choose the shuttle bay");
                ShuttleBay.start();
                break;
            case "engine room":
                Console.WriteLine("You choose the engine room");
                EngineRoom.start();
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }

    }







}

