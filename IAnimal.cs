using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace TheZoo
{
    public interface IAnimal
    {
        public string Species { get; set; }
        public int Age { get; set; }
        public int CageNum { get; set; }

        void RequestUniqueCharacteristic();

        void GetDescription();
    }
}
