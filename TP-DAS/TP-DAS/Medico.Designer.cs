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
            this.grilla = new System.Windows.Forms.DataGridView();
            this.volverBtn = new System.Windows.Forms.Button();
            this.elimMedBtn = new System.Windows.Forms.Button();
            this.editMedBtn = new System.Windows.Forms.Button();
            this.agrMedBtn = new System.Windows.Forms.Button();
            this.cUcmb1 = new TP_DAS.CUcmb();
            this.cU32 = new TP_DAS.CU3();
            this.cU22 = new TP_DAS.CU2();
            this.cU21 = new TP_DAS.CU2();
            this.cU12 = new TP_DAS.CU1();
            this.cU11 = new TP_DAS.CU1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdMedico = new System.Windows.Forms.Label();
            this.txtRutaXML = new System.Windows.Forms.TextBox();
            this.expXMLBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(381, 113);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(713, 256);
            this.grilla.TabIndex = 67;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellClick);
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
            // elimMedBtn
            // 
            this.elimMedBtn.Location = new System.Drawing.Point(77, 478);
            this.elimMedBtn.Name = "elimMedBtn";
            this.elimMedBtn.Size = new System.Drawing.Size(238, 29);
            this.elimMedBtn.TabIndex = 65;
            this.elimMedBtn.Text = "Eliminar";
            this.elimMedBtn.UseVisualStyleBackColor = true;
            this.elimMedBtn.Click += new System.EventHandler(this.elimMedBtn_Click);
            // 
            // editMedBtn
            // 
            this.editMedBtn.Location = new System.Drawing.Point(77, 433);
            this.editMedBtn.Name = "editMedBtn";
            this.editMedBtn.Size = new System.Drawing.Size(238, 29);
            this.editMedBtn.TabIndex = 64;
            this.editMedBtn.Text = "Editar";
            this.editMedBtn.UseVisualStyleBackColor = true;
            this.editMedBtn.Click += new System.EventHandler(this.editMedBtn_Click);
            // 
            // agrMedBtn
            // 
            this.agrMedBtn.Location = new System.Drawing.Point(77, 386);
            this.agrMedBtn.Name = "agrMedBtn";
            this.agrMedBtn.Size = new System.Drawing.Size(238, 29);
            this.agrMedBtn.TabIndex = 63;
            this.agrMedBtn.Text = "Agregar";
            this.agrMedBtn.UseVisualStyleBackColor = true;
            this.agrMedBtn.Click += new System.EventHandler(this.agrMedBtn_Click);
            // 
            // cUcmb1
            // 
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
            this.cU32.Etiqueta = "Espe.";
            this.cU32.Location = new System.Drawing.Point(45, 341);
            this.cU32.Name = "cU32";
            this.cU32.Size = new System.Drawing.Size(305, 28);
            this.cU32.TabIndex = 61;
            this.cU32.TextoSeleccionado = "";
            // 
            // cU22
            // 
            this.cU22.Etiqueta = "Edad";
            this.cU22.Location = new System.Drawing.Point(45, 267);
            this.cU22.Name = "cU22";
            this.cU22.Size = new System.Drawing.Size(292, 33);
            this.cU22.TabIndex = 60;
            this.cU22.Texto = "";
            // 
            // cU21
            // 
            this.cU21.Etiqueta = "DNI";
            this.cU21.Location = new System.Drawing.Point(45, 149);
            this.cU21.Name = "cU21";
            this.cU21.Size = new System.Drawing.Size(292, 33);
            this.cU21.TabIndex = 59;
            this.cU21.Texto = "";
            // 
            // cU12
            // 
            this.cU12.Etiqueta = "Apellido";
            this.cU12.Location = new System.Drawing.Point(45, 227);
            this.cU12.Name = "cU12";
            this.cU12.Size = new System.Drawing.Size(292, 33);
            this.cU12.TabIndex = 58;
            this.cU12.Texto = "";
            // 
            // cU11
            // 
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(45, 188);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(292, 33);
            this.cU11.TabIndex = 57;
            this.cU11.Texto = "";
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
            // txtRutaXML
            // 
            this.txtRutaXML.Location = new System.Drawing.Point(929, 410);
            this.txtRutaXML.Name = "txtRutaXML";
            this.txtRutaXML.Size = new System.Drawing.Size(165, 20);
            this.txtRutaXML.TabIndex = 85;
            // 
            // expXMLBtn
            // 
            this.expXMLBtn.Location = new System.Drawing.Point(929, 375);
            this.expXMLBtn.Name = "expXMLBtn";
            this.expXMLBtn.Size = new System.Drawing.Size(165, 29);
            this.expXMLBtn.TabIndex = 84;
            this.expXMLBtn.Text = "Exportar Turnos del Medico";
            this.expXMLBtn.UseVisualStyleBackColor = true;
            this.expXMLBtn.Click += new System.EventHandler(this.expXMLBtn_Click);
            // 
            // Medico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 646);
            this.Controls.Add(this.txtRutaXML);
            this.Controls.Add(this.expXMLBtn);
            this.Controls.Add(this.IdMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.elimMedBtn);
            this.Controls.Add(this.editMedBtn);
            this.Controls.Add(this.agrMedBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button elimMedBtn;
        private System.Windows.Forms.Button editMedBtn;
        private System.Windows.Forms.Button agrMedBtn;
        private CUcmb cUcmb1;
        private CU3 cU32;
        private CU2 cU22;
        private CU2 cU21;
        private CU1 cU12;
        private CU1 cU11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IdMedico;
        private System.Windows.Forms.TextBox txtRutaXML;
        private System.Windows.Forms.Button expXMLBtn;
    }
}