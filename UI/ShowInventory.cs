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
    private static string PadVisible(string item, int totalWidth)
    {
        // Remove formatting symbols to calculate visible length
        string visible = item.Replace("@", "")
                             .Replace("*", "")
                             .Replace("%", "")
                             .Replace("^", "")
                             .Replace("$", "");
        int visibleLength = visible.Length;
        int spacesToAdd = totalWidth - visibleLength;
        if (spacesToAdd < 0) spacesToAdd = 0;
        return item + new string(' ', spacesToAdd);
    }

    public static void ShowInventory()
    {
        List<string> itemList = new List<string>();

        // Add items the player has to the list with their special formatting
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

        int pageIndex = 0; // Current page of inventory
        const int pageSize = 9; // Number of items per page

        do
        {

            // Display inventory header
            Format.PrintSpecial("\t *-------------------------------------------------*");
            Format.PrintSpecial("\t\t\t  *Inventory*");
            Format.PrintSpecial("\t *You have the following items in your inventory: *");
            Format.PrintSpecial("\t \t $Important Items$ *-* Common Items");
            Format.PrintSpecial($"\t *Page* {pageIndex + 1}");
            Format.PrintSpecial("*\t-------------------------------------------------*");
            Format.PrintSpecial(" ");

            if (itemList.Count == 0)
            {
                Format.PrintSpecial("\t ^You have no items in your inventory.^");
            }
            else
            {
                // Show current page of items
                var itemsToShow = itemList.Skip(pageIndex * pageSize).Take(pageSize).ToList();

                // Loop through items 3 at a time to build rows
                for (int i = 0; i < itemsToShow.Count; i += 3)
                {
                    List<string> rowItems = new List<string>();

                    for (int j = 0; j < 3; j++)
                    {
                        if (i + j < itemsToShow.Count)
                        {
                            // Use PadVisible to pad based on visible length, then add to row
                            rowItems.Add(PadVisible(itemsToShow[i + j], 25));
                        }
                    }

                    // Join with spaces between columns for clarity
                    string line = string.Join("   ", rowItems);
                    Format.PrintSpecial(line.TrimEnd());
                }

                
            }

            // Prompt for navigation or interaction
            Format.PrintSpecial("-- *type* $'next'$ *to see next page, or* $'back'$ *to return* --");
            Format.PrintSpecial("-- *or type an item name to inspect it* --");

            //Player.input = Console.ReadLine().ToLower().Trim();
            Player.GetInput(); // Get input from player


            if (Player.input == "next")
            {
                // Advance page, loop back if past end
                pageIndex++;
                if (pageIndex * pageSize >= itemList.Count)
                    pageIndex = 0;
            }
            else if (Player.input != "back")
            {
                Console.Clear();
                // Match input against known item names
                switch (Player.input)
                {
                    case "handcuffs":
                        if (Items.hasHandcuffs)
                            Format.PrintSpecial("The handcuffs seem to be in working condition.");
                        else PrintMissing();
                        break;

                    case "crowbar":
                        if (Items.hasCrowbar)
                            Format.PrintSpecial("A worn $crowbar$ - sturdy enough to pry open doors or defend yourself.");
                        else PrintMissing();
                        break;

                    case "sword":
                        if (Items.hasSword)
                            Format.PrintSpecial("A ceremonial sword that was once mounted on the wall, sharp despite its ornamental purpose.");
                        else PrintMissing();
                        break;

                    case "fuel canister":
                        if (Items.hasFuelCanister)
                            Format.PrintSpecial("The canister sloshes when moved — there's still some fuel left.");
                        else PrintMissing();
                        break;

                    case "maintenance kit":
                        if (Items.hasMaintenanceKit)
                            Format.PrintSpecial("Full of wires, fuses and pliers.");
                        else PrintMissing();
                        break;

                    case "wrench":
                        if (Items.hasWrench)
                            Format.PrintSpecial("A heavy tool, stained with oil and dented at the edges.");
                        else PrintMissing();
                        break;

                    case "oxygen tank":
                        if (Items.hasOxygenTank)
                            Format.PrintSpecial("A nearly full tank, marked for emergency use only.");
                        else PrintMissing();
                        break;

                    case "parachute":
                        if (Items.hasParachute)
                            Format.PrintSpecial("A compact parachute pack with signs of recent handling.");
                        else PrintMissing();
                        break;

                    case "launch key":
                        if (Items.hasLaunchKey)
                            Format.PrintSpecial("A key with a tag attached reading \"ESC-001\".");
                        else PrintMissing();
                        break;

                    case "green key":
                        if (Items.hasGreenKey)
                            Format.PrintSpecial("A black key card with two %green stripes% across the top.");
                        else PrintMissing();
                        break;

                    case "wall map":
                        if (Items.hasWallMap)
                            Format.PrintSpecial("A faded map showing key ship sections. Some labels are smeared.");
                        else PrintMissing();
                        break;

                    case "purple key":
                        if (Items.hasPurpleKey)
                            Format.PrintSpecial("A silver key card with two @purple stripes@ across the top.");
                        else PrintMissing();
                        break;

                    case "first aid kit":
                        if (Items.hasFirstAidKit)
                            Format.PrintSpecial("Standard supplies — gauze, bandages, antiseptic.");
                        else PrintMissing();
                        break;

                    case "surgical tool":
                        if (Items.hasSurgicalTool)
                            Format.PrintSpecial("A clean scalpel, sharp and ready.");
                        else PrintMissing();
                        break;

                    case "medicine bottle":
                        if (Items.hasMedicineBottle)
                            Format.PrintSpecial("Label worn off — contents unknown.");
                        else PrintMissing();
                        break;

                    case "shuttle fuel":
                        if (Items.hasShuttleFuel)
                            Format.PrintSpecial("Sealed drum labeled: \"Volatile – Handle with care\".");
                        else PrintMissing();
                        break;

                    case "fuel cell":
                        if (Items.hasFuelCell)
                            Format.PrintSpecial("A beveled cylinder with a pulsing *blue bar* across its length. Seems full.");
                        else PrintMissing();
                        break;

                    case "red key":
                        if (Items.hasRedKey)
                            Format.PrintSpecial("A silver key card with two ^red stripes^ across the top.");
                        else PrintMissing();
                        break;

                    case "blue key":
                        if (Items.hasBlueKey)
                            Format.PrintSpecial("A silver key card with two *blue stripes* across the top.");
                        else PrintMissing();
                        break;
                    case "boarding pass":
                        if (Items.hasBoardingPass)
                            Format.PrintSpecial("It's a tattered boarding pass. The first name is burned through but last name %'Collins'% " +
                                "They seemed to be traveling beyond the station and just stopped for a refuel." +
                                "You could probably use this to gain access to a few more areas");
                        else PrintMissing();
                        break;

                    default:
                        Format.PrintSpecial("^Unknown Input^");
                        break;
                }


                Format.PrintSpecial("Press %'enter'% to continue.", 15, ConsoleColor.DarkGray);
                Player.GetInput();
            }

        } while (Player.input != "back"); // Loop until player types 'back'
    }

    // Helper method for unavailable items
    private static void PrintMissing()
    {
        Format.PrintSpecial("Item not in your inventory.");
    }
}








