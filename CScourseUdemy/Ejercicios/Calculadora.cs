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
    public partial class Calculadora : UserControl
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        public string titulo;
        string operacion;
        double num1, num2, resultado;
        private void panelNumeros_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GenerarNumeros()
        {
            char[] numeros;
            numeros = "7894561230.".ToCharArray();
            foreach (char c in numeros)
            {

                Button btns = new Button();
                btns.Text = c.ToString();
                btns.Size = new Size(35, 35);
                btns.FlatStyle = FlatStyle.Flat;
                btns.ForeColor = Color.White;
                btns.BackColor = Color.Transparent;
                btns.BackgroundImage = Properties.Resources.elipse;
                btns.BackgroundImageLayout = ImageLayout.Stretch;
                btns.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btns.FlatAppearance.BorderSize = 0;
                btns.FlatAppearance.MouseOverBackColor = Color.Transparent;
                panelNumeros.Controls.Add(btns);
                btns.Click += Btns_Click;

            }
        }

        private void Btns_Click(object? sender, EventArgs e)
        {
            string numeroString = ((Button)sender).Text;

            if (txtPantalla1.Text == "0")
            {
                txtPantalla1.Clear();
            }
            txtPantalla1.Text += numeroString;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            lblText.Text = titulo;
            GenerarNumeros();
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }
        //Operaciones-------------------------------------------
        private void Operaciones()
        {
            Asignar();
            if (num2 > 0)
            {
                lblResult.Text = txtPantalla1.Text;
                lblOperacion.Text = operacion;
                txtPantalla1.Text = "0";
            }
        }
        private void Asignar()
        {
            num1 = Convert.ToDouble(lblResult.Text);
            num2 = Convert.ToDouble(txtPantalla1.Text);

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = btnDiv.Text;
            Operaciones();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Calcular();
        }
        private void Calcular()
        {
            Asignar();
            if(lblOperacion.Text == btnDiv.Text)
            {
                Dividir();    
            }
        }
        private void Dividir()
        {
            resultado = num1 / num2;
            txtPantalla1.Text = resultado.ToString();
            lblOperacion.Text = "0";
            lblResult.Text = "0";
        }
    }

}
