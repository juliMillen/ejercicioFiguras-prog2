using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso3
{
    abstract class Figura
    {
        protected double alto;
        public string Descripcion { get; set; }

        public Figura(double alto)
        {
            this.alto = alto;
        }
        public abstract double Volumen();
        public abstract double Perimetro();
    }
}
