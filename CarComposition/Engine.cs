using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarComposition
{
    internal class Engine
    {
        string type;
        string size;
        int power;

        public Engine(string tp, string sz, int hp)
        {
            type = tp;
            size = sz;
            power = hp;
        }

        public void startEngine()
        {
            Console.WriteLine("the engine is powering on");
            Thread.Sleep(3000);
            Console.WriteLine("status : on");
        }

        public void stopEngine()
        {
            Console.WriteLine("the engine is powering off");
            Thread.Sleep(3000);
            Console.WriteLine("status : off");
        }

        public void engineSelftest()
        {
            Console.WriteLine("The engine is being tested");
            Thread.Sleep(5000);
            Console.WriteLine("all test have been done and are successful");
        }

        public void showEngineInfo()
        {
            Console.WriteLine(type);
            Console.WriteLine(size);
            Console.WriteLine(power);
            Console.WriteLine("--------------------------------------");

        }
    }
}
