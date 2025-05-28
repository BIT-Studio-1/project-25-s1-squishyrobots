using System;
using Globals;



public static class Brig
{
    public const string name = "brig";


    // replaces main
    public static void start()
    {


        Format.PrintSpecial("You are in the Brig.");


        Map.SurroundingRooms =
           [
            EngineRoom.name
           ];


        string description =
            "The brig, every station has one, its just a matter of where they put it, " +
            "seems like this particular designer decided right next to the most important " +
            "part of the ship was a good idea. The laser grid that would normally make up " +
            "the containment area seems to be absent at this given moment, but maybe it's " +
            "just invisible."
            ;


        string[] observations =
        {
            "In the back corner of the room sits a desk with a *terminal* . Typically a guard " +
            "would be sitting there but given the current situation I'm not surprised to find " +
            "the guard missing.",
            "Hanging on the wall you can see a pair of *handcuffs* , the key still in them.",
            "There is a small room sectioned off from the rest of the room, separated by a simple " +
            "*door* .",
            "A small *window* looks out into the engine room.",
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
            case "handcuffs":
                if (!Items.hasHandcuffs)
                {
                    while (Player.input != "back")
                    {
                        if (!Items.hasHandcuffs)
                        {
                            Format.PrintSpecial("Taking a closer look at the *handcuffs* they seem beat up but still in working condition, they may prove useful if you need to put on your detective hat and solve a murder.\r\n");
                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                            switch (Player.input)
                            {
                                case "handcuffs":
                                    Format.PrintSpecial("Several strands of pink fluff fall from the handcuffs as you pick them up. You aquired work-related handcuffs (SFW)!", 13);
                                    Items.hasHandcuffs = true;
                                    Format.PrintSpecial("Press %'enter'% to return or type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                    Player.GetInput();
                                    break;

                                case "back":
                                    break;
                                default:
                                    Format.PrintSpecial("^unknown command^");
                                    Format.PrintSpecial("Press %'enter'% to return or type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                    Player.GetInput();
                                    break;
                            }
                        }
                        else
                        {
                            Format.PrintSpecial("An empty hook where the word-related handcuffs (SFW) used to be.");
                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                        }
                    }
                }
                else
                {
                    Format.PrintSpecial("An empty hook where the word-related handcuffs (SFW) used to be.");
                    Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    Player.GetInput();
                }
                break;

            case "terminal":
                Format.PrintSpecial("The screen of the terminal has a few applications open, the one immediately shown " +
                    "to you is the prisoner management system, a simple database showing the list of inmates, what they " +
                    "did and how long they need to be held before being transported to the systems judicial holding site. " +
                    "You scan the names to see if you recognize any of them. None immediately jump out at you however. " +
                    "The second application is the security monitoring system, it shows the feeds of a variety of cameras " +
                    "around the station. Nothing out of the ordinary that you can see, well apart from the absence of the " +
                    "crew but we knew this already.");
                Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                Player.GetInput();
                break;

            case "door":
                Format.PrintSpecial("Trying the door you find it unlocked and inside is a restraint chair, its bulky and on " +
                    "the arm rest are leather straps, this relic is a remanent of Terra Sol 3, we have more effective ways of " +
                    "getting information now but sometimes these are still used.");
                Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                Player.GetInput();
                break;

            case "window":
                if (!Items.hasCrowbar)
                {
                    while (Player.input != "back")
                    {
                        if (!Items.hasCrowbar)
                        {
                            Format.PrintSpecial("You approach the window and spot a *crowbar* leaning against the wall underneath it. ");
                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                            switch (Player.input)
                            {
                                case "crowbar":
                                    Format.PrintSpecial("You pick up the crowbar, it feels heavy in your hands and you feel like you could do some damage to anything refusing to open.");
                                    Items.hasCrowbar = true;
                                    Format.PrintSpecial("Press %'enter'% to return or type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                    Player.GetInput();
                                    break;

                                case "back":
                                    break;
                                default:
                                    Format.PrintSpecial("^unknown command^");
                                    Format.PrintSpecial("Press %'enter'% to return or type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                    Player.GetInput();
                                    break;
                            }
                        } 
                        else
                        {
                            Format.PrintSpecial("The window looks dusty and you can hardly make out the engine room through the crimson glass.");
                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                        }
                    }
                }
                else
                {
                    Format.PrintSpecial("The window looks dusty and you can hardly make out the engine room through the crimson glass.");
                    Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    Player.GetInput();  
                }
                break;

        }



        // locations
        switch (Player.input.ToLower())
        {
            case "engine room":
                Map.MoveTo(EngineRoom.name);
                break;

            default:
                break;
        }





    }




}





