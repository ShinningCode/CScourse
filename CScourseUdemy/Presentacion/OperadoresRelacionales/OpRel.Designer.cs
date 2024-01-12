namespace CScourseUdemy.OperadoresRelacionales
{
    partial class OpRel
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnmayor = new Label();
            btnmenor = new Label();
            btnmayorque = new Label();
            btnmenorque = new Label();
            btnigual = new Label();
            btndifque = new Label();
            label1 = new Label();
            lblresult = new Label();
            txtnum2 = new TextBox();
            panel2 = new Panel();
            txtnum1 = new TextBox();
            panel1 = new Panel();
            lblnum2 = new Label();
            lblnum1 = new Label();
            lbltitulo = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnmayor);
            flowLayoutPanel1.Controls.Add(btnmenor);
            flowLayoutPanel1.Controls.Add(btnmayorque);
            flowLayoutPanel1.Controls.Add(btnmenorque);
            flowLayoutPanel1.Controls.Add(btnigual);
            flowLayoutPanel1.Controls.Add(btndifque);
            flowLayoutPanel1.Location = new Point(228, 228);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(462, 74);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // btnmayor
            // 
            btnmayor.BackColor = Color.FromArgb(255, 224, 192);
            btnmayor.BorderStyle = BorderStyle.Fixed3D;
            btnmayor.Cursor = Cursors.Hand;
            btnmayor.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmayor.ForeColor = SystemColors.ActiveCaptionText;
            btnmayor.Location = new Point(4, 0);
            btnmayor.Margin = new Padding(4, 0, 4, 0);
            btnmayor.Name = "btnmayor";
            btnmayor.Size = new Size(64, 64);
            btnmayor.TabIndex = 0;
            btnmayor.Text = ">";
            btnmayor.TextAlign = ContentAlignment.MiddleCenter;
            btnmayor.Click += btnmayor_Click;
            // 
            // btnmenor
            // 
            btnmenor.BackColor = Color.FromArgb(255, 224, 192);
            btnmenor.BorderStyle = BorderStyle.Fixed3D;
            btnmenor.Cursor = Cursors.Hand;
            btnmenor.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmenor.ForeColor = SystemColors.ActiveCaptionText;
            btnmenor.Location = new Point(76, 0);
            btnmenor.Margin = new Padding(4, 0, 4, 0);
            btnmenor.Name = "btnmenor";
            btnmenor.Size = new Size(64, 64);
            btnmenor.TabIndex = 0;
            btnmenor.Text = "<";
            btnmenor.TextAlign = ContentAlignment.MiddleCenter;
            btnmenor.Click += btnmenor_Click;
            // 
            // btnmayorque
            // 
            btnmayorque.BackColor = Color.FromArgb(255, 224, 192);
            btnmayorque.BorderStyle = BorderStyle.Fixed3D;
            btnmayorque.Cursor = Cursors.Hand;
            btnmayorque.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmayorque.ForeColor = SystemColors.ActiveCaptionText;
            btnmayorque.Location = new Point(148, 0);
            btnmayorque.Margin = new Padding(4, 0, 4, 0);
            btnmayorque.Name = "btnmayorque";
            btnmayorque.Size = new Size(64, 64);
            btnmayorque.TabIndex = 0;
            btnmayorque.Text = "<=";
            btnmayorque.TextAlign = ContentAlignment.MiddleCenter;
            btnmayorque.Click += btnmayorque_Click;
            // 
            // btnmenorque
            // 
            btnmenorque.BackColor = Color.FromArgb(255, 224, 192);
            btnmenorque.BorderStyle = BorderStyle.Fixed3D;
            btnmenorque.Cursor = Cursors.Hand;
            btnmenorque.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmenorque.ForeColor = SystemColors.ActiveCaptionText;
            btnmenorque.Location = new Point(220, 0);
            btnmenorque.Margin = new Padding(4, 0, 4, 0);
            btnmenorque.Name = "btnmenorque";
            btnmenorque.Size = new Size(64, 64);
            btnmenorque.TabIndex = 0;
            btnmenorque.Text = ">=";
            btnmenorque.TextAlign = ContentAlignment.MiddleCenter;
            btnmenorque.Click += btnmenorque_Click;
            // 
            // btnigual
            // 
            btnigual.BackColor = Color.FromArgb(255, 224, 192);
            btnigual.BorderStyle = BorderStyle.Fixed3D;
            btnigual.Cursor = Cursors.Hand;
            btnigual.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnigual.ForeColor = SystemColors.ActiveCaptionText;
            btnigual.Location = new Point(292, 0);
            btnigual.Margin = new Padding(4, 0, 4, 0);
            btnigual.Name = "btnigual";
            btnigual.Size = new Size(64, 64);
            btnigual.TabIndex = 0;
            btnigual.Text = "==";
            btnigual.TextAlign = ContentAlignment.MiddleCenter;
            btnigual.Click += btnigual_Click;
            // 
            // btndifque
            // 
            btndifque.BackColor = Color.FromArgb(255, 224, 192);
            btndifque.BorderStyle = BorderStyle.Fixed3D;
            btndifque.Cursor = Cursors.Hand;
            btndifque.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndifque.ForeColor = SystemColors.ActiveCaptionText;
            btndifque.Location = new Point(364, 0);
            btndifque.Margin = new Padding(4, 0, 4, 0);
            btndifque.Name = "btndifque";
            btndifque.Size = new Size(64, 64);
            btndifque.TabIndex = 0;
            btndifque.Text = "!=";
            btndifque.TextAlign = ContentAlignment.MiddleCenter;
            btndifque.Click += btndifque_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(228, 305);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 14;
            label1.Text = "Resultado =";
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.ForeColor = SystemColors.ActiveCaption;
            lblresult.Location = new Point(342, 305);
            lblresult.Margin = new Padding(4, 0, 4, 0);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(14, 15);
            lblresult.TabIndex = 15;
            lblresult.Text = "- ";
            lblresult.TextAlign = ContentAlignment.MiddleCenter;
            lblresult.Click += lblresult_Click;
            // 
            // txtnum2
            // 
            txtnum2.BackColor = SystemColors.MenuText;
            txtnum2.BorderStyle = BorderStyle.None;
            txtnum2.ForeColor = SystemColors.Info;
            txtnum2.Location = new Point(326, 181);
            txtnum2.Margin = new Padding(4);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(244, 14);
            txtnum2.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Location = new Point(324, 202);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 3);
            panel2.TabIndex = 13;
            // 
            // txtnum1
            // 
            txtnum1.BackColor = SystemColors.MenuText;
            txtnum1.BorderStyle = BorderStyle.None;
            txtnum1.ForeColor = SystemColors.Info;
            txtnum1.Location = new Point(326, 130);
            txtnum1.Margin = new Padding(4);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(246, 14);
            txtnum1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Location = new Point(326, 150);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 3);
            panel1.TabIndex = 11;
            // 
            // lblnum2
            // 
            lblnum2.AutoSize = true;
            lblnum2.ForeColor = SystemColors.ButtonHighlight;
            lblnum2.Location = new Point(228, 181);
            lblnum2.Margin = new Padding(4, 0, 4, 0);
            lblnum2.Name = "lblnum2";
            lblnum2.Size = new Size(65, 15);
            lblnum2.TabIndex = 8;
            lblnum2.Text = "Numero 2:";
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.ForeColor = SystemColors.ButtonHighlight;
            lblnum1.Location = new Point(228, 130);
            lblnum1.Margin = new Padding(4, 0, 4, 0);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(65, 15);
            lblnum1.TabIndex = 9;
            lblnum1.Text = "Numero 1:";
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = SystemColors.ButtonHighlight;
            lbltitulo.Location = new Point(304, 79);
            lbltitulo.Margin = new Padding(4, 0, 4, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(299, 32);
            lbltitulo.TabIndex = 9;
            lbltitulo.Text = "Operadores Relacionales";
            lbltitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OpRel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(lblresult);
            Controls.Add(txtnum2);
            Controls.Add(panel2);
            Controls.Add(txtnum1);
            Controls.Add(panel1);
            Controls.Add(lblnum2);
            Controls.Add(lbltitulo);
            Controls.Add(lblnum1);
            Font = new Font("Arial", 9F);
            Name = "OpRel";
            Text = "OpRel";
            Load += OpRel_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label btnmayor;
        private Label btnmenor;
        private Label btnmayorque;
        private Label btnmenorque;
        private Label label1;
        private Label lblresult;
        private TextBox txtnum2;
        private Panel panel2;
        private TextBox txtnum1;
        private Panel panel1;
        private Label lblnum2;
        private Label lblnum1;
        private Label btnigual;
        private Label btndifque;
        private Label lbltitulo;
    }
}