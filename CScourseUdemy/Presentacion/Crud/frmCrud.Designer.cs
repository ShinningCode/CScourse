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
            SuspendLayout();
            // 
            // frmCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 29, 29);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 420);
            DoubleBuffered = true;
            Font = new Font("Consolas", 9F);
            Name = "frmCrud";
            Text = "CRUD";
            WindowState = FormWindowState.Maximized;
            Load += frmCrud_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}