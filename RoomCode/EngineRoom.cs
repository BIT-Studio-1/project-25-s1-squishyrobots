using System;
using Globals;



public static class EngineRoom
{
    public static string name = "engine room";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Engine Room.");


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





