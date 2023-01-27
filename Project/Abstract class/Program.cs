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

        public void GetInfo()
        {
            Console.WriteLine(GetType().Name);
        }
    }

    class Player
    {
        public void Shoot(Gun gun)
        {
            gun.Shoot();
        }

        public void ShowInfo(Gun gun)
        {
            gun.GetInfo();
        }

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
            Player player = new Player();

            Gun[] inventory = { new Pistol(), new heavyGun() , new rifle()};

            foreach (Gun item in inventory)
            {
                player.ShowInfo(item);
                player.Shoot(item);
            }
            Console.Read();
        }
    }
}
