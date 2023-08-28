using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso3
{
    class Cilindro:Figura
    {
        private double radio;

        public Cilindro(double radio, double alto) : base(alto)
        {
            this.radio = radio;
        }

        public override double Perimetro()
        {
            double perimetro;
           return perimetro = Math.Pow(2, radio) * Math.PI * alto;
        }

        public override double Volumen()
        {
            double volumen;
            return volumen = Math.PI * Math.Pow(2, radio);
        }
    }
}
