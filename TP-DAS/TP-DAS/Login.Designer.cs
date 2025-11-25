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
            this.loginBtn = new System.Windows.Forms.Button();
            this.cuPass1 = new TP_DAS.CUPass();
            this.cuEmail1 = new TP_DAS.CUEmail();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(372, 253);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(217, 39);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Iniciar Sesión";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // cuPass1
            // 
            this.cuPass1.Etiqueta = "Contraseña";
            this.cuPass1.Location = new System.Drawing.Point(372, 198);
            this.cuPass1.Name = "cuPass1";
            this.cuPass1.Size = new System.Drawing.Size(217, 33);
            this.cuPass1.TabIndex = 4;
            this.cuPass1.Texto = "";
            // 
            // cuEmail1
            // 
            this.cuEmail1.Etiqueta = "Email";
            this.cuEmail1.Location = new System.Drawing.Point(372, 159);
            this.cuEmail1.Name = "cuEmail1";
            this.cuEmail1.Size = new System.Drawing.Size(217, 33);
            this.cuEmail1.TabIndex = 3;
            this.cuEmail1.Texto = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cuPass1);
            this.Controls.Add(this.cuEmail1);
            this.Controls.Add(this.loginBtn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loginBtn;
        private CUEmail cuEmail1;
        private CUPass cuPass1;
        private System.Windows.Forms.Button button1;
    }
}