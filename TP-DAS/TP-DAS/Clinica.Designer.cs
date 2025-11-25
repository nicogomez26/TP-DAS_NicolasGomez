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
            this.label1 = new System.Windows.Forms.Label();
            this.logueadoTxt = new System.Windows.Forms.Label();
            this.irUsuariosBtn = new System.Windows.Forms.Button();
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
            this.irPacientesBtn.Click += new System.EventHandler(this.irPacientesBtn_Click);
            // 
            // irMedicosBtn
            // 
            this.irMedicosBtn.Location = new System.Drawing.Point(387, 128);
            this.irMedicosBtn.Name = "irMedicosBtn";
            this.irMedicosBtn.Size = new System.Drawing.Size(190, 73);
            this.irMedicosBtn.TabIndex = 1;
            this.irMedicosBtn.Text = "Medicos";
            this.irMedicosBtn.UseVisualStyleBackColor = true;
            this.irMedicosBtn.Click += new System.EventHandler(this.irMedicosBtn_Click);
            // 
            // irTurnosBtn
            // 
            this.irTurnosBtn.Location = new System.Drawing.Point(597, 128);
            this.irTurnosBtn.Name = "irTurnosBtn";
            this.irTurnosBtn.Size = new System.Drawing.Size(190, 73);
            this.irTurnosBtn.TabIndex = 2;
            this.irTurnosBtn.Text = "Turnos";
            this.irTurnosBtn.UseVisualStyleBackColor = true;
            this.irTurnosBtn.Click += new System.EventHandler(this.irTurnosBtn_Click);
            // 
            // irEspecialidadesBtn
            // 
            this.irEspecialidadesBtn.Location = new System.Drawing.Point(177, 216);
            this.irEspecialidadesBtn.Name = "irEspecialidadesBtn";
            this.irEspecialidadesBtn.Size = new System.Drawing.Size(190, 73);
            this.irEspecialidadesBtn.TabIndex = 3;
            this.irEspecialidadesBtn.Text = "Especialidades";
            this.irEspecialidadesBtn.UseVisualStyleBackColor = true;
            this.irEspecialidadesBtn.Click += new System.EventHandler(this.irEspecialidadesBtn_Click);
            // 
            // irObSocBtn
            // 
            this.irObSocBtn.Location = new System.Drawing.Point(387, 216);
            this.irObSocBtn.Name = "irObSocBtn";
            this.irObSocBtn.Size = new System.Drawing.Size(190, 73);
            this.irObSocBtn.TabIndex = 4;
            this.irObSocBtn.Text = "Obras Sociales";
            this.irObSocBtn.UseVisualStyleBackColor = true;
            this.irObSocBtn.Click += new System.EventHandler(this.irObSocBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenido,";
            // 
            // logueadoTxt
            // 
            this.logueadoTxt.AutoSize = true;
            this.logueadoTxt.Location = new System.Drawing.Point(812, 38);
            this.logueadoTxt.Name = "logueadoTxt";
            this.logueadoTxt.Size = new System.Drawing.Size(10, 13);
            this.logueadoTxt.TabIndex = 6;
            this.logueadoTxt.Text = "-";
            // 
            // irUsuariosBtn
            // 
            this.irUsuariosBtn.Location = new System.Drawing.Point(597, 216);
            this.irUsuariosBtn.Name = "irUsuariosBtn";
            this.irUsuariosBtn.Size = new System.Drawing.Size(190, 73);
            this.irUsuariosBtn.TabIndex = 7;
            this.irUsuariosBtn.Text = "Usuarios";
            this.irUsuariosBtn.UseVisualStyleBackColor = true;
            this.irUsuariosBtn.Click += new System.EventHandler(this.irUsuariosBtn_Click);
            // 
            // Clinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 417);
            this.Controls.Add(this.irUsuariosBtn);
            this.Controls.Add(this.logueadoTxt);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button irPacientesBtn;
        private System.Windows.Forms.Button irMedicosBtn;
        private System.Windows.Forms.Button irTurnosBtn;
        private System.Windows.Forms.Button irEspecialidadesBtn;
        private System.Windows.Forms.Button irObSocBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logueadoTxt;
        private System.Windows.Forms.Button irUsuariosBtn;
    }
}
