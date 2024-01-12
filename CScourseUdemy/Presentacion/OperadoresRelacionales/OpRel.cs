using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CScourseUdemy.OperadoresRelacionales
{
    public partial class OpRel : Form
    {
        public OpRel()
        {
            InitializeComponent();
        }
        //Aqui se declaran las variables
        int num1, num2;
        bool result;
        private void OpRel_Load(object sender, EventArgs e)
        {

        }

        private void btnmayor_Click(object sender, EventArgs e)
        {
            Mayorque();

        }
        private void btnmenor_Click(object sender, EventArgs e)
        {
            Menorque();
        }
        private void btnmayorque_Click(object sender, EventArgs e)
        {
            MayoroIque();

        }
        private void btnmenorque_Click(object sender, EventArgs e)
        {
            MenoroIque();
        }
        private void btnigual_Click(object sender, EventArgs e)
        {
            Igual();
        }
        private void btndifque_Click(object sender, EventArgs e)
        {
            Diferente();
        }
        private void Mayorque()
        {
            asignar();
            if (num1 > num2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            lblresult.Text = result.ToString();
        }
        private void Menorque()
        {
            asignar();
            if (num1 < num2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            lblresult.Text = result.ToString();
        }
        private void MenoroIque()
        {
            asignar();
            if (num1 <= num2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            lblresult.Text = result.ToString();
        }
        private void MayoroIque()
        {
            asignar();
            if (num1 >= num2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            lblresult.Text = result.ToString();
        }
        private void Igual()
        {
            asignar();
            if (num1 == num2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            lblresult.Text = result.ToString();
        }
        private void Diferente()
        {
            asignar();
            if (num1 != num2)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            lblresult.Text = result.ToString();
        }
        private void asignar()
        {
            num1 = Convert.ToInt32(txtnum1.Text);
            num2 = Convert.ToInt32(txtnum2.Text);
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        
    }
}

