using System;

namespace CarComposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Porshe = new Car("911", "Porshe", 2003, 306);
            Car Mclaren = new Car("p1", "Mclaren", 2016, 302);

            //add engine properties
            Engine electricEngine = new Engine("Electric", "100kg", 320);
            Engine gasEngine = new Engine("Gas", "220kg", 800);
            Engine hybridEngine = new Engine("Hybrid", "180kg", 562);
            Porshe.addEngine(gasEngine);
            Mclaren.addEngine(hybridEngine);

            //display cars infomation
            Porshe.showCarInfo();
            //end
        }
    }
}
