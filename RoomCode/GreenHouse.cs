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


        string description =
            "blank"

            ;


        string[] observations =
        {

        };



        Format.printConformed(description);

        for (int i = 0; i < observations.Length; i++)
        {
            Format.printSpecial(observations[i]);
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





