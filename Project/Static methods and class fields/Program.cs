using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_methods_and_class_fields
{
   
    class Count
    {
        public Count()
        {
            counter++;
        }

        private static int counter;

        public static int Counter
        {
            get { return counter; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Count count1 = new Count();
            Count count2 = new Count();
            Count count3 = new Count();

            Console.WriteLine(Count.Counter);
            Console.Read();
        }
    }
}
