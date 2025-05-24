using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Globals;


public static class Map
{



    public static void ShowMap()
    {
        Format.PrintCharacters(mapBase, mapWidth, ConsoleColor.Cyan);

        Format.PrintSpecial($"You are in the {Player.location}.", Format.lineWidthDefault, ConsoleColor.DarkGray);
        Format.PrintSpecial("Surrounding rooms:");
        string temp = "";
        for (int i = 0; i < SurroundingRooms.Length; i++)
        {
            temp = temp + "\t" + SurroundingRooms[i] + "\n";
        }
        Format.PrintSpecial(temp, Format.lineWidthDefault, ConsoleColor.Blue);

        Player.GetInput();

        for (int i = 0; i < SurroundingRooms.Length; i++)
        {
            if (Player.input == SurroundingRooms[i])
            {
                Player.location = SurroundingRooms[i]; // can be used for getting into rooms that are locked ** FIX
            }
        }
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


}

