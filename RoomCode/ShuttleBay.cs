using System;
using Globals;



public static class ShuttleBay
{

    public static string name = "shuttle bay";

    // replaces main
    public static void start()
    {
        Map.enter(name); // possibly use in switch statements for actions.

        Console.WriteLine("\tYou are in the shuttle bay.\n");

        
        // switch on room state? - inspection of items, documentation and main?
        // switch includes rules and inventory methods found in global? possible separation into interaction file?



        string description =
            "The shuttle bay is much like the ones you have seen before, \n" +
            "though this one is noticeably more cluttered than most.\n" +
            "Large steel boxes line the walls, some with the cargo straps still on them.\n" +
            "The ship you arrived on sits idle on one of the many gravity locks.\n" +
            "The lights in the bay seem to be malfunctioning might be something to do with the power, \n" +
            "or lack there of. The walls are white with subtle red accents, \n" +
            "a common paint theme when it comes to {Name of company}\n"
            ;


        string[] observations =
        {
            "You see a *fuel cell* in the corner that may help you restore power.",
            "There is a strange shine on the floor, and on closer inspection you find a *boarding pass* resting atop a puddle of glossy oil.",
            "A *repair kit* rests next to the damaged ship you came in with.",
            "There is a stack of *cargo* that looks abandoned. You see the corner of a floral shirt sticking from a duffel bag."

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
            case "fuel cell":

                break;
            case "boarding pass":
                
                break;
            case "repair kit":

                break;
            case "cargo":

                break;

        }


        switch (Player.input)
        {
            case "escape pods":
                Player.location = "escape pods";
                break;
            case "store room":
                Player.location = "store room";
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
        }


    }



}

