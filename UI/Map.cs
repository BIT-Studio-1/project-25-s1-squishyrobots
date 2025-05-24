using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Globals;



    // Map class to handle the map display and surrounding rooms
    // This class is used to show the map and the rooms around the player
    // It also contains the map data and the width of the map
    // The map is a string that represents the layout of the space station
    // The surrounding rooms are stored in a string array

public static class Map
{



    public static void ShowMap()
    {
        // print map
        Format.PrintCharacters(mapBase, mapWidth, ConsoleColor.Cyan);



        // use surrounding rooms to print out the rooms that are around the player
        Format.PrintSpecial($"You are in the {Player.location}.", Format.lineWidthDefault, ConsoleColor.DarkGray);
        Format.PrintSpecial("Surrounding rooms:");
        string temp = "";
        for (int i = 0; i < SurroundingRooms.Length; i++)
        {
            temp = temp + "\t" + SurroundingRooms[i] + "\n";
        }
        Format.PrintSpecial(temp, Format.lineWidthDefault, ConsoleColor.Blue);

        Player.GetInput();

        //// temp solution to move between rooms
        //for (int i = 0; i < SurroundingRooms.Length; i++)
        //{
        //    if (Player.input == SurroundingRooms[i])
        //    {
        //        Player.location = SurroundingRooms[i]; // can be used for getting into rooms that are locked ** FIX
        //    }
        //}
    }



    public static string[] SurroundingRooms = new string[0];

    private static int mapWidth = 100;



    // # = door
    // :. = wall - maybe change . to be floor and colour background of space station
    // / = window
    // o/0/& = seat
    // v = pool
    // | = wood/panel
    private static string mapBase = "" +
        "                                                                                                    " +
        "                                                                                                    " +
        "                                                                                                    " +
        "                                                                                                    " +
        "                                                          :::::-/////-:::::                         " +
        "                         :::-//////-:::                   ::==   ___o  ==::                         " +
        "                         / --x-  -xx- /                   ::==   o o   ==::                         " +
        "                         / -x-    -x- /                   ::==      .....::::::::::                 " +
        "                         ::x       xx::          :::-///-:::.....##.:]    # #    [:::-/////////     " +
        "            :::::::::::::::...###....::          ::  ooo ooo   :    :(-__): :(__-):   [=====]  /    " +
        "            ::[[] [][]]  #         [=/            /  [ ] [ ]   :    :.....: :.....:]   o o o   /    " +
        "      ::::::::...###.....:=]  [ ]  [=/            /  ooo ooo   #    :]    # #    [:]           /    " +
        "        |                :==]     [==::          ::         c==:    :(-__): :(__-):]  o|  o|   /    " +
        "        |                :....###...::::::-//-:::::.....##.....:    :.....:-:.....:       o|   /    " +
        "        |                #                                                       #    IO       /    " +
        "        |   ___          #                                                       #    |o       /    " +
        "        |   (})          :....###.....::::-//-:::::.....##....:      :....##......:       o|   /    " +
        "        |   (})          :[  ]        /          :: &     [==]:      :===]   -+++-:]  o|  o|   /    " +
        "      :::::::::          #       (]Z[)::         /   & []     #      :=]          :]           /    " +
        "             / (||)      :....###.....::         / &   []   / :      :[|     (__-):]   o o o   /    " +
        "             /       (||):|||         /          ::  o o   / X:      :]|     _____:   [=====]  /    " +
        "             / (||)      :|||       ||::         ::-///-::::..:..##..:..:::::-///-:::-/////////     " +
        "             ::::-///-::::::::-///-:::::                  :: [|       |[::                          " +
        "                                                          :: ]| vvvvv |]::                          " +
        "                                                           /    vvvvv |[::                          " +
        "                                                           /          |]::                          " +
        "                                                          ::[    |[|]|[|::                          " +
        "                                                          ::|]|  |]|[|]|::                          " +
        "                                                          :::-////////-:::                          " +
        "                                                                                                    " +
        "                                                                                                    " +
        "                                                                                                    ";









    /// <summary>
    /// Checks if the player can access a room based on their current location and the level of access they hold.
    /// </summary>
    /// <param name="roomName"></param>
    /// <returns></returns>
    public static bool CanIAccess(string roomName)
    {

        string purpleKeyDenied = $"^Denied Access^ ! You need the purple key to access the ^{roomName}^ !";
        string blueKeyDenied = $"^Denied Access^ ! You need the *blue* key to access the ^{roomName}^ !";
        string redKeyDenied = $"^Denied Access^ ! You need the ^red^ key to access the ^{roomName}^ !";

        // switch statement based on Player.location and room input.

        // has purple key & in lab 

        switch (Player.location)
        {
            case "store room":
                switch (roomName)
                {
                    case "shuttle bay":
                        return true;

                    case "lab":
                        if (Player.hasPurpleKey)
                        {
                            return true;
                        }
                        else
                        {
                            RefuseAccess(purpleKeyDenied);
                            return false;
                        }

                    default:
                        return false;
                }

            case "lab":
                switch (roomName)
                {
                    case "store room":
                        if (Player.hasPurpleKey)
                        {
                            return true;
                        }
                        else
                        {
                            RefuseAccess(purpleKeyDenied);
                            return false;
                        }

                    case "greenhouse":
                        if (Player.hasPurpleKey)
                        {
                            return true;
                        }
                        else
                        {
                            RefuseAccess(purpleKeyDenied);
                            return false;
                        }
                    default:
                        return false;
                }

            case "shuttle bay":
                switch (roomName)
                {
                    case "store room":
                        return true;

                    case "escape pods":
                        return true;

                    case "Engine Room":
                        if (Player.hasBlueKey)
                        {
                            return true;
                        }
                        else
                        {
                            RefuseAccess(blueKeyDenied);
                            return false;
                        }

                    default:
                        return false;
                }

            case "engine room":
                switch (roomName)
                {
                    case "shuttle bay":
                        return true;

                    case "escape pods":
                        return true;

                    case "brig":
                        if (Player.hasRedKey)
                        {
                            return true;
                        }
                        else
                        {
                            RefuseAccess(redKeyDenied);
                            return false;
                        }

                    default:
                        return false;
                }

            case "brig":
                switch (roomName)
                {
                    case "engine room":
                        return true;
                    default:
                        return false;
                }

        }




        return false;
    }


    public static void RefuseAccess(string message)
    {
        Format.PrintSpecial(message);
        Format.PrintSpecial("Press %'enter'% to continue.", Format.lineWidthDefault, ConsoleColor.DarkGray);
        Player.GetInput();
    }








}



