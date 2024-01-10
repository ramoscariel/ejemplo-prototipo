using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploUdemy
{
    public abstract class Shape
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public abstract Shape Clone();
    }
}
