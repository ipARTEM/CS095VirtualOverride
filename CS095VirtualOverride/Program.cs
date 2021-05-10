using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS095VirtualOverride
{
    class Car
    {
        protected virtual void StartEngine()
        {
            Console.WriteLine("Двигатель запущен!");
        }

        public virtual void Drive()
        {
            StartEngine();

            Console.WriteLine("Я машина, я еду!");
        }
    }

    class SportCar:Car
    {
        protected override void StartEngine()
        {
            Console.WriteLine("др-др-дРРР-РРРР-рррр");
        }

        public override void Drive()
        {
            StartEngine();
            Console.WriteLine("Я супер быстрая машина и я еду!");
        }
    }


    class Person
    {
        public  void Drive(Car car)
        {
            car.Drive();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Person person = new Person();

            person.Drive(car);

            person.Drive(new SportCar());

            Console.WriteLine("****************************");

            person.Drive(new Car());

        }
    }
}
