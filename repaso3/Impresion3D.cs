using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace repaso3
{
    class Impresion3D
    {
        private ArrayList figuras = new ArrayList();
        private double precio;
        private double tiempo;
        private Cliente nuevoCliente;
        private double precioTotal;

        public int CantidadDeFiguras
        {
            get { return figuras.Count; }
        }

        public Impresion3D(double precioBase, string nombre, int cuit)
        {
            precio = precioBase;
            nuevoCliente = new Cliente(nombre, cuit);
        }

        public void AgregarFigura(Figura pieza)
        {
            figuras.Add(pieza);
        }

        public double PrecioEstimado()
        {
                foreach(Figura figura in figuras)
            {
                if(figura is Prisma)
                {
                    precioTotal += figura.Volumen() * precio;
                }
                else if(figura is Cilindro)
                {
                    precioTotal += figura.Volumen() * precio;
                }
            }
            return precioTotal;
            
        }

        public double Tiempo()
        {
            foreach(Figura figura in figuras)
            {
                if(figura is Prisma)
                {
                    tiempo+= figura.Perimetro()*1.75;
                }
                else if(figura is Cilindro)
                {
                    tiempo += figura.Perimetro() * 1.75;
                }
            }
            return tiempo;
        }
    }
}
