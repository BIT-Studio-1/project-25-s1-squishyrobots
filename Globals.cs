// Ignore Spelling: interactibles

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
        public Interactible[] interactables;


        /// <summary>
        /// This function is used to create a new room with the given name and surrounding rooms
        /// </summary>
        public Room(string roomName, string[] surroundingRooms, Interactible[] interactibles)
        {
            this.roomName = roomName;
            this.surroundingRoomNames = surroundingRooms;
            this.interactables = interactibles;

        }


    }



    /// <summary>
    /// This class is used to store the interactible objects in the room
    /// </summary>
    public class Interactible
    {
        public static string name = "Null";
        public static string description = "Null";
        public static Use[] actions;
    }


    /// <summary>
    /// This class is used to store the actions that can be performed on the interactible objects
    /// </summary>
    public class Use 
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


        public static string[] options;
        
    }



    /// <summary>
    /// This class is used to store the generic global map variables
    /// </summary>
    public static class Map
    {
        //public static int seed = -1;


        /// <summary>
        /// This stores each room and its data
        /// </summary>
        // generating a list of rooms
        public static List<Room> roomList =
            [
                // modular hallway rooms template
            //new Room("Escape Pods", new string[] { "Shuttle Bay", "Engine Room" }, new Interactible[] { new Interactible() }), // input all interactibles within room
            //new Room("Shuttle Bay", new string[] { "Escape Pods", "Storage", "Hallway" }, new Interactible[] { new Interactible() }),
            //new Room("Engine Room", new string[] { "Escape Pods", "Brig", "Hallway" }, new Interactible[] { new Interactible() }),
            //new Room("Bridge", new string[] { "Hallway" }, new Interactible[] { new Interactible() }),
            //new Room("Lab", new string[] { "Storage", "Greenhouse", "Hallway" }, new Interactible[] { new Interactible() }),
            //new Room("Storage", new string[] { "Shuttle Bay", "Lab" }, new Interactible[] { new Interactible() }),
            //new Room("Brig", new string[] { "Engine Room" }, new Interactible[] { new Interactible() }),
            //new Room("Mess Hall", new string[] { "Hallway" }, new Interactible[] { new Interactible() }),
            //new Room("Medical Bay", new string[] { "Hallway" }, new Interactible[] { new Interactible() }),
            //new Room("Captain Quarters", new string[] { "Hallway" }, new Interactible[] { new Interactible() }),
            //new Room("Recreational Room", new string[] { "Hallway" }, new Interactible[] { new Interactible() }),
            //new Room("Library", new string[] { "Hallway" }, new Interactible[] { new Interactible() }),
            //new Room("Crew Quarters", new string[] { "Hallway" }, new Interactible[] { new Interactible() }),




                // non-modular hallway rooms
            new Room("Escape Pods", new string[] { "Shuttle Bay", "Engine Room" }, new Interactible[] { new Interactible() }), // input all interactibles within room
            new Room("Shuttle Bay", new string[] { "Escape Pods", "Storage", "Hallway1" }, new Interactible[] { new Interactible() }),
            new Room("Engine Room", new string[] { "Escape Pods", "Brig", "Hallway1" }, new Interactible[] { new Interactible() }),
            new Room("Bridge", new string[] { "Hallway7" }, new Interactible[] { new Interactible() }),
            new Room("Lab", new string[] { "Storage", "Greenhouse", "Hallway1" }, new Interactible[] { new Interactible() }),
            new Room("Storage", new string[] { "Shuttle Bay", "Lab" }, new Interactible[] { new Interactible() }),
            new Room("Brig", new string[] { "Engine Room" }, new Interactible[] { new Interactible() }),
            new Room("Mess Hall", new string[] { "Hallway3", "Hallway4" }, new Interactible[] { new Interactible() }),
            new Room("Medical Bay", new string[] { "Hallway4" }, new Interactible[] { new Interactible() }),
            new Room("Captain Quarters", new string[] { "Hallway4", "Hallway7" }, new Interactible[] { new Interactible() }),
            new Room("Recreational Room", new string[] { "Hallway3", "Hallway6" }, new Interactible[] { new Interactible() }),
            new Room("Library", new string[] { "Hallway6" }, new Interactible[] { new Interactible() }),
            new Room("Crew Quarters", new string[] { "Hallway6", "Hallway7" }, new Interactible[] { new Interactible() }),


            // adjust later for modular use
            new Room("Hallway1", new string[] { "Hallway2", "Lab", "Shuttle Bay", "Engine Room" }, new Interactible[] { new Interactible() }),
            new Room("Hallway2", new string[] { "Hallway1", "Hallway3" }, new Interactible[] { new Interactible() }),
            new Room("Hallway3", new string[] { "Hallway2", "Hallway4", "Mess Hall", "Recreational Room" }, new Interactible[] { new Interactible() }),
            new Room("Hallway4", new string[] { "Hallway5", "Mess Hall", "Medical Bay" }, new Interactible[] { new Interactible() }),
            new Room("Hallway5", new string[] { "Hallway3", "Hallway5", "Hallway6", "Hallway7" }, new Interactible[] { new Interactible() }),
            new Room("Hallway6", new string[] { "Hallway5", "Recreational Room", "Library" }, new Interactible[] { new Interactible() }),
            new Room("Hallway7", new string[] { "Hallway5", "Captain Quarters", "Crew Quarters", "Bridge" }, new Interactible[] { new Interactible() }),

            ];


        public static int hallway = 0;



    }


    // default function that is called every time a room spawns in
    

}


