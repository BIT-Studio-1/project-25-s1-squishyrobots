// Ignore Spelling: interactibles

using System;
using System.Xml.Serialization;






// This page is used to store global variables that can be accessed from anywhere in the program.
namespace Globals
{
    


    /// <summary>
    /// This class is used to store the player global variables
    /// </summary>
    public static class Player
    {
        public static string input;
        public static string location;


        public static bool hasRedKey = false;
        public static bool hasGreenKey = false;
        public static bool hasCrowbar = false;
        public static bool hasBattery = false;



        /// <summary>
        /// This function is used to parse the input from the player
        /// </summary>
        public static void GetInput()
        {
            input = Console.ReadLine().ToLower();
            Console.Clear();
        }

        public static void ClearInput()
        {
           input = "";

        }


    }

    
    /// <summary>
    /// This class is used to store the generic global map variables
    /// </summary>
    public static class Map
    {
        

        public static void enter(string locationName)
        {
            Player.location = locationName;
            Player.ClearInput(); // may cause errors - check back later

        }   


    }


}


