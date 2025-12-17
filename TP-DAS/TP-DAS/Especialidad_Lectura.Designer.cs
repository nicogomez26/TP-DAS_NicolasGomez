namespace TP_DAS
{
    partial class Especialidad_Lectura
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
            this.grilla = new TP_DAS.CUDataGrid();
            this.volverBtn = new TP_DAS.CUButton();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(220, 128);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(704, 315);
            this.grilla.TabIndex = 78;
            // 
            // volverBtn
            // 
            this.volverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.volverBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.volverBtn.ColorTexto = System.Drawing.Color.White;
            this.volverBtn.Location = new System.Drawing.Point(12, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.NombreBoton = null;
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 106;
            this.volverBtn.Texto = "Volver";
            // 
            // Especialidad_Lectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 593);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.grilla);
            this.Name = "Especialidad_Lectura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.Especialidad_Lectura_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CUDataGrid grilla;
        private CUButton volverBtn;
    }
}