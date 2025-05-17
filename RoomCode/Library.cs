using System;
using Globals;



public static class Library
{
    public static string name = "library";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Library.");



        string description =
            "blank"

            ;


        string[] observations =
        {

        };




        Format.PrintConformed(description);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
            Console.WriteLine();
        }




        Player.GetInput();


        switch (Player.input)
        {
            case "anienct tome":
                break;

            case "books":
                break;

            case "book-mark":
                break;

            case "digital reader":
                break;

            case "computers":
                break;
            case "research notes":
                break;
            case "maps":
                break;



        }
        Console.WriteLine();







    }




}





