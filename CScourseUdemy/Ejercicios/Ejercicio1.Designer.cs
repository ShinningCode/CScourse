namespace CScourseUdemy.Ejercicios
{
    partial class Ejercicio1
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
            panel1 = new Panel();
            label3 = new Label();
            lblresult = new Label();
            txtnum2 = new TextBox();
            panel2 = new Panel();
            txtnum1 = new TextBox();
            panel3 = new Panel();
            lblnum2 = new Label();
            lblnum1 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            textBox1 = new TextBox();
            lblsuma = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Consolas", 15.75F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(744, 51);
            label1.TabIndex = 0;
            label1.Text = "Ejercicio 1";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.FormulaGeneral;
            pictureBox1.Location = new Point(0, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(744, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Consolas", 15F);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(0, 202);
            label2.Name = "label2";
            label2.Size = new Size(744, 49);
            label2.TabIndex = 2;
            label2.Text = "Solución";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblsuma);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblresult);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtnum2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtnum1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblnum2);
            panel1.Controls.Add(lblnum1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 251);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 210);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(200, 160);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 14);
            label3.TabIndex = 14;
            label3.Text = "Resultado =";
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.ForeColor = SystemColors.Control;
            lblresult.Location = new Point(314, 160);
            lblresult.Margin = new Padding(4, 0, 4, 0);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(21, 14);
            lblresult.TabIndex = 15;
            lblresult.Text = "- ";
            // 
            // txtnum2
            // 
            txtnum2.BackColor = Color.FromArgb(57, 57, 57);
            txtnum2.BorderStyle = BorderStyle.None;
            txtnum2.ForeColor = SystemColors.Info;
            txtnum2.Location = new Point(66, 64);
            txtnum2.Margin = new Padding(4);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(237, 15);
            txtnum2.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Location = new Point(64, 85);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 2);
            panel2.TabIndex = 13;
            // 
            // txtnum1
            // 
            txtnum1.BackColor = Color.FromArgb(57, 57, 57);
            txtnum1.BorderStyle = BorderStyle.None;
            txtnum1.ForeColor = SystemColors.Info;
            txtnum1.Location = new Point(66, 13);
            txtnum1.Margin = new Padding(4);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(239, 15);
            txtnum1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HighlightText;
            panel3.Location = new Point(66, 33);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 2);
            panel3.TabIndex = 11;
            // 
            // lblnum2
            // 
            lblnum2.AutoSize = true;
            lblnum2.Font = new Font("Consolas", 12F);
            lblnum2.ForeColor = SystemColors.ButtonHighlight;
            lblnum2.Location = new Point(33, 62);
            lblnum2.Margin = new Padding(4, 0, 4, 0);
            lblnum2.Name = "lblnum2";
            lblnum2.Size = new Size(27, 19);
            lblnum2.TabIndex = 8;
            lblnum2.Text = "b:";
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.Font = new Font("Consolas", 12F);
            lblnum1.ForeColor = SystemColors.ButtonHighlight;
            lblnum1.Location = new Point(33, 11);
            lblnum1.Margin = new Padding(4, 0, 4, 0);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(27, 19);
            lblnum1.TabIndex = 9;
            lblnum1.Text = "a:";
            lblnum1.Click += lblnum1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(33, 107);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(27, 19);
            label4.TabIndex = 8;
            label4.Text = "c:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.HighlightText;
            panel4.Location = new Point(64, 130);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(239, 2);
            panel4.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(57, 57, 57);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(66, 109);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 15);
            textBox1.TabIndex = 12;
            // 
            // lblsuma
            // 
            lblsuma.BackColor = Color.FromArgb(255, 224, 192);
            lblsuma.BorderStyle = BorderStyle.Fixed3D;
            lblsuma.Cursor = Cursors.Hand;
            lblsuma.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsuma.ForeColor = SystemColors.ActiveCaptionText;
            lblsuma.Location = new Point(342, 62);
            lblsuma.Margin = new Padding(4, 0, 4, 0);
            lblsuma.Name = "lblsuma";
            lblsuma.Size = new Size(156, 48);
            lblsuma.TabIndex = 16;
            lblsuma.Text = "Calcular";
            lblsuma.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Ejercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 57, 57);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Ejercicio1";
            Size = new Size(744, 461);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label lblresult;
        private TextBox txtnum2;
        private Panel panel2;
        private TextBox txtnum1;
        private Panel panel3;
        private Label lblnum2;
        private Label lblnum1;
        private TextBox textBox1;
        private Panel panel4;
        private Label label4;
        private Label lblsuma;
    }
}
