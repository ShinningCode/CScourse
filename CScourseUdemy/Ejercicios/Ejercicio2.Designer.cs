namespace CScourseUdemy.Ejercicios
{
    partial class Ejercicio2
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
            lbltitulo2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnCalcular = new Label();
            label3 = new Label();
            lblresult1 = new Label();
            txtnum1 = new TextBox();
            panel3 = new Panel();
            lblnum1 = new Label();
            label2 = new Label();
            lblresult2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbltitulo2
            // 
            lbltitulo2.Dock = DockStyle.Top;
            lbltitulo2.Font = new Font("Consolas", 16F);
            lbltitulo2.ForeColor = SystemColors.ButtonFace;
            lbltitulo2.Location = new Point(0, 0);
            lbltitulo2.Name = "lbltitulo2";
            lbltitulo2.Size = new Size(750, 79);
            lbltitulo2.TabIndex = 0;
            lbltitulo2.Text = "Ejercicio 2";
            lbltitulo2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.e2;
            pictureBox1.Location = new Point(0, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(750, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Consolas", 16F);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(0, 282);
            label1.Name = "label1";
            label1.Size = new Size(750, 65);
            label1.TabIndex = 2;
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
            btnCalcular.Location = new Point(466, 377);
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
            label3.Location = new Point(152, 428);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 26);
            label3.TabIndex = 26;
            label3.Text = "Área =";
            // 
            // lblresult1
            // 
            lblresult1.AutoSize = true;
            lblresult1.Font = new Font("Consolas", 16F);
            lblresult1.ForeColor = SystemColors.InactiveCaption;
            lblresult1.Location = new Point(262, 428);
            lblresult1.Margin = new Padding(4, 0, 4, 0);
            lblresult1.Name = "lblresult1";
            lblresult1.Size = new Size(36, 26);
            lblresult1.TabIndex = 27;
            lblresult1.Text = "- ";
            // 
            // txtnum1
            // 
            txtnum1.BackColor = Color.FromArgb(57, 57, 57);
            txtnum1.BorderStyle = BorderStyle.None;
            txtnum1.ForeColor = SystemColors.Info;
            txtnum1.Location = new Point(185, 379);
            txtnum1.Margin = new Padding(4);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(239, 15);
            txtnum1.TabIndex = 20;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Location = new Point(185, 399);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 2);
            panel3.TabIndex = 21;
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.Font = new Font("Consolas", 12F);
            lblnum1.ForeColor = SystemColors.ButtonHighlight;
            lblnum1.Location = new Point(152, 377);
            lblnum1.Margin = new Padding(4, 0, 4, 0);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(27, 19);
            lblnum1.TabIndex = 19;
            lblnum1.Text = "r:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 16F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(152, 468);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 26);
            label2.TabIndex = 26;
            label2.Text = "Longitud =";
            // 
            // lblresult2
            // 
            lblresult2.AutoSize = true;
            lblresult2.Font = new Font("Consolas", 16F);
            lblresult2.ForeColor = SystemColors.InactiveCaption;
            lblresult2.Location = new Point(292, 468);
            lblresult2.Margin = new Padding(4, 0, 4, 0);
            lblresult2.Name = "lblresult2";
            lblresult2.Size = new Size(36, 26);
            lblresult2.TabIndex = 29;
            lblresult2.Text = "- ";
            // 
            // Ejercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 57, 57);
            Controls.Add(lblresult2);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lblresult1);
            Controls.Add(txtnum1);
            Controls.Add(panel3);
            Controls.Add(lblnum1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbltitulo2);
            Font = new Font("Consolas", 9F);
            Name = "Ejercicio2";
            Size = new Size(750, 603);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label btnCalcular;
        private Label label3;
        private Label lblresult1;
        private TextBox txtnum1;
        private Panel panel3;
        private Label lblnum1;
        private Label label2;
        private Label lblresult2;
    }
}
