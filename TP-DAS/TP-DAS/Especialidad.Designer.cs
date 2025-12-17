namespace TP_DAS
{
    partial class Especialidad
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
            this.elimEspBtn = new TP_DAS.CUButton();
            this.cU11 = new TP_DAS.CU1();
            this.editEspBtn = new TP_DAS.CUButton();
            this.agrEspBtn = new TP_DAS.CUButton();
            this.IdEsp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.volverBtn = new TP_DAS.CUButton();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(385, 126);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(665, 293);
            this.grilla.TabIndex = 77;
            // 
            // elimEspBtn
            // 
            this.elimEspBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.elimEspBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.elimEspBtn.ColorTexto = System.Drawing.Color.White;
            this.elimEspBtn.Location = new System.Drawing.Point(86, 362);
            this.elimEspBtn.Name = "elimEspBtn";
            this.elimEspBtn.NombreBoton = null;
            this.elimEspBtn.Size = new System.Drawing.Size(245, 38);
            this.elimEspBtn.TabIndex = 86;
            this.elimEspBtn.Texto = "Eliminar";
            // 
            // cU11
            // 
            this.cU11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(46, 204);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(310, 48);
            this.cU11.TabIndex = 81;
            this.cU11.Texto = "";
            // 
            // editEspBtn
            // 
            this.editEspBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.editEspBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.editEspBtn.ColorTexto = System.Drawing.Color.White;
            this.editEspBtn.Location = new System.Drawing.Point(86, 318);
            this.editEspBtn.Name = "editEspBtn";
            this.editEspBtn.NombreBoton = null;
            this.editEspBtn.Size = new System.Drawing.Size(245, 38);
            this.editEspBtn.TabIndex = 85;
            this.editEspBtn.Texto = "Editar";
            // 
            // agrEspBtn
            // 
            this.agrEspBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.agrEspBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.agrEspBtn.ColorTexto = System.Drawing.Color.White;
            this.agrEspBtn.Location = new System.Drawing.Point(86, 274);
            this.agrEspBtn.Name = "agrEspBtn";
            this.agrEspBtn.NombreBoton = null;
            this.agrEspBtn.Size = new System.Drawing.Size(245, 38);
            this.agrEspBtn.TabIndex = 84;
            this.agrEspBtn.Texto = "Agregar";
            // 
            // IdEsp
            // 
            this.IdEsp.AutoSize = true;
            this.IdEsp.Location = new System.Drawing.Point(108, 166);
            this.IdEsp.Name = "IdEsp";
            this.IdEsp.Size = new System.Drawing.Size(10, 13);
            this.IdEsp.TabIndex = 83;
            this.IdEsp.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Id";
            // 
            // volverBtn
            // 
            this.volverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.volverBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.volverBtn.ColorTexto = System.Drawing.Color.White;
            this.volverBtn.Location = new System.Drawing.Point(46, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.NombreBoton = null;
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 105;
            this.volverBtn.Texto = "Volver";
            // 
            // Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 595);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.elimEspBtn);
            this.Controls.Add(this.cU11);
            this.Controls.Add(this.editEspBtn);
            this.Controls.Add(this.agrEspBtn);
            this.Controls.Add(this.IdEsp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla);
            this.Name = "Especialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.Especialidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CUDataGrid grilla;
        private CUButton elimEspBtn;
        private CU1 cU11;
        private CUButton editEspBtn;
        private CUButton agrEspBtn;
        private System.Windows.Forms.Label IdEsp;
        private System.Windows.Forms.Label label2;
        private CUButton volverBtn;
    }
}