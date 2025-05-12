using System;
using System.Xml.Serialization;






// This page is used to store global variables that can be accessed from anywhere in the program.
namespace Globals
{
    
    /// <summary>
    /// This class is used to store the room data and their surrounding rooms
    /// </summary>
    public class Room
    {
        public string roomName = "Null";
        public string[] surroundingRoomNames;
        public Interactible[] interactibles;


        /// <summary>
        /// This function is used to create a new room with the given name and surrounding rooms
        /// </summary>
        public Room(string roomName, string[] surroundingRooms, Interactible[] interactibles)
        {
            this.roomName = roomName;
            this.surroundingRoomNames = surroundingRooms;
            this.interactibles = interactibles;

        }


    }



    /// <summary>
    /// This class is used to store the interactible objects in the room
    /// </summary>
    public class Interactible
    {
        public static string name = "Null";
        public static string description = "Null";
        public static Action[] actions;

    }

    /// <summary>
    /// This class is used to store the actions that can be performed on the interactible objects
    /// </summary>
    public class Action 
    { 
        public static string name = "Null";
        public static string description = "Null";
        
    }


    /// <summary>
    /// This class is used to store the player global variables
    /// </summary>
    public static class Player
    {
        public static string input;


        /// <summary>
        /// This function is used to parse the input from the player
        /// </summary>
        public static void GetInput()
        {

            input = Console.ReadLine();

            Console.Clear();
        }



    }

    /// <summary>
    /// This class is used to store the generic global map variables
    /// </summary>
    public static class Map
    {
        public static int seed = -1;



        /// <summary>
        /// This stores each room and its data
        /// </summary>
        // generating a list of rooms
        public static List<Room> roomNames =
            [
            new Room("Escape Pods", new string[] { "Shuttle Bay", "Engine Room" }, new Interactible[] { new Interactible() }),
            new Room("Shuttle Bay", new string[] { "Escape Pods", "Engine Room" }, new Interactible[] { new Interactible() }),
            ];
            







    }


    // default function that is called every time a room spawns in
    

}


