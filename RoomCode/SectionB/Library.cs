using System;
using Globals;



public static class Library
{
    public const string name = "library";


    // replaces main
    public static void start()
    {



        Format.PrintSpecial("You are in the Library.");



        Map.SurroundingRooms =
           [

           ];


        string description =
            "blank"

            ;


        string[] observations =
        {

        };


        Format.PrintSpecial(description);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.PrintSpecial(observations[i]);
        }




        Player.GetInput();


        // actions
        switch (Player.input)
        {
            case "ancient tome":
                break;

            case "books":
                break;

            case "bookmark":
                break;

            case "digital reader":
                break;

            case "computer":
                break;
            case "research notes":
                break;
            case "maps":
                break;



        }

        //locations





    }




}





