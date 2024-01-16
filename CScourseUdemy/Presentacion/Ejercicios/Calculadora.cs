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
        bool reiniciar = false, punto = true;
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
            ReiniciarProceso();
            string numeroString = ((Button)sender).Text;
            if (numeroString == ".")
            {
                punto = true;
                if (txtPantalla1.Text.Contains("."))
                {
                    punto = false;
                }
                if (punto == true)
                {
                    if (txtPantalla1.Text != "")
                    {
                        txtPantalla1.Text += ".";
                    }
                }
            }
            else
            {

                if (txtPantalla1.Text == "0")
                {
                    txtPantalla1.Clear();
                }
                txtPantalla1.Text += numeroString;

            }
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

                lblResult.Visible = true;
                lblOperacion.Visible = true;
            }
        }
        private void Asignar()
        {
            num1 = Convert.ToDouble(lblResult.Text);
            num2 = Convert.ToDouble(txtPantalla1.Text);

        }
        //--------BOTONES--------------------------
        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = btnDiv.Text;
            Operaciones();
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            operacion = btnMult.Text;
            Operaciones();
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            operacion = btnPlus.Text;
            Operaciones();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            operacion = btnMinus.Text;
            Operaciones();
        }
        private void btnPors_Click(object sender, EventArgs e)
        {
            operacion = btnPors.Text;
            Operaciones();
        }
        //-------LIMPIAR--PANTALLA--------
        private void btnAc_Click(object sender, EventArgs e)
        {
            Borrar();
        }
        //-------RESOLVER--OPERACION-------
        private void btnEquals_Click(object sender, EventArgs e)
        {
            Calcular();
        }
        //---------SALIR----------------------------------------
        private void BtnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //--------COPIAR-EN-PORTAPAPELES-----------------------
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPantalla1.Text);
        }

        //-----------------------------------------------------
        private void Calcular()
        {
            Asignar();
            if (lblOperacion.Text == btnDiv.Text)
            {
                Dividir();
            }
            if (lblOperacion.Text == btnMult.Text)
            {
                Multiplicar();
            }
            if (lblOperacion.Text == btnPlus.Text)
            {
                Sumar();
            }
            if (lblOperacion.Text == btnMinus.Text)
            {
                Restar();
            }
            if (lblOperacion.Text == btnPors.Text)
            {
                Porcentaje();
            }
            //if (lblOperacion.Text == btnAc.Text)
            //{
            //    Borrar();
            //}

        }
        private void ReiniciarProceso()
        {
            if (reiniciar == true)
            {
                txtPantalla1.Text = "0";
                reiniciar = false;
            }
        }
        private void Limpiar()
        {
            reiniciar = true;
            lblOperacion.Text = "0";
            lblResult.Text = "0";
            lblOperacion.Visible = false;
            lblResult.Visible = false;
        }
        private void Dividir()
        {
            resultado = num1 / num2;
            txtPantalla1.Text = resultado.ToString();

            Limpiar();
        }
        private void Multiplicar()
        {
            resultado = num1 * num2;
            txtPantalla1.Text = resultado.ToString();
            Limpiar();
        }
        private void Sumar()
        {
            resultado = num1 + num2;
            txtPantalla1.Text = resultado.ToString();
            Limpiar();
        }
        private void Restar()
        {
            resultado = num1 - num2;
            txtPantalla1.Text = resultado.ToString();
            Limpiar();
        }
        private void Porcentaje()
        {
            resultado = num1 * num2 / 100;
            txtPantalla1.Text = resultado.ToString();
            Limpiar();
        }
        private void Borrar()
        {
            txtPantalla1.Text = "0";
            lblOperacion.Text = "0";
            lblResult.Text = "0";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
