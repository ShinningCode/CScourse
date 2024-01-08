using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CScourseUdemy.Ejercicios;
namespace CScourseUdemy.Ejercicios
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //E1 frm = new E1();
            //frm.ShowDialog();
        }

        private void panelVisor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Ejercicio1()
        {
            Ejercicio1 ctl = new Ejercicio1();
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }
    }
}
