using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaEncapsulationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ▼ Creating instance of Car and defining properties 
            Car car = new Car()
            {
                Brand = "Renault",
                Color = "Red",
                Model = "2023",
                DoorCount = 3
            };

            // Cause of defining Door count 3, there will be warning and door count will be -1
            car.DisplayInfo();
        }
    }
}
