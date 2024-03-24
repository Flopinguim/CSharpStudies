using Color = Heranca_e_Polimorfismo.Enums.Color;

namespace Heranca_e_Polimorfismo.Entidades
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double area();
    }
}
