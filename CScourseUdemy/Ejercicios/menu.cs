﻿using System;
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
        private void Ejercicio1()
        {
            Ejercicio1 ctl = new Ejercicio1();
            ctl.titulo = button1.Text;
            ctl.Dock = DockStyle.Fill;
            panelVisor.Controls.Add(ctl);
            ctl.Show();
        }

        private void panelVisor_Paint(object sender, PaintEventArgs e)
        {

        }
     

    }
}
