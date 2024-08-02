using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaEncapsulationTask
{
    public class Car
    {
        // ▼ Fields ▼
        private string _brand;
        private string _model;
        private string _color;
        private int _doorCount;

        // ▼ Properties ▼
        public string Brand
        {
            get { return _brand; }
            set { _brand=value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model=value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color=value; }
        }

        // ▼ Task instruction: Make encapsulation on door count property.▼
        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                // ▼ Checking 2 or 4 situation. 
                if (value == 2 || value == 4)
                {
                    _doorCount = value;
                }
                // if not making doorcount -1 that coming from task instruction
                else
                {
                    Console.WriteLine("Count of door must be only 2 or 4!");
                    _doorCount = -1;
                }
            }
        }

        //▼ method for showing car infos ▼
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand:{_brand}\nModel:{_model}\nColor:{_color}\nDoor Count:{_doorCount}");
        }
    }
}
