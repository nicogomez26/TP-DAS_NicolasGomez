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
            this.grilla = new System.Windows.Forms.DataGridView();
            this.volverBtn = new System.Windows.Forms.Button();
            this.IdMedico = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.expMedBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(373, 97);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(713, 256);
            this.grilla.TabIndex = 87;
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(11, 9);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 86;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
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
            // expMedBtn
            // 
            this.expMedBtn.Location = new System.Drawing.Point(751, 359);
            this.expMedBtn.Name = "expMedBtn";
            this.expMedBtn.Size = new System.Drawing.Size(165, 29);
            this.expMedBtn.TabIndex = 93;
            this.expMedBtn.Text = "Exportar Medicos";
            this.expMedBtn.UseVisualStyleBackColor = true;
            this.expMedBtn.Click += new System.EventHandler(this.expMedBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(922, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 29);
            this.button1.TabIndex = 92;
            this.button1.Text = "Exportar Turnos del Medico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Medico_Lectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 533);
            this.Controls.Add(this.expMedBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IdMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.volverBtn);
            this.Name = "Medico_Lectura";
            this.Text = "Medico_Lectura";
            this.Load += new System.EventHandler(this.Medico_Lectura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Label IdMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button expMedBtn;
        private System.Windows.Forms.Button button1;
    }
}