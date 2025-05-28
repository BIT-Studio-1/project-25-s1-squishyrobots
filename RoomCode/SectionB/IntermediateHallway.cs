using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Globals;

public static class IntermediateHallway
{
    public const string name = "hallway";
    // replaces main
    public static void start()
    {

        Format.PrintSpecial("You are in the *Hallway* .");

        Map.SurroundingRooms =
            [
                Brig.name,
                Lab.name,
                GreenHouse.name,
                ShuttleBay.name
            ];



        string description = "" +
            ""
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
                Map.MoveTo(Lab.name);
                break;

            case "shuttle bay":
                Map.MoveTo(ShuttleBay.name);
                break;

            default:
                break;
        }
    }
}
