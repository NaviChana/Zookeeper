using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheZoo;

namespace TheZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //variable initialization
            string cage;
            string species;
            int age;

            //Created objects within a list
            List<IAnimal> list = new List<IAnimal>();
            IAnimal lion = new Lion();
            IAnimal bear = new Bear();
            IAnimal wolf = new Wolf();

            list.Add(lion);
            list.Add(bear);
            list.Add(wolf);


            // Start of program, prompts user to input animal attributes
            for (int i = 1; i <= 3; i++)
            {

                cage = "Cage " + i;
                Console.WriteLine(cage);

                Console.WriteLine("What is the animals species? (Please capitalize the first letter)");
                species = Console.ReadLine();
                
                    
                if (species == "Lion" || species == "Bear" || species == "Wolf")
                {    
                Console.WriteLine("How old is the animal?");
                Convert.ToInt16(Console.ReadLine());  
                } 
                else
                {
                    Console.WriteLine("Please enter Lion, Bear, or Wolf.");
                    Console.WriteLine("What is the animals species? (Please capitalize the first letter)");
                    species = Console.ReadLine();
                    Console.WriteLine("How old is the animal?");
                    age = Convert.ToInt32(Console.ReadLine());
                }

                if (species == "Lion")
                {
                    lion.RequestUniqueCharacteristic();
                    Console.WriteLine();
                }
                else if (species == "Bear")
                {
                    bear.RequestUniqueCharacteristic();
                    Console.WriteLine();
                }
                else if (species == "Wolf")
                {
                    wolf.RequestUniqueCharacteristic();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Something went wrong. Please try again.");
                }
            }

            Console.WriteLine("-----------------------------------");

            // Prints a summary from each class (Bear, Lion, Wolf)
            foreach (IAnimal item in list)
            {
                item.GetDescription();
            }
            Console.ReadLine();

            Console.WriteLine("Cages 1 - 3 have been updated.");
        }
    }
}