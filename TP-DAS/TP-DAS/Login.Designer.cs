namespace TP_DAS
{
    partial class Login
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
            this.cambioPassBtn = new TP_DAS.CUButton();
            this.loginBtn = new TP_DAS.CUButton();
            this.cuPass1 = new TP_DAS.CUPass();
            this.cuEmail1 = new TP_DAS.CUEmail();
            this.SuspendLayout();
            // 
            // cambioPassBtn
            // 
            this.cambioPassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cambioPassBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.cambioPassBtn.ColorTexto = System.Drawing.Color.White;
            this.cambioPassBtn.Location = new System.Drawing.Point(368, 305);
            this.cambioPassBtn.Name = "cambioPassBtn";
            this.cambioPassBtn.NombreBoton = null;
            this.cambioPassBtn.Size = new System.Drawing.Size(245, 38);
            this.cambioPassBtn.TabIndex = 82;
            this.cambioPassBtn.Texto = "Olvidé mi Contraseña";
            this.cambioPassBtn.Load += new System.EventHandler(this.cambioPassBtn_Load);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.loginBtn.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.loginBtn.ColorTexto = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(368, 261);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.NombreBoton = null;
            this.loginBtn.Size = new System.Drawing.Size(245, 38);
            this.loginBtn.TabIndex = 81;
            this.loginBtn.Texto = "Iniciar Sesión";
            this.loginBtn.Load += new System.EventHandler(this.loginBtn_Load);
            // 
            // cuPass1
            // 
            this.cuPass1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cuPass1.Etiqueta = "Contraseña";
            this.cuPass1.Location = new System.Drawing.Point(325, 179);
            this.cuPass1.Name = "cuPass1";
            this.cuPass1.Size = new System.Drawing.Size(310, 60);
            this.cuPass1.TabIndex = 4;
            this.cuPass1.Texto = "";
            // 
            // cuEmail1
            // 
            this.cuEmail1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(232)))));
            this.cuEmail1.Etiqueta = "Email";
            this.cuEmail1.Location = new System.Drawing.Point(325, 123);
            this.cuEmail1.Name = "cuEmail1";
            this.cuEmail1.Size = new System.Drawing.Size(310, 50);
            this.cuEmail1.TabIndex = 3;
            this.cuEmail1.Texto = "";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.cambioPassBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.cuPass1);
            this.Controls.Add(this.cuEmail1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CUEmail cuEmail1;
        private CUPass cuPass1;
        private CUButton cambioPassBtn;
        private CUButton loginBtn;
    }
}