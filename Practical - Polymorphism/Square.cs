using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticalPolymorphism
{
    public class Square : BaseGeometricShape
    {
        public Square(double width, double height) : base(width, height)
        {

           
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }



    }
}
