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
            btnCalcular = new Label();
            label3 = new Label();
            lblresult = new Label();
            txtnum3 = new TextBox();
            panel4 = new Panel();
            txtnum2 = new TextBox();
            panel2 = new Panel();
            txtnum1 = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            lblnum2 = new Label();
            lblnum1 = new Label();
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
            pictureBox1.Image = Properties.Resources.Untitled;
            pictureBox1.Location = new Point(0, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(744, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Consolas", 15F);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(0, 234);
            label2.Name = "label2";
            label2.Size = new Size(744, 49);
            label2.TabIndex = 2;
            label2.Text = "Solución";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblresult);
            panel1.Controls.Add(txtnum3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtnum2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtnum1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblnum2);
            panel1.Controls.Add(lblnum1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 283);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 210);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(255, 224, 192);
            btnCalcular.BorderStyle = BorderStyle.Fixed3D;
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(342, 62);
            btnCalcular.Margin = new Padding(4, 0, 4, 0);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(156, 48);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular";
            btnCalcular.TextAlign = ContentAlignment.MiddleCenter;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 16F);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(162, 160);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 26);
            label3.TabIndex = 14;
            label3.Text = "Resultado =";
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.Font = new Font("Consolas", 16F);
            lblresult.ForeColor = SystemColors.InactiveCaption;
            lblresult.Location = new Point(314, 160);
            lblresult.Margin = new Padding(4, 0, 4, 0);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(36, 26);
            lblresult.TabIndex = 15;
            lblresult.Text = "- ";
            // 
            // txtnum3
            // 
            txtnum3.BackColor = Color.FromArgb(57, 57, 57);
            txtnum3.BorderStyle = BorderStyle.None;
            txtnum3.ForeColor = SystemColors.Info;
            txtnum3.Location = new Point(66, 109);
            txtnum3.Margin = new Padding(4);
            txtnum3.Name = "txtnum3";
            txtnum3.Size = new Size(237, 15);
            txtnum3.TabIndex = 12;
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
            Size = new Size(744, 502);
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
        private TextBox txtnum3;
        private Panel panel4;
        private Label label4;
        private Label btnCalcular;
    }
}
