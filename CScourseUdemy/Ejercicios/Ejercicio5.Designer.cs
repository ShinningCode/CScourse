namespace CScourseUdemy.Ejercicios
{
    partial class Ejercicio5
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnsolucion = new Button();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            lbl3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Consolas", 14F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(746, 48);
            label1.TabIndex = 0;
            label1.Text = "Ejercicio 5";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.ej5;
            pictureBox1.Location = new Point(0, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(746, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Consolas", 14F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(0, 182);
            label2.Name = "label2";
            label2.Size = new Size(746, 48);
            label2.TabIndex = 2;
            label2.Text = "Soulción";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnsolucion
            // 
            btnsolucion.BackColor = SystemColors.InactiveCaption;
            btnsolucion.Cursor = Cursors.Hand;
            btnsolucion.FlatAppearance.BorderSize = 0;
            btnsolucion.FlatStyle = FlatStyle.Flat;
            btnsolucion.Font = new Font("Consolas", 14F);
            btnsolucion.Location = new Point(571, 269);
            btnsolucion.Name = "btnsolucion";
            btnsolucion.Size = new Size(85, 32);
            btnsolucion.TabIndex = 3;
            btnsolucion.Text = "Probar";
            btnsolucion.UseVisualStyleBackColor = false;
            btnsolucion.Click += btnsolucion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(69, 261);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 4;
            label3.Text = "Numero 1 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(69, 295);
            label4.Name = "label4";
            label4.Size = new Size(99, 19);
            label4.TabIndex = 4;
            label4.Text = "Numero 2 :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(165, 278);
            panel1.Name = "panel1";
            panel1.Size = new Size(82, 2);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(165, 313);
            panel2.Name = "panel2";
            panel2.Size = new Size(82, 2);
            panel2.TabIndex = 6;
            // 
            // txtnum1
            // 
            txtnum1.BackColor = Color.FromArgb(57, 57, 57);
            txtnum1.BorderStyle = BorderStyle.None;
            txtnum1.Font = new Font("Consolas", 12F);
            txtnum1.ForeColor = SystemColors.Info;
            txtnum1.Location = new Point(165, 259);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(82, 19);
            txtnum1.TabIndex = 7;
            // 
            // txtnum2
            // 
            txtnum2.BackColor = Color.FromArgb(57, 57, 57);
            txtnum2.BorderStyle = BorderStyle.None;
            txtnum2.Font = new Font("Consolas", 12F);
            txtnum2.ForeColor = SystemColors.Info;
            txtnum2.Location = new Point(165, 294);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(82, 19);
            txtnum2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(321, 261);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 8;
            label5.Text = "Tipo :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(321, 295);
            label6.Name = "label6";
            label6.Size = new Size(63, 19);
            label6.TabIndex = 8;
            label6.Text = "Tipo :";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Consolas", 12F);
            lbl2.ForeColor = SystemColors.ButtonFace;
            lbl2.Location = new Point(390, 295);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(18, 19);
            lbl2.TabIndex = 8;
            lbl2.Text = "-";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Consolas", 12F);
            lbl1.ForeColor = SystemColors.ButtonFace;
            lbl1.Location = new Point(390, 261);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(18, 19);
            lbl1.TabIndex = 8;
            lbl1.Text = "-";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Consolas", 18F);
            lbl3.ForeColor = SystemColors.ButtonFace;
            lbl3.Location = new Point(165, 336);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(25, 28);
            lbl3.TabIndex = 8;
            lbl3.Text = "-";
            // 
            // Ejercicio5
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 57, 57);
            Controls.Add(lbl1);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnsolucion);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Consolas", 9F);
            Name = "Ejercicio5";
            Size = new Size(746, 376);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnsolucion;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtnum1;
        private TextBox txtnum2;
        private Label label5;
        private Label label6;
        private Label lbl2;
        private Label lbl1;
        private Label lbl3;
    }
}
