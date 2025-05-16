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


        Console.WriteLine(
            "The shuttle bay is much like the ones you have seen before, \n" +
            "though this one is noticeably more cluttered than most.\n" +
            "Large steel boxes line the walls, some with the cargo straps still on them.\n" +
            "The ship you arrived on sits idle on one of the many gravity locks.\n" +
            "The lights in the bay seem to be malfunctioning might be something to do with the power, \n" +
            "or lack there of. The walls are white with subtle red accents, \n" +
            "a common paint theme when it comes to {Name of company}"
            );
        Console.WriteLine();



        int lineWordLimit = 5;


        string[] observations =
        {
            "You see a *fuel cell* in the corner that may help you restore power.",
            "There is a strange shine on the floor, and on closer inspection you find a *boarding pass* resting atop a puddle of glossy oil.",
            "A *repair kit* rests next to the damaged ship you came in with.",
            "There is a stack of *cargo* that looks abandoned. You see the corner of a floral shirt sticking from a duffle bag."
        };


        for (int i = 0; i < observations.Length; i++)
        {
            string[] chunks = observations[i].Split('*');
            for (int j = 0; j < chunks.Length; j++)
            {
                if (j % 2 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if (j % lineWordLimit == 0)
                {
                    Console.WriteLine();
                }


                if (j != chunks[j].Length - 1)
                {
                    Console.Write(chunks[j] + " ");
                }
                else
                {
                    Console.Write(chunks[j]);
                }


            }
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




        

        Console.WriteLine();


      




















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

