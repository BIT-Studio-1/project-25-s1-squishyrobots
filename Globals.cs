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




    /// <summary>
    /// This class is used to store methods that format inputted strings and prints them
    /// </summary>
    public static class Format
    {
        public const int lineWidthDefault = 5;



        public static void printConformed(string input = "*null* text input", int lineWidth = lineWidthDefault)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;




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
        /// This method is used to take a string and look for asterisks to 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="lineWidth"></param>
        public static void printSpecial(string input = "*null* text input", int lineWidth = lineWidthDefault)
        {

            Console.ForegroundColor = ConsoleColor.White;

            string[] words = input.Split(' ');

            bool isSpecial = false;

            for (int j = 0; j < words.Length; j++)
            {
                if (j % lineWidth == 0)
                {
                    Console.WriteLine();
                }

                if (words[j][0] == '*' && words[j][words[j].Length - 1] == '*')
                {
                    // if started and ended with * then make blue then set back to default
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(words[j].Remove(words[j].Length - 1).Remove(0, 1));
                    Console.ForegroundColor = ConsoleColor.White;
                    isSpecial = false;
                }
                else if (words[j][0] == '*')
                {
                    // if started with * then set blue until stop
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(words[j].Remove(0, 1));
                    isSpecial = true;
                }
                else if (words[j][words[j].Length - 1] == '*')
                {
                    // if ended with * then set back to default
                    Console.Write(words[j].Remove(words[j].Length - 1));
                    Console.ForegroundColor = ConsoleColor.White;
                    isSpecial = false;
                }
                else
                {
                    Console.Write(words[j]);
                }


                if (j != words.Length - 1 % lineWidth)
                {
                    Console.Write(" ");
                }


            }

        }



    }


}


