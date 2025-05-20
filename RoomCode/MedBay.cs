using System;
using Globals;



public static class MedBay
{
    public static string name = "medical bay";


    // replaces main
    public static void start()
    {

        Console.WriteLine("You are in the Medical Bay.");


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
            case "first aid kit":
                break;

            case "surgical tools":
                break;

            case "medical scanner":
                break;

            case "medical bottle":
                break;

            case "stretcher":
                break;


        }
        Console.WriteLine();






    }




}





