using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    interface IFirstInterface
    {
        void Function();
    }
    interface ISecondInterface
    {
        void Function();
    }

    class TestClass :ISecondInterface , IFirstInterface
    {
        void IFirstInterface.Function()
        {
            Console.WriteLine("It's the firstInterface function");
        }

        void ISecondInterface.Function()
        {
            Console.WriteLine("It's the secondInterface function");
        }
    }


    class Program
    {

        static void Foo(IFirstInterface firstInterface)
        {
            firstInterface.Function();
        }

        static void Foo_second(ISecondInterface secondInterface)
        {
            secondInterface.Function();
        }


        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();


            if (testClass is ISecondInterface secondInterface)
            {
                secondInterface.Function();
                Console.WriteLine();
            }
            else if (testClass is IFirstInterface firstInterface)
            {
                firstInterface.Function();
                Console.WriteLine();
            }

            Console.Read();


        }
    }
}
