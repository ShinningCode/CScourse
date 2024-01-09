using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CScourseUdemy.Ejercicios
{
    public partial class Casacas : UserControl
    {
        public Casacas()
        {
            InitializeComponent();
        }
        public string titulo4;
        private void Casacas_Load(object sender, EventArgs e)
        {
            lbltitulo.Text = titulo4;
        }

        private void Calcular()
        {
            double total = 0;
            string detalle = "";
            if (rbtnl.Checked == true)
            {
                total += 150;
                detalle = "Casaca Talla L $150 \r\n";
            }
            if (rbtnm.Checked == true)
            {
                total += 100;
                detalle = "Casaca Talla M $100 \r\n";
            }
            if (rbtns.Checked == true)
            {
                total += 50;
                detalle = "Casaca Talla S $50 \r\n";
            }
            if (rbtnb.Checked == true)
            {
                detalle += "Color Blanco \r\n";
            }
            if (rbtnr.Checked == true)
            {
                detalle += "Color Rojo \r\n";
            }
            txtCarrito.Text = detalle;
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
