using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CScourseUdemy.OperadoresAritmeticos
{
    public partial class OpAtms : Form
    {
        public OpAtms()
        {
            InitializeComponent();
        }
        //Declaracion de variables
        int numero1, numero2, resultado;

        private void OpAtms_Load(object sender, EventArgs e)
        {

        }

        private void lblsuma_Click(object sender, EventArgs e)
        {
            Suma(); //Se llama a funcion Suma
        }
        private void Suma()
        {
            numero1 = Convert.ToInt32(txtnum1.Text);
            numero2 = Convert.ToInt32(txtnum2.Text);
            resultado = numero1 + numero2;
            lblresult.Text = resultado.ToString(); //Convert.ToString(resultado);
        }

    }
}
