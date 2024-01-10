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
            lbltitulo = new Label();
            lstLista = new ListView();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lbltitulo
            // 
            lbltitulo.Dock = DockStyle.Top;
            lbltitulo.Font = new Font("Consolas", 14F);
            lbltitulo.Location = new Point(0, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(800, 57);
            lbltitulo.TabIndex = 0;
            lbltitulo.Text = "Listas";
            lbltitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstLista
            // 
            lstLista.Location = new Point(12, 75);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(283, 201);
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
            btnAgregar.Location = new Point(322, 75);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 60);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmListas
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            ClientSize = new Size(800, 420);
            Controls.Add(btnAgregar);
            Controls.Add(lstLista);
            Controls.Add(lbltitulo);
            Font = new Font("Consolas", 9F);
            ForeColor = SystemColors.ButtonFace;
            Name = "FrmListas";
            Text = "FrmListas";
            ResumeLayout(false);
        }

        #endregion

        private Label lbltitulo;
        private ListView lstLista;
        private Button btnAgregar;
    }
}