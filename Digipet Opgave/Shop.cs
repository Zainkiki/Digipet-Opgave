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
                Console.WriteLine("2. Buy MidGameWeapon");
                Console.WriteLine("3. Buy EndGameWeapon");
                Console.WriteLine("4. Sell");
                Console.WriteLine("0. I will be back!");
                Console.Write("\nYour choice: ");

                choiceW = Console.ReadLine() ?? "0";
                Console.Clear();
                switch (choiceW)
                {
                    case "1":
                        StarterWeapon sWeapon = new StarterWeapon("Rusty Sword", 12, 1 );
                        Console.WriteLine("Hello there youø're new here I see");
                        Thread.Sleep(1000);
                        Console.WriteLine("Take this as a welcome gift: " + sWeapon.Name);
                        Thread.Sleep(2000);
                        pet.RecieveItem(sWeapon);
                        break;

                    case "2":
                        MidGameWeapon mWeapon = new MidGameWeapon("Great Sword", 35, 100);
                        Console.WriteLine("You have just bought a great Sword!");
                        Thread.Sleep(1000);
                        Console.WriteLine("Earn more gold and come back to buy the best Sword ever");
                        pet.RecieveItem(mWeapon);
                        break;

                    case "3":
                        EndGameWeapon eWeapon = new EndGameWeapon("Ultra Sword", 10000000, 100);
                        Console.WriteLine("You now have earned the rights to own the strongest sword ever!");
                        Thread.Sleep(1000);
                        Console.WriteLine("With this sword you can one shot any monster!");
                        pet.RecieveItem(eWeapon);
                        break;

                    case "4":
                        Console.WriteLine("I DIDN'T HAVE TIME");
                        break;

                    default:
                        Console.WriteLine("I will be back!");
                        break;
                }

                if (choiceW != "0")
                {
                    Console.ReadLine();
                }

            } while (choiceW != "0");
        }

    }
}
