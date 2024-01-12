using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CScourseUdemy.Operadores_Logicos
{
    public partial class OpLog : Form
    {
        public OpLog()
        {
            InitializeComponent();
        }
        int num1, num2;
        bool resultado;

        private void btny_Click(object sender, EventArgs e)
        {
            OperacionY();
        }
        private void btnno_Click(object sender, EventArgs e)
        {
            OperacionNo();
        }
        private void btno_Click(object sender, EventArgs e)
        {
            OperacionO();
        }
        private void asignar()
        {
            num1 = Convert.ToInt32(txtnum1.Text);
            num2 = Convert.ToInt32(txtnum2.Text);
        }

        private void OperacionY()
        {
            asignar();
            if (num1 > 5 && num2 < 10)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresult.Text = Convert.ToString(resultado);
        }
        private void OperacionO()
        {
            asignar();
            if (num1 > 5 || num2 < 10)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresult.Text = Convert.ToString(resultado);
        }
        private void OperacionNo()
        {
            asignar();
            if (!(num1 > 5) && num2 < 10)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            lblresult.Text = Convert.ToString(resultado);
        }


    }
}
