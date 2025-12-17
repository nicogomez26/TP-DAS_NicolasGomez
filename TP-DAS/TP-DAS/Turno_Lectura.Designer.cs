namespace TP_DAS
{
    partial class Turno_Lectura
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
            this.expXMLBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.grilla = new TP_DAS.CUDataGrid();
            this.SuspendLayout();
            // 
            // expXMLBtn
            // 
            this.expXMLBtn.Location = new System.Drawing.Point(911, 384);
            this.expXMLBtn.Name = "expXMLBtn";
            this.expXMLBtn.Size = new System.Drawing.Size(130, 29);
            this.expXMLBtn.TabIndex = 84;
            this.expXMLBtn.Text = "Exportar Turnos";
            this.expXMLBtn.UseVisualStyleBackColor = true;
            this.expXMLBtn.Click += new System.EventHandler(this.expXMLBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(12, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 82;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(256, 93);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(785, 285);
            this.grilla.TabIndex = 95;
            // 
            // Turno_Lectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 524);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.expXMLBtn);
            this.Controls.Add(this.volverBtn);
            this.Name = "Turno_Lectura";
            this.Text = "Turno_Lectura";
            this.Load += new System.EventHandler(this.Turno_Lectura_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button expXMLBtn;
        private System.Windows.Forms.Button volverBtn;
        private CUDataGrid grilla;
    }
}