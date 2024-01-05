namespace CScourseUdemy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblholamundo = new Label();
            SuspendLayout();
            // 
            // lblholamundo
            // 
            lblholamundo.BackColor = SystemColors.ActiveCaption;
            lblholamundo.Dock = DockStyle.Fill;
            lblholamundo.Font = new Font("Ink Free", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblholamundo.Location = new Point(0, 0);
            lblholamundo.Name = "lblholamundo";
            lblholamundo.Size = new Size(800, 450);
            lblholamundo.TabIndex = 0;
            lblholamundo.Text = "Hola mundo";
            lblholamundo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblholamundo);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion

        private Label lblholamundo;
    }
}
