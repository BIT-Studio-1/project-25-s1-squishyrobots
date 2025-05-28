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
        // While player.input is not set to "back" do all this:
        List<string> itemList = new List<string>();

        if (Items.hasPurpleKey) itemList.Add("@Purple Key@");
        if (Items.hasBlueKey) itemList.Add("*Blue Key*");
        if (Items.hasGreenKey) itemList.Add("%Green Key%");
        if (Items.hasRedKey) itemList.Add("^Red Key^");
        if (Items.hasCrowbar) itemList.Add("$Crowbar$");
        if (Items.hasFuelCell) itemList.Add("Fuel Cell");
        if (Items.hasHandcuffs) itemList.Add("Handcuffs");
        if (Items.hasSword) itemList.Add("Sword");
        if (Items.hasWrench) itemList.Add("Wrench");
        if (Items.hasFuelCanister) itemList.Add("Fuel Canister");
        if (Items.hasMaintenanceKit) itemList.Add("Maintenance Kit");
        if (Items.hasOxygenTank) itemList.Add("Oxygen Tank");
        if (Items.hasParachute) itemList.Add("Parachute");
        if (Items.hasLaunchKey) itemList.Add("Launch Key");
        if (Items.hasWallMap) itemList.Add("Wall Map");
        if (Items.hasFirstAidKit) itemList.Add("First Aid Kit");
        if (Items.hasSurgicalTool) itemList.Add("Surgical Tool");
        if (Items.hasMedicineBottle) itemList.Add("Medicine Bottle");
        if (Items.hasShuttleFuel) itemList.Add("Shuttle Fuel");
        if (Items.hasBoardingPass) itemList.Add("$Boarding Pass$");

        int pageIndex = 0;
        const int pageSize = 9;

        do
        {
            Console.Clear();
            Format.PrintSpecial("\t *-------------------------------------------------*");
            Format.PrintSpecial("\t\t\t  *Inventory*");
            Format.PrintSpecial("\t *You have the following items in your inventory: *");
            Format.PrintSpecial("\t \t '$Important Items$' *-* 'Common Items'");
            Format.PrintSpecial($"\t *Page* {pageIndex+1}");
            Format.PrintSpecial("*\t-------------------------------------------------*");
            Format.PrintSpecial(" ");

            if (itemList.Count == 0)
            {
                Format.PrintSpecial("\t ^You have no items in your inventory.^");
            }
            else
            {
                var itemsToShow = itemList.Skip(pageIndex * pageSize).Take(pageSize).ToList();

                for (int i = 0; i < itemsToShow.Count; i++)
                {
                    Console.Write(itemsToShow[i].PadRight(25));
                    if ((i + 1) % 3 == 0 || i == itemsToShow.Count - 1) Console.WriteLine();
                }
                Console.WriteLine();
            }

            Format.PrintSpecial("\n-- *type* $'next'$ *to see more, or* $'back'$ *to return* --\n");

            Player.input = Console.ReadLine().ToLower();

            if (Player.input == "next")
            {
                pageIndex++;
                if (pageIndex * pageSize >= itemList.Count)
                {
                    pageIndex = 0;
                }
            }
            else if (Player.input != "back")
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
                            case "wrench":
                                if (Items.hasWrench)
                                {
                                    Format.PrintSpecial("A heavy tool, stained with oil and dented at the edges");
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

                            // Green House
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








 