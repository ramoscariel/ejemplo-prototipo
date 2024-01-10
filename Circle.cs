using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploUdemy
{
    public class Circle : Shape
    {
        public double Radius { get; set; } // Nuevo atributo

        public Circle(double radius)
        {
            Type = "Circle";
            Radius = radius;
        }

        public override Shape Clone()
        {
            // Clonar el objeto actual
            return (Shape)this.MemberwiseClone();
        }
    }
}
