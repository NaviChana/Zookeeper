using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo
{
    internal class Wolf : IAnimal
    {
        public int Speed { get; set; }

        public string Species { get; set; }

        public int Age { get; set; }

        public int CageNum { get; set; }



        public Wolf()
        {

        }

        public Wolf(int age, string species, int speed, int cageNum)
        {
            Age = age;
            Species = species;
            Speed = speed;
            CageNum = cageNum;

        }

        public void GetAge(int age)
        {
            if (Species == "Wolf")
            {
                this.Age = age;
            }
        }

        public void RequestUniqueCharacteristic()
        {
            Console.WriteLine("How fast can it run (in km/h)?");
            Speed = Convert.ToInt32(Console.ReadLine());
        }

        public void GetCageNum(int cageNum)
        {
            if (Species == "Wolf")
            {
                this.CageNum = cageNum;
            }
        }

        public void GetDescription()
        {
            Console.WriteLine($"Cage {CageNum} contains a {Age}-year-old {Species} that runs {Speed} km/h.");
        } 
    }
}
