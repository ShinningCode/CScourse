using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CScourseUdemy.Condicionales
{
    public partial class Frmcondicionales : Form
    {
        public Frmcondicionales()
        {
            InitializeComponent();
        }
        double num1;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Asignar();
            Calcular();
        }
        private void Asignar()
        {
            num1 = Convert.ToDouble(txtnum1.Text);
        }
        private void Calcular()
        {
            if(num1 == 0)
            {
                lblResult.ForeColor = Color.White;
                lblResult.Text = "Es 0";
            } else if(num1 < 0)
            {
                lblResult.ForeColor = Color.IndianRed;
                lblResult.Text = "Numero negativo";
            }else
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "Es un numero positivo";
            }
        }
    }
}
