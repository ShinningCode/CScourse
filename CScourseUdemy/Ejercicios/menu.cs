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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio1();

        }
        private void btn2(object sender, EventArgs e)
        {
            Ejercicio2();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Ejercicio3();
        }
        private void Ejercicio1()
        {
            panelVisor.Controls.Clear();
            Ejercicio1 ctl = new Ejercicio1();
            ctl.titulo = button1.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }
        private void Ejercicio2()
        {
            panelVisor.Controls.Clear();
            Ejercicio2 ctl2 = new Ejercicio2();
            ctl2.titulo2 = btnEjercicio2.Text;
            ctl2.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl2);
            ctl2.Show();
        }
        private void Ejercicio3()
        {
            panelVisor.Controls.Clear();
            IMC ctl3 = new IMC();
            ctl3.titulo3 = btn3.Text;
            ctl3.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl3);
            ctl3.Show();
        }


        private void panelVisor_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
