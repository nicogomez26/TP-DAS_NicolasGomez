namespace TP_DAS
{
    partial class Turno
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
            this.elimTurBtn = new System.Windows.Forms.Button();
            this.editTurBtn = new System.Windows.Forms.Button();
            this.agrTurBtn = new System.Windows.Forms.Button();
            this.cU11 = new TP_DAS.CU1();
            this.label1 = new System.Windows.Forms.Label();
            this.cU32 = new TP_DAS.CU3();
            this.cU31 = new TP_DAS.CU3();
            this.cuDate1 = new TP_DAS.CUDate();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(381, 154);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(418, 272);
            this.grilla.TabIndex = 74;
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(20, 25);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 73;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // elimTurBtn
            // 
            this.elimTurBtn.Location = new System.Drawing.Point(89, 420);
            this.elimTurBtn.Name = "elimTurBtn";
            this.elimTurBtn.Size = new System.Drawing.Size(238, 29);
            this.elimTurBtn.TabIndex = 72;
            this.elimTurBtn.Text = "Eliminar";
            this.elimTurBtn.UseVisualStyleBackColor = true;
            // 
            // editTurBtn
            // 
            this.editTurBtn.Location = new System.Drawing.Point(89, 375);
            this.editTurBtn.Name = "editTurBtn";
            this.editTurBtn.Size = new System.Drawing.Size(238, 29);
            this.editTurBtn.TabIndex = 71;
            this.editTurBtn.Text = "Editar";
            this.editTurBtn.UseVisualStyleBackColor = true;
            // 
            // agrTurBtn
            // 
            this.agrTurBtn.Location = new System.Drawing.Point(89, 328);
            this.agrTurBtn.Name = "agrTurBtn";
            this.agrTurBtn.Size = new System.Drawing.Size(238, 29);
            this.agrTurBtn.TabIndex = 70;
            this.agrTurBtn.Text = "Agregar";
            this.agrTurBtn.UseVisualStyleBackColor = true;
            this.agrTurBtn.Click += new System.EventHandler(this.agrTurBtn_Click);
            // 
            // cU11
            // 
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(55, 147);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(292, 33);
            this.cU11.TabIndex = 69;
            this.cU11.Texto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Crear Turno";
            // 
            // cU32
            // 
            this.cU32.Etiqueta = "Paciente";
            this.cU32.Location = new System.Drawing.Point(55, 253);
            this.cU32.Name = "cU32";
            this.cU32.Size = new System.Drawing.Size(305, 28);
            this.cU32.TabIndex = 75;
            this.cU32.Load += new System.EventHandler(this.cU32_Load);
            // 
            // cU31
            // 
            this.cU31.Etiqueta = "Medico";
            this.cU31.Location = new System.Drawing.Point(55, 287);
            this.cU31.Name = "cU31";
            this.cU31.Size = new System.Drawing.Size(305, 28);
            this.cU31.TabIndex = 76;
            // 
            // cuDate1
            // 
            this.cuDate1.Etiqueta = "Fecha";
            this.cuDate1.Location = new System.Drawing.Point(55, 199);
            this.cuDate1.Maximo = new System.DateTime(2026, 2, 5, 2, 40, 40, 761);
            this.cuDate1.Minimo = new System.DateTime(2025, 11, 7, 2, 40, 40, 761);
            this.cuDate1.Name = "cuDate1";
            this.cuDate1.Size = new System.Drawing.Size(305, 28);
            this.cuDate1.TabIndex = 77;
            this.cuDate1.Valor = new System.DateTime(2025, 11, 7, 2, 40, 40, 777);
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 500);
            this.Controls.Add(this.cuDate1);
            this.Controls.Add(this.cU31);
            this.Controls.Add(this.cU32);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.elimTurBtn);
            this.Controls.Add(this.editTurBtn);
            this.Controls.Add(this.agrTurBtn);
            this.Controls.Add(this.cU11);
            this.Controls.Add(this.label1);
            this.Name = "Turno";
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.Turno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button elimTurBtn;
        private System.Windows.Forms.Button editTurBtn;
        private System.Windows.Forms.Button agrTurBtn;
        private CU1 cU11;
        private System.Windows.Forms.Label label1;
        private CU3 cU32;
        private CU3 cU31;
        private CUDate cuDate1;
    }
}