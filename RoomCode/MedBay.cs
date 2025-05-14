using System;
using Globals;



public static class MedBay
{
    public static string name = "medical bay";


    // replaces main
    public static void start()
    {
        Map.enter(name);

        Console.WriteLine("You are in the Medical Bay.");

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





