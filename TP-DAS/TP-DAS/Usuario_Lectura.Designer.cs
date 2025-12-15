namespace TP_DAS
{
    partial class Usuario_Lectura
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
            this.label3 = new System.Windows.Forms.Label();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.volverBtn = new System.Windows.Forms.Button();
            this.expXMLBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(946, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Bienvenido,";
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(367, 100);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(708, 272);
            this.grilla.TabIndex = 74;
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(16, 15);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 73;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // expXMLBtn
            // 
            this.expXMLBtn.Location = new System.Drawing.Point(945, 378);
            this.expXMLBtn.Name = "expXMLBtn";
            this.expXMLBtn.Size = new System.Drawing.Size(130, 29);
            this.expXMLBtn.TabIndex = 82;
            this.expXMLBtn.Text = "Exportar Usuarios";
            this.expXMLBtn.UseVisualStyleBackColor = true;
            this.expXMLBtn.Click += new System.EventHandler(this.expXMLBtn_Click);
            // 
            // Usuario_Lectura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 556);
            this.Controls.Add(this.expXMLBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.volverBtn);
            this.Name = "Usuario_Lectura";
            this.Text = "Usuario_Lectura";
            this.Load += new System.EventHandler(this.Usuario_Lectura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button expXMLBtn;
    }
}