namespace CScourseUdemy.Ejercicios
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            btnEjercicio2 = new Button();
            btn3 = new Button();
            btn4 = new Label();
            label1 = new Label();
            panelVisor = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 420);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(btnEjercicio2);
            flowLayoutPanel1.Controls.Add(btn3);
            flowLayoutPanel1.Controls.Add(btn4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.ForeColor = SystemColors.ActiveCaptionText;
            flowLayoutPanel1.Location = new Point(0, 30);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(192, 390);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(54, 54, 54);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 12F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(186, 75);
            button1.TabIndex = 0;
            button1.Text = "Ejercicio 1\r\n{Operadores Aritmeticos}\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnEjercicio2
            // 
            btnEjercicio2.BackColor = Color.FromArgb(54, 54, 54);
            btnEjercicio2.Cursor = Cursors.Hand;
            btnEjercicio2.FlatAppearance.BorderSize = 0;
            btnEjercicio2.FlatStyle = FlatStyle.Flat;
            btnEjercicio2.Font = new Font("Consolas", 12F);
            btnEjercicio2.ForeColor = SystemColors.ButtonHighlight;
            btnEjercicio2.Location = new Point(3, 84);
            btnEjercicio2.Name = "btnEjercicio2";
            btnEjercicio2.Size = new Size(186, 75);
            btnEjercicio2.TabIndex = 1;
            btnEjercicio2.Text = "Ejercicio 2\r\n{Radio y Longitud de un Circulo}\r\n";
            btnEjercicio2.UseVisualStyleBackColor = false;
            btnEjercicio2.Click += btn2;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(54, 54, 54);
            btn3.Cursor = Cursors.Hand;
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Consolas", 12F);
            btn3.ForeColor = SystemColors.ButtonHighlight;
            btn3.Location = new Point(3, 165);
            btn3.Name = "btn3";
            btn3.Size = new Size(186, 75);
            btn3.TabIndex = 2;
            btn3.Text = "Ejercicio 3\r\n{Calculo de IMC}\r\n";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(54, 54, 54);
            btn4.Cursor = Cursors.Hand;
            btn4.Font = new Font("Consolas", 12F);
            btn4.ForeColor = SystemColors.ButtonHighlight;
            btn4.Location = new Point(3, 243);
            btn4.Name = "btn4";
            btn4.Size = new Size(186, 80);
            btn4.TabIndex = 3;
            btn4.Text = "Ejercicio 4 { if Condicionales }";
            btn4.TextAlign = ContentAlignment.MiddleCenter;
            btn4.Click += btn4_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 1;
            label1.Text = "Ejercicios";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelVisor
            // 
            panelVisor.Dock = DockStyle.Fill;
            panelVisor.Location = new Point(192, 0);
            panelVisor.Name = "panelVisor";
            panelVisor.Size = new Size(608, 420);
            panelVisor.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 27, 27);
            ClientSize = new Size(800, 420);
            Controls.Add(panelVisor);
            Controls.Add(panel1);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            Name = "Menu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Panel panelVisor;
        private Button btnEjercicio2;
        private Button btn3;
        private Label btn4;
    }
}