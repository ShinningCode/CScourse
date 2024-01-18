namespace CScourseUdemy.Presentacion.Crud
{
    partial class frmCrud
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
            btnGuardar = new Button();
            txtNombres = new TextBox();
            txtCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtEdad = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pnl1 = new Panel();
            button1 = new Button();
            datalist = new DataGridView();
            pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datalist).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(134, 204, 240);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(136, 151);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombres
            // 
            txtNombres.BackColor = Color.FromArgb(19, 19, 19);
            txtNombres.BorderStyle = BorderStyle.None;
            txtNombres.Font = new Font("Consolas", 12F);
            txtNombres.ForeColor = SystemColors.Info;
            txtNombres.Location = new Point(136, 61);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(200, 19);
            txtNombres.TabIndex = 12;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.FromArgb(19, 19, 19);
            txtCodigo.BorderStyle = BorderStyle.None;
            txtCodigo.Font = new Font("Consolas", 12F);
            txtCodigo.ForeColor = SystemColors.Info;
            txtCodigo.Location = new Point(136, 26);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 19);
            txtCodigo.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(40, 61);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 8;
            label4.Text = "Nombres :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(40, 28);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 9;
            label3.Text = "Codigo :";
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.FromArgb(19, 19, 19);
            txtEdad.BorderStyle = BorderStyle.None;
            txtEdad.Font = new Font("Consolas", 12F);
            txtEdad.ForeColor = SystemColors.Info;
            txtEdad.Location = new Point(136, 100);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(200, 19);
            txtEdad.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(136, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 2);
            panel3.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(40, 101);
            label1.Name = "label1";
            label1.Size = new Size(63, 19);
            label1.TabIndex = 14;
            label1.Text = "Edad :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(136, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 2);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(136, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 2);
            panel2.TabIndex = 16;
            // 
            // pnl1
            // 
            pnl1.BackColor = Color.FromArgb(19, 19, 19);
            pnl1.BackgroundImageLayout = ImageLayout.Zoom;
            pnl1.Controls.Add(button1);
            pnl1.Controls.Add(txtEdad);
            pnl1.Controls.Add(panel2);
            pnl1.Controls.Add(btnGuardar);
            pnl1.Controls.Add(panel1);
            pnl1.Controls.Add(label3);
            pnl1.Controls.Add(label4);
            pnl1.Controls.Add(panel3);
            pnl1.Controls.Add(txtCodigo);
            pnl1.Controls.Add(label1);
            pnl1.Controls.Add(txtNombres);
            pnl1.ForeColor = SystemColors.ActiveBorder;
            pnl1.Location = new Point(12, 12);
            pnl1.Name = "pnl1";
            pnl1.Size = new Size(541, 199);
            pnl1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(55, 180, 93);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(217, 151);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 17;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = false;
            // 
            // datalist
            // 
            datalist.AllowUserToAddRows = false;
            datalist.BackgroundColor = Color.FromArgb(29, 29, 29);
            datalist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datalist.Location = new Point(12, 240);
            datalist.Name = "datalist";
            datalist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datalist.Size = new Size(440, 240);
            datalist.TabIndex = 18;
            datalist.CellClick += datalist_CellClick;
            datalist.CellContentClick += datalist_CellContentClick;
            // 
            // frmCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 420);
            Controls.Add(datalist);
            Controls.Add(pnl1);
            DoubleBuffered = true;
            Font = new Font("Consolas", 9F);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmCrud";
            Text = "CRUD";
            WindowState = FormWindowState.Maximized;
            Load += frmCrud_Load;
            pnl1.ResumeLayout(false);
            pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datalist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtNombres;
        private TextBox txtCodigo;
        private Label label4;
        private Label label3;
        private TextBox txtEdad;
        private Panel panel3;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel pnl1;
        private DataGridView datalist;
        private Button button1;
    }
}