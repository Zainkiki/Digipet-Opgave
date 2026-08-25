using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Digipet_Opgave
{
    public static class PetManager
    {
        public static void PromptStart()
        {


            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Choose your pet:");
                Console.WriteLine("1: Maxi the Dog:");
                Console.WriteLine("2: Kiwi the Cat:");


                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    pet = new Dog("Maxi");
                    break;
                }

                else if (choice == "2")
                {
                    pet = new Cat("Kiwi");
                    break;
                }
                else
                {
                    Console.WriteLine("\nPress any key to go back...");
                    Console.ReadLine();
                }
            }
        }

        static IPet pet;

        public static void PromptMenu()
        {
            string choice;
            
            Timer timer = new Timer(pet.Update, null, 10000, 10000);

            do
            {
                Console.Clear();
                Console.WriteLine("=== Pet Actions ===");
                Console.WriteLine("1. List all of the stats");
                Console.WriteLine("2. Train");
                Console.WriteLine("3. Feed");
                Console.WriteLine("4. Play");
                Console.WriteLine("5. Fight");
                Console.WriteLine("6. Sleep");
                Console.WriteLine("0. Never mind I don't wanna be here");
                Console.Write("\nYour choice: ");

                choice = Console.ReadLine() ?? "0";
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        pet.Print();
                        break;

                    case "2":
                        pet.Train();
                        break;

                    case "3":
                        pet.Feed();
                        break;

                    case "4":
                        pet.Play();
                        break;

                    case "5":
                        Monster Rat = new Monster("Big poison Rat", 12, 300);
                        pet.Fight(Rat);
                        break;

                    case "6":
                        pet.Sleep();
                        break;

                    default:
                        Console.WriteLine("Not a valid option. Try again.");
                        break;
                }
                    
                if (choice != "0")
                {
                    Console.WriteLine("\nPress any key to go back...");
                    Console.ReadLine();
                }

            } while (choice != "0");
        }
        
    }
}
