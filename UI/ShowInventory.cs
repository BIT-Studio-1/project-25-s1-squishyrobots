using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Globals;

internal class Inventory
{
    public static void ShowInventory()
    {

        do
        {

            Format.PrintSpecial("-------------------------------------------------");
            Format.PrintSpecial("You have the following items in your inventory: ");
            Format.PrintSpecial("-------------------------------------------------");



            // Starting Items
            if (Items.hasRedKey == true)
            {
                Format.PrintSpecial("Red Key");
            }

            // Brig Items
            if (Items.hasHandcuffs == true)
            {
                Format.PrintSpecial("Handcuffs");
            }

            // Captain Quarters Items
            if (Items.hasRedKey == true)
            {
                Format.PrintSpecial("Red Key");
            }

            // Engine Room Items
            if (Items.hasWrench == true)
            {
                Format.PrintSpecial("Wrench");
            }
            if (Items.hasFuelCanister == true)
            {
                Format.PrintSpecial("Fuel Canister");
            }
            if (Items.hasMaintenanceKit == true)
            {
                Format.PrintSpecial("Maintenance Kit");
            }

            //Escape Pods
            if (Items.hasOxygenTank == true)
            {
                Format.PrintSpecial("Oxygen Tank");
            }
            if (Items.hasParachute == true)
            {
                Format.PrintSpecial("Parachute");
            }
            if (Items.hasLaunchKey == true)
            {
                Format.PrintSpecial("Launch Key");
            }

            // Hallway Items
            if (Items.hasWallMap == true)
            {
                Format.PrintSpecial("Wall Map");
            }

            // Med Bay Items
            if (Items.hasFirstAidKit == true)
            {
                Format.PrintSpecial("First Aid Kit");
            }
            if (Items.hasSurgicalTool == true)
            {
                Format.PrintSpecial("Surgical Tool");
            }
            if (Items.hasMedicineBottle == true)
            {
                Format.PrintSpecial("Medicine Bottle");
            }
            if (Items.hasShuttleFuel == true)
            {
                Format.PrintSpecial("Shuttle Fuel");
            }

            // If no items are in the inventory
            if (!Items.hasRedKey && !Items.hasGreenKey && !Items.hasCrowbar && !Items.hasFuelCell && !Items.hasPurpleKey && !Items.hasBlueKey && !Items.hasHandcuffs
                && !Items.hasSword && !Items.hasWrench && !Items.hasFuelCanister && !Items.hasMaintenanceKit && !Items.hasOxygenTank && !Items.hasLaunchKey && !Items.hasWallMap
                && !Items.hasFirstAidKit && !Items.hasSurgicalTool && !Items.hasMaintenanceKit && !Items.hasShuttleFuel)
            {
                Format.PrintSpecial("You have no items in your inventory.");
            }

            // Instructions for exit
            Format.PrintSpecial("\n-- type 'back' to return --\n");


            // Wait for input
            Player.input = Console.ReadLine();


            // Player input for each item & back
            if (Player.input != "back")
            {
                switch (Player.input)
                {

                    case "back":
                        break;
                    case "red key":
                        Console.Clear();
                        Format.PrintSpecial("A silver key card with two ^red stripes^ across the top.");
                        Thread.Sleep(5000);
                        break;
                    case "green key":
                        Console.Clear();
                        Format.PrintSpecial("You have a green key.");
                        Thread.Sleep(5000);
                        break;
                    case "crowbar":
                        Console.Clear();
                        Format.PrintSpecial("You have a crowbar.");
                        Thread.Sleep(5000);
                        break;
                    case "fuel cell":
                        Console.Clear();
                        Format.PrintSpecial("A beveled cylinder with a pulsing *blue bar* across its length. You get the feeling it still has an abundance of power stored within.");
                        Thread.Sleep(5000);
                        break;
                    case "blue key":
                        Console.Clear();
                        Format.PrintSpecial("You have a blue key");
                        Thread.Sleep(5000);
                        break;
                    case "purple key":
                        Console.Clear();
                        Format.PrintSpecial("You have a purple key");
                        Thread.Sleep(5000);
                        break;
                    default:
                        Console.Clear();
                        Format.PrintSpecial("^Unknown Item^");
                        Thread.Sleep(5000);
                        break;

                }
            }

            Console.Clear();


        } while (Player.input != "back");
    }
}








 