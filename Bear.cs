using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    internal class Bear : IAnimal
    {
        public bool isGrizzly;

        public string Species { get; set; }

        public int Age { get; set; }

        public int CageNum { get; set; }



        public Bear()
        {

        }

        public Bear(int age, string species, int cageNum)
        {
            Age = age;
            Species = species;
            CageNum = cageNum;
        }

        public void GetAge(int age)
        {
            if (Species == "Bear")
            {
                this.Age = age;
            }
        }

        public void RequestUniqueCharacteristic()
        {
            Console.WriteLine("Is it a Grizzly bear?(true/false)");
            isGrizzly = Convert.ToBoolean(Console.ReadLine());
        }

        public void GetCageNum(int cageNum)
        {
            if (Species == "Bear")
            {
                this.CageNum = cageNum;
            }
        }

        public void GetDescription()
        {
            if (isGrizzly == true)
            {
                Console.WriteLine($"Cage {CageNum} contains a {Age}-year-old Grizzly {Species}.");
            }
            else
            {
                Console.WriteLine($"Cage {CageNum} contains a {Age}-year-old Non-Grizzly {Species}.");
            }
        }  
    }
}
