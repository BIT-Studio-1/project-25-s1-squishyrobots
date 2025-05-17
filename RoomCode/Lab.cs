using System;
using Globals;



public static class Lab
{
    public static string name = "lab";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Lab.");



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
            case "test tube":
                break;

            case "microscope":
                break;

            case "experiment log":
                break;

            case "chemical flask":
                break;

            case "data pad":
                break;


        }
        Console.WriteLine();

        switch (Player.input.ToLower())
        {
            case "storege":
                Console.WriteLine("You choose the storege");
                EscapePods.start();
                break;
            case "greenhouse":
                Console.WriteLine("You choose the shuttle bay");
                ShuttleBay.start();
                break;

            default:
                Console.WriteLine("Invalid option");
                break;
        }






    }




}





