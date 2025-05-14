using System;
using Globals;



public static class GreenHouse
{
    public static string name = "green house";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Green House.");

        Player.GetInput();

        switch (Player.input)
        {
            case "lighting":
                break;

            case "temperature control ":
                break;

            case "humidity control":
                break;


        }
        Console.WriteLine();









    }




}





