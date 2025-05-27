using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Inventory
{
    public static string ShowInventory(Inventory inventory)
    {
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






    }
}