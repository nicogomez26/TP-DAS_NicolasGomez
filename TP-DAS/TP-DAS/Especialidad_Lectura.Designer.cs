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
            this.volverBtn = new System.Windows.Forms.Button();
            this.grilla = new TP_DAS.CUDataGrid();
            this.SuspendLayout();
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(14, 22);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 75;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(220, 128);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(704, 315);
            this.grilla.TabIndex = 78;
            // 
            // Especialidad_Lectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 593);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.volverBtn);
            this.Name = "Especialidad_Lectura";
            this.Text = "Especialidad_Lectura";
            this.Load += new System.EventHandler(this.Especialidad_Lectura_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button volverBtn;
        private CUDataGrid grilla;
    }
}