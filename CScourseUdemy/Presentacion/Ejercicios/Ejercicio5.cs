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
    public partial class Ejercicio5 : UserControl
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }
        double num1, num2;
        //bool resultado;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnsolucion_Click(object sender, EventArgs e)
        {
            Asignar();
            Calcular();
        }
        private void Asignar()
        {
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);
        }
        private void Calcular()
        {
            
            if (num1 % 2 == 0) { 
            lbl1.Text = "Par";
            } else
            {
                lbl1.Text = "Impar";
            }
            if (num2 % 2 == 0)
            {
                lbl2.Text = "Par";
            }
            else
            {
                lbl1.Text = "Impar";
            }
            if (num1 % 2 == 0 && num2 % 2 == 0)
            {
                lbl1.BackColor = Color.Green;
                lbl2.BackColor = Color.Green;
                lbl2.BackColor = Color.Green;
                lbl3.Text = "Ambos son Pares";
            } else if(num1 % 2 == 0 && num2 %2 != 0)
            {
                lbl1.BackColor = Color.GreenYellow;
                lbl3.BackColor = Color.GreenYellow;

                lbl3.Text = "El numero 1 es Par";
            } else if(num1 % 2 != 0 && num2 % 2 == 0)
            {
                lbl2.BackColor = Color.GreenYellow;
                lbl3.BackColor = Color.GreenYellow;
                lbl3.Text = "El numero 2 es Par";
            }
            else
            {
                lbl1.BackColor = Color.Red;
                lbl2.BackColor = Color.Red;
                lbl3.BackColor = Color.Red;
                lbl3.Text = "Los dos son impares";
            }
        }
    }
}
