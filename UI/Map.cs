using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Globals;
using static System.Collections.Specialized.BitVector32;



// Map class to handle the map display and surrounding rooms
// This class is used to show the map and the rooms around the player
// It also contains the map data and the width of the map
// The map is a string that represents the layout of the space station
// The surrounding rooms are stored in a string array

public static class Map
{

    public static string[] SurroundingRooms = new string[0];
    private static int mapWidth = 100;

    public static bool powerOn = false;



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
        Format.PrintSpecial($"You are in the %{Player.location}% .", Format.lineWidthDefault, ConsoleColor.DarkGray);
        Format.PrintSpecial("Surrounding rooms:");
        string temp = "";
        for (int i = 0; i < SurroundingRooms.Length; i++)
        {
            temp = temp + "\t" + SurroundingRooms[i] + "\n";
        }
        Format.PrintSpecial(temp, Format.lineWidthDefault, Format.defaultHintColour);

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
    /// Moves the player to a specified room if they have access but displays message if they don't.
    /// </summary>
    public static void MoveTo(string roomName)
    {

        string purpleKeyDenied = $"^Denied Access^ ! You need the @purple@ key to access the ^{roomName}^ !";
        string blueKeyDenied = $"^Denied Access^ ! You need the *blue* key to access the ^{roomName}^ !";
        string redKeyDenied = $"^Denied Access^ ! You need the ^red^ key to access the ^{roomName}^ !";
        string greenKeyDenied = $"^Denied Access^ ! You need the %green% key to access the ^{roomName}^ !";



        //Store room - lab - green key
        //Store room - greenhouse green key

        //Store room - engine room - red key
        //Greenhouse - brig - blue key


        //Brig - lab locker - crowbar 
        //Lab locker - section B - purple key
        



        // switch statement based on Player.location and room input.
        switch (Player.location)
        {
            case "store room":
                switch (roomName)
                {
                    case "shuttle bay":
                        Player.location = "shuttle bay";
                        break;
                    case "lab":
                        if (Items.hasGreenKey)
                        {
                            Player.location = "lab";    
                        }
                        else
                        {
                            RefuseAccess(greenKeyDenied);
                        }
                        break;
                    default:
                        break;
                }
                break;

            case "lab":
                switch (roomName)
                {
                    case "store room":
                        if (Items.hasGreenKey)
                        {
                            Player.location = "store room";
                        }
                        else
                        {
                            RefuseAccess(greenKeyDenied);
                            
                        }
                        break;
                    case "greenhouse":
                        if (Items.hasGreenKey)
                        {
                            Player.location = "greenhouse";
                        }
                        else
                        {
                            RefuseAccess(greenKeyDenied);
                        }
                        break;
                    case "hallway":
                        Player.location = "hallway";
                        Player.currentHallway = 1;
                        break;
                    default:
                        break;
                }
                break;

            case "shuttle bay":
                switch (roomName)
                {
                    case "store room":
                        Player.location = "store room";
                        break;
                    case "escape pods":
                        Player.location = "escape pods";
                        break;
                    case "Engine Room":
                        if (Items.hasRedKey)
                        {
                            Player.location = "engine room";
                        }
                        else
                        {
                            RefuseAccess(redKeyDenied);
                        }
                        break;
                    case "hallway":
                        Player.location = "hallway";
                        Player.currentHallway = 1;
                        break;
                    default:
                        break;
                }
                break;

            case "engine room":
                switch (roomName)
                {
                    case "shuttle bay":
                        Player.location = "shuttle bay";
                        break;
                    case "escape pods":
                        Player.location = "escape pods";
                        break;
                    case "brig":
                        if (Items.hasBlueKey)
                        {
                            Player.location = "brig";
                        }
                        else
                        {
                            RefuseAccess(blueKeyDenied);
                        }
                        break;
                    case "hallway":
                        Player.location = "hallway";
                        Player.currentHallway = 1;
                        break;
                    default:
                        break;
                }
                break;

            case "brig":
                switch (roomName)
                {
                    case "engine room":
                        Player.location = "engine room";
                        break;
                    default:
                        break;
                }
                break;

            case "escape pods":
                switch (roomName)
                {
                    case "shuttle bay":
                        Player.location = "shuttle bay";
                        break;

                    case "engine room":
                        if (Items.hasRedKey)
                        {
                            Player.location = "engine room";
                        }
                        else
                        {
                            RefuseAccess(redKeyDenied);
                        }
                        break;
                    default:
                        break;
                }
                break;

            case "greenhouse":
                switch (roomName)
                {
                    case "lab":
                        Player.location = "lab";
                        break;
                    default:
                        break;
                }
                break;

            case "hallway":
                switch (roomName)
                {
                    case "shuttle bay":
                        Player.location = "shuttle bay";
                        break;

                    case "engine room":
                        if (Items.hasRedKey)
                        {
                            Player.location = "engine room";
                        }
                        else
                        {
                            RefuseAccess(redKeyDenied);
                        }
                        break;

                    case "lab":
                        Player.location = "lab";
                        break;

                    case "hallway":
                        if (Items.hasPurpleKey)
                        {

                            if (Player.hasWon == true)
                            {
                                Format.PrintSpecial("You have already won the game, there is no need to go back to the hallway.");
                                Player.GetInput();
                            } else
                            {
                                Utility.Win();
                                Player.hasWon = true;
                            }

                            //Player.location = "hallway";
                            //Player.currentHallway = 2; // move to the next hallway
                        }
                        else
                        {
                            RefuseAccess(purpleKeyDenied);
                        }
                        break;

                    default:
                        break;
                }
                break;




            default:
                break;
        }
    }


    /// <summary>
    /// Displays a message to the player refusing access to a room and prompts them to continue.
    /// </summary>
    private static void RefuseAccess(string message)
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



