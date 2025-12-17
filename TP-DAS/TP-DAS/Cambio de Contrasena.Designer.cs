namespace TP_DAS
{
    partial class Cambio_de_Contrasena
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
            this.cuPassNew1 = new TP_DAS.CUPass();
            this.cuPassAct = new TP_DAS.CUPass();
            this.cuPassNew2 = new TP_DAS.CUPass();
            this.cuEmail1 = new TP_DAS.CUEmail();
            this.cambiarPassBtn = new TP_DAS.CUButton();
            this.cancelarBtn = new TP_DAS.CUButton();
            this.SuspendLayout();
            // 
            // cuPassNew1
            // 
            this.cuPassNew1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cuPassNew1.Etiqueta = "Contraseña Nueva";
            this.cuPassNew1.Location = new System.Drawing.Point(479, 223);
            this.cuPassNew1.Name = "cuPassNew1";
            this.cuPassNew1.Size = new System.Drawing.Size(217, 33);
            this.cuPassNew1.TabIndex = 9;
            this.cuPassNew1.Texto = "";
            // 
            // cuPassAct
            // 
            this.cuPassAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cuPassAct.Etiqueta = "Contraseña Actual";
            this.cuPassAct.Location = new System.Drawing.Point(479, 184);
            this.cuPassAct.Name = "cuPassAct";
            this.cuPassAct.Size = new System.Drawing.Size(217, 33);
            this.cuPassAct.TabIndex = 11;
            this.cuPassAct.Texto = "";
            // 
            // cuPassNew2
            // 
            this.cuPassNew2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cuPassNew2.Etiqueta = "Repetir Contraseña";
            this.cuPassNew2.Location = new System.Drawing.Point(479, 262);
            this.cuPassNew2.Name = "cuPassNew2";
            this.cuPassNew2.Size = new System.Drawing.Size(217, 33);
            this.cuPassNew2.TabIndex = 12;
            this.cuPassNew2.Texto = "";
            // 
            // cuEmail1
            // 
            this.cuEmail1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cuEmail1.Etiqueta = "Email";
            this.cuEmail1.Location = new System.Drawing.Point(479, 145);
            this.cuEmail1.Name = "cuEmail1";
            this.cuEmail1.Size = new System.Drawing.Size(217, 33);
            this.cuEmail1.TabIndex = 13;
            this.cuEmail1.Texto = "";
            // 
            // cambiarPassBtn
            // 
            this.cambiarPassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cambiarPassBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cambiarPassBtn.ColorTexto = System.Drawing.Color.White;
            this.cambiarPassBtn.Location = new System.Drawing.Point(460, 321);
            this.cambiarPassBtn.Name = "cambiarPassBtn";
            this.cambiarPassBtn.Size = new System.Drawing.Size(248, 37);
            this.cambiarPassBtn.TabIndex = 14;
            this.cambiarPassBtn.Texto = "Cambiar Contraseña";
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cancelarBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cancelarBtn.ColorTexto = System.Drawing.Color.White;
            this.cancelarBtn.Location = new System.Drawing.Point(460, 364);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(248, 37);
            this.cancelarBtn.TabIndex = 15;
            this.cancelarBtn.Texto = "Cancelar";
            // 
            // Cambio_de_Contrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 547);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.cambiarPassBtn);
            this.Controls.Add(this.cuEmail1);
            this.Controls.Add(this.cuPassNew2);
            this.Controls.Add(this.cuPassAct);
            this.Controls.Add(this.cuPassNew1);
            this.Name = "Cambio_de_Contrasena";
            this.Text = "Cambio_de_Contrasena";
            this.Load += new System.EventHandler(this.Cambio_de_Contrasena_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CUPass cuPassNew1;
        private CUPass cuPassAct;
        private CUPass cuPassNew2;
        private CUEmail cuEmail1;
        private CUButton cambiarPassBtn;
        private CUButton cancelarBtn;
    }
}