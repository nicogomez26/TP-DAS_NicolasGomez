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
            this.volverBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IdEsp = new System.Windows.Forms.Label();
            this.espGrp = new System.Windows.Forms.GroupBox();
            this.grilla = new TP_DAS.CUDataGrid();
            this.cU11 = new TP_DAS.CU1();
            this.agrEspBtn = new TP_DAS.CUButton();
            this.editEspBtn = new TP_DAS.CUButton();
            this.elimEspBtn = new TP_DAS.CUButton();
            this.espGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(23, 18);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 73;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Id";
            // 
            // IdEsp
            // 
            this.IdEsp.AutoSize = true;
            this.IdEsp.Location = new System.Drawing.Point(63, 56);
            this.IdEsp.Name = "IdEsp";
            this.IdEsp.Size = new System.Drawing.Size(10, 13);
            this.IdEsp.TabIndex = 76;
            this.IdEsp.Text = "-";
            // 
            // espGrp
            // 
            this.espGrp.Controls.Add(this.elimEspBtn);
            this.espGrp.Controls.Add(this.cU11);
            this.espGrp.Controls.Add(this.editEspBtn);
            this.espGrp.Controls.Add(this.agrEspBtn);
            this.espGrp.Controls.Add(this.IdEsp);
            this.espGrp.Controls.Add(this.label2);
            this.espGrp.Location = new System.Drawing.Point(44, 126);
            this.espGrp.Name = "espGrp";
            this.espGrp.Size = new System.Drawing.Size(319, 293);
            this.espGrp.TabIndex = 77;
            this.espGrp.TabStop = false;
            this.espGrp.Text = "Gestionar Especialidades";
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(385, 126);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(665, 293);
            this.grilla.TabIndex = 77;
            // 
            // cU11
            // 
            this.cU11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(6, 82);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(292, 33);
            this.cU11.TabIndex = 69;
            this.cU11.Texto = "";
            // 
            // agrEspBtn
            // 
            this.agrEspBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.agrEspBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.agrEspBtn.ColorTexto = System.Drawing.Color.White;
            this.agrEspBtn.Location = new System.Drawing.Point(38, 145);
            this.agrEspBtn.Name = "agrEspBtn";
            this.agrEspBtn.Size = new System.Drawing.Size(245, 38);
            this.agrEspBtn.TabIndex = 78;
            this.agrEspBtn.Texto = "Agregar";
            // 
            // editEspBtn
            // 
            this.editEspBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.editEspBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.editEspBtn.ColorTexto = System.Drawing.Color.White;
            this.editEspBtn.Location = new System.Drawing.Point(38, 189);
            this.editEspBtn.Name = "editEspBtn";
            this.editEspBtn.Size = new System.Drawing.Size(245, 38);
            this.editEspBtn.TabIndex = 79;
            this.editEspBtn.Texto = "Editar";
            // 
            // elimEspBtn
            // 
            this.elimEspBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.elimEspBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.elimEspBtn.ColorTexto = System.Drawing.Color.White;
            this.elimEspBtn.Location = new System.Drawing.Point(38, 233);
            this.elimEspBtn.Name = "elimEspBtn";
            this.elimEspBtn.Size = new System.Drawing.Size(245, 38);
            this.elimEspBtn.TabIndex = 80;
            this.elimEspBtn.Texto = "Eliminar";
            // 
            // Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 595);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.espGrp);
            this.Controls.Add(this.volverBtn);
            this.Name = "Especialidad";
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.Especialidad_Load);
            this.espGrp.ResumeLayout(false);
            this.espGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button volverBtn;
        private CU1 cU11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IdEsp;
        private System.Windows.Forms.GroupBox espGrp;
        private CUDataGrid grilla;
        private CUButton elimEspBtn;
        private CUButton editEspBtn;
        private CUButton agrEspBtn;
    }
}