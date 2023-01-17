using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//\t

namespace ProjectTasks
{
    class Program
    {

        static int isGreater(int value1, int value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            else if (value2 > value1)
            {
                return value2;
            }
            else
            {
                Console.WriteLine("They are equal");
                return 0;
            }
        }



        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            Console.WriteLine("\t\tProgram compares two numbers");

            Console.WriteLine("\nPlease, enter your numbers:");

            Console.Write("First number:");
            string strValue1 = Console.ReadLine();

            bool value1Parsed = int.TryParse( strValue1, out firstNumber);
            if (value1Parsed)
            {
                Console.Write("Second number:");
                string strValue2 = Console.ReadLine();

                bool value2Parsed = int.TryParse(strValue2, out secondNumber);
                if (value2Parsed)
                {
                    int result = isGreater(firstNumber, secondNumber);
                    Console.WriteLine("Result: " + result);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Oops, something went wrong =( ");

                }

            }
            else
            {
                Console.WriteLine("Oops, something went wrong =( ");
            }

        }

    }
}
