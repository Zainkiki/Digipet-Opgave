using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Digipet_Opgave
{
    public static class PetManager
    {
        public static void PromptStart() // first menu where the user can chose their pet or to load saved pets stats 
        {


            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Choose your pet:");
                Console.WriteLine("1: Maxi the Dog:");
                Console.WriteLine("2: Kiwi the Cat:");
                Console.WriteLine("3: Load pet from file");
                Console.Write("\nYour choice: ");


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
                else if (choice == "3")
                {
                    LoadPet();
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
        public static void PromptMenu() // this is where the user can chose what to do with their pet 
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
                Console.WriteLine("7. Shop");
                Console.WriteLine("8. Save Pet stats");
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
                        Monster Rat = new Monster("Big poison Rat", 20, 300); // can change monster stats from here
                        pet.Fight(Rat);
                        break;

                    case "6":
                        pet.Sleep();
                        break;

                    case "7":
                        Shop.OpenShop(pet);
                        break;

                    case "8":
                        Console.WriteLine("Save Pet stats");
                        SavePet();
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
        public static void SavePet() // a method to save the pet stats to a text file found it on Reddit
        {
            File.WriteAllText("pet.txt",
                pet.GetType().Name + "\n" +
                pet.Name + "\n" +
                pet.Hunger + "\n" +
                pet.Happiness + "\n" +
                pet.Health + "\n" +
                pet.AttackPower + "\n" +
                pet.Level + "\n" +
                pet.Gold);
        }

        public static void LoadPet() // this is how we load the pet stats
        {
            string[] data = File.ReadAllLines("pet.txt");

            if (data[0] == "Dog")
                pet = new Dog(data[1]);
            else
                pet = new Cat(data[1]);

            pet.Hunger = int.Parse(data[2]);
            pet.Happiness = int.Parse(data[3]);
            pet.Health = int.Parse(data[4]);
            pet.AttackPower = int.Parse(data[5]);
            pet.Level = int.Parse(data[6]);
            pet.Gold = int.Parse(data[7]);

        }
    }
}
