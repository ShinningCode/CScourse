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
    public partial class Ejercicio2 : UserControl
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        double radio;
        const double PI = Math.PI;
        double area, longitud;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            asignar();
            Calcular();
        }
        private void asignar()
        {
            radio = Convert.ToDouble(txtnum1.Text);
        }
        private void Calcular()
        {
            area = PI * (Math.Pow(radio,2));
            longitud = 2 * PI * radio;
            lblresult1.Text = Convert.ToString(area);
            lblresult2.Text = Convert.ToString(longitud);
        }
    }
}
