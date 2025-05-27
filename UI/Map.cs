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

    public static string[] SurroundingRooms = new string[0];
    private static int mapWidth = 100;



    public static void ShowMap()
    {
        // print map


        string tempMap  = "mapBase";

        switch (Player.location)
        {
            // Section A

            case "brig":
                tempMap = mapBrig; // use the brig map
                break;

            case "engine room":
                tempMap = mapEngineRoom; // use the engine room map
                break;

            case "escape pods":
                tempMap = mapEscapePods; // use the escape pods map
                break;

            case "greenhouse":
                tempMap = mapGreenhouse; // use the greenhouse map
                break;

            case "lab":
                tempMap = mapLab; // use the lab map
                break;

            case "shuttle bay":
                tempMap = mapShuttleBay; // use the shuttle bay map
                break;

            case "store room":
                tempMap = mapStoreRoom; // use the store room map
                break;


            // Section B
            case "library":

                break;

            case "med bay":

                break;

            case "mess hall":

                break;

            case "rec room":

                break;


            // Section C
            case "bridge":

                break;

            case "captains quarters":

                break;

            case "crew quarters":

                break;


            // switch on hallway selection due to ease of player input & consistency
            case "hallway":
                switch (Player.currentHallway)
                {
                    case 1:
                        tempMap = mapPrimaryHallway; // Section A
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    default:
                        break;
                }
                break;

            default:
                tempMap = mapBase; // default map if no room is found
                break;
        }

        Format.PrintCharacters(tempMap, mapWidth, ConsoleColor.Cyan);



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





    /// <summary>
    /// Checks if the player can access a room based on their current location and the level of access they hold.
    /// </summary>
    /// <param name="roomName"></param>
    /// <returns></returns>
    public static bool CheckAccess(string roomName)
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
                        if (Items.hasPurpleKey)
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
                        if (Items.hasPurpleKey)
                        {
                            return true;
                        }
                        else
                        {
                            RefuseAccess(purpleKeyDenied);
                            return false;
                        }

                    case "greenhouse":
                        if (Items.hasPurpleKey)
                        {
                            return true;
                        }
                        else
                        {
                            RefuseAccess(purpleKeyDenied);

                            return false;
                        }

                    case "hallway":
                        return true;

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
                        if (Items.hasBlueKey)
                        {
                            return true;
                        }
                        else
                        {
                            RefuseAccess(blueKeyDenied);
                            return false;
                        }

                    case "hallway":
                        return true;

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
                        if (Items.hasRedKey)
                        {
                            return true;
                        }
                        else
                        {
                            RefuseAccess(redKeyDenied);
                            return false;
                        }

                    case "hallway":
                        return true;

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

            case "escape pods":
                switch (roomName)
                {
                    case "shuttle bay":

                        return true;

                    case "engine room":
                        if (Items.hasBlueKey)
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

            case "greenhouse":
                switch (roomName)
                {
                    case "lab":
                        return true;

                    default:
                        return false;
                }

            case "hallway":
                switch (roomName)
                {
                    case "shuttle bay":
                        return true;
                    case "engine room":
                        if (Items.hasBlueKey)
                        {
                            return true;
                        }
                        else
                        {
                            RefuseAccess(blueKeyDenied);
                            return false;
                        }
                    case "lab":
                        return true;
                    case "hallway":
                        if (Items.hasPurpleKey)
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




            default:
                return false;


        }

    }


    public static void RefuseAccess(string message)
    {
        Format.PrintSpecial(message);
        Format.PrintSpecial("Press %'enter'% to continue.", Format.lineWidthDefault, ConsoleColor.DarkGray);
        Player.GetInput();
    }










    // # = door
    // :. = wall - maybe change . to be floor and colour background of space station
    // / = window
    // o/0/& = seat
    // v = pool
    // | = wood/panel
    // *[0.0]* = robot
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
        "        |                #                 |                         |           #    IO       /    " +
        "        |   ___          #                 |                         |           #    |o       /    " +
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

    private static string mapBrig = "" +
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
        "        |                #                 |                         |           #    IO       /    " +
        "        |   ___          #                 |                         |           #    |o       /    " +
        "        |   (})          :....###.....::::-//-:::::.....##....:      :....##......:       o|   /    " +
        "        |   (})          :[  ]        /          :: &     [==]:      :===]   -+++-:]  o|  o|   /    " +
        "      :::::::::          #       (]Z[)::         /   & []     #      :=]          :]           /    " +
        "             / (||)      :....###.....::         / &   []   / :      :[|     (__-):]   o o o   /    " +
        "             /       (||):||| *[0.0]* /          ::  o o   / X:      :]|     _____:   [=====]  /    " +
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


    private static string mapEngineRoom = "" +
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
        "        |                #                 |                         |           #    IO       /    " +
        "        |   ___          #                 |                         |           #    |o       /    " +
        "        |   (})          :....###.....::::-//-:::::.....##....:      :....##......:       o|   /    " +
        "        |   (})          :[  *[0.0]*  /          :: &     [==]:      :===]   -+++-:]  o|  o|   /    " +
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

    private static string mapEscapePods = "" +
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
        "        |                #                 |                         |           #    IO       /    " +
        "        |   ___          #                 |                         |           #    |o       /    " +
        "        |   (})          :....###.....::::-//-:::::.....##....:      :....##......:       o|   /    " +
        "        |   (})          :[  ]        /          :: &     [==]:      :===]   -+++-:]  o|  o|   /    " +
        "      :::::::::          #       (]Z[)::         /   & []     #      :=]          :]           /    " +
        "             / (||)      :....###.....::         / &   []   / :      :[|     (__-):]   o o o   /    " +
        "             / *[0.0]* |):|||         /          ::  o o   / X:      :]|     _____:   [=====]  /    " +
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


    private static string mapGreenhouse = "" +
            "                                                                                                    " +
            "                                                                                                    " +
            "                                                                                                    " +
            "                                                                                                    " +
            "                                                          :::::-/////-:::::                         " +
            "                         :::-//////-:::                   ::==   ___o  ==::                         " +
            "                         / --x-  -xx- /                   ::==   o o   ==::                         " +
            "                         / -x-    -x- /                   ::==      .....::::::::::                 " +
            "                         ::x *[0.0]* x::          :::-///-:::.....##.:]    # #    [:::-/////////     " +
            "            :::::::::::::::...###....::          ::  ooo ooo   :    :(-__): :(__-):   [=====]  /    " +
            "            ::[[] [][]]  #         [=/            /  [ ] [ ]   :    :.....: :.....:]   o o o   /    " +
            "      ::::::::...###.....:=]  [ ]  [=/            /  ooo ooo   #    :]    # #    [:]           /    " +
            "        |                :==]     [==::          ::         c==:    :(-__): :(__-):]  o|  o|   /    " +
            "        |                :....###...::::::-//-:::::.....##.....:    :.....:-:.....:       o|   /    " +
            "        |                #                 |                         |           #    IO       /    " +
            "        |   ___          #                 |                         |           #    |o       /    " +
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


    private static string mapLab = "" +
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
        "            ::[[] [][]]  # *[0.0]* [=/            /  [ ] [ ]   :    :.....: :.....:]   o o o   /    " +
        "      ::::::::...###.....:=]  [ ]  [=/            /  ooo ooo   #    :]    # #    [:]           /    " +
        "        |                :==]     [==::          ::         c==:    :(-__): :(__-):]  o|  o|   /    " +
        "        |                :....###...::::::-//-:::::.....##.....:    :.....:-:.....:       o|   /    " +
        "        |                #                 |                         |           #    IO       /    " +
        "        |   ___          #                 |                         |           #    |o       /    " +
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


    private static string mapPrimaryHallway = "" +
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
        "        |                #                 |                         |           #    IO       /    " +
        "        |   ___          #        *[0.0]*  |                         |           #    |o       /    " +
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







    private static string mapShuttleBay = "" +
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
        "        |       *[0.0]*  #                 |                       |             #    IO       /  " +
        "        |   ___          #                 |                         |           #    |o       /    " +
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



    private static string mapStoreRoom = "" +
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
       "            ::[[ *[0.0]* #         [=/            /  [ ] [ ]   :    :.....: :.....:]   o o o   /    " +
       "      ::::::::...###.....:=]  [ ]  [=/            /  ooo ooo   #    :]    # #    [:]           /    " +
       "        |                :==]     [==::          ::         c==:    :(-__): :(__-):]  o|  o|   /    " +
       "        |                :....###...::::::-//-:::::.....##.....:    :.....:-:.....:       o|   /    " +
       "        |                #                 |                         |           #    IO       /    " +
       "        |   ___          #                 |                         |           #    |o       /    " +
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












}



