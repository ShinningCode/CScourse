namespace CScourseUdemy.OperadoresAritmeticos
{
    partial class OpAtms
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
            lblsuma = new Label();
            lblnum1 = new Label();
            lblnum2 = new Label();
            txtnum1 = new TextBox();
            panel1 = new Panel();
            txtnum2 = new TextBox();
            panel2 = new Panel();
            lblresult = new Label();
            label1 = new Label();
            lblrest = new Label();
            lblmult = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbldiv = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblsuma
            // 
            lblsuma.BackColor = Color.FromArgb(255, 224, 192);
            lblsuma.BorderStyle = BorderStyle.Fixed3D;
            lblsuma.Cursor = Cursors.Hand;
            lblsuma.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsuma.ForeColor = SystemColors.ActiveCaptionText;
            lblsuma.Location = new Point(4, 0);
            lblsuma.Margin = new Padding(4, 0, 4, 0);
            lblsuma.Name = "lblsuma";
            lblsuma.Size = new Size(51, 48);
            lblsuma.TabIndex = 0;
            lblsuma.Text = "+";
            lblsuma.TextAlign = ContentAlignment.MiddleCenter;
            lblsuma.Click += lblsuma_Click;
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.ForeColor = SystemColors.ButtonHighlight;
            lblnum1.Location = new Point(202, 121);
            lblnum1.Margin = new Padding(4, 0, 4, 0);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(90, 19);
            lblnum1.TabIndex = 1;
            lblnum1.Text = "Numero 1:";
            // 
            // lblnum2
            // 
            lblnum2.AutoSize = true;
            lblnum2.ForeColor = SystemColors.ButtonHighlight;
            lblnum2.Location = new Point(202, 172);
            lblnum2.Margin = new Padding(4, 0, 4, 0);
            lblnum2.Name = "lblnum2";
            lblnum2.Size = new Size(90, 19);
            lblnum2.TabIndex = 1;
            lblnum2.Text = "Numero 2:";
            // 
            // txtnum1
            // 
            txtnum1.BackColor = SystemColors.MenuText;
            txtnum1.BorderStyle = BorderStyle.None;
            txtnum1.ForeColor = SystemColors.Info;
            txtnum1.Location = new Point(300, 121);
            txtnum1.Margin = new Padding(4);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(246, 19);
            txtnum1.TabIndex = 2;
            txtnum1.TextChanged += txtnum1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Location = new Point(300, 141);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 3);
            panel1.TabIndex = 3;
            // 
            // txtnum2
            // 
            txtnum2.BackColor = SystemColors.MenuText;
            txtnum2.BorderStyle = BorderStyle.None;
            txtnum2.ForeColor = SystemColors.Info;
            txtnum2.Location = new Point(300, 172);
            txtnum2.Margin = new Padding(4);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(244, 19);
            txtnum2.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Location = new Point(298, 193);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 3);
            panel2.TabIndex = 5;
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.ForeColor = SystemColors.Control;
            lblresult.Location = new Point(316, 296);
            lblresult.Margin = new Padding(4, 0, 4, 0);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(27, 19);
            lblresult.TabIndex = 6;
            lblresult.Text = "- ";
            lblresult.Click += lblresult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(202, 296);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 6;
            label1.Text = "Resultado =";
            // 
            // lblrest
            // 
            lblrest.BackColor = Color.FromArgb(255, 224, 192);
            lblrest.BorderStyle = BorderStyle.Fixed3D;
            lblrest.Cursor = Cursors.Hand;
            lblrest.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblrest.ForeColor = SystemColors.ActiveCaptionText;
            lblrest.Location = new Point(63, 0);
            lblrest.Margin = new Padding(4, 0, 4, 0);
            lblrest.Name = "lblrest";
            lblrest.Size = new Size(51, 48);
            lblrest.TabIndex = 0;
            lblrest.Text = "-";
            lblrest.TextAlign = ContentAlignment.MiddleCenter;
            lblrest.Click += lblrest_Click;
            // 
            // lblmult
            // 
            lblmult.BackColor = Color.FromArgb(255, 224, 192);
            lblmult.BorderStyle = BorderStyle.Fixed3D;
            lblmult.Cursor = Cursors.Hand;
            lblmult.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblmult.ForeColor = SystemColors.ActiveCaptionText;
            lblmult.Location = new Point(122, 0);
            lblmult.Margin = new Padding(4, 0, 4, 0);
            lblmult.Name = "lblmult";
            lblmult.Size = new Size(51, 48);
            lblmult.TabIndex = 0;
            lblmult.Text = "x";
            lblmult.TextAlign = ContentAlignment.MiddleCenter;
            lblmult.Click += lblmult_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lblsuma);
            flowLayoutPanel1.Controls.Add(lblrest);
            flowLayoutPanel1.Controls.Add(lblmult);
            flowLayoutPanel1.Controls.Add(lbldiv);
            flowLayoutPanel1.Location = new Point(202, 219);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(344, 54);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // lbldiv
            // 
            lbldiv.BackColor = Color.FromArgb(255, 224, 192);
            lbldiv.BorderStyle = BorderStyle.Fixed3D;
            lbldiv.Cursor = Cursors.Hand;
            lbldiv.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldiv.ForeColor = SystemColors.ActiveCaptionText;
            lbldiv.Location = new Point(181, 0);
            lbldiv.Margin = new Padding(4, 0, 4, 0);
            lbldiv.Name = "lbldiv";
            lbldiv.Size = new Size(51, 48);
            lbldiv.TabIndex = 0;
            lbldiv.Text = "/";
            lbldiv.TextAlign = ContentAlignment.MiddleCenter;
            lbldiv.Click += lbldiv_Click;
            // 
            // OpAtms
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(1029, 570);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(lblresult);
            Controls.Add(txtnum2);
            Controls.Add(panel2);
            Controls.Add(txtnum1);
            Controls.Add(panel1);
            Controls.Add(lblnum2);
            Controls.Add(lblnum1);
            Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            Name = "OpAtms";
            Text = "Operadores Aritmeticos";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblsuma;
        private Label lblnum1;
        private Label lblnum2;
        private TextBox txtnum1;
        private Panel panel1;
        private TextBox txtnum2;
        private Panel panel2;
        private Label lblresult;
        private Label label1;
        private Label lblrest;
        private Label lblmult;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbldiv;
    }
}