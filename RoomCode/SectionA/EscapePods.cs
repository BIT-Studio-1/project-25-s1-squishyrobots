using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using Globals;



public static class EscapePods
{
    public static string name = "escape pods";

    // replaces main
    public static void start()
    {


        Format.PrintSpecial("You are in the *Escape Pod room* .");


        Map.SurroundingRooms =
           [
            ShuttleBay.name,
            EngineRoom.name
           ];


        string description =
            "Escape pods line the walls on either side of you. " +
            "Some are bigger than the others, those are typically saved for the important personnel. " +
            "At the end of the room there is a lever that reads ^'Release all escape pods'^ with a " +
            "large red light above it, the lever is currently behind a glass shield that is locked " +
            "and requires two keys too open. The hallway that goes between the rows of escape pods " +
            "is tight. "
            ;


        string[] observations =
        {
                "Below the 'Release all escape pods' lever there is a *book* , the page count you estimate in the hundreds.",
                "A door to a $luxury$ *escape pod* is slightly ajar. You've always wondered what they looked like inside, now might be your chance to have a peek.",
                "Along the back wall sits a rack of what seem to be *parachutes* .",
                "A *key* hangs from a hook on the back wall"
        };




        Format.PrintSpecial(description, Format.lineWidthDefault, ConsoleColor.DarkGray, ConsoleColor.DarkBlue, ConsoleColor.DarkRed, ConsoleColor.DarkGreen);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
        }


        Player.GetInput();


        // actions
        switch (Player.input)
        {
            case "escape pod":
                Format.PrintSpecial("" +
                    "Its surprisingly spacious, the chairs that line the walls are covered in a " +
                    "nice soft fabric, but you doubt that would make a difference when you are " +
                    "being flung through space at 1389km/h with no internal gravity lock, there " +
                    "is also a large table in the center on the pod, again you are not quite sure " +
                    "how useful that would be but your guess is that the 'Investors' thought it " +
                    "would provide insensitive for those climbing the corporate ladder. Other than " +
                    "that there is the standard oxygen tanks and food rations although there is " +
                    "more of those than in the standard pods.");
                Format.PrintSpecial("Press %'enter'% to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                Player.GetInput();
                break;
            case "book":
                Format.PrintSpecial("" +
                    "Upon closer inspection you find its the user manual for the escape pods, " +
                    "its rather odd that its located out here and not in the escape pod itself " +
                    "but it may just be a maintenance manual.");
                Format.PrintSpecial("Press %'enter'% to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                Player.GetInput();
                break;
            case "parachute":
                Format.PrintSpecial("" +
                    "You may think that parachutes in space are useless and that they have no " +
                    "place being on a space station, and normally you would be right but, due " +
                    "to an accident in Sol 648/2487397.5 (2098/28/2) where a space station fell " +
                    "from orbit and crash landed on Promerculus, All space stations are now required " +
                    "to provide personnel with a parachute in case of total catastrophic failure of " +
                    "the orbit thrusters.");
                Format.PrintSpecial("Press %'enter'% to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                Player.GetInput();
                break;
            case "key":
                Format.PrintSpecial("This must be one of the keys to launch the escape pod, you " +
                    "know its rather interesting that even now we still use simple metal keys to " +
                    "lock important things away, This is due to the simplicity of clone-a-keycard.");
                Format.PrintSpecial("Press %'enter'% to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                Player.GetInput();
                break;
            default:
                break;
        }





        // locations
        switch (Player.input)
        {
            case "shuttle bay":
                Map.MoveTo(ShuttleBay.name);
                break;
            case "engine room":
                Map.MoveTo(EngineRoom.name);
                break;
            default:
                break;
        }


        

    }







}

