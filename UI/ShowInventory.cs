using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Globals;

internal class Inventory
{
    public static string ShowInventory(Inventory inventory)
    {

        do
        {

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("You have the following items in your inventory: ");
            Console.WriteLine("-------------------------------------------------");



            // Starting Items
            if (Items.hasRedKey == true)
            {
                Console.WriteLine("Red Key");
            }

            // Brig Items
            if (Items.hasHandcuffs == true)
            {
                Console.WriteLine("Handcuffs");
            }

            // Captain Quarters Items
            if (Items.hasRedKey == true)
            {
                Console.WriteLine("Red Key");
            }

            // Engine Room Items
            if (Items.hasWrench == true)
            {
                Console.WriteLine("Wrench");
            }
            if (Items.hasFuelCanister == true)
            {
                Console.WriteLine("Fuel Canister");
            }
            if (Items.hasMaintenanceKit == true)
            {
                Console.WriteLine("Maintenance Kit");
            }

            //Escape Pods
            if (Items.hasOxygenTank == true)
            {
                Console.WriteLine("Oxygen Tank");
            }
            if (Items.hasParachute == true)
            {
                Console.WriteLine("Parachute");
            }
            if (Items.hasLaunchKey == true)
            {
                Console.WriteLine("Launch Key");
            }

            // Hallway Items
            if (Items.hasWallMap == true)
            {
                Console.WriteLine("Wall Map");
            }

            // Med Bay Items
            if (Items.hasFirstAidKit == true)
            {
                Console.WriteLine("First Aid Kit");
            }
            if (Items.hasSurgicalTool == true)
            {
                Console.WriteLine("Surgical Tool");
            }
            if (Items.hasMedicineBottle == true)
            {
                Console.WriteLine("Medicine Bottle");
            }
            if (Items.hasShuttleFuel == true)
            {
                Console.WriteLine("Shuttle Fuel");
            }

            // if no items are in the inventory
            if (!Items.hasRedKey && !Items.hasGreenKey && !Items.hasCrowbar && !Items.hasFuelCell && !Items.hasPurpleKey && !Items.hasBlueKey && !Items.hasHandcuffs
                && !Items.hasSword && !Items.hasWrench && !Items.hasFuelCanister && !Items.hasMaintenanceKit && !Items.hasOxygenTank && !Items.hasLaunchKey && !Items.hasWallMap
                && !Items.hasFirstAidKit && !Items.hasSurgicalTool && !Items.hasMaintenanceKit && !Items.hasShuttleFuel)
            {
                Console.WriteLine("You have no items in your inventory.");
            }

            // instructions for exit
            Console.WriteLine("\n-- type 'back' to return --\n");

            
            // Player input for each item & back
            if (Player.input != "back")
            {
                switch (Player.input)
                {
                    case "red key":
                        Format.PrintSpecial("A silver key card with two ^red stripes^ across the top.");
                        break;
                    case "green key":
                        Format.PrintSpecial("You have a green key.");
                        break;
                    case "crowbar":
                        Format.PrintSpecial("You have a crowbar.");
                        break;
                    case "fuel cell":
                        Format.PrintSpecial("A beveled cylinder with a pulsing *blue bar* across its length. You get the feeling it still has an abundance of power stored within.");
                        break;
                    case "blue key":
                        Format.PrintSpecial("You have a blue key");
                        break;
                    case "purple key":
                        Format.PrintSpecial("You have a purple key");
                        break;
                    default:
                        Format.PrintSpecial("^Unknown Item^");
                        break;

                }

                Format.PrintSpecial("\nPress %'enter'% to return");
                Console.ReadLine();


            } while (Player.input != "back");







        }
}