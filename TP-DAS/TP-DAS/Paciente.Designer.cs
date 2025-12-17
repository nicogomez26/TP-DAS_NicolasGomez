namespace TP_DAS
{
    partial class Paciente
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
            this.label2 = new System.Windows.Forms.Label();
            this.idPaciente = new System.Windows.Forms.Label();
            this.cUcmb1 = new TP_DAS.CUcmb();
            this.cU32 = new TP_DAS.CU3();
            this.cU22 = new TP_DAS.CU2();
            this.cU21 = new TP_DAS.CU2();
            this.cU12 = new TP_DAS.CU1();
            this.cU11 = new TP_DAS.CU1();
            this.grilla = new TP_DAS.CUDataGrid();
            this.elimPacBtn = new TP_DAS.CUButton();
            this.editPacBtn = new TP_DAS.CUButton();
            this.agrPacBtn = new TP_DAS.CUButton();
            this.cuButton1 = new TP_DAS.CUButton();
            this.cuButton2 = new TP_DAS.CUButton();
            this.volverBtn = new TP_DAS.CUButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID:";
            // 
            // idPaciente
            // 
            this.idPaciente.AutoSize = true;
            this.idPaciente.Location = new System.Drawing.Point(95, 77);
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.Size = new System.Drawing.Size(10, 13);
            this.idPaciente.TabIndex = 57;
            this.idPaciente.Text = "-";
            // 
            // cUcmb1
            // 
            this.cUcmb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cUcmb1.Etiqueta = "Sexo";
            this.cUcmb1.Items = new string[0];
            this.cUcmb1.Location = new System.Drawing.Point(42, 307);
            this.cUcmb1.Name = "cUcmb1";
            this.cUcmb1.SelectedItem = "";
            this.cUcmb1.Size = new System.Drawing.Size(310, 58);
            this.cUcmb1.TabIndex = 9;
            // 
            // cU32
            // 
            this.cU32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU32.Etiqueta = "Obra Soc.";
            this.cU32.Location = new System.Drawing.Point(42, 370);
            this.cU32.Name = "cU32";
            this.cU32.Size = new System.Drawing.Size(310, 58);
            this.cU32.TabIndex = 8;
            this.cU32.TextoSeleccionado = "";
            this.cU32.ValorSeleccionado = -1;
            // 
            // cU22
            // 
            this.cU22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU22.Etiqueta = "Edad";
            this.cU22.Location = new System.Drawing.Point(42, 252);
            this.cU22.Name = "cU22";
            this.cU22.Size = new System.Drawing.Size(310, 50);
            this.cU22.TabIndex = 5;
            this.cU22.Texto = "";
            // 
            // cU21
            // 
            this.cU21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU21.Etiqueta = "DNI";
            this.cU21.Location = new System.Drawing.Point(42, 93);
            this.cU21.Name = "cU21";
            this.cU21.Size = new System.Drawing.Size(310, 48);
            this.cU21.TabIndex = 4;
            this.cU21.Texto = "";
            // 
            // cU12
            // 
            this.cU12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU12.Etiqueta = "Apellido";
            this.cU12.Location = new System.Drawing.Point(42, 199);
            this.cU12.Name = "cU12";
            this.cU12.Size = new System.Drawing.Size(310, 48);
            this.cU12.TabIndex = 3;
            this.cU12.Texto = "";
            // 
            // cU11
            // 
            this.cU11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(42, 146);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(310, 48);
            this.cU11.TabIndex = 2;
            this.cU11.Texto = "";
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(391, 114);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(689, 255);
            this.grilla.TabIndex = 95;
            // 
            // elimPacBtn
            // 
            this.elimPacBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.elimPacBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.elimPacBtn.ColorTexto = System.Drawing.Color.White;
            this.elimPacBtn.Location = new System.Drawing.Point(119, 505);
            this.elimPacBtn.Name = "elimPacBtn";
            this.elimPacBtn.NombreBoton = null;
            this.elimPacBtn.Size = new System.Drawing.Size(162, 28);
            this.elimPacBtn.TabIndex = 101;
            this.elimPacBtn.Texto = "Eliminar";
            // 
            // editPacBtn
            // 
            this.editPacBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.editPacBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.editPacBtn.ColorTexto = System.Drawing.Color.White;
            this.editPacBtn.Location = new System.Drawing.Point(119, 471);
            this.editPacBtn.Name = "editPacBtn";
            this.editPacBtn.NombreBoton = null;
            this.editPacBtn.Size = new System.Drawing.Size(162, 28);
            this.editPacBtn.TabIndex = 100;
            this.editPacBtn.Texto = "Editar";
            // 
            // agrPacBtn
            // 
            this.agrPacBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.agrPacBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.agrPacBtn.ColorTexto = System.Drawing.Color.White;
            this.agrPacBtn.Location = new System.Drawing.Point(119, 437);
            this.agrPacBtn.Name = "agrPacBtn";
            this.agrPacBtn.NombreBoton = null;
            this.agrPacBtn.Size = new System.Drawing.Size(162, 28);
            this.agrPacBtn.TabIndex = 99;
            this.agrPacBtn.Texto = "Agregar";
            // 
            // cuButton1
            // 
            this.cuButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cuButton1.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cuButton1.ColorTexto = System.Drawing.Color.White;
            this.cuButton1.Location = new System.Drawing.Point(584, 375);
            this.cuButton1.Name = "cuButton1";
            this.cuButton1.NombreBoton = null;
            this.cuButton1.Size = new System.Drawing.Size(245, 38);
            this.cuButton1.TabIndex = 102;
            this.cuButton1.Texto = "Exportar Pacientes";
            this.cuButton1.Load += new System.EventHandler(this.cuButton1_Load);
            // 
            // cuButton2
            // 
            this.cuButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cuButton2.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cuButton2.ColorTexto = System.Drawing.Color.White;
            this.cuButton2.Location = new System.Drawing.Point(835, 375);
            this.cuButton2.Name = "cuButton2";
            this.cuButton2.NombreBoton = null;
            this.cuButton2.Size = new System.Drawing.Size(245, 38);
            this.cuButton2.TabIndex = 103;
            this.cuButton2.Texto = "Exportar Turnos del Paciente";
            this.cuButton2.Load += new System.EventHandler(this.cuButton2_Load);
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
            this.volverBtn.TabIndex = 108;
            this.volverBtn.Texto = "Volver";
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 542);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.cuButton2);
            this.Controls.Add(this.cuButton1);
            this.Controls.Add(this.elimPacBtn);
            this.Controls.Add(this.editPacBtn);
            this.Controls.Add(this.agrPacBtn);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.idPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cUcmb1);
            this.Controls.Add(this.cU32);
            this.Controls.Add(this.cU22);
            this.Controls.Add(this.cU21);
            this.Controls.Add(this.cU12);
            this.Controls.Add(this.cU11);
            this.Name = "Paciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Paciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CU1 cU11;
        private CU1 cU12;
        private CU2 cU21;
        private CU2 cU22;
        private CU3 cU32;
        private CUcmb cUcmb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idPaciente;
        private CUDataGrid grilla;
        private CUButton elimPacBtn;
        private CUButton editPacBtn;
        private CUButton agrPacBtn;
        private CUButton cuButton1;
        private CUButton cuButton2;
        private CUButton volverBtn;
    }
}