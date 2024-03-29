﻿namespace CScourseUdemy.Ejercicios
{
    partial class Calculadora
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
            panel1 = new Panel();
            lblText = new Label();
            panel2 = new Panel();
            lblResult = new Label();
            button1 = new Button();
            lblOperacion = new Label();
            txtPantalla1 = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAc = new Button();
            btnPors = new Button();
            BtnOff = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnEquals = new Button();
            panelNumeros = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.image_removebg_preview;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(lblText);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(26, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 449);
            panel1.TabIndex = 3;
            // 
            // lblText
            // 
            lblText.Dock = DockStyle.Left;
            lblText.Font = new Font("Consolas", 16F);
            lblText.ForeColor = SystemColors.ButtonHighlight;
            lblText.Location = new Point(0, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(160, 449);
            lblText.TabIndex = 2;
            lblText.Text = "Ejercicio 6";
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Click += lblText_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(25, 26, 28);
            panel2.Controls.Add(lblResult);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(lblOperacion);
            panel2.Controls.Add(txtPantalla1);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(panelNumeros);
            panel2.Location = new Point(241, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(168, 280);
            panel2.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(25, 26, 28);
            lblResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResult.ForeColor = Color.White;
            lblResult.Location = new Point(65, 3);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(100, 13);
            lblResult.TabIndex = 8;
            lblResult.Text = "0";
            lblResult.TextAlign = ContentAlignment.TopRight;
            lblResult.Visible = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.doc;
            button1.Location = new Point(4, 49);
            button1.Name = "button1";
            button1.Size = new Size(23, 24);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblOperacion
            // 
            lblOperacion.BackColor = Color.FromArgb(25, 26, 28);
            lblOperacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOperacion.ForeColor = Color.FromArgb(51, 177, 134);
            lblOperacion.Location = new Point(65, 24);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(100, 13);
            lblOperacion.TabIndex = 6;
            lblOperacion.Text = "0";
            lblOperacion.TextAlign = ContentAlignment.TopRight;
            lblOperacion.Visible = false;
            // 
            // txtPantalla1
            // 
            txtPantalla1.BackColor = Color.FromArgb(25, 26, 28);
            txtPantalla1.BorderStyle = BorderStyle.None;
            txtPantalla1.Font = new Font("Verdana", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPantalla1.ForeColor = SystemColors.Window;
            txtPantalla1.Location = new Point(33, 40);
            txtPantalla1.Name = "txtPantalla1";
            txtPantalla1.ReadOnly = true;
            txtPantalla1.Size = new Size(132, 36);
            txtPantalla1.TabIndex = 5;
            txtPantalla1.Text = "0";
            txtPantalla1.TextAlign = HorizontalAlignment.Right;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnAc);
            flowLayoutPanel2.Controls.Add(btnPors);
            flowLayoutPanel2.Controls.Add(BtnOff);
            flowLayoutPanel2.Location = new Point(3, 79);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(123, 37);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnAc
            // 
            btnAc.BackgroundImage = Properties.Resources.elipse__;
            btnAc.BackgroundImageLayout = ImageLayout.Stretch;
            btnAc.Cursor = Cursors.Hand;
            btnAc.FlatAppearance.BorderSize = 0;
            btnAc.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAc.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAc.FlatStyle = FlatStyle.Flat;
            btnAc.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAc.ForeColor = Color.Black;
            btnAc.Location = new Point(3, 3);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(35, 33);
            btnAc.TabIndex = 13;
            btnAc.Text = "AC";
            btnAc.UseVisualStyleBackColor = true;
            btnAc.Click += btnAc_Click;
            // 
            // btnPors
            // 
            btnPors.BackgroundImage = Properties.Resources.elipse__;
            btnPors.BackgroundImageLayout = ImageLayout.Zoom;
            btnPors.Cursor = Cursors.Hand;
            btnPors.FlatAppearance.BorderSize = 0;
            btnPors.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPors.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPors.FlatStyle = FlatStyle.Flat;
            btnPors.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPors.ForeColor = Color.Black;
            btnPors.Location = new Point(44, 3);
            btnPors.Name = "btnPors";
            btnPors.Size = new Size(35, 33);
            btnPors.TabIndex = 14;
            btnPors.Text = "%";
            btnPors.UseVisualStyleBackColor = true;
            btnPors.Click += btnPors_Click;
            // 
            // BtnOff
            // 
            BtnOff.BackgroundImage = Properties.Resources.elipse__;
            BtnOff.BackgroundImageLayout = ImageLayout.Zoom;
            BtnOff.Cursor = Cursors.Hand;
            BtnOff.FlatAppearance.BorderSize = 0;
            BtnOff.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnOff.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnOff.FlatStyle = FlatStyle.Flat;
            BtnOff.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            BtnOff.ForeColor = Color.Black;
            BtnOff.Location = new Point(85, 3);
            BtnOff.Name = "BtnOff";
            BtnOff.Size = new Size(35, 33);
            BtnOff.TabIndex = 15;
            BtnOff.Text = "OFF";
            BtnOff.UseVisualStyleBackColor = true;
            BtnOff.Click += BtnOff_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(25, 26, 28);
            flowLayoutPanel1.Controls.Add(btnPlus);
            flowLayoutPanel1.Controls.Add(btnMinus);
            flowLayoutPanel1.Controls.Add(btnMult);
            flowLayoutPanel1.Controls.Add(btnDiv);
            flowLayoutPanel1.Controls.Add(btnEquals);
            flowLayoutPanel1.Location = new Point(129, 79);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(39, 201);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnPlus
            // 
            btnPlus.BackgroundImage = Properties.Resources.elipse__;
            btnPlus.BackgroundImageLayout = ImageLayout.Zoom;
            btnPlus.Cursor = Cursors.Hand;
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPlus.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnPlus.ForeColor = Color.Black;
            btnPlus.Location = new Point(3, 3);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(35, 33);
            btnPlus.TabIndex = 16;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackgroundImage = Properties.Resources.elipse__;
            btnMinus.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinus.Cursor = Cursors.Hand;
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMinus.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnMinus.ForeColor = Color.Black;
            btnMinus.Location = new Point(3, 42);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(35, 33);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMult
            // 
            btnMult.BackgroundImage = Properties.Resources.elipse__;
            btnMult.BackgroundImageLayout = ImageLayout.Zoom;
            btnMult.Cursor = Cursors.Hand;
            btnMult.FlatAppearance.BorderSize = 0;
            btnMult.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMult.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMult.FlatStyle = FlatStyle.Flat;
            btnMult.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnMult.ForeColor = Color.Black;
            btnMult.Location = new Point(3, 81);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(35, 33);
            btnMult.TabIndex = 18;
            btnMult.Text = "x";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackgroundImage = Properties.Resources.elipse__;
            btnDiv.BackgroundImageLayout = ImageLayout.Zoom;
            btnDiv.Cursor = Cursors.Hand;
            btnDiv.FlatAppearance.BorderSize = 0;
            btnDiv.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDiv.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDiv.FlatStyle = FlatStyle.Flat;
            btnDiv.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDiv.ForeColor = Color.Black;
            btnDiv.Location = new Point(3, 120);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(35, 33);
            btnDiv.TabIndex = 19;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackgroundImage = Properties.Resources.elipse__;
            btnEquals.BackgroundImageLayout = ImageLayout.Zoom;
            btnEquals.Cursor = Cursors.Hand;
            btnEquals.FlatAppearance.BorderSize = 0;
            btnEquals.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEquals.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnEquals.ForeColor = Color.Black;
            btnEquals.Location = new Point(3, 159);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(35, 33);
            btnEquals.TabIndex = 20;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // panelNumeros
            // 
            panelNumeros.BackColor = Color.FromArgb(25, 26, 28);
            panelNumeros.Location = new Point(3, 120);
            panelNumeros.Name = "panelNumeros";
            panelNumeros.Size = new Size(123, 160);
            panelNumeros.TabIndex = 0;
            panelNumeros.Paint += panelNumeros_Paint;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            Controls.Add(panel1);
            Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Calculadora";
            Size = new Size(678, 452);
            Load += Calculadora_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel panelNumeros;
        private Label lblText;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnAc;
        private Button btnPors;
        private Button BtnOff;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMult;
        private Button btnDiv;
        private Button btnEquals;
        private TextBox txtPantalla1;
        private Label lblOperacion;
        private Button button1;
        private Label lblResult;
    }
}
