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
        string estado;
        public string titulo3;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            asignar();
            Calcular();
        }
        private void asignar()
        {
            altura = Convert.ToDouble(txtnum1.Text);
            peso = Convert.ToDouble(txtnum2.Text);
            //estado = lblestado.ToString();
        }
        //Probar condiciones
        private void Calcular()
        {
            imc = (peso / altura) * 2;

            if (imc < 18.5)
            {
                lblestado.Text = "Por Debajo";
                lblresult.Text = imc.ToString();
            }
        }

        private void IMC_Load(object sender, EventArgs e)
        {
            lbltitulo3.Text = titulo 

        }
    }
}
