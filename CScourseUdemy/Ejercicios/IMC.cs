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
    public partial class IMC : UserControl
    {
        public IMC()
        {
            InitializeComponent();
        }
        double altura, peso, imc;
        public string titulo3;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            asignar();
            Calcular();
            Condiciones();
        }
        private void asignar()
        {
            altura = Convert.ToDouble(txtnum2.Text);
            peso = Convert.ToDouble(txtnum1.Text);
            //estado = lblestado.ToString();
        }
        //Probar condiciones
        private void Calcular()
        {
            imc = (peso / Math.Pow(altura,2));

            
        }
        private void Condiciones()
        {
            if (imc <= 18.5)
            {
                lblestado.ForeColor = Color.AliceBlue;
                lblestado.Text = "Por Debajo";
                lblresult.Text = imc.ToString("N2");
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                lblestado.ForeColor = Color.Green;
                lblestado.Text = "Saludable";
                lblresult.Text = imc.ToString("N2");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                lblestado.ForeColor = Color.OrangeRed;
                lblestado.Text = "Sobrepeso";
                lblresult.Text = imc.ToString("N2");
            }
            else if (imc > 30)
            {
                lblestado.ForeColor = Color.Red;
                lblestado.Text = "Obesidad";
                lblresult.Text = imc.ToString("N2");
            }
        }

        private void IMC_Load(object sender, EventArgs e)
        {
            lbltitulo3.Text = titulo3;

        }
    }
}
