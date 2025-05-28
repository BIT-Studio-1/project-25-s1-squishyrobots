using Globals;



public static class Lab
{
    public const string name = "lab";

    public static bool lockerLocked = true; // locker is locked by default, crowbar can unlock it

    // replaces main
    public static void start()
    {

        Format.PrintSpecial("You are in the Lab.");


        Map.SurroundingRooms =
           [
            PrimaryHallway.name,
            StoreRoom.name,
            GreenHouse.name
           ];


        string description =
            "The lab is pristine but that is too be expected, even one thing out of place could put an entire experiment off." +
            "The counter tops are a surprisingly polished white marble, something you would not expect to see in a lab." +
            "The room as a whole gives off almost a cold feeling, not physically, you can't quite figure out what it is." +
            "In the center of the room on the floor there is what seems to be the remnants of a beaker the glass shards scattered on the floor."
            ;

        string[] observations = new string[0];

        if (Map.powerOn)
        {
            observations = new string[]
            {
                "A *terminal* sits on the counter, its green screen sitting idly waiting for an input, fans roaring behind its stoic monitor.",
                "A few test tube racks are placed around the room, some on the shelves are empty but " +
                "you see one that has some sort of liquid in it.",
                "The locker that sits above the counter looks like it could house a variety of items, but it " +
                "unfortunately seems to be locked. Maybe you could attempt a more unorthadox approach this time."
            };
        }
        else
        {
            observations = new string[]
            {
                "A ^terminal^ sits on the counter, it remains off due to lack of power.",
                "A few *test tube* racks are placed around the room, some on the shelves are empty but " +
                "you see one that has some sort of liquid in it.",
                "The *locker* that sits above the counter looks like it could house a variety of items, but it " +
                "unfortunately seems to be locked. Maybe you could attempt a more unorthadox approach this time."
            };
        }



        Format.PrintSpecial(description, Format.lineWidthDefault, ConsoleColor.DarkGray, ConsoleColor.DarkBlue, ConsoleColor.DarkRed, ConsoleColor.DarkGreen);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
        }






        Player.GetInput();


        // actions
        switch (Player.input)
        {
            case "test tube":
                Format.PrintSpecial("Approaching the test tube to get a better look at its contents, you notice it has a noticable glow coming from it." +
                    "The liquid is coloured a vibrant blue, similar to the colour used to represent lightning in comic books back on Terra Sol III." +
                    "Honestly it looks rather tasty. Just a taste couldn't hurt. Could it?");
                Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                Player.GetInput();
                break;

            case "terminal":
                if (Map.powerOn)
                {
                    while (Player.input != "back")
                    {
                        Format.PrintSpecial("Luckily for you the whoever was using this terminal last is not very security conscious " +
                        "they seemed to have left themselves logged in.Most of the files are logs from the various " +
                        "experiments that were performed in the lab, all dated and nicely sorted into folders.You lightly skim " +
                        "through the various documents some much longer than other until you get to the final report.This one seems different however. *Read* ?");
                        Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                        Player.GetInput();
                        switch (Player.input)
                        {
                            case "read":
                                Format.PrintSpecial("Sol 141/2549392.5 (2267/25/11)\n" +
                                    "The test was an astounding success, we were able to create artificial life. Everything was going according to plan until " +
                                    "Francis dropped the beaker containing the specimen, then we lost sight of it. It seemed to shy away from the light however, " +
                                    "maybe its got some high levels of photosensitivity and can't stay in the light too long, Lets just hope it dose'nt take " +
                                    "us too long to find it. Unfortunately until we can find and contain the specimen we are unable to continue testing " +
                                    "so begrudgingly I must end this report here.\n" +
                                    "Dr,Ableton");
                                Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
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
                }
                else
                {
                    Format.PrintSpecial("The terminal is off, it seems to be powered down due to the lack of " +
                        "power in the station. You should try to find a way to turn the power back on.");
                    Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    Player.GetInput();
                }
                break;

            case "locker":
                if (lockerLocked)
                {
                    if (Items.hasCrowbar)
                    {

                        while (Player.input != "back")
                        {
                            if (lockerLocked)
                            {
                                Format.PrintSpecial("You approach the locker, it seems to be locked.");
                                Format.PrintSpecial("You have an item in your inventory that can be used.");
                                Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                Player.GetInput();
                                switch (Player.input)
                                {
                                    case "crowbar":
                                        Format.PrintSpecial("You pry the locker open with the crowbar. Good thing you picked it up. Literally nothing else could be " +
                                            "used to open this flimsy locker door.");
                                        lockerLocked = false;
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
                                if (!Items.hasPurpleKey)
                                {
                                    while (Player.input != "back")
                                    {
                                        if (!Items.hasPurpleKey)
                                        {
                                            Format.PrintSpecial("Inside the locker you find mostly paper, loose unused paper, along with empty flasks and beakers and a purple *keycard* .");
                                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                            Player.GetInput();
                                            switch (Player.input)
                                            {
                                                case "keycard":
                                                    Format.PrintSpecial("You pick up the @purple keycard@ from the locker.");
                                                    Items.hasPurpleKey = true;
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
                                            Format.PrintSpecial("Inside the locker you find mostly paper, loose unused paper, along with empty flasks and beakers");
                                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                            Player.GetInput();
                                        }



                                    }
                                }
                                else
                                {
                                    Format.PrintSpecial("Inside the locker you find mostly paper, loose unused paper, along with empty flasks and beakers");
                                    Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                    Player.GetInput();
                                }
                            }
                        }
                    }
                    else
                    {
                        Format.PrintSpecial("You approach the locker. Might need a bit of grunt work to get this one open.");
                        Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                        Player.GetInput();
                    }
                }
                else
                {
                    if (!Items.hasPurpleKey)
                    {
                        while (Player.input != "back")
                        {
                            Format.PrintSpecial("Inside the locker you find mostly paper, loose unused paper, along with empty flasks and beakers and a purple *keycard* .");
                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                            switch (Player.input)
                            {
                                case "keycard":
                                    Format.PrintSpecial("You pick up the @purple keycard@ from the locker.");
                                    Items.hasPurpleKey = true;
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
                    }
                    else
                    {
                        Format.PrintSpecial("Inside the locker you find mostly paper, loose unused paper, along with empty flasks and beakers");
                        Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                        Player.GetInput();
                    }
                }

                break;

        }



        // locations
        switch (Player.input)
        {
            case "store room":
                Map.MoveTo(StoreRoom.name);
                break;
            case "greenhouse":
                Map.MoveTo(GreenHouse.name);
                break;
            case "hallway":
                Map.MoveTo(PrimaryHallway.name);
                break;

            default:
                break;
        }






    }




}





