namespace TP_DAS
{
    partial class Especialidad
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
            this.elimEspBtn = new System.Windows.Forms.Button();
            this.editEspBtn = new System.Windows.Forms.Button();
            this.agrEspBtn = new System.Windows.Forms.Button();
            this.cU11 = new TP_DAS.CU1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdEsp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(384, 147);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(708, 272);
            this.grilla.TabIndex = 74;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellClick);
            // 
            // volverBtn
            // 
            this.volverBtn.Location = new System.Drawing.Point(23, 18);
            this.volverBtn.Name = "volverBtn";
            this.volverBtn.Size = new System.Drawing.Size(133, 44);
            this.volverBtn.TabIndex = 73;
            this.volverBtn.Text = "Volver";
            this.volverBtn.UseVisualStyleBackColor = true;
            this.volverBtn.Click += new System.EventHandler(this.volverBtn_Click);
            // 
            // elimEspBtn
            // 
            this.elimEspBtn.Location = new System.Drawing.Point(91, 346);
            this.elimEspBtn.Name = "elimEspBtn";
            this.elimEspBtn.Size = new System.Drawing.Size(238, 29);
            this.elimEspBtn.TabIndex = 72;
            this.elimEspBtn.Text = "Eliminar";
            this.elimEspBtn.UseVisualStyleBackColor = true;
            this.elimEspBtn.Click += new System.EventHandler(this.elimEspBtn_Click);
            // 
            // editEspBtn
            // 
            this.editEspBtn.Location = new System.Drawing.Point(91, 301);
            this.editEspBtn.Name = "editEspBtn";
            this.editEspBtn.Size = new System.Drawing.Size(238, 29);
            this.editEspBtn.TabIndex = 71;
            this.editEspBtn.Text = "Editar";
            this.editEspBtn.UseVisualStyleBackColor = true;
            this.editEspBtn.Click += new System.EventHandler(this.editEspBtn_Click);
            // 
            // agrEspBtn
            // 
            this.agrEspBtn.Location = new System.Drawing.Point(91, 254);
            this.agrEspBtn.Name = "agrEspBtn";
            this.agrEspBtn.Size = new System.Drawing.Size(238, 29);
            this.agrEspBtn.TabIndex = 70;
            this.agrEspBtn.Text = "Agregar";
            this.agrEspBtn.UseVisualStyleBackColor = true;
            this.agrEspBtn.Click += new System.EventHandler(this.agrEspBtn_Click);
            // 
            // cU11
            // 
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(59, 183);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(292, 33);
            this.cU11.TabIndex = 69;
            this.cU11.Texto = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Crear Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Id";
            // 
            // IdEsp
            // 
            this.IdEsp.AutoSize = true;
            this.IdEsp.Location = new System.Drawing.Point(116, 157);
            this.IdEsp.Name = "IdEsp";
            this.IdEsp.Size = new System.Drawing.Size(10, 13);
            this.IdEsp.TabIndex = 76;
            this.IdEsp.Text = "-";
            // 
            // Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 595);
            this.Controls.Add(this.IdEsp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.volverBtn);
            this.Controls.Add(this.elimEspBtn);
            this.Controls.Add(this.editEspBtn);
            this.Controls.Add(this.agrEspBtn);
            this.Controls.Add(this.cU11);
            this.Controls.Add(this.label1);
            this.Name = "Especialidad";
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.Especialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button elimEspBtn;
        private System.Windows.Forms.Button editEspBtn;
        private System.Windows.Forms.Button agrEspBtn;
        private CU1 cU11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IdEsp;
    }
}