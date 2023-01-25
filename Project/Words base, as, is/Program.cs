using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words_base__as__is
{
    class Car
    {
        private float _maxSpeed;
        private string _markName;
        private float _zeroTo100;
        private DateTime _releaseYear;


        public string Mark { get; set; }
        public float maxSpeed  { get; set; }
        public float zeroTo100 { get; set; }
        public DateTime  releaseYear { get; set; }


        public void Print()
        {
            Console.WriteLine($"Mark: {_markName}");
            Console.WriteLine($"Max speed: {_maxSpeed}");
            Console.WriteLine($"From 0 to 100: {_zeroTo100}");
            Console.WriteLine($"Release year: {_releaseYear}");
            Console.WriteLine($"Mark: {Mark}");
        }

        public Car(string mark, float maxSpeed, float zeroTo100, DateTime dateTime )
        {
            _markName = mark;
            _maxSpeed = maxSpeed;
            _zeroTo100 = zeroTo100;
            _releaseYear = dateTime;
        }

    }

    class Cost
    {
        private decimal _cost;
        public decimal cost { get; set; }


       // public Cost():base( string mark,maxSpeed,zeroTo100,dateTime)
       // { }

    }

    class Program
    {


        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2021, 07, 15);
            Car car = new Car("Volvo", 240f, 1.5f, dateTime);
            car.Print();
        }
    }
}
