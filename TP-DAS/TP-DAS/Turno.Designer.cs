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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTurno = new System.Windows.Forms.Label();
            this.expXMLBtn = new System.Windows.Forms.Button();
            this.cuDate1 = new TP_DAS.CUDate();
            this.cU31 = new TP_DAS.CU3();
            this.cU32 = new TP_DAS.CU3();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(381, 104);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(758, 285);
            this.grilla.TabIndex = 74;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellClick);
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
            this.elimTurBtn.Location = new System.Drawing.Point(89, 410);
            this.elimTurBtn.Name = "elimTurBtn";
            this.elimTurBtn.Size = new System.Drawing.Size(238, 29);
            this.elimTurBtn.TabIndex = 72;
            this.elimTurBtn.Text = "Eliminar";
            this.elimTurBtn.UseVisualStyleBackColor = true;
            this.elimTurBtn.Click += new System.EventHandler(this.elimTurBtn_Click);
            // 
            // editTurBtn
            // 
            this.editTurBtn.Location = new System.Drawing.Point(89, 375);
            this.editTurBtn.Name = "editTurBtn";
            this.editTurBtn.Size = new System.Drawing.Size(238, 29);
            this.editTurBtn.TabIndex = 71;
            this.editTurBtn.Text = "Editar";
            this.editTurBtn.UseVisualStyleBackColor = true;
            this.editTurBtn.Click += new System.EventHandler(this.editTurBtn_Click);
            // 
            // agrTurBtn
            // 
            this.agrTurBtn.Location = new System.Drawing.Point(89, 340);
            this.agrTurBtn.Name = "agrTurBtn";
            this.agrTurBtn.Size = new System.Drawing.Size(238, 29);
            this.agrTurBtn.TabIndex = 70;
            this.agrTurBtn.Text = "Agregar";
            this.agrTurBtn.UseVisualStyleBackColor = true;
            this.agrTurBtn.Click += new System.EventHandler(this.agrTurBtn_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Id:";
            // 
            // idTurno
            // 
            this.idTurno.AutoSize = true;
            this.idTurno.Location = new System.Drawing.Point(131, 168);
            this.idTurno.Name = "idTurno";
            this.idTurno.Size = new System.Drawing.Size(10, 13);
            this.idTurno.TabIndex = 79;
            this.idTurno.Text = "-";
            this.idTurno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // expXMLBtn
            // 
            this.expXMLBtn.Location = new System.Drawing.Point(1009, 395);
            this.expXMLBtn.Name = "expXMLBtn";
            this.expXMLBtn.Size = new System.Drawing.Size(130, 29);
            this.expXMLBtn.TabIndex = 80;
            this.expXMLBtn.Text = "Exportar Turnos";
            this.expXMLBtn.UseVisualStyleBackColor = true;
            this.expXMLBtn.Click += new System.EventHandler(this.expXMLBtn_Click);
            // 
            // cuDate1
            // 
            this.cuDate1.Etiqueta = "Fecha";
            this.cuDate1.Location = new System.Drawing.Point(55, 199);
            this.cuDate1.Maximo = new System.DateTime(2026, 3, 15, 1, 28, 10, 613);
            this.cuDate1.Minimo = new System.DateTime(2025, 12, 15, 1, 28, 10, 613);
            this.cuDate1.Name = "cuDate1";
            this.cuDate1.Size = new System.Drawing.Size(305, 28);
            this.cuDate1.TabIndex = 77;
            this.cuDate1.Valor = new System.DateTime(2025, 12, 15, 1, 28, 10, 613);
            // 
            // cU31
            // 
            this.cU31.Etiqueta = "Medico";
            this.cU31.Location = new System.Drawing.Point(55, 287);
            this.cU31.Name = "cU31";
            this.cU31.Size = new System.Drawing.Size(305, 28);
            this.cU31.TabIndex = 76;
            this.cU31.TextoSeleccionado = "";
            // 
            // cU32
            // 
            this.cU32.Etiqueta = "Paciente";
            this.cU32.Location = new System.Drawing.Point(55, 253);
            this.cU32.Name = "cU32";
            this.cU32.Size = new System.Drawing.Size(305, 28);
            this.cU32.TabIndex = 75;
            this.cU32.TextoSeleccionado = "";
            this.cU32.Load += new System.EventHandler(this.cU32_Load);
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 527);
            this.Controls.Add(this.expXMLBtn);
            this.Controls.Add(this.idTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cuDate1);
            this.Controls.Add(this.cU31);
            this.Controls.Add(this.cU32);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.elimTurBtn);
            this.Controls.Add(this.editTurBtn);
            this.Controls.Add(this.agrTurBtn);
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
        private System.Windows.Forms.Label label1;
        private CU3 cU32;
        private CU3 cU31;
        private CUDate cuDate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idTurno;
        private System.Windows.Forms.Button expXMLBtn;
    }
}