using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CScourseUdemy.Listas
{
    public partial class FrmListas : Form
    {
        public FrmListas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //AgregarLista();
            AgregarArray();

        }
        private void AgregarLista()
        {
            List<string> nombres = new List<string>();
            nombres.Add("Fuck");
            nombres.Add("Fuck");
            nombres.Add("Fuck");
            nombres.Add("Fuck");
            nombres.Add("Fuck");
            // Esta es una mala forma de guardar informacion en una lista, un bucle es mejor
            //for (int i = 0; i < nombres.Count(); i++)
            //{
            //    lstLista.Items.Add(nombres[i]);
            //}
            foreach (string datos in nombres)
            {
                lstLista.Items.Add(datos);
            }
        }
        private void AgregarArray()
        {
            string[] nombres = new string[] { "Edgar", "Yamil", "Maya", "Alec", "May" };
            foreach (string datos in nombres)
            {
                lstLista.Items.Add(datos);
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
        }
        private void GenerarBotones()
        {
            char[] numeros;
            numeros = "123456789#0*".ToCharArray();
            panelNumerico.Controls.Clear();
            foreach (char data in numeros)
            {
                Button btn = new Button();
                btn.Text = data.ToString();
                btn.Size = new Size(75, 66);
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.FromArgb(192,192,255); //Colores RGB 
                btn.FlatAppearance.BorderSize=3;
                panelNumerico.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            string numero  = ((Button)sender).Text;
            txtPantalla.Text += numero;
        }

        private void FrmListas_Load(object sender, EventArgs e)
        {
            GenerarBotones();
        }
    }
}
