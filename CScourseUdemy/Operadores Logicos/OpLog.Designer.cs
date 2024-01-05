namespace CScourseUdemy.Operadores_Logicos
{
    partial class OpLog
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
            btny = new Label();
            btnno = new Label();
            btno = new Label();
            label1 = new Label();
            lblresult = new Label();
            txtnum2 = new TextBox();
            panel2 = new Panel();
            txtnum1 = new TextBox();
            panel1 = new Panel();
            lblnum2 = new Label();
            lbltitulo = new Label();
            lblnum1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btny);
            flowLayoutPanel1.Controls.Add(btno);
            flowLayoutPanel1.Controls.Add(btnno);
            flowLayoutPanel1.Location = new Point(217, 322);
            flowLayoutPanel1.Margin = new Padding(4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(594, 94);
            flowLayoutPanel1.TabIndex = 26;
            // 
            // btny
            // 
            btny.BackColor = Color.FromArgb(255, 224, 192);
            btny.BorderStyle = BorderStyle.Fixed3D;
            btny.Cursor = Cursors.Hand;
            btny.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btny.ForeColor = SystemColors.ActiveCaptionText;
            btny.Location = new Point(5, 0);
            btny.Margin = new Padding(5, 0, 5, 0);
            btny.Name = "btny";
            btny.Size = new Size(82, 81);
            btny.TabIndex = 0;
            btny.Text = "Y(&&)";
            btny.TextAlign = ContentAlignment.MiddleCenter;
            btny.Click += btny_Click;
            // 
            // btnno
            // 
            btnno.BackColor = Color.FromArgb(255, 224, 192);
            btnno.BorderStyle = BorderStyle.Fixed3D;
            btnno.Cursor = Cursors.Hand;
            btnno.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btnno.ForeColor = SystemColors.ActiveCaptionText;
            btnno.Location = new Point(189, 0);
            btnno.Margin = new Padding(5, 0, 5, 0);
            btnno.Name = "btnno";
            btnno.Size = new Size(82, 81);
            btnno.TabIndex = 0;
            btnno.Text = "No(!)";
            btnno.TextAlign = ContentAlignment.MiddleCenter;
            btnno.Click += btnno_Click;
            // 
            // btno
            // 
            btno.BackColor = Color.FromArgb(255, 224, 192);
            btno.BorderStyle = BorderStyle.Fixed3D;
            btno.Cursor = Cursors.Hand;
            btno.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            btno.ForeColor = SystemColors.ActiveCaptionText;
            btno.Location = new Point(97, 0);
            btno.Margin = new Padding(5, 0, 5, 0);
            btno.Name = "btno";
            btno.Size = new Size(82, 81);
            btno.TabIndex = 0;
            btno.Text = "O(||)";
            btno.TextAlign = ContentAlignment.MiddleCenter;
            btno.Click += btno_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(217, 419);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 24;
            label1.Text = "Resultado =";
            // 
            // lblresult
            // 
            lblresult.AutoSize = true;
            lblresult.ForeColor = SystemColors.ActiveCaption;
            lblresult.Location = new Point(364, 419);
            lblresult.Margin = new Padding(5, 0, 5, 0);
            lblresult.Name = "lblresult";
            lblresult.Size = new Size(27, 19);
            lblresult.TabIndex = 25;
            lblresult.Text = "- ";
            lblresult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtnum2
            // 
            txtnum2.BackColor = SystemColors.MenuText;
            txtnum2.BorderStyle = BorderStyle.None;
            txtnum2.ForeColor = SystemColors.Info;
            txtnum2.Location = new Point(343, 262);
            txtnum2.Margin = new Padding(5);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(314, 19);
            txtnum2.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HighlightText;
            panel2.Location = new Point(341, 289);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 4);
            panel2.TabIndex = 23;
            // 
            // txtnum1
            // 
            txtnum1.BackColor = SystemColors.MenuText;
            txtnum1.BorderStyle = BorderStyle.None;
            txtnum1.ForeColor = SystemColors.Info;
            txtnum1.Location = new Point(343, 198);
            txtnum1.Margin = new Padding(5);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(316, 19);
            txtnum1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Location = new Point(343, 223);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 4);
            panel1.TabIndex = 21;
            // 
            // lblnum2
            // 
            lblnum2.AutoSize = true;
            lblnum2.ForeColor = SystemColors.ButtonHighlight;
            lblnum2.Location = new Point(217, 262);
            lblnum2.Margin = new Padding(5, 0, 5, 0);
            lblnum2.Name = "lblnum2";
            lblnum2.Size = new Size(90, 19);
            lblnum2.TabIndex = 17;
            lblnum2.Text = "Numero 2:";
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = SystemColors.ButtonHighlight;
            lbltitulo.Location = new Point(315, 133);
            lbltitulo.Margin = new Padding(5, 0, 5, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(243, 32);
            lbltitulo.TabIndex = 18;
            lbltitulo.Text = "Operadores Logicos";
            lbltitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblnum1
            // 
            lblnum1.AutoSize = true;
            lblnum1.ForeColor = SystemColors.ButtonHighlight;
            lblnum1.Location = new Point(217, 198);
            lblnum1.Margin = new Padding(5, 0, 5, 0);
            lblnum1.Name = "lblnum1";
            lblnum1.Size = new Size(90, 19);
            lblnum1.TabIndex = 19;
            lblnum1.Text = "Numero 1:";
            // 
            // OpLog
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1029, 570);
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
            Font = new Font("Consolas", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "OpLog";
            Text = "OpLog";
            WindowState = FormWindowState.Maximized;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label btny;
        private Label btnno;
        private Label btno;
        private Label label1;
        private Label lblresult;
        private TextBox txtnum2;
        private Panel panel2;
        private TextBox txtnum1;
        private Panel panel1;
        private Label lblnum2;
        private Label lbltitulo;
        private Label lblnum1;
    }
}