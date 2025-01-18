using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign05oop.Ishape
{
    internal class Circle : ICircle
    {
        public double Radious { get; set; }
        public double Area { get; set; }
        public Circle(double radious) 
        {
            Radious = radious; 
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radious = {Radious} , Area = {3.14*Radious*Radious}");
        }
    }
}
