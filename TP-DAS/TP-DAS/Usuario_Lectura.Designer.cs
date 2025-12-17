namespace TP_DAS
{
    partial class Usuario_Lectura
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
            this.label3 = new System.Windows.Forms.Label();
            this.volverBtn = new System.Windows.Forms.Button();
            this.grilla = new TP_DAS.CUDataGrid();
            this.expXMLBtn = new TP_DAS.CUButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(946, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Bienvenido,";
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(16, 15);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 73;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(386, 117);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(689, 255);
            this.grilla.TabIndex = 95;
            // 
            // expXMLBtn
            // 
            this.expXMLBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.expXMLBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.expXMLBtn.ColorTexto = System.Drawing.Color.White;
            this.expXMLBtn.Location = new System.Drawing.Point(830, 378);
            this.expXMLBtn.Name = "expXMLBtn";
            this.expXMLBtn.NombreBoton = null;
            this.expXMLBtn.Size = new System.Drawing.Size(245, 38);
            this.expXMLBtn.TabIndex = 110;
            this.expXMLBtn.Texto = "Exportar Usuarios";
            // 
            // Usuario_Lectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 556);
            this.Controls.Add(this.expXMLBtn);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.volverBtn);
            this.Name = "Usuario_Lectura";
            this.Text = "Usuario_Lectura";
            this.Load += new System.EventHandler(this.Usuario_Lectura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button volverBtn;
        private CUDataGrid grilla;
        private CUButton expXMLBtn;
    }
}