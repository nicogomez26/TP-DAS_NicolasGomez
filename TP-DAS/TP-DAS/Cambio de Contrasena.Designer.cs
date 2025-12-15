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
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.cuPassNew1 = new TP_DAS.CUPass();
            this.cambiarPassBtn = new System.Windows.Forms.Button();
            this.cuPassAct = new TP_DAS.CUPass();
            this.cuPassNew2 = new TP_DAS.CUPass();
            this.cuEmail1 = new TP_DAS.CUEmail();
            this.SuspendLayout();
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(479, 364);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(217, 39);
            this.cancelarBtn.TabIndex = 10;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            // 
            // cuPassNew1
            // 
            this.cuPassNew1.Etiqueta = "Contraseña Nueva";
            this.cuPassNew1.Location = new System.Drawing.Point(479, 223);
            this.cuPassNew1.Name = "cuPassNew1";
            this.cuPassNew1.Size = new System.Drawing.Size(217, 33);
            this.cuPassNew1.TabIndex = 9;
            this.cuPassNew1.Texto = "";
            // 
            // cambiarPassBtn
            // 
            this.cambiarPassBtn.Location = new System.Drawing.Point(479, 319);
            this.cambiarPassBtn.Name = "cambiarPassBtn";
            this.cambiarPassBtn.Size = new System.Drawing.Size(217, 39);
            this.cambiarPassBtn.TabIndex = 7;
            this.cambiarPassBtn.Text = "Cambiar Contraseña";
            this.cambiarPassBtn.UseVisualStyleBackColor = true;
            this.cambiarPassBtn.Click += new System.EventHandler(this.cambiarPassBtn_Click_1);
            // 
            // cuPassAct
            // 
            this.cuPassAct.Etiqueta = "Contraseña Actual";
            this.cuPassAct.Location = new System.Drawing.Point(479, 184);
            this.cuPassAct.Name = "cuPassAct";
            this.cuPassAct.Size = new System.Drawing.Size(217, 33);
            this.cuPassAct.TabIndex = 11;
            this.cuPassAct.Texto = "";
            // 
            // cuPassNew2
            // 
            this.cuPassNew2.Etiqueta = "Repetir Contraseña";
            this.cuPassNew2.Location = new System.Drawing.Point(479, 262);
            this.cuPassNew2.Name = "cuPassNew2";
            this.cuPassNew2.Size = new System.Drawing.Size(217, 33);
            this.cuPassNew2.TabIndex = 12;
            this.cuPassNew2.Texto = "";
            // 
            // cuEmail1
            // 
            this.cuEmail1.Etiqueta = "Email";
            this.cuEmail1.Location = new System.Drawing.Point(479, 145);
            this.cuEmail1.Name = "cuEmail1";
            this.cuEmail1.Size = new System.Drawing.Size(217, 33);
            this.cuEmail1.TabIndex = 13;
            this.cuEmail1.Texto = "";
            // 
            // Cambio_de_Contrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 547);
            this.Controls.Add(this.cuEmail1);
            this.Controls.Add(this.cuPassNew2);
            this.Controls.Add(this.cuPassAct);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.cuPassNew1);
            this.Controls.Add(this.cambiarPassBtn);
            this.Name = "Cambio_de_Contrasena";
            this.Text = "Cambio_de_Contrasena";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelarBtn;
        private CUPass cuPassNew1;
        private System.Windows.Forms.Button cambiarPassBtn;
        private CUPass cuPassAct;
        private CUPass cuPassNew2;
        private CUEmail cuEmail1;
    }
}