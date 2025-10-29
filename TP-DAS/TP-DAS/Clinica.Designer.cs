namespace TP_DAS
{
    partial class Clinica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.irPacientesBtn = new System.Windows.Forms.Button();
            this.irMedicosBtn = new System.Windows.Forms.Button();
            this.irTurnosBtn = new System.Windows.Forms.Button();
            this.irEspecialidadesBtn = new System.Windows.Forms.Button();
            this.irObSocBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // irPacientesBtn
            // 
            this.irPacientesBtn.Location = new System.Drawing.Point(177, 128);
            this.irPacientesBtn.Name = "irPacientesBtn";
            this.irPacientesBtn.Size = new System.Drawing.Size(190, 73);
            this.irPacientesBtn.TabIndex = 0;
            this.irPacientesBtn.Text = "Pacientes";
            this.irPacientesBtn.UseVisualStyleBackColor = true;
            // 
            // irMedicosBtn
            // 
            this.irMedicosBtn.Location = new System.Drawing.Point(387, 128);
            this.irMedicosBtn.Name = "irMedicosBtn";
            this.irMedicosBtn.Size = new System.Drawing.Size(190, 73);
            this.irMedicosBtn.TabIndex = 1;
            this.irMedicosBtn.Text = "Medicos";
            this.irMedicosBtn.UseVisualStyleBackColor = true;
            // 
            // irTurnosBtn
            // 
            this.irTurnosBtn.Location = new System.Drawing.Point(597, 128);
            this.irTurnosBtn.Name = "irTurnosBtn";
            this.irTurnosBtn.Size = new System.Drawing.Size(190, 73);
            this.irTurnosBtn.TabIndex = 2;
            this.irTurnosBtn.Text = "Turnos";
            this.irTurnosBtn.UseVisualStyleBackColor = true;
            // 
            // irEspecialidadesBtn
            // 
            this.irEspecialidadesBtn.Location = new System.Drawing.Point(281, 216);
            this.irEspecialidadesBtn.Name = "irEspecialidadesBtn";
            this.irEspecialidadesBtn.Size = new System.Drawing.Size(190, 73);
            this.irEspecialidadesBtn.TabIndex = 3;
            this.irEspecialidadesBtn.Text = "Especialidades";
            this.irEspecialidadesBtn.UseVisualStyleBackColor = true;
            // 
            // irObSocBtn
            // 
            this.irObSocBtn.Location = new System.Drawing.Point(498, 216);
            this.irObSocBtn.Name = "irObSocBtn";
            this.irObSocBtn.Size = new System.Drawing.Size(190, 73);
            this.irObSocBtn.TabIndex = 4;
            this.irObSocBtn.Text = "Obras Sociales";
            this.irObSocBtn.UseVisualStyleBackColor = true;
            // 
            // Clinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 417);
            this.Controls.Add(this.irObSocBtn);
            this.Controls.Add(this.irEspecialidadesBtn);
            this.Controls.Add(this.irTurnosBtn);
            this.Controls.Add(this.irMedicosBtn);
            this.Controls.Add(this.irPacientesBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clinica";
            this.Text = "Clinica";
            this.Load += new System.EventHandler(this.Clinica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button irPacientesBtn;
        private System.Windows.Forms.Button irMedicosBtn;
        private System.Windows.Forms.Button irTurnosBtn;
        private System.Windows.Forms.Button irEspecialidadesBtn;
        private System.Windows.Forms.Button irObSocBtn;
    }
}
