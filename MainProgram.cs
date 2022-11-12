using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TheZoo;

namespace TheZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Variable initialization
            string cage;
            int cageNum;
            string species;
            int age;

            //Created objects, a list, and added the objects to the list

            List<IAnimal> list = new();
            Lion lion = new();
            Bear bear = new();
            Wolf wolf = new();

            list.Add(lion);
            list.Add(bear);
            list.Add(wolf);

            
            // Start of program, prompts user to input animal attributes
            for (cageNum = 1; cageNum <= 3; cageNum++)
            {
                cage = "Cage " + cageNum;
                Console.WriteLine(cage);

                Console.WriteLine("What is the animals species? (Please capitalize the first letter)");
                species = Console.ReadLine();

                // Assigns the animal classes species with the users input
                switch (species)
                    {
                        case "Bear":
                            bear.Species = species;
                            break;
                        case "Wolf":
                            wolf.Species = species;
                            break;
                        case "Lion":
                            lion.Species = species;
                            break;
                }    
                
                // Requests the age of the animal
                if (species == "Lion" || species == "Bear" || species == "Wolf")
                {    
                Console.WriteLine("How old is the animal?");
                age = Convert.ToInt16(Console.ReadLine());
                        // Assigns the animal classes age with the users input
                    
                    switch (species)
                    {
                        case "Bear":
                            bear.GetAge(age);
                            break;
                        case "Wolf":
                            wolf.GetAge(age);
                            break;
                        case "Lion":
                            lion.GetAge(age);
                            break;
                    } 
                } 

                // Asks user to input the animals unique characteristic by calling the method
                switch (species)
                    {
                        case "Bear":
                            bear.RequestUniqueCharacteristic();
                            bear.GetCageNum(cageNum);
                            Console.WriteLine();
                            break;
                        case "Wolf":
                            wolf.RequestUniqueCharacteristic();
                            wolf.GetCageNum(cageNum);
                            Console.WriteLine();
                            break;
                        case "Lion":
                            lion.RequestUniqueCharacteristic();
                            lion.GetCageNum(cageNum);
                            Console.WriteLine();
                            break;
                    }

                Console.WriteLine("============================================");

                if (cageNum == 3)
                {
                    foreach (IAnimal animal in list)
                    {
                        animal.GetDescription();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Cages 1 - 3 have been updated.");
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}