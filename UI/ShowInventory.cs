using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Globals;
using Microsoft.VisualBasic;

internal class Inventory
{
    public static void ShowInventory()
    {

        do
        {

            Format.PrintSpecial("*-------------------------------------------------*");
            Format.PrintSpecial("*You have the following items in your inventory: * ");
            Format.PrintSpecial("*-------------------------------------------------*");



            if (Items.hasPurpleKey == true)
            {
                Format.PrintSpecial("@Purple Key@");
            }
            if (Items.hasBlueKey == true)
            {
                Format.PrintSpecial("*Blue Key*");
            }
            if (Items.hasHandcuffs == true)
            {
                Format.PrintSpecial("%Green Key%");
            }
            if (Items.hasCrowbar == true)
            {
                Format.PrintSpecial("$Crowbar$");
            }
            if (Items.hasFuelCell == true)
            {
                Format.PrintSpecial("Fuel Cell");
            }


            // Brig Items
            if (Items.hasHandcuffs == true)
            {
                Format.PrintSpecial("Handcuffs");
            }

            // Captain Quarters Items
            if (Items.hasRedKey == true)
            {
                Format.PrintSpecial("^Red Key^");
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
                Format.PrintSpecial("^You have no items in your inventory.^");
            }
                       

            // Instructions for exit
            Format.PrintSpecial("\n-- type 'back' to return --\n");


            // Wait for input
            Player.input = Console.ReadLine();


            // Player input for each item & back
            if (Player.input != "back")
            {
                Console.Clear();

                switch (Player.input)
                {

                                

                            // Brig Items
                            case "handcuffs":
                                if (Items.hasHandcuffs)
                                {
                                    Format.PrintSpecial("The Handcuffs seems to be in working condition");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;
                            case "crowbar":
                                if (Items.hasCrowbar)
                                {
                                    Format.PrintSpecial("A worn $crowbar$, sturdy enough to pry open doors—or defend yourself.");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Captain Quarters Items
                            case "sword":
                                if (Items.hasSword)
                                {
                                    Format.PrintSpecial("A ceremonial sword that was once mounted on the wall, sharp despite its ornamental purpose");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Engine Room Items
                            case "fuel Canister":
                                if (Items.hasFuelCanister)
                                {
                                    Format.PrintSpecial("The canister sloshes when moved - there's still some fuel left");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "maintenance Kit":
                                if (Items.hasMaintenanceKit)
                                {
                                    Format.PrintSpecial("Full of wires, fuses and pilers");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Escape Pod Items
                            case "oxygen Tank":
                                if (Items.hasOxygenTank)
                                {
                                    Format.PrintSpecial("A nearly full tank, marked for emergency use only");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "parachute":
                                if (Items.hasParachute)
                                {
                                    Format.PrintSpecial("A compact parachute pack with signs of recent handling");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "launch key":
                                if (Items.hasLaunchKey)
                                {
                                    Format.PrintSpecial("A key with a tag attached reading \"ESC-001");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Green Room
                            case "green key":
                                if (Items.hasGreenKey)
                                {
                                    Format.PrintSpecial("A black key card with two %green stripes% across the top.");
                                    Thread.Sleep(5000);
                                }
                            else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                            break;

                            // Hallway Items
                            case "wall map":
                                 if (Items.hasWallMap)
                                 {
                                     Format.PrintSpecial("A faded map showing key ship sections. Some labels are smeared");
                                     Thread.Sleep(5000);
                                 }
                                 else
                                 {
                                     Format.PrintSpecial("Item not in your inventory");
                                     Thread.Sleep(5000);
                                 }
                                 break;

                            // Lab Items
                            case "purple key":
                                if (Items.hasPurpleKey)
                                {
                                    Format.PrintSpecial("A silver key card with two @purple stripes@ across the top.");
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Medbay Items
                            case "first aid kit":
                                if (Items.hasFirstAidKit)
                                {
                                    Format.PrintSpecial("Standard supplies — gauze, bandages, antiseptic");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "surgical tool":
                                if (Items.hasSurgicalTool)
                                {
                                    Format.PrintSpecial("A clean scalpel, sharp and ready");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "medicine bottle":
                                if (Items.hasMedicineBottle)
                                {
                                    Format.PrintSpecial("Label worn off - contents unknown");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Shuttle Bay Items
                            case "shuttle fuel":
                                if (Items.hasShuttleFuel)
                                {
                                    Format.PrintSpecial("Sealed drum labeled: \"Volatile – Handle with care\"");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;
                            case "fuel cell":
                                if (Items.hasFuelCell)
                                {
                                    Format.PrintSpecial("A beveled cylinder with a pulsing *blue bar* across its length. You get the feeling it still has an abundance of power stored within.");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;
                            // Store Room Items
                            case "red key":
                                if (Items.hasRedKey)
                                {
                                    Format.PrintSpecial("A silver key card with two ^red stripes^ across the top.");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;
                            case "blue key":
                                if (Items.hasBlueKey)
                                {
                                    Format.PrintSpecial("A silver key card with two *blue stripes* across the top.");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            default:
                                Format.PrintSpecial("^Unknown Input^");
                                Thread.Sleep(3000);
                                break;
                            }                             
                }
            
            Console.Clear();


        } while (Player.input != "back");
    }
}








 