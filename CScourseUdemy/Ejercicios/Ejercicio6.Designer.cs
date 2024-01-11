namespace CScourseUdemy.Ejercicios
{
    partial class Ejercicio6
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblText = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtPantalla = new TextBox();
            panelNumeros = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.Dock = DockStyle.Top;
            lblText.Font = new Font("Consolas", 16F);
            lblText.ForeColor = SystemColors.ButtonHighlight;
            lblText.Location = new Point(0, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(721, 66);
            lblText.TabIndex = 0;
            lblText.Text = "Ejercicio 6";
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.ej6;
            pictureBox1.Location = new Point(0, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(721, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.image_removebg_preview;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 198);
            panel1.Name = "panel1";
            panel1.Size = new Size(721, 558);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 29, 29);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(txtPantalla);
            panel2.Controls.Add(panelNumeros);
            panel2.Location = new Point(166, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 300);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(29, 29, 29);
            flowLayoutPanel1.Location = new Point(124, 53);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(40, 247);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // txtPantalla
            // 
            txtPantalla.BackColor = Color.FromArgb(29, 29, 29);
            txtPantalla.BorderStyle = BorderStyle.None;
            txtPantalla.Font = new Font("Georgia", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPantalla.ForeColor = SystemColors.Window;
            txtPantalla.Location = new Point(17, 3);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(139, 33);
            txtPantalla.TabIndex = 0;
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // panelNumeros
            // 
            panelNumeros.BackColor = Color.FromArgb(29, 29, 29);
            panelNumeros.Location = new Point(3, 53);
            panelNumeros.Name = "panelNumeros";
            panelNumeros.Size = new Size(117, 247);
            panelNumeros.TabIndex = 0;
            panelNumeros.Paint += flowLayoutPanel1_Paint;
            // 
            // Ejercicio6
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 54, 54);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblText);
            Font = new Font("Consolas", 9F);
            Name = "Ejercicio6";
            Size = new Size(721, 660);
            Load += Ejercicio6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblText;
        private PictureBox pictureBox1;
        private Panel panel1;
        private FlowLayoutPanel panelNumeros;
        private TextBox txtPantalla;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
