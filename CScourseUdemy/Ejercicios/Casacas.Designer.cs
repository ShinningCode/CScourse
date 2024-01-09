namespace CScourseUdemy.Ejercicios
{
    partial class Casacas
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
            lbltitulo = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            rbtnl = new RadioButton();
            rbtns = new RadioButton();
            rbtnm = new RadioButton();
            groupBox2 = new GroupBox();
            rbtnb = new RadioButton();
            rbtnr = new RadioButton();
            btnAgregar = new Button();
            txtCarrito = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.Dock = DockStyle.Top;
            lbltitulo.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltitulo.ForeColor = SystemColors.ButtonFace;
            lbltitulo.Location = new Point(0, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(732, 64);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Ejercicio 4";
            lbltitulo.TextAlign = ContentAlignment.MiddleLeft;
            lbltitulo.Click += lbltitulo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.ejercicio4;
            pictureBox1.Location = new Point(0, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(732, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnl);
            groupBox1.Controls.Add(rbtns);
            groupBox1.Controls.Add(rbtnm);
            groupBox1.Font = new Font("Consolas", 12F);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(6, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 119);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tallas";
            // 
            // rbtnl
            // 
            rbtnl.AutoSize = true;
            rbtnl.Location = new Point(25, 87);
            rbtnl.Name = "rbtnl";
            rbtnl.Size = new Size(162, 23);
            rbtnl.TabIndex = 0;
            rbtnl.TabStop = true;
            rbtnl.Text = "Talla L ( $150)";
            rbtnl.UseVisualStyleBackColor = true;
            // 
            // rbtns
            // 
            rbtns.AutoSize = true;
            rbtns.Location = new Point(25, 24);
            rbtns.Name = "rbtns";
            rbtns.Size = new Size(153, 23);
            rbtns.TabIndex = 0;
            rbtns.TabStop = true;
            rbtns.Text = "Talla S ( $50)";
            rbtns.UseVisualStyleBackColor = true;
            // 
            // rbtnm
            // 
            rbtnm.AutoSize = true;
            rbtnm.Location = new Point(25, 55);
            rbtnm.Name = "rbtnm";
            rbtnm.Size = new Size(162, 23);
            rbtnm.TabIndex = 0;
            rbtnm.TabStop = true;
            rbtnm.Text = "Talla M ( $100)";
            rbtnm.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtnb);
            groupBox2.Controls.Add(rbtnr);
            groupBox2.Font = new Font("Consolas", 12F);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(221, 163);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 119);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Colores";
            // 
            // rbtnb
            // 
            rbtnb.AutoSize = true;
            rbtnb.Location = new Point(25, 24);
            rbtnb.Name = "rbtnb";
            rbtnb.Size = new Size(81, 23);
            rbtnb.TabIndex = 0;
            rbtnb.TabStop = true;
            rbtnb.Text = "Blanco";
            rbtnb.UseVisualStyleBackColor = true;
            // 
            // rbtnr
            // 
            rbtnr.AutoSize = true;
            rbtnr.Location = new Point(25, 55);
            rbtnr.Name = "rbtnr";
            rbtnr.Size = new Size(63, 23);
            rbtnr.TabIndex = 0;
            rbtnr.TabStop = true;
            rbtnr.Text = "Rojo";
            rbtnr.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(427, 172);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(205, 35);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar a Carrito";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCarrito
            // 
            txtCarrito.BackColor = Color.FromArgb(80, 80, 80);
            txtCarrito.Font = new Font("Consolas", 12F);
            txtCarrito.ForeColor = SystemColors.Window;
            txtCarrito.Location = new Point(6, 288);
            txtCarrito.Multiline = true;
            txtCarrito.Name = "txtCarrito";
            txtCarrito.ScrollBars = ScrollBars.Vertical;
            txtCarrito.Size = new Size(415, 182);
            txtCarrito.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Consolas", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(6, 484);
            label2.Name = "label2";
            label2.Size = new Size(153, 19);
            label2.TabIndex = 5;
            label2.Text = "Total a Pagar : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Consolas", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(188, 484);
            label3.Name = "label3";
            label3.Size = new Size(18, 19);
            label3.TabIndex = 5;
            label3.Text = "-";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Consolas", 12F);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(170, 484);
            label4.Name = "label4";
            label4.Size = new Size(18, 19);
            label4.TabIndex = 6;
            label4.Text = "$";
            // 
            // Casacas
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 57, 57);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCarrito);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(lbltitulo);
            Font = new Font("Consolas", 9F);
            Name = "Casacas";
            Size = new Size(732, 555);
            Load += Casacas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitulo;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton rbtnl;
        private RadioButton rbtns;
        private RadioButton rbtnm;
        private GroupBox groupBox2;
        private RadioButton rbtnb;
        private RadioButton rbtnr;
        private Button btnAgregar;
        private TextBox txtCarrito;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
