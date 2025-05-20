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
        public static string location;



        /// <summary>
        /// This function is used to parse the input from the player
        /// </summary>
        public static void GetInput()
        {
            input = Console.ReadLine().ToLower();
            Console.Clear();
        }


        public static bool hasRedKey = true;
        public static bool hasGreenKey = false;
        public static bool hasCrowbar = false;
        public static bool hasBattery = false;



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
                if (hasBattery)
                {
                    Console.WriteLine("Battery");
                }

                // if no items are in the inventory
                if (!hasRedKey && !hasGreenKey && !hasCrowbar && !hasBattery)
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
                            Console.WriteLine("A silver key card with two red stripes across the top");
                            break;
                        case "green key":
                            Console.WriteLine("You have a green key.");
                            break;
                        case "crowbar":
                            Console.WriteLine("You have a crowbar.");
                            break;
                        case "battery":
                            Console.WriteLine("A cylinder with a pulsing ");
                            break;
                        default:
                            Console.WriteLine("Unknown Item");
                            break;
                    }
                    Console.WriteLine("\n\tPress enter to return");
                    Console.ReadLine();
                }
                Console.Clear();


            } while (input != "back");
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
        }


        /// <summary>
        /// This method is used to take a string and look for special characters to highlight with differing colours, breaking each line at the line width
        /// </summary>
        /// <param name="input"></param>
        /// <param name="lineWidth"></param>
        public static void PrintSpecial(string input = "*null* text input", int lineWidth = lineWidthDefault, ConsoleColor baseColour = defaultColour, ConsoleColor interestColour = defaultInterestColour)
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




                if (words[j][0] == '*' && words[j][words[j].Length - 1] == '*')
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

        }



    }


    
}


