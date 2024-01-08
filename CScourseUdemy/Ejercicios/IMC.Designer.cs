namespace CScourseUdemy.Ejercicios
{
    partial class IMC
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
            lbltitulo3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnCalcular = new Label();
            label3 = new Label();
            lblresult = new Label();
            txtnum2 = new TextBox();
            panel2 = new Panel();
            txtnum1 = new TextBox();
            panel3 = new Panel();
            lblnum2 = new Label();
            lblnum1 = new Label();
            lblestado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbltitulo3
            // 
            lbltitulo3.Dock = DockStyle.Top;
            lbltitulo3.Font = new Font("Consolas", 16F);
            lbltitulo3.ForeColor = SystemColors.ButtonFace;
            lbltitulo3.Location = new Point(0, 0);
            lbltitulo3.Name = "lbltitulo3";
            lbltitulo3.Size = new Size(739, 79);
            lbltitulo3.TabIndex = 1;
            lbltitulo3.Text = "Ejercicio 3";
            lbltitulo3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.imc;
            pictureBox1.Location = new Point(0, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(739, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Consolas", 16F);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(0, 314);
            label1.Name = "label1";
            label1.Size = new Size(739, 56);
            label1.TabIndex = 3;
            label1.Text = "Solución";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(255, 224, 192);
            btnCalcular.BorderStyle = BorderStyle.Fixed3D;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(551, 390);
            btnCalcular.Margin = new Padding(4, 0, 4, 0);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(156, 48);
            btnCalcular.TabIndex = 28;
            btnCalcular.Text = "Calcular";
            btnCalcular.TextAlign = ContentAlignment.MiddleCenter;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 16F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(194, 476);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 26);
            label3.TabIndex = 26;
            label3.Text = "IMC =";
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Font = new Font("Consolas", 16F);
            lblresult.ForeColor = Color.IndianRed;
            lblresult.Location = new Point(274, 476);
            lblresult.Margin = new Padding(4, 0, 4, 0);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(36, 26);
            lblresult.TabIndex = 27;
            lblresult.Text = "- ";
            // 
            // txtnum2
            // 
            txtnum2.BackColor = Color.FromArgb(57, 57, 57);
            txtnum2.BorderStyle = BorderStyle.None;
            txtnum2.ForeColor = SystemColors.Info;
            txtnum2.Location = new Point(274, 421);
            txtnum2.Margin = new Padding(4);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(237, 16);
            txtnum2.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Location = new Point(272, 442);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 2);
            panel2.TabIndex = 25;
            // 
            // txtnum1
            // 
            txtnum1.BackColor = Color.FromArgb(57, 57, 57);
            txtnum1.BorderStyle = BorderStyle.None;
            txtnum1.ForeColor = SystemColors.Info;
            txtnum1.Location = new Point(274, 370);
            txtnum1.Margin = new Padding(4);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(239, 16);
            txtnum1.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Location = new Point(274, 390);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 2);
            panel3.TabIndex = 21;
            // 
            // lblnum2
            // 
            lblnum2.AutoSize = true;
            lblnum2.Font = new Font("Consolas", 12F);
            lblnum2.ForeColor = SystemColors.ButtonHighlight;
            lblnum2.Location = new Point(196, 418);
            lblnum2.Margin = new Padding(4, 0, 4, 0);
            lblnum2.Name = "lblnum2";
            lblnum2.Size = new Size(72, 19);
            lblnum2.TabIndex = 18;
            lblnum2.Text = "Altura:";
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.Font = new Font("Consolas", 12F);
            lblnum1.ForeColor = SystemColors.ButtonHighlight;
            lblnum1.Location = new Point(212, 367);
            lblnum1.Margin = new Padding(4, 0, 4, 0);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(54, 19);
            lblnum1.TabIndex = 19;
            lblnum1.Text = "Peso:";
            // 
            // lblestado
            // 
            lblestado.AutoSize = true;
            lblestado.Font = new Font("Consolas", 20F);
            lblestado.ForeColor = Color.Gainsboro;
            lblestado.Location = new Point(274, 525);
            lblestado.Margin = new Padding(4, 0, 4, 0);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(44, 32);
            lblestado.TabIndex = 29;
            lblestado.Text = "- ";
            // 
            // IMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 57, 57);
            Controls.Add(lblestado);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(lblresult);
            Controls.Add(txtnum2);
            Controls.Add(panel2);
            Controls.Add(txtnum1);
            Controls.Add(panel3);
            Controls.Add(lblnum2);
            Controls.Add(lblnum1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbltitulo3);
            Name = "IMC";
            Size = new Size(739, 587);
            Load += IMC_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo3;
        private PictureBox pictureBox1;
        private Label label1;
        private Label btnCalcular;
        private Label label3;
        private Label lblresult;
        private TextBox txtnum2;
        private Panel panel2;
        private TextBox txtnum1;
        private Panel panel3;
        private Label lblnum2;
        private Label lblnum1;
        private Label lblestado;
    }
}
