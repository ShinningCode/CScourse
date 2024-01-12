namespace CScourseUdemy.Listas
{
    partial class FrmListas
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
            lstLista = new ListView();
            btnAgregar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtPantalla = new TextBox();
            panelNumerico = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lstLista
            // 
            lstLista.Location = new Point(6, 25);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(191, 201);
            lstLista.TabIndex = 1;
            lstLista.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Consolas", 14F);
            btnAgregar.ForeColor = SystemColors.ActiveCaption;
            btnAgregar.Location = new Point(227, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 60);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(lstLista);
            groupBox1.Font = new Font("Consolas", 12F);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 273);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listas - Array";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPantalla);
            groupBox2.Controls.Add(panelNumerico);
            groupBox2.Font = new Font("Consolas", 12F);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(393, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 475);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Teclado Numerico";
            // 
            // txtPantalla
            // 
            txtPantalla.BackColor = Color.FromArgb(29, 29, 29);
            txtPantalla.Font = new Font("Consolas", 14F);
            txtPantalla.ForeColor = SystemColors.Info;
            txtPantalla.Location = new Point(23, 25);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.Size = new Size(239, 29);
            txtPantalla.TabIndex = 5;
            // 
            // panelNumerico
            // 
            panelNumerico.Location = new Point(21, 57);
            panelNumerico.Name = "panelNumerico";
            panelNumerico.Size = new Size(256, 368);
            panelNumerico.TabIndex = 0;
            // 
            // FrmListas
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(800, 749);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Consolas", 9F);
            ForeColor = SystemColors.ButtonFace;
            Name = "FrmListas";
            Text = "FrmListas";
            Load += FrmListas_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListView lstLista;
        private Button btnAgregar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private FlowLayoutPanel panelNumerico;
        private TextBox txtPantalla;
    }
}