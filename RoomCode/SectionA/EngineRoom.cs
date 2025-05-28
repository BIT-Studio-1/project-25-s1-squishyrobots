using Globals;



public static class EngineRoom
{
    public const string name = "engine room";


    public static bool panelRemoved = false;

    // replaces main
    public static void start()
    {


        Format.PrintSpecial("You are in the Engine Room.");


        Map.SurroundingRooms =
           [
            EscapePods.name,
            ShuttleBay.name,
            Brig.name,
            PrimaryHallway.name
           ];



        string description =
            "As you enter the engine room the rhythmic wurr of the engine can be heard Due to some sort of " +
            "science that you are unable to understand, the noise is isolated to this room. Regardless you " +
            "always found the sound of the engine calming The walls in this room are grey, seems they didnt " +
            "bother painting these ones. Everyone always complains when they are put on engine maintenance " +
            "you never understood why though, yes its cramped but at least its a nice temperature that can't " +
            "be said about every room."
            ;


        string[] observations =
        {
            "On the ground next to the door you notice a *wrench*",
            "The screen on the side of the *engine* shows text reading simply ^'LOW POWER MODE ENABLED'^",
            "Sitting on a small shelf in the corner of the room you notice a *tool box* , its cold metal being calling out too you"
        };


        Format.PrintSpecial(description, Format.lineWidthDefault, ConsoleColor.DarkGray, ConsoleColor.DarkBlue, ConsoleColor.DarkRed, ConsoleColor.DarkGreen);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
        }






        Player.GetInput();


