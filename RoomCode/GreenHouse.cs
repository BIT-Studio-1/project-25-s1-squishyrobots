using System;
using Globals;



public static class GreenHouse
{
    public static string name = "greenhouse";


    // replaces main
    public static void start()
    {

        Console.WriteLine("You are in the Green House.");


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





