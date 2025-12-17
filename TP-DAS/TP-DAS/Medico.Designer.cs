namespace TP_DAS
{
    partial class Medico
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdMedico = new System.Windows.Forms.Label();
            this.cUcmb1 = new TP_DAS.CUcmb();
            this.cU32 = new TP_DAS.CU3();
            this.cU22 = new TP_DAS.CU2();
            this.cU21 = new TP_DAS.CU2();
            this.cU12 = new TP_DAS.CU1();
            this.cU11 = new TP_DAS.CU1();
            this.grilla = new TP_DAS.CUDataGrid();
            this.elimMedBtn = new TP_DAS.CUButton();
            this.editMedBtn = new TP_DAS.CUButton();
            this.agrMedBtn = new TP_DAS.CUButton();
            this.expXMLBtn = new TP_DAS.CUButton();
            this.expMedBtn = new TP_DAS.CUButton();
            this.SuspendLayout();
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(19, 25);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 66;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Crear Medico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Id";
            // 
            // IdMedico
            // 
            this.IdMedico.AutoSize = true;
            this.IdMedico.Location = new System.Drawing.Point(131, 124);
            this.IdMedico.Name = "IdMedico";
            this.IdMedico.Size = new System.Drawing.Size(10, 13);
            this.IdMedico.TabIndex = 69;
            this.IdMedico.Text = "-";
            // 
            // cUcmb1
            // 
            this.cUcmb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cUcmb1.Etiqueta = "Sexo";
            this.cUcmb1.Items = new string[0];
            this.cUcmb1.Location = new System.Drawing.Point(45, 306);
            this.cUcmb1.Name = "cUcmb1";
            this.cUcmb1.SelectedItem = "";
            this.cUcmb1.Size = new System.Drawing.Size(305, 28);
            this.cUcmb1.TabIndex = 62;
            // 
            // cU32
            // 
            this.cU32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU32.Etiqueta = "Espe.";
            this.cU32.Location = new System.Drawing.Point(45, 341);
            this.cU32.Name = "cU32";
            this.cU32.Size = new System.Drawing.Size(305, 28);
            this.cU32.TabIndex = 61;
            this.cU32.TextoSeleccionado = "";
            // 
            // cU22
            // 
            this.cU22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU22.Etiqueta = "Edad";
            this.cU22.Location = new System.Drawing.Point(45, 267);
            this.cU22.Name = "cU22";
            this.cU22.Size = new System.Drawing.Size(292, 33);
            this.cU22.TabIndex = 60;
            this.cU22.Texto = "";
            // 
            // cU21
            // 
            this.cU21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU21.Etiqueta = "DNI";
            this.cU21.Location = new System.Drawing.Point(45, 149);
            this.cU21.Name = "cU21";
            this.cU21.Size = new System.Drawing.Size(292, 33);
            this.cU21.TabIndex = 59;
            this.cU21.Texto = "";
            // 
            // cU12
            // 
            this.cU12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU12.Etiqueta = "Apellido";
            this.cU12.Location = new System.Drawing.Point(45, 227);
            this.cU12.Name = "cU12";
            this.cU12.Size = new System.Drawing.Size(292, 33);
            this.cU12.TabIndex = 58;
            this.cU12.Texto = "";
            // 
            // cU11
            // 
            this.cU11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(45, 188);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(292, 33);
            this.cU11.TabIndex = 57;
            this.cU11.Texto = "";
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(411, 149);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(684, 220);
            this.grilla.TabIndex = 87;
            // 
            // elimMedBtn
            // 
            this.elimMedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.elimMedBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.elimMedBtn.ColorTexto = System.Drawing.Color.White;
            this.elimMedBtn.Location = new System.Drawing.Point(72, 463);
            this.elimMedBtn.Name = "elimMedBtn";
            this.elimMedBtn.NombreBoton = null;
            this.elimMedBtn.Size = new System.Drawing.Size(245, 38);
            this.elimMedBtn.TabIndex = 101;
            this.elimMedBtn.Texto = "Eliminar";
            // 
            // editMedBtn
            // 
            this.editMedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.editMedBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.editMedBtn.ColorTexto = System.Drawing.Color.White;
            this.editMedBtn.Location = new System.Drawing.Point(72, 419);
            this.editMedBtn.Name = "editMedBtn";
            this.editMedBtn.NombreBoton = null;
            this.editMedBtn.Size = new System.Drawing.Size(245, 38);
            this.editMedBtn.TabIndex = 100;
            this.editMedBtn.Texto = "Editar";
            // 
            // agrMedBtn
            // 
            this.agrMedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.agrMedBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.agrMedBtn.ColorTexto = System.Drawing.Color.White;
            this.agrMedBtn.Location = new System.Drawing.Point(72, 375);
            this.agrMedBtn.Name = "agrMedBtn";
            this.agrMedBtn.NombreBoton = null;
            this.agrMedBtn.Size = new System.Drawing.Size(245, 38);
            this.agrMedBtn.TabIndex = 99;
            this.agrMedBtn.Texto = "Agregar";
            // 
            // expXMLBtn
            // 
            this.expXMLBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.expXMLBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.expXMLBtn.ColorTexto = System.Drawing.Color.White;
            this.expXMLBtn.Location = new System.Drawing.Point(850, 375);
            this.expXMLBtn.Name = "expXMLBtn";
            this.expXMLBtn.NombreBoton = null;
            this.expXMLBtn.Size = new System.Drawing.Size(245, 38);
            this.expXMLBtn.TabIndex = 103;
            this.expXMLBtn.Texto = "Exportar Turnos del Medico";
            // 
            // expMedBtn
            // 
            this.expMedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.expMedBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.expMedBtn.ColorTexto = System.Drawing.Color.White;
            this.expMedBtn.Location = new System.Drawing.Point(599, 375);
            this.expMedBtn.Name = "expMedBtn";
            this.expMedBtn.NombreBoton = null;
            this.expMedBtn.Size = new System.Drawing.Size(245, 38);
            this.expMedBtn.TabIndex = 102;
            this.expMedBtn.Texto = "Exportar Medicos";
            // 
            // Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 646);
            this.Controls.Add(this.expXMLBtn);
            this.Controls.Add(this.expMedBtn);
            this.Controls.Add(this.elimMedBtn);
            this.Controls.Add(this.editMedBtn);
            this.Controls.Add(this.agrMedBtn);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.IdMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.cUcmb1);
            this.Controls.Add(this.cU32);
            this.Controls.Add(this.cU22);
            this.Controls.Add(this.cU21);
            this.Controls.Add(this.cU12);
            this.Controls.Add(this.cU11);
            this.Controls.Add(this.label1);
            this.Name = "Medico";
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.Medico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button volverBtn;
        private CUcmb cUcmb1;
        private CU3 cU32;
        private CU2 cU22;
        private CU2 cU21;
        private CU1 cU12;
        private CU1 cU11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IdMedico;
        private CUDataGrid grilla;
        private CUButton elimMedBtn;
        private CUButton editMedBtn;
        private CUButton agrMedBtn;
        private CUButton expXMLBtn;
        private CUButton expMedBtn;
    }
}