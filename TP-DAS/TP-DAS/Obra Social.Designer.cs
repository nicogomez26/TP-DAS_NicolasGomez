namespace TP_DAS
{
    partial class Obra_Social
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
            this.cU11 = new TP_DAS.CU1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idObraSocial = new System.Windows.Forms.Label();
            this.grilla = new TP_DAS.CUDataGrid();
            this.elimOSBtn = new TP_DAS.CUButton();
            this.editOSBtn = new TP_DAS.CUButton();
            this.agrOSBtn = new TP_DAS.CUButton();
            this.SuspendLayout();
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(12, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 66;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // cU11
            // 
            this.cU11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(48, 177);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(292, 33);
            this.cU11.TabIndex = 57;
            this.cU11.Texto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Crear Obra Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Id";
            // 
            // idObraSocial
            // 
            this.idObraSocial.AutoSize = true;
            this.idObraSocial.Location = new System.Drawing.Point(107, 141);
            this.idObraSocial.Name = "idObraSocial";
            this.idObraSocial.Size = new System.Drawing.Size(10, 13);
            this.idObraSocial.TabIndex = 69;
            this.idObraSocial.Text = "-";
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(357, 114);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(689, 255);
            this.grilla.TabIndex = 95;
            // 
            // elimOSBtn
            // 
            this.elimOSBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.elimOSBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.elimOSBtn.ColorTexto = System.Drawing.Color.White;
            this.elimOSBtn.Location = new System.Drawing.Point(80, 321);
            this.elimOSBtn.Name = "elimOSBtn";
            this.elimOSBtn.Size = new System.Drawing.Size(245, 38);
            this.elimOSBtn.TabIndex = 98;
            this.elimOSBtn.Texto = "Eliminar";
            // 
            // editOSBtn
            // 
            this.editOSBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.editOSBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.editOSBtn.ColorTexto = System.Drawing.Color.White;
            this.editOSBtn.Location = new System.Drawing.Point(80, 277);
            this.editOSBtn.Name = "editOSBtn";
            this.editOSBtn.Size = new System.Drawing.Size(245, 38);
            this.editOSBtn.TabIndex = 97;
            this.editOSBtn.Texto = "Editar";
            // 
            // agrOSBtn
            // 
            this.agrOSBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.agrOSBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.agrOSBtn.ColorTexto = System.Drawing.Color.White;
            this.agrOSBtn.Location = new System.Drawing.Point(80, 233);
            this.agrOSBtn.Name = "agrOSBtn";
            this.agrOSBtn.Size = new System.Drawing.Size(245, 38);
            this.agrOSBtn.TabIndex = 96;
            this.agrOSBtn.Texto = "Agregar";
            // 
            // Obra_Social
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 594);
            this.Controls.Add(this.elimOSBtn);
            this.Controls.Add(this.editOSBtn);
            this.Controls.Add(this.agrOSBtn);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.idObraSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.cU11);
            this.Controls.Add(this.label1);
            this.Name = "Obra_Social";
            this.Text = "Obra_Social";
            this.Load += new System.EventHandler(this.Obra_Social_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button volverBtn;
        private CU1 cU11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idObraSocial;
        private CUDataGrid grilla;
        private CUButton elimOSBtn;
        private CUButton editOSBtn;
        private CUButton agrOSBtn;
    }
}