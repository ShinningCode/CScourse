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
        double numero1, numero2, resultado;


        private void lblsuma_Click(object sender, EventArgs e)
        {
            Suma(); //Se llama a funcion Suma
        }
        private void lblrest_Click(object sender, EventArgs e)
        {
            Resta(); //Se llama a funcion Suma
        }
        private void lblmult_Click(object sender, EventArgs e)
        {
            Mult();
        }
        private void lbldiv_Click(object sender, EventArgs e)
        {
            Div();
        }
        private void Suma()
        {
            try //Doble tab para generar codigo completo
            {
                txtnum1.Text = txtnum1.Text.Replace(",", ".");
                txtnum2.Text = txtnum2.Text.Replace(",", ".");
                numero1 = Convert.ToDouble(txtnum1.Text);
                numero2 = Convert.ToDouble(txtnum2.Text);
                resultado = numero1 + numero2;
                lblresult.Text = resultado.ToString(); //Convert.ToString(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace); // Mostrar mensaje .Message para resumir error
                throw;
            }
        }
        private void Resta()
        {
            try //Doble tab para generar codigo completo
            {
                numero1 = Convert.ToDouble(txtnum1.Text);
                numero2 = Convert.ToDouble(txtnum2.Text);
                resultado = numero1 - numero2;
                lblresult.Text = resultado.ToString(); //Convert.ToString(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Mostrar mensaje .Message para resumir error
                throw;
            }
        }
        private void Mult()
        {
            try //Doble tab para generar codigo completo
            {
                numero1 = Convert.ToDouble(txtnum1.Text);
                numero2 = Convert.ToDouble(txtnum2.Text);
                resultado = numero1 * numero2;
                lblresult.Text = resultado.ToString(); //Convert.ToString(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace); // Mostrar mensaje .Message para resumir error
                throw;
            }
        }
        private void Div()
        {
            try //Doble tab para generar codigo completo
            {
                numero1 = Convert.ToDouble(txtnum1.Text);
                numero2 = Convert.ToDouble(txtnum2.Text);
                resultado = numero1 / numero2;
                lblresult.Text = resultado.ToString(); //Convert.ToString(resultado);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace); // Mostrar mensaje .Message para resumir error
                throw;
            }
        }

    }
}
