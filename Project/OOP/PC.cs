using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    enum Brand
    {
        MSI,
        ASUS,
        Gigabyte,
        Palit,
        HP
    }
    class PC
    {
        public Brand brand;
        public string motherBoard;
        public string GPU;
        public string CPU;
        public int RAM;
        public string boxName;
        public float value;
    }
}
