using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploUdemy
{
    public class Square : Shape
    {
        public double SideLength { get; set; } // Nuevo atributo

        public Square(double sideLength)
        {
            Type = "Square";
            SideLength = sideLength;
        }

        public override Shape Clone()
        {
            // Clonar el objeto actual
            return (Shape)this.MemberwiseClone();
        }
    }
}
