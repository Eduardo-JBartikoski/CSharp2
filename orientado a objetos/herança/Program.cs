using System;

namespace Heranca
{
    public abstract class Forma
    {
        protected double BaseRetangulo { get; set; }
        protected double AlturaRetangulo { get; set; }
        public abstract double CalcularArea();
    }

    class Retangulo : Forma
    {
        public Retangulo(double bas, double altura)
        {
            BaseRetangulo = bas;
            AlturaRetangulo = altura;
        }

        public override double CalcularArea()
        {
            return BaseRetangulo * AlturaRetangulo;
        }
    }
}
