namespace TP_DAS
{
    partial class Paciente
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
            this.label1 = new System.Windows.Forms.Label();
            this.cU12 = new TP_DAS.CU1();
            this.cU13 = new TP_DAS.CU1();
            this.cU21 = new TP_DAS.CU2();
            this.cU22 = new TP_DAS.CU2();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Paciente";
            // 
            // cU12
            // 
            this.cU12.Etiqueta = "label1";
            this.cU12.Location = new System.Drawing.Point(52, 119);
            this.cU12.Name = "cU12";
            this.cU12.Size = new System.Drawing.Size(292, 33);
            this.cU12.TabIndex = 2;
            this.cU12.Texto = "";
            // 
            // cU13
            // 
            this.cU13.Etiqueta = "label1";
            this.cU13.Location = new System.Drawing.Point(52, 158);
            this.cU13.Name = "cU13";
            this.cU13.Size = new System.Drawing.Size(292, 33);
            this.cU13.TabIndex = 3;
            this.cU13.Texto = "";
            // 
            // cU21
            // 
            this.cU21.Etiqueta = "label1";
            this.cU21.Location = new System.Drawing.Point(52, 80);
            this.cU21.Name = "cU21";
            this.cU21.Size = new System.Drawing.Size(292, 33);
            this.cU21.TabIndex = 4;
            this.cU21.Texto = "";
            // 
            // cU22
            // 
            this.cU22.Etiqueta = "label1";
            this.cU22.Location = new System.Drawing.Point(52, 198);
            this.cU22.Name = "cU22";
            this.cU22.Size = new System.Drawing.Size(292, 33);
            this.cU22.TabIndex = 5;
            this.cU22.Texto = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "CREAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cU22);
            this.Controls.Add(this.cU21);
            this.Controls.Add(this.cU13);
            this.Controls.Add(this.cU12);
            this.Controls.Add(this.label1);
            this.Name = "Paciente";
            this.Text = "Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CU1 cU12;
        private CU1 cU13;
        private CU2 cU21;
        private CU2 cU22;
        private System.Windows.Forms.Button button1;
    }
}