        //actions
        switch (Player.input)
        {
            case "wrench":
                Format.PrintSpecial("You pick up the wrench. Its large, and heavy the end of it dented slightly and covered in some " +
                    "sort of black sludge that you cant immediately identify. While these sorts of tools are " +
                    "typically used on bolts that refuse to move they have been known to make effective weapons " +
                    "against pirates and other smaller galactic horrors that may board a ship or station. " +
                    "This may prove useful.");
                Items.hasWrench = true;
                Format.PrintSpecial("Press %'enter'% to exit.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                Player.GetInput();
                break;

            case "engine":
                if (!Map.powerOn)
                {
                    if (!panelRemoved)
                    {
                        if (Items.hasWrench || Items.hasCrowbar)
                        {
                            while (Player.input != "back")
                            {
                                if (!panelRemoved)
                                {
                                    Format.PrintSpecial("The engine is a large cylinder that takes up most of the room, it is currently in low power mode, " +
                                    "you can see the coolant pipes running along the side of it. You can also see a small panel on the side of it, " +
                                    "it seems to be tightly secured with four massive rusted bolts.");
                                    Format.PrintSpecial("You have an item in your inventory can be used.");
                                    Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                    Player.GetInput();
                                    switch (Player.input)
                                    {
                                        case "wrench":
                                            Format.PrintSpecial("You consider the methods in which a panel could be removed. You decide to take it slow and " +
                                                "twist the bolts off with the wrench you just acquired. As you're turning the bolts, however, they snap and " +
                                                "fall off easily. Good job, the panel is now removed.");
                                            panelRemoved = true;
                                            Format.PrintSpecial("Press %'enter'% to return or type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                            Player.GetInput();
                                            break;

                                        case "crowbar":
                                            Format.PrintSpecial("^You don't enjoy panels. They've always given you the side-eye as they know you can't access " +
                                                "the delicious interior of objects while they're blocking you. Due to this long-standing grudge against the " +
                                                "flat pieces of metal, you take your time prying and bending it away from the rusted bolts. As you hear the " +
                                                "metal tearing and pulling from the engine, a huge weight lifts from your shoulders. No more shall you be " +
                                                "scorned by these despicible, glorified plates. You are liberated.^ \n Oh, by the way, you are also free to access the engine now.");
                                            panelRemoved = true;
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
                                    if (Items.hasFuelCell)
                                    {
                                        Format.PrintSpecial("The inside of the engine is a mess of wires and fluid tubes. One item in here literally shines above " +
                                            "the rest as it pulses blue. It resembles the *fuel cell* you acquired in the shuttle bay.");
                                        Format.PrintSpecial("You have an item in your inventory can be used.");
                                        Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                        Player.GetInput();
                                        switch (Player.input)
                                        {
                                            case "fuel cell":
                                                Format.PrintSpecial("You take out the old power cell it pulses dimly which makes sense, its almost out of power after all, " +
                                                    "you put it down to the side finally giving it some much deserved rest and replace it with the power cell you obtained " +
                                                    "from the crate in the shuttle bay, it makes a loud Kurthunk as it slots into place and the lights in the room get noticeably " +
                                                    "brighter. And that rhythmic hum that you oh so adore get louder");
                                                Map.powerOn = true;
                                                Items.hasFuelCell = false; // Remove the fuel cell from inventory after use
                                                Items.hasFuelCanister = true; // Add the fuel canister to inventory after extraction
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
                                        Format.PrintSpecial("The inside of the engine is a mess of wires and fluid tubes. One item in here literally shines above " +
                                            "the rest as it pulses blue. It seems to be a small metal cylinder with dim light emitting from the windows along it's length.");
                                        Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                        Player.GetInput();
                                    }
                                }

                            }

                        }
                        else
                        {
                            Format.PrintSpecial("The engine is a large cylinder that takes up most of the room, it is currently in low power mode, " +
                                 "you can see the coolant pipes running along the side of it. You can also see a small panel on the side of it, " +
                                 "it seems to be tightly secured with four massive rusted bolts.");
                            Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                        }
                    }
                    else
                    {
                        if (Items.hasFuelCell)
                        {
                            while (Player.input != "back")
                            {
                                Format.PrintSpecial("The inside of the engine is a mess of wires and fluid tubes. One item in here literally shines above " +
                                "the rest as it pulses blue. It resembles the *fuel cell* you acquired in the shuttle bay.");
                                Format.PrintSpecial("You have an item in your inventory can be used.");
                                Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                                Player.GetInput();
                                switch (Player.input)
                                {
                                    case "fuel cell":
                                        Format.PrintSpecial("You take out the old power cell it pulses dimly which makes sense, its almost out of power after all, " +
                                            "you put it down to the side finally giving it some much deserved rest and replace it with the power cell you obtained " +
                                            "from the crate in the shuttle bay, it makes a loud Kurthunk as it slots into place and the lights in the room get noticeably " +
                                            "brighter. And that rhythmic hum that you oh so adore get louder");
                                        Map.powerOn = true;
                                        Items.hasFuelCell = false; // Remove the fuel cell from inventory after use
                                        Items.hasFuelCanister = true; // Add the fuel canister to inventory after extraction
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
                            Format.PrintSpecial("The inside of the engine is a mess of wires and fluid tubes. One item in here literally shines above " +
                                "the rest as it pulses blue. It seems to be a small metal cylinder with dim light emitting from the windows along it's length.");
                            Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                        }
                    }
                }
                else
                {
                    Format.PrintSpecial("The engine thrums with power and a fierce glow can be seen within.");
                    Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    Player.GetInput();
                }

                break;
            case "tool box":
                if (!Items.hasMaintenanceKit)
                {
                    while (Player.input != "back")
                    {
                        if (!Items.hasMaintenanceKit)
                        {
                            Format.PrintSpecial("Taking a look inside you find small circuit boards and a few small tools, common place for crew that " +
                                "work on the electrical systems on the station. At the very bottom of the tool box you find a $'Station Engines and How " +
                                "to fix them'$ . This *kit* may come in handy.");
                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                            switch (Player.input)
                            {
                                case "kit":
                                    Format.PrintSpecial("You pick up the the box. Seems the engineer needed it a lot; it has clearly seen many years of use.");
                                    Items.hasMaintenanceKit = true;
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
                            Format.PrintSpecial("Taking a look inside you find small circuit boards and a few small tools, common place for crew that " +
                                "work on the electrical systems on the station. Nothing else sticks out at you.");
                            Format.PrintSpecial("Type %'back'% to leave.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                            Player.GetInput();
                        }
                    }
                }
                else
                {
                    Format.PrintSpecial("Taking a look inside you find small circuit boards and a few small tools, common place for crew that " +
                        "work on the electrical systems on the station. Nothing else sticks out at you.");
                    Format.PrintSpecial("Press %'enter'% to return.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    Player.GetInput();
                }

                break;
            default:
                break;
        }



        // locations
        switch (Player.input)
        {
            case "escape pods":
                Map.MoveTo(EscapePods.name);
                break;
            case "shuttle bay":
                Map.MoveTo(ShuttleBay.name);
                break;

            default:
                break;
        }
    }




}





