namespace CScourseUdemy.Condicionales
{
    partial class Frmcondicionales
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
            label1 = new Label();
            panel1 = new Panel();
            txtnum1 = new TextBox();
            label2 = new Label();
            lblResult = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(53, 35);
            label1.Name = "label1";
            label1.Size = new Size(164, 24);
            label1.TabIndex = 0;
            label1.Text = "Digita un número :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(217, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 2);
            panel1.TabIndex = 1;
            // 
            // txtnum1
            // 
            txtnum1.BackColor = Color.FromArgb(29, 29, 29);
            txtnum1.BorderStyle = BorderStyle.None;
            txtnum1.Font = new Font("Microsoft Sans Serif", 14F);
            txtnum1.ForeColor = SystemColors.ButtonFace;
            txtnum1.Location = new Point(217, 39);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(200, 22);
            txtnum1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(53, 91);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 3;
            label2.Text = "Resultado :";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Microsoft Sans Serif", 14F);
            lblResult.ForeColor = SystemColors.ButtonFace;
            lblResult.Location = new Point(163, 91);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(16, 24);
            lblResult.TabIndex = 3;
            lblResult.Text = "-";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(54, 54, 54);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Consolas", 14F);
            btnCalcular.ForeColor = SystemColors.ButtonFace;
            btnCalcular.Location = new Point(495, 48);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 41);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Frmcondicionales
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(686, 390);
            Controls.Add(btnCalcular);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(txtnum1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Frmcondicionales";
            Text = "Frmcondicionales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtnum1;
        private Label label2;
        private Label lblResult;
        private Button btnCalcular;
    }
}