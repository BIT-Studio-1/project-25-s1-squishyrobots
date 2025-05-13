using System;
using Globals;



public static class ShuttleBay
{
    // replaces main
    public static void start()
    {
        Console.WriteLine("You are in the Shuttle Bay.");

        Player.GetInput();


        switch (Player.input)
        {
            case "shuttle fuel":

                break;
            case "boarding pass":

                break;


        }























        switch (Player.input.ToLower())
        {
            case "escape pods":
                Console.WriteLine("You choose the escape pods");
                EscapePods.start();
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

