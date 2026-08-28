using System;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    public static class Shop
    {
        public static void OpenShop(IPet pet) // remember to Make a shop where the user cna buy items depending on their elvel and Gold 
        {
            string choiceW;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Items Shop ===");
                Console.WriteLine("1. Welcome Gift");
                Console.WriteLine("2. Level 5 Gift");
                Console.WriteLine("3. Level 20 Gift");
                Console.WriteLine("0. I will be back!");
                Console.Write("\nYour choice: ");

                choiceW = Console.ReadLine() ?? "0";
                Console.Clear();
                switch (choiceW)
                {
                    case "1":
                        StarterWeapon sWeapon = new StarterWeapon("Rusty Sword", 12, 1 ); // first item stats can be changed here 
                        Console.WriteLine("Hello there youø're new here I see");
                        Thread.Sleep(1000);
                        Console.WriteLine("Take this as a welcome gift: " + sWeapon.Name);
                        Thread.Sleep(2000);
                        pet.RecieveItem(sWeapon);
                        break;

                    case "2":
                        if (pet.Level >= 5 && pet.Gold == 300)// if the suer is level 5 and has 150 or more he can buy this item
                        {
                            MidGameWeapon mWeapon = new MidGameWeapon("Great Sword", 35, 100); //statts change here
                            Console.WriteLine("You have just bought a great Sword!");
                            Thread.Sleep(1000);
                            Console.WriteLine("Earn more gold and come back to buy the best Sword ever");
                            pet.RecieveItem(mWeapon);
                            pet.Gold = pet.Gold - 150;
                        }
                        else
                        {
                            Console.WriteLine("To buy this Sword you would need to reach level 5 and pay 150 gold");
                        }
                        break;

                    case "3":
                        if (pet.Level >= 20 && pet.Gold == 1000) // level 20 and 1000 gold 
                        {
                            EndGameWeapon eWeapon = new EndGameWeapon("Ultra Sword", 10000000, 100); //stats change here
                            Console.WriteLine("You now have earned the rights to own the strongest sword ever!");
                            Thread.Sleep(1000);
                            Console.WriteLine("With this sword you can one shot any monster!");
                            pet.RecieveItem(eWeapon);
                            pet.Gold = pet.Gold - 1000;
                        }
                        else
                        {
                            Console.WriteLine("To buy this Sword you would need to reach level 20 and pay 1000 gold");
                        }
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
