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
            this.label2 = new System.Windows.Forms.Label();
            this.idTurno = new System.Windows.Forms.Label();
            this.cuDate1 = new TP_DAS.CUDate();
            this.cU31 = new TP_DAS.CU3();
            this.cU32 = new TP_DAS.CU3();
            this.grilla = new TP_DAS.CUDataGrid();
            this.elimTurBtn = new TP_DAS.CUButton();
            this.editTurBtn = new TP_DAS.CUButton();
            this.agrTurBtn = new TP_DAS.CUButton();
            this.volverBtn = new TP_DAS.CUButton();
            this.expXMLBtn = new TP_DAS.CUButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Id:";
            // 
            // idTurno
            // 
            this.idTurno.AutoSize = true;
            this.idTurno.Location = new System.Drawing.Point(135, 125);
            this.idTurno.Name = "idTurno";
            this.idTurno.Size = new System.Drawing.Size(10, 13);
            this.idTurno.TabIndex = 79;
            this.idTurno.Text = "-";
            this.idTurno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cuDate1
            // 
            this.cuDate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cuDate1.Etiqueta = "Fecha";
            this.cuDate1.Location = new System.Drawing.Point(50, 154);
            this.cuDate1.Maximo = new System.DateTime(2026, 3, 17, 0, 31, 53, 60);
            this.cuDate1.Minimo = new System.DateTime(2025, 12, 17, 0, 31, 53, 60);
            this.cuDate1.Name = "cuDate1";
            this.cuDate1.Size = new System.Drawing.Size(310, 38);
            this.cuDate1.TabIndex = 77;
            this.cuDate1.Valor = new System.DateTime(2025, 12, 17, 0, 31, 53, 60);
            // 
            // cU31
            // 
            this.cU31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU31.Etiqueta = "Medico";
            this.cU31.Location = new System.Drawing.Point(50, 266);
            this.cU31.Name = "cU31";
            this.cU31.Size = new System.Drawing.Size(310, 60);
            this.cU31.TabIndex = 76;
            this.cU31.TextoSeleccionado = "";
            this.cU31.ValorSeleccionado = -1;
            // 
            // cU32
            // 
            this.cU32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU32.Etiqueta = "Paciente";
            this.cU32.Location = new System.Drawing.Point(50, 198);
            this.cU32.Name = "cU32";
            this.cU32.Size = new System.Drawing.Size(310, 60);
            this.cU32.TabIndex = 75;
            this.cU32.TextoSeleccionado = "";
            this.cU32.ValorSeleccionado = -1;
            this.cU32.Load += new System.EventHandler(this.cU32_Load);
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(403, 125);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(736, 264);
            this.grilla.TabIndex = 95;
            // 
            // elimTurBtn
            // 
            this.elimTurBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.elimTurBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.elimTurBtn.ColorTexto = System.Drawing.Color.White;
            this.elimTurBtn.Location = new System.Drawing.Point(89, 420);
            this.elimTurBtn.Name = "elimTurBtn";
            this.elimTurBtn.NombreBoton = null;
            this.elimTurBtn.Size = new System.Drawing.Size(245, 38);
            this.elimTurBtn.TabIndex = 104;
            this.elimTurBtn.Texto = "Eliminar";
            // 
            // editTurBtn
            // 
            this.editTurBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.editTurBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.editTurBtn.ColorTexto = System.Drawing.Color.White;
            this.editTurBtn.Location = new System.Drawing.Point(89, 376);
            this.editTurBtn.Name = "editTurBtn";
            this.editTurBtn.NombreBoton = null;
            this.editTurBtn.Size = new System.Drawing.Size(245, 38);
            this.editTurBtn.TabIndex = 103;
            this.editTurBtn.Texto = "Editar";
            // 
            // agrTurBtn
            // 
            this.agrTurBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.agrTurBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.agrTurBtn.ColorTexto = System.Drawing.Color.White;
            this.agrTurBtn.Location = new System.Drawing.Point(89, 332);
            this.agrTurBtn.Name = "agrTurBtn";
            this.agrTurBtn.NombreBoton = null;
            this.agrTurBtn.Size = new System.Drawing.Size(245, 38);
            this.agrTurBtn.TabIndex = 102;
            this.agrTurBtn.Texto = "Agregar";
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
            this.volverBtn.TabIndex = 109;
            this.volverBtn.Texto = "Volver";
            // 
            // expXMLBtn
            // 
            this.expXMLBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.expXMLBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.expXMLBtn.ColorTexto = System.Drawing.Color.White;
            this.expXMLBtn.Location = new System.Drawing.Point(977, 395);
            this.expXMLBtn.Name = "expXMLBtn";
            this.expXMLBtn.NombreBoton = null;
            this.expXMLBtn.Size = new System.Drawing.Size(162, 44);
            this.expXMLBtn.TabIndex = 110;
            this.expXMLBtn.Texto = "Exportar Turnos";
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 527);
            this.Controls.Add(this.expXMLBtn);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.elimTurBtn);
            this.Controls.Add(this.editTurBtn);
            this.Controls.Add(this.agrTurBtn);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.idTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cuDate1);
            this.Controls.Add(this.cU31);
            this.Controls.Add(this.cU32);
            this.Name = "Turno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.Turno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CU3 cU32;
        private CU3 cU31;
        private CUDate cuDate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idTurno;
        private CUDataGrid grilla;
        private CUButton elimTurBtn;
        private CUButton editTurBtn;
        private CUButton agrTurBtn;
        private CUButton volverBtn;
        private CUButton expXMLBtn;
    }
}