using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    
    class Program
    {

        static PC GetPC()
        {
            var pc = new PC();

            pc.brand = Brand.MSI;
            pc.motherBoard = "MSI MAG B660M";
            pc.CPU = "AMD Ryzen 5 5600";
            pc.GPU = "MSI GeForce GTX 1060TI 4GB";
            pc.RAM = 16;
            pc.boxName = "MSI gaming box";
            pc.value = 1000f;

            return pc;
        }
        static void Print(PC pc)
        {
            Console.WriteLine("Full information:");
            Console.WriteLine($"Brand: {pc.brand}");
            Console.WriteLine($"GPU: {pc.GPU}");
            Console.WriteLine($"CPU: {pc.CPU}");
            Console.WriteLine($"RAM: {pc.RAM}");
            Console.WriteLine($"Box name: {pc.boxName}");
            Console.WriteLine($"Value: {pc.value}£");
        }

        static void Main(string[] args)
        {
            var firstPC = GetPC();
            Print(firstPC);

            Console.Read();
        }
    }
}
