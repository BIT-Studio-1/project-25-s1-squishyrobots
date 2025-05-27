// Ignore Spelling: interactibles

using System;
using System.Drawing;
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

    }
    

    /// <summary>
    /// This class is used to store methods that format inputted strings and prints them
    /// </summary>
    public static class Format
    {
        public const int lineWidthDefault = 15;
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


                if (words[j].Length != 0)
                {
                    if (words[j].Length > 1 && (words[j][0] == '*' && words[j][words[j].Length - 1] == '*')) // blue / interest
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
                    



                    // if a fullstop or ended with a fullstop then break line.
                    else if (words[j].Contains('.'))
                    {
                        string[] temp = words[j].Split('.');
                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine(temp[i] + ".");
                            } else
                            {
                                Console.Write(temp[i]);
                            }
                        }
                    }
                    // if no special characters, then write.
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


