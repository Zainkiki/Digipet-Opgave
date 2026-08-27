using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    public static class Shop
    {
        public static void OpenShop(IPet pet)
        {
            string choiceW;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Items Shop ===");
                Console.WriteLine("1. Starter Weapon");
                Console.WriteLine("2. Buy");
                Console.WriteLine("3. Sell");
                Console.WriteLine("0. I will be back!");
                Console.Write("\nYour choice: ");

                choiceW = Console.ReadLine() ?? "0";
                Console.Clear();
                switch (choiceW)
                {
                    case "1":
                        StarterWeapon sWeapon = new StarterWeapon("Rusty Sword", 12, 4, 1 );
                        Console.WriteLine("Hello there youø're new here I see");
                        Thread.Sleep(1000);
                        Console.WriteLine("Take this as a welcome gift: " + sWeapon.Name);
                        Thread.Sleep(2000);
                        pet.RecieveItem(sWeapon);
                        break;

                    case "2":


                    default:
                        Console.WriteLine("Not a valid option. Try again.");
                        break;
                }

                if (choiceW != "0")
                {
                    Console.WriteLine("\nPress any key to go back...");
                    Console.ReadLine();
                }

            } while (choiceW != "0");
        }

    }
}
