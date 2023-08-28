using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso3
{
    class Cliente
    {
        private string nombre;
        private int cuit;

        public Cliente(string nombre, int cuit)
        {
            this.nombre = nombre;
            this.cuit = cuit;
        }

        public string ToString()
        {
            return "Nombre: " + nombre + "Cuit: " + cuit;
        }
    }
}
