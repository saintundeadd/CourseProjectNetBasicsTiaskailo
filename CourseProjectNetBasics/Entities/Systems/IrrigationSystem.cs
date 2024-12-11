using CourseProjectNetBasics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectNetBasics.Entities.Systems
{
    public class IrrigationSystem : IControllable
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Irrigation system turned on.");
        }
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Irrigation system turned off.");

        }
    }
}