using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            

            //Created objects

            Lion lion = new Lion();
            Bear bear = new Bear();
            Wolf wolf = new Wolf();
            //List<IAnimal> animals = new List<IAnimal>() { lion, bear, wolf };


            for (int i = 1; i <= 3; i++)
            {
            cage = "Cage " + i;
            Console.WriteLine(cage);
            Console.WriteLine("What is the animals species?");
            species = Console.ReadLine();
                    if (species == ("bear") || species == "lion" || species == "wolf")
                    {
                        Console.WriteLine("How old is the animal?");
                        age = Convert.ToInt16(Console.ReadLine());
                            if (species == "lion")
                            {
                            lion.RequestUniqueCharacteristic();
                            Console.WriteLine();
                            }
                            else if (species == "bear")
                            {
                            bear.RequestUniqueCharacteristic();
                            Console.WriteLine();
                            }
                            else if (species == "olf")
                            {
                            wolf.RequestUniqueCharacteristic();
                            Console.WriteLine();
                            }
                            else
                            {
                            continue;
                            }
                    }       
            }
            lion.GetDescription();
            bear.GetDescription();
            wolf.GetDescription();
            Console.WriteLine();

        }
    }
}
