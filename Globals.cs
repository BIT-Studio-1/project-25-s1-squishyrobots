// Ignore Spelling: interactibles

using System;
using System.Drawing;
using System.Xml.Serialization;




public static class Room
{
    public static string name = "default room name";

    public static string getName()
    {
        return name;
    }

}



// This page is used to store global variables that can be accessed from anywhere in the program.
namespace Globals
{
    
    /// <summary>
    /// This class is used to store the player global variables
    /// </summary>
    public static class Player
    {
        public static string input;
        public static string location = "shuttle bay";
        public static bool isPlaying = false;


        /// <summary>
        /// This function is used to parse the input from the player
        /// </summary>
        public static void GetInput()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            input = Console.ReadLine().ToLower();
            Console.Clear();
        }


        public static bool hasRedKey = true;
        public static bool hasPurpleKey = false;
        public static bool hasBlueKey = false;
        public static bool hasGreenKey = false;
        public static bool hasCrowbar = false;
        public static bool hasFuelCell = false;


        public static void ShowInventory()
        {

            do
            {

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("You have the following items in your inventory: ");
                Console.WriteLine("-------------------------------------------------");


                // list available items
                if (hasRedKey)
                {
                    Console.WriteLine("Red Key");
                }
                if (hasGreenKey)
                {
                    Console.WriteLine("Green Key");
                }
                if (hasCrowbar)
                {
                    Console.WriteLine("Crowbar");
                }
                if (hasFuelCell)
                {
                    Console.WriteLine("Fuel Cell");
                }


                // if no items are in the inventory
                if (!hasRedKey && !hasGreenKey && !hasCrowbar && !hasFuelCell)
                {
                    Console.WriteLine("You have no items in your inventory.");
                }


                // instructions for exit
                Console.WriteLine("\n-- type 'back' to return --\n");


                GetInput();

                if (input != "back")
                {
                    switch (input)
                    {
                        case "red key":
                            Format.PrintSpecial("A silver key card with two ^red stripes^ across the top.");
                            break;
                        case "green key":
                            Format.PrintSpecial("You have a green key.");
                            break;
                        case "crowbar":
                            Format.PrintSpecial("You have a crowbar.");
                            break;
                        case "fuel cell":
                            Format.PrintSpecial("A beveled cylinder with a pulsing *blue bar* across its length. You get the feeling it still has an abundance of power stored within.");
                            break;
                        case "":
                            break;
                        default:
                            Format.PrintSpecial("^Unknown Item^");
                            break;
                    }

                    Format.PrintSpecial("\nPress %'enter'% to return");
                    Console.ReadLine();

                }

            } while (input != "back");
        }






