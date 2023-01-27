using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{

    abstract class Gun
    {
        public abstract void Shoot();

        public object GetInfo(Gun gun)
        {
            return gun.GetType();
        }
    }

    class Person
    {
        private int health = 5;

    }

    class Pistol : Gun
    {
        public override void Shoot()
        {
            Console.WriteLine("It's pistol");
        }
    }

    class rifle : Gun
    {
        public override void Shoot()
        {
            Console.WriteLine("It's rifle");
        }
    }

    class heavyGun : Gun
    {
        public override void Shoot()
        {
            Console.WriteLine("It's heavy gun");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            rifle rifle = new rifle();
            Console.Read();
        }
    }
}
