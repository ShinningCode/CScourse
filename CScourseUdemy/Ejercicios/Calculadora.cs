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
        private void panelNumeros_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GenerarNumeros()
        {
            char[] numeros;
            numeros = "789456123 0.".ToCharArray();
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

                panelNumeros.Controls.Add(btns);

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
    }
}
