using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign05oop.Ishape
{
    internal class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area {  get; set; }
        public Rectangle (double width, double height) 
        {
            Width = width;
            Height = height;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Width = {Width} , Height = {Height} , Area = {Width*Height}");
        }
    }
}
