using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repaso3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Impresion3D nuevaImpresion;
        Cliente nuevoCliente;
        Cilindro cilindro;
        Prisma prisma;
        private void btnImpresion_Click(object sender, EventArgs e)
        {
            string nombre = tBnombre.Text;
            double precio = Convert.ToDouble(tBprecioM.Text);
            int cuit = Convert.ToInt32(tBcuit.Text);
            nuevoCliente = new Cliente(nombre, cuit);
            nuevaImpresion = new Impresion3D(precio, nombre, cuit);
            tBcuit.Clear();
            tBnombre.Clear();
            tBprecioM.Clear();
        }

        private void btnAgregarF_Click(object sender, EventArgs e)
        {
            FDatos nuevoProducto = new FDatos();

            while(nuevoProducto.ShowDialog()== DialogResult.OK)
            {
                if (nuevoProducto.rBcirculo.Checked)
                {
                    double largo = Convert.ToDouble(nuevoProducto.tBlargo.Text);
                    double alto = Convert.ToDouble(nuevoProducto.tBalto.Text);
                    cilindro = new Cilindro(largo, alto);
                    nuevaImpresion.AgregarFigura(cilindro);

                }
                else if (nuevoProducto.rBprisma.Checked)
                {
                    double largo = Convert.ToDouble(nuevoProducto.tBlargo.Text);
                    double ancho = Convert.ToDouble(nuevoProducto.tBancho.Text);
                    double alto = Convert.ToDouble(nuevoProducto.tBalto.Text);
                    prisma = new Prisma(largo, ancho, alto);
                    nuevaImpresion.AgregarFigura(prisma);

                }
                nuevoProducto.tBalto.Clear();
                nuevoProducto.tBancho.Clear();
                nuevoProducto.tBlargo.Clear();
            }
            nuevoProducto.Dispose();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            lBlista.Items.Clear();
            lBlista.Items.Add(" " + nuevoCliente.ToString());
            lBlista.Items.Add("prisma: " + prisma.Descripcion + "cilindro: " + cilindro.Descripcion);
            lBlista.Items.Add("Precio: " + nuevaImpresion.PrecioEstimado().ToString("0.00"));
            lBlista.Items.Add("Tiempo: " + nuevaImpresion.Tiempo().ToString("0.00"));
        }
    }
}
