using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticalPolymorphism
{
    public class Rectangle :BaseGeometricShape
    {

        public Rectangle(double width, double height) : base(width, height)
        {
            
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }

    }
}
