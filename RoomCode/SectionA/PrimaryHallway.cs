using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Globals;

public static class PrimaryHallway
{
    public const string name = "hallway";

    public static bool bulkheadUnlocked = false;

    // replaces main
    public static void start()
    {


        Format.PrintSpecial("You are in the *Hallway* .");

        if (bulkheadUnlocked)
        {
            Map.SurroundingRooms =
            [
                Brig.name,
                Lab.name,
                GreenHouse.name,
                ShuttleBay.name,
                IntermediateHallway.name
            ];
        }
        else
        {
            Map.SurroundingRooms =
            [
                Brig.name,
                Lab.name,
                GreenHouse.name,
                ShuttleBay.name,
            ];
        }
        



        string description = "" +
            "Yep this is indeed a hallway nothing really special about it, it gets you from point A " +
            "to point B, That's all it really needs to do."

            ;





        string[] observations =
        {
            "This particular hallway seems to have a " +
            "*bulkhead* segmenting it off from its other hallway brothers and " +
            "it has a @purple@ striped keypad on its left."
        };


        Format.PrintSpecial(description, Format.lineWidthDefault, ConsoleColor.DarkGray);


        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
        }




        Player.GetInput();


        //actions
        switch (Player.input)
        {
            case "bulkhead":
                if (bulkheadUnlocked)
                {
                    Format.PrintSpecial("The bulkhead is already unlocked, you can pass through it.");
                    Format.PrintSpecial("Press %'enter'% to continue.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    Player.GetInput();
                }
                else
                {
                    if (Items.hasPurpleKey)
                    {
                        Format.PrintSpecial("You insert the purple key into the keypad and turn it, the bulkhead " +
                             "opens with a hiss of air. You can now pass through it.");
                        bulkheadUnlocked = true;
                        Format.PrintSpecial("Press %'enter'% to continue.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                        Player.GetInput();
                    }
                    else 
                    { 
                        Format.PrintSpecial("The bulkhead is locked, you need to find a way to unlock it.");
                        Format.PrintSpecial("Press %'enter'% to continue.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                        Player.GetInput();
                    }
                }
                break;
        }



        // locations
        switch (Player.input)
        {
            case "lab":
                Map.MoveTo(Lab.name);
                break;

            case "shuttle bay":
                Map.MoveTo(ShuttleBay.name);
                break;

            case "engine room":
                Map.MoveTo(EngineRoom.name);
                break;

            case "hallway":
                if (bulkheadUnlocked)
                {
                    Map.MoveTo(IntermediateHallway.name);
                }
                break;

            default:
                break;
        }
    }
}
