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
            this.grilla = new System.Windows.Forms.DataGridView();
            this.volverBtn = new System.Windows.Forms.Button();
            this.elimPacBtn = new System.Windows.Forms.Button();
            this.editPacBtn = new System.Windows.Forms.Button();
            this.agrPacBtn = new System.Windows.Forms.Button();
            this.cUcmb1 = new TP_DAS.CUcmb();
            this.cU11 = new TP_DAS.CU1();
            this.label1 = new System.Windows.Forms.Label();
            this.logueadoTxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cuEmail1 = new TP_DAS.CUEmail();
            this.cuPass1 = new TP_DAS.CUPass();
            this.desbloquearBtn = new System.Windows.Forms.Button();
            this.expXMLBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // idUser
            // 
            this.idUser.AutoSize = true;
            this.idUser.Location = new System.Drawing.Point(113, 117);
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(10, 13);
            this.idUser.TabIndex = 71;
            this.idUser.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "ID:";
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(381, 97);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(708, 272);
            this.grilla.TabIndex = 69;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellClick);
            this.grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellContentClick);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(30, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 68;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // elimPacBtn
            // 
            this.elimPacBtn.Location = new System.Drawing.Point(97, 399);
            this.elimPacBtn.Name = "elimPacBtn";
            this.elimPacBtn.Size = new System.Drawing.Size(238, 29);
            this.elimPacBtn.TabIndex = 67;
            this.elimPacBtn.Text = "Eliminar";
            this.elimPacBtn.UseVisualStyleBackColor = true;
            this.elimPacBtn.Click += new System.EventHandler(this.elimPacBtn_Click);
            // 
            // editPacBtn
            // 
            this.editPacBtn.Location = new System.Drawing.Point(97, 354);
            this.editPacBtn.Name = "editPacBtn";
            this.editPacBtn.Size = new System.Drawing.Size(238, 29);
            this.editPacBtn.TabIndex = 66;
            this.editPacBtn.Text = "Editar";
            this.editPacBtn.UseVisualStyleBackColor = true;
            this.editPacBtn.Click += new System.EventHandler(this.editPacBtn_Click);
            // 
            // agrPacBtn
            // 
            this.agrPacBtn.Location = new System.Drawing.Point(97, 307);
            this.agrPacBtn.Name = "agrPacBtn";
            this.agrPacBtn.Size = new System.Drawing.Size(238, 29);
            this.agrPacBtn.TabIndex = 65;
            this.agrPacBtn.Text = "Agregar";
            this.agrPacBtn.UseVisualStyleBackColor = true;
            this.agrPacBtn.Click += new System.EventHandler(this.agrPacBtn_Click);
            // 
            // cUcmb1
            // 
            this.cUcmb1.Etiqueta = "Privilegios";
            this.cUcmb1.Items = new string[0];
            this.cUcmb1.Location = new System.Drawing.Point(49, 255);
            this.cUcmb1.Name = "cUcmb1";
            this.cUcmb1.SelectedItem = "";
            this.cUcmb1.Size = new System.Drawing.Size(318, 29);
            this.cUcmb1.TabIndex = 64;
            // 
            // cU11
            // 
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(56, 146);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(292, 33);
            this.cU11.TabIndex = 59;
            this.cU11.Texto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Usuario";
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
            this.cuEmail1.Etiqueta = "Email";
            this.cuEmail1.Location = new System.Drawing.Point(56, 185);
            this.cuEmail1.Name = "cuEmail1";
            this.cuEmail1.Size = new System.Drawing.Size(292, 33);
            this.cuEmail1.TabIndex = 74;
            this.cuEmail1.Texto = "";
            // 
            // cuPass1
            // 
            this.cuPass1.Etiqueta = " Contraseña";
            this.cuPass1.Location = new System.Drawing.Point(49, 224);
            this.cuPass1.Name = "cuPass1";
            this.cuPass1.Size = new System.Drawing.Size(299, 33);
            this.cuPass1.TabIndex = 75;
            this.cuPass1.Texto = "";
            // 
            // desbloquearBtn
            // 
            this.desbloquearBtn.Location = new System.Drawing.Point(97, 442);
            this.desbloquearBtn.Name = "desbloquearBtn";
            this.desbloquearBtn.Size = new System.Drawing.Size(238, 29);
            this.desbloquearBtn.TabIndex = 76;
            this.desbloquearBtn.Text = "Desbloquear";
            this.desbloquearBtn.UseVisualStyleBackColor = true;
            this.desbloquearBtn.Click += new System.EventHandler(this.desbloquearBtn_Click);
            // 
            // expXMLBtn
            // 
            this.expXMLBtn.Location = new System.Drawing.Point(959, 375);
            this.expXMLBtn.Name = "expXMLBtn";
            this.expXMLBtn.Size = new System.Drawing.Size(130, 29);
            this.expXMLBtn.TabIndex = 81;
            this.expXMLBtn.Text = "Exportar Usuarios";
            this.expXMLBtn.UseVisualStyleBackColor = true;
            this.expXMLBtn.Click += new System.EventHandler(this.expXMLBtn_Click);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 507);
            this.Controls.Add(this.expXMLBtn);
            this.Controls.Add(this.desbloquearBtn);
            this.Controls.Add(this.cuPass1);
            this.Controls.Add(this.cuEmail1);
            this.Controls.Add(this.logueadoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.elimPacBtn);
            this.Controls.Add(this.editPacBtn);
            this.Controls.Add(this.agrPacBtn);
            this.Controls.Add(this.cUcmb1);
            this.Controls.Add(this.cU11);
            this.Controls.Add(this.label1);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button elimPacBtn;
        private System.Windows.Forms.Button editPacBtn;
        private System.Windows.Forms.Button agrPacBtn;
        private CUcmb cUcmb1;
        private CU1 cU11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logueadoTxt;
        private System.Windows.Forms.Label label3;
        private CUEmail cuEmail1;
        private CUPass cuPass1;
        private System.Windows.Forms.Button desbloquearBtn;
        private System.Windows.Forms.Button expXMLBtn;
    }
}