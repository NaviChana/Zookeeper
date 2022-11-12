using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    internal class Lion:IAnimal
    {
        
        public string Species { get; set; }

        public int Age { get; set; }

        public string ManeColour { get; set; }

        public int CageNum { get; set; }



        public Lion()
        {

        }

        public Lion(int age, string species, string maneColour, int cageNum)
        {
            Species = species;
            Age = age;
            ManeColour = maneColour;
            CageNum = cageNum;
        }

        public void GetAge(int age)
        {
            if (Species == "Lion")
            {
                this.Age = age;
            }
        }

        public void RequestUniqueCharacteristic()
        {  
            Console.WriteLine("What colour is the Lions mane?");
            ManeColour = Console.ReadLine();
        }

        public void GetCageNum(int cageNum)
        {
            if (Species == "Lion")
            {
                this.CageNum = cageNum;
            }
        }

        public void GetDescription()
        {
            Console.WriteLine($"Cage {CageNum} contains a {Age}-year-old {Species} with a {ManeColour} mane.");
        }
    }
}
