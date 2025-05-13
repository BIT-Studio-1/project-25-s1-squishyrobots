using System;
using Globals;



public static class EscapePods
{
    // replaces main
    public static void start()
    {
        Console.WriteLine("You are in the Escape Pod room.");

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

