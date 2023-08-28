using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso3
{
    class Prisma:Figura
    {
        private double largo;
        private double ancho;

        public Prisma(double largo, double ancho, double alto):base(alto)
        {
            this.largo = largo;
            this.ancho = ancho;
        }

        public override double Volumen()
        {
            double volumen;
            return volumen = largo * ancho * alto;
        }

        public override double Perimetro()
        {
            double perimetro;
            return perimetro = (2 * largo + 2 * ancho) * alto;
        }
    }
}
