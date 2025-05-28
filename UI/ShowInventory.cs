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

            Format.PrintSpecial("*-------------------------------------------------*");
            Format.PrintSpecial("*You have the following items in your inventory: * ");
            Format.PrintSpecial("*-------------------------------------------------*");



            // Starting Items
            
            if (Items.hasPurpleKey == true)
            {
                Format.PrintSpecial("Purple Key");
            }
            if (Items.hasBlueKey == true)
            {
                Format.PrintSpecial("Blue Key");
            }
            if (Items.hasHandcuffs == true)
            {
                Format.PrintSpecial("Green Key");
            }
            if (Items.hasCrowbar == true)
            {
                Format.PrintSpecial("Crowbar");
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

                    // Starting Items
                              case "Red Key":
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

                            case "Green Key":
                                if (Items.hasGreenKey)
                                {
                                    Format.PrintSpecial("You have a green key.");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "Crowbar":
                                if (Items.hasCrowbar)
                                {
                                    Format.PrintSpecial("You have a crowbar.");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "Fuel Cell":
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

                            case "Blue Key":
                                if (Items.hasBlueKey)
                                {
                                    Format.PrintSpecial("You have a blue key");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "Purple Key":
                                if (Items.hasPurpleKey)
                                {
                                    Format.PrintSpecial("You have a purple key");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Brig Items
                            case "Handcuffs":
                                if (Items.hasHandcuffs)
                                {
                                    Format.PrintSpecial("You have handcuffs");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Captain Quarters Items
                            case "Sword":
                                if (Items.hasSword)
                                {
                                    Format.PrintSpecial("You have a sword");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Engine Room Items
                            case "Fuel Canister":
                                if (Items.hasFuelCanister)
                                {
                                    Format.PrintSpecial("You have a fuel canister");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "Maintenance Kit":
                                if (Items.hasMaintenanceKit)
                                {
                                    Format.PrintSpecial("You have a maintenance kit");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Escape Pod Items
                            case "Oxygen Tank":
                                if (Items.hasOxygenTank)
                                {
                                    Format.PrintSpecial("You have an oxygen tank");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "Parachute":
                                if (Items.hasParachute)
                                {
                                    Format.PrintSpecial("You have a parachute");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "Launch Key":
                                if (Items.hasLaunchKey)
                                {
                                    Format.PrintSpecial("You have a launch key");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Hallway Items
                            case "Wall Map":
                                if (Items.hasWallMap)
                                {
                                    Format.PrintSpecial("You have a wall map");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Medbay Items
                            case "First Aid Kit":
                                if (Items.hasFirstAidKit)
                                {
                                    Format.PrintSpecial("You have a first aid kit");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "Surgical Tool":
                                if (Items.hasSurgicalTool)
                                {
                                    Format.PrintSpecial("You have a surgical tool");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            case "Medicine Bottle":
                                if (Items.hasMedicineBottle)
                                {
                                    Format.PrintSpecial("You have a medicine bottle");
                                    Thread.Sleep(5000);
                                }
                                else
                                {
                                    Format.PrintSpecial("Item not in your inventory");
                                    Thread.Sleep(5000);
                                }
                                break;

                            // Shuttle Bay Items
                            case "Shuttle Fuel":
                                if (Items.hasShuttleFuel)
                                {
                                    Format.PrintSpecial("You have shuttle fuel");
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








 