using System;
using Globals;



public static class EngineRoom
{
    // replaces main
    public static void start()
    {
        Console.WriteLine("You are in the Engine Room.");

        Player.GetInput();
        switch (Player.input.ToLower())
        {
            case "escape pods":
                Console.WriteLine("You choose the escape pods");
                EscapePods.start();
                break;
            case "shuttle bay":
                Console.WriteLine("You choose the shuttle bay");
                ShuttleBay.start();
                break;

            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }




}





