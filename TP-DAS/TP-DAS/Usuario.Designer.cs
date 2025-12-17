namespace TP_DAS
{
    partial class Usuario
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
            this.idUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cUcmb1 = new TP_DAS.CUcmb();
            this.cU11 = new TP_DAS.CU1();
            this.logueadoTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cuEmail1 = new TP_DAS.CUEmail();
            this.cuPass1 = new TP_DAS.CUPass();
            this.grilla = new TP_DAS.CUDataGrid();
            this.elimPacBtn = new TP_DAS.CUButton();
            this.editPacBtn = new TP_DAS.CUButton();
            this.agrPacBtn = new TP_DAS.CUButton();
            this.desbloquearBtn = new TP_DAS.CUButton();
            this.expXMLBtn = new TP_DAS.CUButton();
            this.volverBtn = new TP_DAS.CUButton();
            this.SuspendLayout();
            // 
            // idUser
            // 
            this.idUser.AutoSize = true;
            this.idUser.Location = new System.Drawing.Point(100, 77);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(10, 13);
            this.idUser.TabIndex = 71;
            this.idUser.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "ID:";
            // 
            // cUcmb1
            // 
            this.cUcmb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cUcmb1.Etiqueta = "Privilegios";
            this.cUcmb1.Items = new string[0];
            this.cUcmb1.Location = new System.Drawing.Point(56, 292);
            this.cUcmb1.Name = "cUcmb1";
            this.cUcmb1.SelectedItem = "";
            this.cUcmb1.Size = new System.Drawing.Size(310, 60);
            this.cUcmb1.TabIndex = 64;
            // 
            // cU11
            // 
            this.cU11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(56, 114);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(310, 50);
            this.cU11.TabIndex = 59;
            this.cU11.Texto = "";
            // 
            // logueadoTxt
            // 
            this.logueadoTxt.AutoSize = true;
            this.logueadoTxt.Location = new System.Drawing.Point(1020, 28);
            this.logueadoTxt.Name = "logueadoTxt";
            this.logueadoTxt.Size = new System.Drawing.Size(10, 13);
            this.logueadoTxt.TabIndex = 73;
            this.logueadoTxt.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(960, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Bienvenido,";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cuEmail1
            // 
            this.cuEmail1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cuEmail1.Etiqueta = "Email";
            this.cuEmail1.Location = new System.Drawing.Point(56, 170);
            this.cuEmail1.Name = "cuEmail1";
            this.cuEmail1.Size = new System.Drawing.Size(310, 50);
            this.cuEmail1.TabIndex = 74;
            this.cuEmail1.Texto = "";
            // 
            // cuPass1
            // 
            this.cuPass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cuPass1.Etiqueta = " Contraseña";
            this.cuPass1.Location = new System.Drawing.Point(56, 226);
            this.cuPass1.Name = "cuPass1";
            this.cuPass1.Size = new System.Drawing.Size(310, 60);
            this.cuPass1.TabIndex = 75;
            this.cuPass1.Texto = "";
            // 
            // grilla
            // 
            this.grilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.grilla.Location = new System.Drawing.Point(400, 114);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(689, 255);
            this.grilla.TabIndex = 95;
            // 
            // elimPacBtn
            // 
            this.elimPacBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.elimPacBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.elimPacBtn.ColorTexto = System.Drawing.Color.White;
            this.elimPacBtn.Location = new System.Drawing.Point(94, 424);
            this.elimPacBtn.Name = "elimPacBtn";
            this.elimPacBtn.NombreBoton = null;
            this.elimPacBtn.Size = new System.Drawing.Size(245, 27);
            this.elimPacBtn.TabIndex = 107;
            this.elimPacBtn.Texto = "Eliminar";
            // 
            // editPacBtn
            // 
            this.editPacBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.editPacBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.editPacBtn.ColorTexto = System.Drawing.Color.White;
            this.editPacBtn.Location = new System.Drawing.Point(94, 391);
            this.editPacBtn.Name = "editPacBtn";
            this.editPacBtn.NombreBoton = null;
            this.editPacBtn.Size = new System.Drawing.Size(245, 27);
            this.editPacBtn.TabIndex = 106;
            this.editPacBtn.Texto = "Editar";
            // 
            // agrPacBtn
            // 
            this.agrPacBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.agrPacBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.agrPacBtn.ColorTexto = System.Drawing.Color.White;
            this.agrPacBtn.Location = new System.Drawing.Point(94, 358);
            this.agrPacBtn.Name = "agrPacBtn";
            this.agrPacBtn.NombreBoton = null;
            this.agrPacBtn.Size = new System.Drawing.Size(245, 27);
            this.agrPacBtn.TabIndex = 105;
            this.agrPacBtn.Texto = "Agregar";
            // 
            // desbloquearBtn
            // 
            this.desbloquearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.desbloquearBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.desbloquearBtn.ColorTexto = System.Drawing.Color.White;
            this.desbloquearBtn.Location = new System.Drawing.Point(94, 457);
            this.desbloquearBtn.Name = "desbloquearBtn";
            this.desbloquearBtn.NombreBoton = null;
            this.desbloquearBtn.Size = new System.Drawing.Size(245, 27);
            this.desbloquearBtn.TabIndex = 108;
            this.desbloquearBtn.Texto = "Desbloquear";
            this.desbloquearBtn.Load += new System.EventHandler(this.desbloquearBtn_Load);
            // 
            // expXMLBtn
            // 
            this.expXMLBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.expXMLBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.expXMLBtn.ColorTexto = System.Drawing.Color.White;
            this.expXMLBtn.Location = new System.Drawing.Point(844, 375);
            this.expXMLBtn.Name = "expXMLBtn";
            this.expXMLBtn.NombreBoton = null;
            this.expXMLBtn.Size = new System.Drawing.Size(245, 38);
            this.expXMLBtn.TabIndex = 109;
            this.expXMLBtn.Texto = "Exportar Usuarios";
            this.expXMLBtn.Load += new System.EventHandler(this.expXMLBtn_Load);
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
            this.volverBtn.TabIndex = 110;
            this.volverBtn.Texto = "Volver";
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 507);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.expXMLBtn);
            this.Controls.Add(this.desbloquearBtn);
            this.Controls.Add(this.elimPacBtn);
            this.Controls.Add(this.editPacBtn);
            this.Controls.Add(this.agrPacBtn);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.cuPass1);
            this.Controls.Add(this.cuEmail1);
            this.Controls.Add(this.logueadoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cUcmb1);
            this.Controls.Add(this.cU11);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idUser;
        private System.Windows.Forms.Label label2;
        private CUcmb cUcmb1;
        private CU1 cU11;
        private System.Windows.Forms.Label logueadoTxt;
        private System.Windows.Forms.Label label3;
        private CUEmail cuEmail1;
        private CUPass cuPass1;
        private CUDataGrid grilla;
        private CUButton elimPacBtn;
        private CUButton editPacBtn;
        private CUButton agrPacBtn;
        private CUButton desbloquearBtn;
        private CUButton expXMLBtn;
        private CUButton volverBtn;
    }
}