        /// <summary>
        /// This method is used to check if the player can access a room based on the room name
        /// </summary>
        /// <param name="roomName"></param>
        public static bool CanIAccess(string roomName)
        {

            string purpleKeyDenied = $"^Denied Access^ ! You need the purple key to access the ^{roomName}^ !";
            string blueKeyDenied = $"^Denied Access^ ! You need the blue key to access the ^{roomName}^ !";
            string redKeyDenied = $"^Denied Access^ ! You need the red key to access the ^{roomName}^ !";

            // switch statement based on Player.location and room input.

            // has purple key & in lab 

            switch (location)
            {
                case "store room":
                    switch (roomName)
                    {
                        case "shuttle bay":
                            return true;

                        case "lab":
                            if (hasPurpleKey)
                            {
                                return true;
                            }
                            else
                            {
                                Format.PrintSpecial(purpleKeyDenied);
                                return false;
                            }

                        default:
                            return false;
                    }

                case "lab":
                    switch (roomName)
                    {
                        case "store room":
                                if (hasPurpleKey)
                                {
                                    return true;
                                }
                                else
                                {
                                    Format.PrintSpecial(purpleKeyDenied);
                                    return false;
                                }

                        case "greenhouse":
                            if (hasPurpleKey)
                            {
                                return true;
                            }
                            else
                            {
                                Format.PrintSpecial(purpleKeyDenied);
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
                            if (hasBlueKey)
                            {
                                return true;
                            }
                            else
                            {
                                Format.PrintSpecial(blueKeyDenied);
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
                            if (hasRedKey)
                            {
                                return true;
                            }
                            else
                            {
                                Format.PrintSpecial(redKeyDenied);
                                return false;
                            }

                        default:
                            return false;
                    }
            }




            return false;
        }





    }

    
    /// <summary>
    /// This class is used to store the generic global map variables
    /// </summary>
    public static class Map
    {
        
    }
    

    /// <summary>
    /// This class is used to store methods that format inputted strings and prints them
    /// </summary>
    public static class Format
    {
        public const int lineWidthDefault = 12;
        public const ConsoleColor defaultColour = ConsoleColor.Gray;
        public const ConsoleColor defaultInterestColour = ConsoleColor.Blue;
        public const ConsoleColor defaultDangerColour = ConsoleColor.Red;
        public const ConsoleColor defaultHelpColour = ConsoleColor.Green;


        /// <summary>
        /// This method is used to print a string in a default format no special characters, breaking each line at the line width
        /// </summary>
        /// <param name="input"></param>
        /// <param name="lineWidth"></param>
        /// <param name="colour"></param>
        public static void PrintConformed(string input = "*null* text input", int lineWidth = lineWidthDefault, ConsoleColor colour = ConsoleColor.DarkGray)
        {
            Console.ForegroundColor = colour;

            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {

                if (i % lineWidth == 0)
                {
                    Console.WriteLine();
                }

                Console.Write(words[i]);

                if (i != words.Length - 1 % lineWidth)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Method <c>PrintSpecial</c> formats and colour text then prints to console |
        /// ^ Red |
        /// % Green |
        /// * Blue |
        /// </summary>
        /// 
        /// <param name="input">The text that is to be formatted</param>
        /// <param name="lineWidth"></param>
        /// <param name="baseColour"></param>
        /// <param name="interestColour"></param>
        /// <param name="dangerColour"></param>
        /// <param name="helpColour"></param>
        public static void PrintSpecial(string input = "*null* text input", int lineWidth = lineWidthDefault, ConsoleColor baseColour = defaultColour, ConsoleColor interestColour = defaultInterestColour, ConsoleColor dangerColour = defaultDangerColour, ConsoleColor helpColour = defaultHelpColour)
        {

            Console.ForegroundColor = baseColour;
            string[] words = input.Split(' ');

            // loop through the words and check for asterisks
            for (int j = 0; j < words.Length; j++)
            {



                // if the sentence is too long, split it into multiple lines
                if (j % lineWidth == 0)
                {
                    Console.WriteLine();
                }



                if (words[j][0] == '*' && words[j][words[j].Length - 1] == '*') // blue / interest
                {
                    // if started and ended with * then make blue then set back to default
                    Console.ForegroundColor = interestColour;
                    Console.Write(words[j].Remove(words[j].Length - 1).Remove(0, 1));
                    Console.ForegroundColor = baseColour;
                }
                else if (words[j][0] == '*')
                {
                    // if started with * then set blue until stop
                    Console.ForegroundColor = interestColour;
                    Console.Write(words[j].Remove(0, 1));
                }
                else if (words[j][words[j].Length - 1] == '*')
                {
                    // if ended with * then set back to default
                    Console.Write(words[j].Remove(words[j].Length - 1));
                    Console.ForegroundColor = baseColour;
                }
                else if (words[j][0] == '^' && words[j][words[j].Length - 1] == '^') // red / danger
                {
                    // if started and ended with ^ then make red then set back to default
                    Console.ForegroundColor = dangerColour;
                    Console.Write(words[j].Remove(words[j].Length - 1).Remove(0, 1));
                    Console.ForegroundColor = baseColour;
                }
                else if (words[j][0] == '^')
                {
                    // if started with ^ then set red until stop
                    Console.ForegroundColor = dangerColour;
                    Console.Write(words[j].Remove(0, 1));
                }
                else if (words[j][words[j].Length - 1] == '^')
                {
                    // if ended with ^ then set back to default
                    Console.Write(words[j].Remove(words[j].Length - 1));
                    Console.ForegroundColor = baseColour;
                }
                else if (words[j][0] == '%' && words[j][words[j].Length - 1] == '%') // green / helpful
                {
                    // if started and ended with % then make green then set back to default
                    Console.ForegroundColor = helpColour;
                    Console.Write(words[j].Remove(words[j].Length - 1).Remove(0, 1));
                    Console.ForegroundColor = baseColour;
                }
                else if (words[j][0] == '%')
                {
                    // if started with % then set green until stop
                    Console.ForegroundColor = helpColour;
                    Console.Write(words[j].Remove(0, 1));
                }
                else if (words[j][words[j].Length - 1] == '%')
                {
                    // if ended with & then set back to default
                    Console.Write(words[j].Remove(words[j].Length - 1));
                    Console.ForegroundColor = baseColour;
                }

                // can place other special characters here <<<<<<<<<<<<<<<<<<<<<<
                // if the word is not a special word, just print it
                else
                {
                    Console.Write(words[j]);
                }




                // if the word is not the last word in the line, add a space
                if (j != words.Length - 1 % lineWidth)
                {
                    Console.Write(" ");
                }


            }

            Console.WriteLine();

        }

        public static void PrintCharacters(string input = "*null* text input", int lineWidth = lineWidthDefault * 5, ConsoleColor colour = ConsoleColor.DarkGray)
        {
            Console.ForegroundColor = colour;

            char[] characters = input.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {

                if (i % lineWidth == 0)
                {
                    Console.WriteLine();
                }

                Console.Write(input[i]);

                //if (i != input.Length - 1 % lineWidth)
                //{
                //    Console.Write(" ");
                //}
            }

            Console.WriteLine();
        }

    }


    
}


