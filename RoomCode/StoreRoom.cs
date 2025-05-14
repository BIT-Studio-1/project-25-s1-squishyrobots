using System;
using Globals;



public static class StoreRoom
{
    public static string name = "store room";


    // replaces main
    public static void start()
    {
        Map.enter(name);



        Console.WriteLine("You are in the Store Room.");

        Player.GetInput();

        switch (Player.input)
        {
            case "spare parts kits":
                break;

            case "emergecy rations":
                break;

            case "tool boxs":
                break;

            case "oxygen canisters":
                break;

            case "storage create":
                break;
            case "boxes":
                break;



        }
        Console.WriteLine();


        switch (Player.input.ToLower())
        {
            case "shuttlue bay":
                Console.WriteLine("You choose the shuttlue bay");
                EscapePods.start();
                break;
            case "lab":
                Console.WriteLine("You choose the lab");
                ShuttleBay.start();
                break;

            default:
                Console.WriteLine("Invalid option");
                break;
        }







    }




}





