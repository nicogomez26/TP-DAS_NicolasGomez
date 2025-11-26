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
            this.label2 = new System.Windows.Forms.Label();
            this.IdEsp = new System.Windows.Forms.Label();
            this.cU11 = new TP_DAS.CU1();
            this.espGrp = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.espGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(378, 126);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(714, 293);
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
            this.elimEspBtn.Location = new System.Drawing.Point(38, 245);
            this.elimEspBtn.Name = "elimEspBtn";
            this.elimEspBtn.Size = new System.Drawing.Size(238, 29);
            this.elimEspBtn.TabIndex = 72;
            this.elimEspBtn.Text = "Eliminar";
            this.elimEspBtn.UseVisualStyleBackColor = true;
            this.elimEspBtn.Click += new System.EventHandler(this.elimEspBtn_Click);
            // 
            // editEspBtn
            // 
            this.editEspBtn.Location = new System.Drawing.Point(38, 200);
            this.editEspBtn.Name = "editEspBtn";
            this.editEspBtn.Size = new System.Drawing.Size(238, 29);
            this.editEspBtn.TabIndex = 71;
            this.editEspBtn.Text = "Editar";
            this.editEspBtn.UseVisualStyleBackColor = true;
            this.editEspBtn.Click += new System.EventHandler(this.editEspBtn_Click);
            // 
            // agrEspBtn
            // 
            this.agrEspBtn.Location = new System.Drawing.Point(38, 153);
            this.agrEspBtn.Name = "agrEspBtn";
            this.agrEspBtn.Size = new System.Drawing.Size(238, 29);
            this.agrEspBtn.TabIndex = 70;
            this.agrEspBtn.Text = "Agregar";
            this.agrEspBtn.UseVisualStyleBackColor = true;
            this.agrEspBtn.Click += new System.EventHandler(this.agrEspBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Id";
            // 
            // IdEsp
            // 
            this.IdEsp.AutoSize = true;
            this.IdEsp.Location = new System.Drawing.Point(63, 56);
            this.IdEsp.Name = "IdEsp";
            this.IdEsp.Size = new System.Drawing.Size(10, 13);
            this.IdEsp.TabIndex = 76;
            this.IdEsp.Text = "-";
            // 
            // cU11
            // 
            this.cU11.Etiqueta = "Nombre";
            this.cU11.Location = new System.Drawing.Point(6, 82);
            this.cU11.Name = "cU11";
            this.cU11.Size = new System.Drawing.Size(292, 33);
            this.cU11.TabIndex = 69;
            this.cU11.Texto = "";
            // 
            // espGrp
            // 
            this.espGrp.Controls.Add(this.cU11);
            this.espGrp.Controls.Add(this.IdEsp);
            this.espGrp.Controls.Add(this.label2);
            this.espGrp.Controls.Add(this.agrEspBtn);
            this.espGrp.Controls.Add(this.editEspBtn);
            this.espGrp.Controls.Add(this.elimEspBtn);
            this.espGrp.Location = new System.Drawing.Point(44, 126);
            this.espGrp.Name = "espGrp";
            this.espGrp.Size = new System.Drawing.Size(319, 293);
            this.espGrp.TabIndex = 77;
            this.espGrp.TabStop = false;
            this.espGrp.Text = "Gestionar Especialidades";
            // 
            // Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 595);
            this.Controls.Add(this.espGrp);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.volverBtn);
            this.Name = "Especialidad";
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.Especialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.espGrp.ResumeLayout(false);
            this.espGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button volverBtn;
        private System.Windows.Forms.Button elimEspBtn;
        private System.Windows.Forms.Button editEspBtn;
        private System.Windows.Forms.Button agrEspBtn;
        private CU1 cU11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IdEsp;
        private System.Windows.Forms.GroupBox espGrp;
    }
}