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
            this.label1 = new System.Windows.Forms.Label();
            this.elimPacBtn = new System.Windows.Forms.Button();
            this.editPacBtn = new System.Windows.Forms.Button();
            this.agrPacBtn = new System.Windows.Forms.Button();
            this.volverBtn = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.idPaciente = new System.Windows.Forms.Label();
            this.cUcmb1 = new TP_DAS.CUcmb();
            this.cU32 = new TP_DAS.CU3();
            this.cU22 = new TP_DAS.CU2();
            this.cU21 = new TP_DAS.CU2();
            this.cU12 = new TP_DAS.CU1();
            this.cU11 = new TP_DAS.CU1();
            this.txtRutaXML = new System.Windows.Forms.TextBox();
            this.expXMLBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Paciente";
            // 
            // elimPacBtn
            // 
            this.elimPacBtn.Location = new System.Drawing.Point(79, 465);
            this.elimPacBtn.Name = "elimPacBtn";
            this.elimPacBtn.Size = new System.Drawing.Size(238, 29);
            this.elimPacBtn.TabIndex = 47;
            this.elimPacBtn.Text = "Eliminar";
            this.elimPacBtn.UseVisualStyleBackColor = true;
            this.elimPacBtn.Click += new System.EventHandler(this.elimPacBtn_Click);
            // 
            // editPacBtn
            // 
            this.editPacBtn.Location = new System.Drawing.Point(79, 420);
            this.editPacBtn.Name = "editPacBtn";
            this.editPacBtn.Size = new System.Drawing.Size(238, 29);
            this.editPacBtn.TabIndex = 46;
            this.editPacBtn.Text = "Editar";
            this.editPacBtn.UseVisualStyleBackColor = true;
            this.editPacBtn.Click += new System.EventHandler(this.editPacBtn_Click);
            // 
            // agrPacBtn
            // 
            this.agrPacBtn.Location = new System.Drawing.Point(79, 373);
            this.agrPacBtn.Name = "agrPacBtn";
            this.agrPacBtn.Size = new System.Drawing.Size(238, 29);
            this.agrPacBtn.TabIndex = 45;
            this.agrPacBtn.Text = "Agregar";
            this.agrPacBtn.UseVisualStyleBackColor = true;
            this.agrPacBtn.Click += new System.EventHandler(this.agrPacBtn_Click);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(21, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 54;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(372, 97);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(708, 272);
            this.grilla.TabIndex = 55;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "ID:";
            // 
            // idPaciente
            // 
            this.idPaciente.AutoSize = true;
            this.idPaciente.Location = new System.Drawing.Point(104, 117);
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.Size = new System.Drawing.Size(10, 13);
            this.idPaciente.TabIndex = 57;
            this.idPaciente.Text = "-";
            // 
            // cUcmb1
            // 
            this.cUcmb1.Etiqueta = "Sexo";
            this.cUcmb1.Items = new string[0];
            this.cUcmb1.Location = new System.Drawing.Point(47, 293);
            this.cUcmb1.Name = "cUcmb1";
            this.cUcmb1.SelectedItem = "";
            this.cUcmb1.Size = new System.Drawing.Size(305, 28);
            this.cUcmb1.TabIndex = 9;
            // 
            // cU32
            // 
            this.cU32.Etiqueta = "Obra Soc.";
            this.cU32.Location = new System.Drawing.Point(47, 328);
            this.cU32.Name = "cU32";
            this.cU32.Size = new System.Drawing.Size(305, 28);
            this.cU32.TabIndex = 8;
            this.cU32.TextoSeleccionado = "";
            // 
            // cU22
            // 
            this.cU22.Etiqueta = "Edad";
            this.cU22.Location = new System.Drawing.Point(47, 254);
            this.cU22.Name = "cU22";
            this.cU22.Size = new System.Drawing.Size(292, 33);
            this.cU22.TabIndex = 5;
            this.cU22.Texto = "";
            // 
            // cU21
            // 
            this.cU21.Etiqueta = "DNI";
            this.cU21.Location = new System.Drawing.Point(47, 136);
            this.cU21.Name = "cU21";
            this.cU21.Size = new System.Drawing.Size(292, 33);
            this.cU21.TabIndex = 4;
            this.cU21.Texto = "";
            // 
            // cU12
            // 
            this.cU12.Etiqueta = "Apellido";
            this.cU12.Location = new System.Drawing.Point(47, 214);
            this.cU12.Name = "cU12";
            this.cU12.Size = new System.Drawing.Size(292, 33);
            this.cU12.TabIndex = 3;
            this.cU12.Texto = "";
            // 
            // cU11
            // 
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(47, 175);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(292, 33);
            this.cU11.TabIndex = 2;
            this.cU11.Texto = "";
            // 
            // txtRutaXML
            // 
            this.txtRutaXML.Location = new System.Drawing.Point(915, 410);
            this.txtRutaXML.Name = "txtRutaXML";
            this.txtRutaXML.Size = new System.Drawing.Size(165, 20);
            this.txtRutaXML.TabIndex = 83;
            // 
            // expXMLBtn
            // 
            this.expXMLBtn.Location = new System.Drawing.Point(915, 375);
            this.expXMLBtn.Name = "expXMLBtn";
            this.expXMLBtn.Size = new System.Drawing.Size(165, 29);
            this.expXMLBtn.TabIndex = 82;
            this.expXMLBtn.Text = "Exportar Turnos del Paciente";
            this.expXMLBtn.UseVisualStyleBackColor = true;
            this.expXMLBtn.Click += new System.EventHandler(this.expXMLBtn_Click);
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 542);
            this.Controls.Add(this.txtRutaXML);
            this.Controls.Add(this.expXMLBtn);
            this.Controls.Add(this.idPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.elimPacBtn);
            this.Controls.Add(this.editPacBtn);
            this.Controls.Add(this.agrPacBtn);
            this.Controls.Add(this.cUcmb1);
            this.Controls.Add(this.cU32);
            this.Controls.Add(this.cU22);
            this.Controls.Add(this.cU21);
            this.Controls.Add(this.cU12);
            this.Controls.Add(this.cU11);
            this.Controls.Add(this.label1);
            this.Name = "Paciente";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CU1 cU11;
        private CU1 cU12;
        private CU2 cU21;
        private CU2 cU22;
        private CU3 cU32;
        private CUcmb cUcmb1;
        private System.Windows.Forms.Button elimPacBtn;
        private System.Windows.Forms.Button editPacBtn;
        private System.Windows.Forms.Button agrPacBtn;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idPaciente;
        private System.Windows.Forms.TextBox txtRutaXML;
        private System.Windows.Forms.Button expXMLBtn;
    }
}