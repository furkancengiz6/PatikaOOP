using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticalPolymorphism
{
    public class RightTriangle : BaseGeometricShape
    {
        public RightTriangle(double width, double height) : base(width, height)
        {
            CalculateArea();
        }
        public override double CalculateArea()
        {
            return (Width * Height) / 2;
        }
    }
    
    }
