using Heranca_e_Polimorfismo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_e_Polimorfismo.Entidades
{
    public class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double area() => Width * Height;
    }
}
