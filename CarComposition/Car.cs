using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComposition
{
    internal class Car
    {
        string model;
        string brand;
        int year;
        int speed;
        Engine carEngine;

        //default constructor
        public Car()
        {

        }
        //constructor
        public Car(string ml, string br, int yr, int sp)
        {
            model = ml;
            brand = br;
            year = yr;
            speed = sp;
        }

        public void accelerate(int speedToBeAdded)
        {
            speed = speed + speedToBeAdded;
        }

        public void showCarInfo()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(model);
            Console.WriteLine(brand);
            Console.WriteLine(year);
            Console.WriteLine(speed);
            Console.WriteLine("--------------------------------------");
            carEngine.showEngineInfo();

        }

        public void startCar()
        {
            carEngine.engineSelftest();
            carEngine.startEngine();
        }

        public void stopCar()
        {
            carEngine.engineSelftest();
            carEngine.stopEngine();
        }

        public void addEngine(Engine addedEngine)
        {
            carEngine = addedEngine;
        }
    }
}
