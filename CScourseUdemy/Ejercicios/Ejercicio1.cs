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
    public partial class Ejercicio1 : UserControl
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        double a, b, c, result;

        private void lblnum1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Asignar()
        {
            a = Convert.ToDouble(txtnum1.Text);
            b = Convert.ToDouble(txtnum2.Text);
            c = Convert.ToDouble(txtnum3.Text);
            result = Convert.ToDouble(lblresult.Text);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Asignar();
            Calcular();
        }
        private void Calcular()
        {
            
            result = (c + 5) * (Math.Pow(b, 2) - 3 * (a * c) * (Math.Pow(a, 2))) / (4 * a);
            lblresult.Text = result.ToString();
        }
    }
}
