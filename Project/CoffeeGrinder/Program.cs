using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeGrinder
{
    class CofeeGrinder
    {
        private int _voltage;
        private bool turnedOn = false;


        private void startWorking(int voltage)
        {
            _voltage = voltage;
            if (_voltage < 220)
            {
                turnedOn = false;
                Console.WriteLine($"Some voltage problem: {voltage}W \nTry again!");
            }
            else
            {
                Console.WriteLine("Everything is okay");
                turnedOn = true;
                Console.WriteLine("Start grinding...");
            }
        }


        public void Welcome(int voltage)
        {
            Console.WriteLine("Welcome\nChecking the voltage...");

            startWorking(voltage);
        }

    }

    class Program
    {
        

        static void Main(string[] args)
        {
            CofeeGrinder cofeeGrinder = new CofeeGrinder();
            cofeeGrinder.Welcome(voltage:230);


        }
    }
}
