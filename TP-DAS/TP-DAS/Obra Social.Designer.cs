namespace TP_DAS
{
    partial class Obra_Social
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
            this.elimOSBtn = new System.Windows.Forms.Button();
            this.editOSBtn = new System.Windows.Forms.Button();
            this.agrOSBtn = new System.Windows.Forms.Button();
            this.cU11 = new TP_DAS.CU1();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(373, 141);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(708, 272);
            this.grilla.TabIndex = 67;
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(12, 12);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 66;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // elimOSBtn
            // 
            this.elimOSBtn.Location = new System.Drawing.Point(80, 340);
            this.elimOSBtn.Name = "elimOSBtn";
            this.elimOSBtn.Size = new System.Drawing.Size(238, 29);
            this.elimOSBtn.TabIndex = 65;
            this.elimOSBtn.Text = "Eliminar";
            this.elimOSBtn.UseVisualStyleBackColor = true;
            // 
            // editOSBtn
            // 
            this.editOSBtn.Location = new System.Drawing.Point(80, 295);
            this.editOSBtn.Name = "editOSBtn";
            this.editOSBtn.Size = new System.Drawing.Size(238, 29);
            this.editOSBtn.TabIndex = 64;
            this.editOSBtn.Text = "Editar";
            this.editOSBtn.UseVisualStyleBackColor = true;
            // 
            // agrOSBtn
            // 
            this.agrOSBtn.Location = new System.Drawing.Point(80, 248);
            this.agrOSBtn.Name = "agrOSBtn";
            this.agrOSBtn.Size = new System.Drawing.Size(238, 29);
            this.agrOSBtn.TabIndex = 63;
            this.agrOSBtn.Text = "Agregar";
            this.agrOSBtn.UseVisualStyleBackColor = true;
            this.agrOSBtn.Click += new System.EventHandler(this.agrOSBtn_Click);
            // 
            // cU11
            // 
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(48, 177);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(292, 33);
            this.cU11.TabIndex = 57;
            this.cU11.Texto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Crear Obra Social";
            // 
            // Obra_Social
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 594);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.elimOSBtn);
            this.Controls.Add(this.editOSBtn);
            this.Controls.Add(this.agrOSBtn);
            this.Controls.Add(this.cU11);
            this.Controls.Add(this.label1);
            this.Name = "Obra_Social";
            this.Text = "Obra_Social";
            this.Load += new System.EventHandler(this.Obra_Social_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button elimOSBtn;
        private System.Windows.Forms.Button editOSBtn;
        private System.Windows.Forms.Button agrOSBtn;
        private CU1 cU11;
        private System.Windows.Forms.Label label1;
    }
}