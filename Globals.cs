﻿// Ignore Spelling: interactibles



// This page is used to store global variables that can be accessed from anywhere in the program.
using Globals;



namespace Globals
{



    /// <summary>
    /// This class is used to store the player global variables
    /// </summary>
    public static class Player
    {
        public static string input = "";
        public static string location = "shuttle bay";
        //public static bool isPlaying = false;
        public static bool hasWon = false;
        public static int currentHallway = 0;


        /// <summary>
        /// This function is used to parse the input from the player >> ALWAYS LOWERCASE 
        /// </summary>
        public static void GetInput()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            input = Console.ReadLine().ToLower();

            Console.Clear();
            Utility.showCount--; // possibly redundant

            Utility.Show();
            Utility.showCount++; // possibly redundant

            Utility.Check(); // used after every GetInput to check if the input is a command, an action or a movement


        }


    }



    /// <summary>
    /// This class is used to store methods that are used throughout the game, such as showing the menu, checking the input and winning the game.
    /// </summary>
    public static class Utility
    {

        public static int showCount = 0;

        /// <summary>
        /// This method is used to show the menu at the start of the game and after every action, it will print out the instructions and the available commands.
        /// </summary>
        public static void Show()
        {
            

            if (showCount < 1)
            {
                // print out instructions:
                Format.PrintSpecial("" +
                " ~ Menu ~ " +
                " *Inventory ~* " +
                " ^Help ~^ " +
                " %Map ~% ", 50, ConsoleColor.DarkMagenta, ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.DarkYellow);
            }
        }


        /// <summary>
        /// This method is used to check the input from the player, if the input is a command, it will execute the command or fall through to move or interact.
        /// </summary>
        public static void Check()
        {
            // map, inventory, help, menu

            switch (Player.input)
            {
                case "map":

                    Map.ShowMap();
                    break;

                case "inventory":

                    Inventory.ShowInventory();
                    break;

                case "help":

                    Format.PrintSpecial("%Instructions% : \n" +
                        "1. You are a robot, and you are being piloted to find the ship's black box.\n" +
                        "2. You can interact with blue objects in the environment.\n" +
                        "3. Use the *'inventory'* to check your items.\n" +
                        "4. Use the *'map'* to check where you are and where you can go next.\n" +
                        "5. Use the ^'exit'^ command to leave the game.\n\n" +
                        " $This game is best enjoyed in 'Fullscreen' mode. Please consider adjusting your window.$ ", 40);
                    Format.PrintSpecial("Press %'enter'% to continue.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    Player.GetInput();
                    break;

                case "menu":

                    MainMenu.ShowMenu();

                    //Format.PrintSpecial("Unfortunately, due to looping, we had to remove menu functionality for the time being.");
                    //Format.PrintSpecial("Press %'enter'% to continue.", Format.lineWidthDefault, ConsoleColor.DarkGray);
                    //Player.GetInput();

                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// This method is used to print a message when the player wins the game, it will clear the console and print a message congratulating the player.
        /// </summary>
        public static void Win()
        {
            Console.Clear();
            Format.PrintSpecial("Congratulations! You completed the demo! More to come soon. Thanks for playing <3", Format.lineWidthDefault, ConsoleColor.Green);
            Format.PrintSpecial("Press %'enter'% to continue exploring or ^'exit'^ to leave the game.", Format.lineWidthDefault, ConsoleColor.DarkGray, Format.defaultInterestColour, Format.defaultDangerColour, ConsoleColor.DarkGreen);
            Player.hasWon = true;
            Player.GetInput();

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
        public const ConsoleColor defaultImportantColour = ConsoleColor.Magenta;
        public const ConsoleColor defaultHintColour = ConsoleColor.Yellow;


        /// <summary>
        /// This method is used to print a string in a default format no special characters, breaking each line at the line width.
        /// </summary>
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
        /// @ Purple |
        /// $ Yellow |
        /// </summary>
        public static void PrintSpecial(string input = "*null* text input", int lineWidth = lineWidthDefault, ConsoleColor baseColour = defaultColour, ConsoleColor interestColour = defaultInterestColour, ConsoleColor dangerColour = defaultDangerColour, ConsoleColor helpColour = defaultHelpColour, ConsoleColor importantColour = defaultImportantColour, ConsoleColor hintColour = defaultHintColour)
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
                    // check for special characters and format accordingly
                    // BLUE
                    if (words[j].Length > 1 && (words[j][0] == '*' && words[j][words[j].Length - 1] == '*')) // blue / interest / action
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

                    // RED
                    else if (words[j][0] == '^' && words[j][words[j].Length - 1] == '^') // red / danger / enemy
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

                    // GREEN
                    else if (words[j][0] == '%' && words[j][words[j].Length - 1] == '%') // green / helpful / command
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

                    // PURPLE
                    else if (words[j][0] == '@' && words[j][words[j].Length - 1] == '@') // purple / important / pretty cool
                    {
                        // if started and ended with @ then make purple then set back to default
                        Console.ForegroundColor = importantColour;
                        Console.Write(words[j].Remove(words[j].Length - 1).Remove(0, 1));
                        Console.ForegroundColor = baseColour;
                    }
                    else if (words[j][0] == '@')
                    {
                        // if started with @ then set purple until stop
                        Console.ForegroundColor = importantColour;
                        Console.Write(words[j].Remove(0, 1));
                    }
                    else if (words[j][words[j].Length - 1] == '@')
                    {
                        // if ended with @ then set back to default
                        Console.Write(words[j].Remove(words[j].Length - 1));
                        Console.ForegroundColor = baseColour;
                    }

                    // YELLOW
                    else if (words[j][0] == '$' && words[j][words[j].Length - 1] == '$') // yellow / location / hints
                    {
                        // if started and ended with $ then make yellow then set back to default
                        Console.ForegroundColor = hintColour;
                        Console.Write(words[j].Remove(words[j].Length - 1).Remove(0, 1));
                        Console.ForegroundColor = baseColour;
                    }
                    else if (words[j][0] == '$')
                    {
                        // if started with $ then set yellow until stop
                        Console.ForegroundColor = hintColour;
                        Console.Write(words[j].Remove(0, 1));
                    }
                    else if (words[j][words[j].Length - 1] == '$')
                    {
                        // if ended with $ then set back to default
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
                            }
                            else
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
                    if (/*j < 1 && words[j-1][words[j-1].Length-1] != '.' && */j != words.Length - 1 % lineWidth)
                    {
                        Console.Write(" ");
                    }
                }



            }

            Console.WriteLine();

        }

        public static void PrintCharacters(string input = "*null* text input", int lineWidth = lineWidthDefault * 5, ConsoleColor baseColour = ConsoleColor.DarkGray, ConsoleColor playerColour = defaultHelpColour)
        {
            Console.ForegroundColor = baseColour;

            char[] characters = input.ToCharArray();
            bool isCharacter = false;

            for (int i = 0; i < characters.Length; i++)
            {

                if (characters[i] == '*') // green
                {
                    // if started and ended with * then make green then set back to default
                    if (!isCharacter)
                    {
                        Console.ForegroundColor = playerColour;
                        isCharacter = true;
                    } else
                    {
                        Console.ForegroundColor = baseColour;
                        isCharacter = false;
                    }
                } else
                {
                    Console.Write(input[i]);
                }

                if (i % lineWidth == 0)
                {
                    Console.WriteLine();
                }



            }

            Console.WriteLine();
        }

    }



}


