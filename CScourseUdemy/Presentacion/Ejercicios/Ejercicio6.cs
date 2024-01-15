using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CScourseUdemy.Ejercicios
{
    public partial class Ejercicio6 : UserControl
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GenerarBotones()
        {
            char[] numeros = "0123456789".ToCharArray();
            panelNumeros.Controls.Clear();
            foreach (char data in numeros)
            {
                Button btn = new Button();
                btn.Text = data.ToString();
                btn.Size = new Size(25, 25);
                btn.ForeColor = Color.FromArgb(192, 192, 255);
                panelNumeros.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }
        private void GenerarOperaciones()
        {
            char[] numeros = "-+x/".ToCharArray();
            panelNumeros.Controls.Clear();
            foreach (char data in numeros)
            {
                Button btn = new Button();
                btn.Text = data.ToString();
                btn.Size = new Size(25, 25);
                btn.ForeColor = Color.FromArgb(192, 192, 255);
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            string numero = ((Button)sender).Text;
            txtPantalla.Text += numero;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ejercicio6_Load(object sender, EventArgs e)
        {
            GenerarBotones();
            GenerarOperaciones();
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
