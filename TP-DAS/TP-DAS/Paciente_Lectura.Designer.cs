namespace TP_DAS
{
    partial class Paciente_Lectura
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
            this.expPacientesBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idPaciente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grilla = new TP_DAS.CUDataGrid();
            this.SuspendLayout();
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(12, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 84;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // expPacientesBtn
            // 
            this.expPacientesBtn.Location = new System.Drawing.Point(654, 354);
            this.expPacientesBtn.Name = "expPacientesBtn";
            this.expPacientesBtn.Size = new System.Drawing.Size(165, 29);
            this.expPacientesBtn.TabIndex = 88;
            this.expPacientesBtn.Text = "Exportar Pacientes";
            this.expPacientesBtn.UseVisualStyleBackColor = true;
            this.expPacientesBtn.Click += new System.EventHandler(this.expPacientesBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(825, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 29);
            this.button2.TabIndex = 87;
            this.button2.Text = "Exportar Turnos del Paciente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idPaciente
            // 
            this.idPaciente.AutoSize = true;
            this.idPaciente.Location = new System.Drawing.Point(119, 89);
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.Size = new System.Drawing.Size(10, 13);
            this.idPaciente.TabIndex = 90;
            this.idPaciente.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "ID:";
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(301, 93);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(689, 255);
            this.grilla.TabIndex = 95;
            // 
            // Paciente_Lectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 465);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.idPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.expPacientesBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.volverBtn);
            this.Name = "Paciente_Lectura";
            this.Text = "Paciente_Lectura";
            this.Load += new System.EventHandler(this.Paciente_Lectura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button expPacientesBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label idPaciente;
        private System.Windows.Forms.Label label2;
        private CUDataGrid grilla;
    }
}