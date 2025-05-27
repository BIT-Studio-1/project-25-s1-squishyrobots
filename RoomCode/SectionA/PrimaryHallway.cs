using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Globals;

public static class PrimaryHallway
{
    public const string name = "hallway";
    public const bool bulkheadUnlocked = false;
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
            "to point B, That's all it really needs to do, This particular hallway seems to have a " +
            "*bulkhead* segmenting it off from its other hallway brothers. " +
            "It has a ^colour^ striped keypad on its left."
            ;





        string[] observations =
        {

        };


        Format.PrintSpecial(description, Format.lineWidthDefault, ConsoleColor.DarkGray);


        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
        }




        Player.GetInput();


        //actions






        Utility.Check();


        // locations
        switch (Player.input)
        {
            case "lab":
                if (Map.CheckAccess(Lab.name))
                {
                    Player.location = Lab.name;
                }
                break;

            case "shuttle bay":
                if (Map.CheckAccess(ShuttleBay.name))
                {
                    Player.location = ShuttleBay.name;
                }
                break;

            case "engine room":
                if (Map.CheckAccess(EngineRoom.name))
                {
                    Player.location = EngineRoom.name;
                }
                break;

            case "hallway":

                if (Map.CheckAccess(IntermediateHallway.name + "2"))
                {

                    if (Player.hasWon == true)
                    {
                        Format.PrintSpecial("You have already won the game, there is no need to go back to the hallway.");
                        Player.GetInput();
                    }


                    Player.currentHallway = 2;

                    //Player.location = IntermediateHallway.name;

                    Player.hasWon = true;

                }
                break;

            default:
                break;
        }
    }
}
