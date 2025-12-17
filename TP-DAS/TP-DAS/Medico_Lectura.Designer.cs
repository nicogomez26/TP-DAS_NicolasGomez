namespace TP_DAS
{
    partial class Medico_Lectura
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
            this.IdMedico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grilla = new TP_DAS.CUDataGrid();
            this.volverBtn = new TP_DAS.CUButton();
            this.expMedBtn = new TP_DAS.CUButton();
            this.button1 = new TP_DAS.CUButton();
            this.SuspendLayout();
            // 
            // IdMedico
            // 
            this.IdMedico.AutoSize = true;
            this.IdMedico.Location = new System.Drawing.Point(137, 97);
            this.IdMedico.Name = "IdMedico";
            this.IdMedico.Size = new System.Drawing.Size(10, 13);
            this.IdMedico.TabIndex = 91;
            this.IdMedico.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Id";
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(262, 80);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(689, 255);
            this.grilla.TabIndex = 94;
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
            this.volverBtn.TabIndex = 105;
            this.volverBtn.Texto = "Volver";
            // 
            // expMedBtn
            // 
            this.expMedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.expMedBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.expMedBtn.ColorTexto = System.Drawing.Color.White;
            this.expMedBtn.Location = new System.Drawing.Point(591, 341);
            this.expMedBtn.Name = "expMedBtn";
            this.expMedBtn.NombreBoton = null;
            this.expMedBtn.Size = new System.Drawing.Size(177, 30);
            this.expMedBtn.TabIndex = 106;
            this.expMedBtn.Texto = "Exportar Medicos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.button1.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.button1.ColorTexto = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(774, 341);
            this.button1.Name = "button1";
            this.button1.NombreBoton = null;
            this.button1.Size = new System.Drawing.Size(177, 30);
            this.button1.TabIndex = 107;
            this.button1.Texto = "Exportar Turnos del Medico";
            // 
            // Medico_Lectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 533);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.expMedBtn);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.IdMedico);
            this.Controls.Add(this.label2);
            this.Name = "Medico_Lectura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.Medico_Lectura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IdMedico;
        private System.Windows.Forms.Label label2;
        private CUDataGrid grilla;
        private CUButton volverBtn;
        private CUButton expMedBtn;
        private CUButton button1;
    }
}