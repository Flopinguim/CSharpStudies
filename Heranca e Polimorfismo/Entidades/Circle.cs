using Heranca_e_Polimorfismo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_e_Polimorfismo.Entidades
{
    public class Circle : Shape
    {
        public double Radious { get; set; }

        public Circle(double radious, Color color) : base(color)
        {
            Radious = radious;
        }

        public override double area() => Math.PI * Math.Pow(Radious,2);
    }
}
