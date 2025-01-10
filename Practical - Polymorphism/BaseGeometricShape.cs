using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticalPolymorphism
{
    public abstract class BaseGeometricShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        //uzunluk ve genişlik degerleri gereklı turetlılmıs sınıflar icin
        public BaseGeometricShape(double width, double height)
        {
            Width = width;
            Height = height;
        }
        //abstruct sınıf oluşturuldu ki her şekilde formul degisiyor.
       public abstract double CalculateArea();






    }
}
