using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{

    interface IHasInfo
    {
        void ShowInfo();
    }

    interface IThrowingWeapon:IWeapon
    {
        void Throw();
    }

    interface IWeapon
    {
        void Fire();
    }

    abstract class Weapon : IHasInfo, IWeapon
    {
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name}");
        }
    }


    class Player
    {
        public void Melee(IThrowingWeapon throwingWeapon)
        {
            throwingWeapon.Throw();
        }

        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(IHasInfo hasInfo)
        {
            hasInfo.ShowInfo();
        }

        class Gun: IWeapon
    {
        //public override void Fire()

        public void Fire()
        {
            Console.WriteLine("Fire!");
            //ShowInfo();
        }
    }

    }

    class Pistol : IWeapon //, IHasInfo
    {

        //public override void Fire()
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Its a pistol");
        }

    }

    class rifle : IWeapon    //, IHasInfo
    {
       // public override void Fire()
       public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Its a rifle");
        }

    }


    class heavyGun : IWeapon
    {
       // public override void Fire()

        public void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Its a heavy gun");
        }
    }

    class Knife : IThrowingWeapon
    {
        // public override void Fire()
        public void Fire()
        {
            Console.WriteLine($"{GetType().Name} ");
        }
        public void Throw()
        {
            Console.WriteLine("It's been throwned");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Player player = new Player();

            IWeapon[] inventory = { new Pistol(), new heavyGun() , new rifle(), new Knife()};

            foreach (IWeapon item in inventory)
            {
                //player.CheckInfo(item);
                
                player.Fire(item);

                Console.WriteLine();
            }
            player.Melee(new Knife());

            Console.Read();
        }
    }
}
