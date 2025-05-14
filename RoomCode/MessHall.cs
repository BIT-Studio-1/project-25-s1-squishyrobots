using System;
using Globals;



public static class MessHall
{
    public static string name = "mess hall";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Mess Hall.");

        Player.GetInput();


        switch (Player.input)
        {
            case "food tray":
                break;

            case "cooking pot":
                break;

            case "tableware":
                break;

            case "vednding machine":
                break;

            case "meal":
                break;


        }
        Console.WriteLine();







    }




}





