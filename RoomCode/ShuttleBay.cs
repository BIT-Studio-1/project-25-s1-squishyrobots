using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using Globals;
using static System.Runtime.InteropServices.JavaScript.JSType;



public static class ShuttleBay
{

    public static string name = "shuttle bay";

    // replaces main
    public static void start()
    {

        Console.WriteLine("\tYou are in the shuttle bay.\n");

        
        // switch on room state? - inspection of items, documentation and main?
        // switch includes rules and inventory methods found in global? possible separation into interaction file?



        string description =
            "The shuttle bay is much like the ones you have seen before, though this one is noticeably more cluttered than most" +
            "The ship you arrived on sits idle on one of the many gravity locks this for of landing pad is still pretty new but is still common place among the space stations in the system" +
            "The lights in the bay seem to be flickering, must be something to do with the power, or lack there of" +
            "The walls are white with subtle red accents, a common paint theme when it comes to { Name of company}"
            ;


        string[] observations =
        {
            "In the corner of the room you notice a *steel crate* , it looks like many of the others in the room but this one seems to be the only one lacking a lock on it",
            "A *desk* sits near the door too what you can only assume to be the rest of the ship",
            "On the side of the landing pad sits a large cylindrical structure, made entirely out of steel and painted in a vibrant red. Looks like a *silo* .",
        };




        Format.PrintConformed(description);

        Console.WriteLine();

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
            Console.WriteLine();
        }


        Player.GetInput();



        // Interactions
        switch (Player.input)
        {
            case "steel crate":
                Format.PrintSpecial("It takes some effort but you finally get the steel crate open, Inside sits a *fuel cell*, these are typically used for powering space stations much like this one, this might come in handy");

                Format.PrintSpecial("Use 'back' to exit.");
                Player.GetInput();
                switch (Player.input)
                {
                    case "fuel cell":
                        Format.PrintSpecial("You pick up the ^fuel cell!");
                        Player.hasFuelCell = true;
                        break;
                    case "back":
                        break;
                    default:
                        Format.PrintSpecial("^unknown command^");
                        break;
                }
                break;
            case "desk":
                
                break;
            case "repair kit":

                break;
            case "cargo":

                break;

        }  


        // Locations
        switch (Player.input)
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

