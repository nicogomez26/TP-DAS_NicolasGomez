namespace TP_DAS
{
    partial class CUcmb
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben eliminarse; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            this.cmb = new System.Windows.Forms.ComboBox();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb
            // 
            this.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point(55, 3);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(239, 21);
            this.cmb.TabIndex = 1;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.cboOpciones_SelectedIndexChanged);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(3, 6);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(46, 13);
            this.lblEtiqueta.TabIndex = 0;
            this.lblEtiqueta.Text = "Etiqueta";
            // 
            // CU3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.lblEtiqueta);
            this.Name = "CU3";
            this.Size = new System.Drawing.Size(305, 28);
            this.Load += new System.EventHandler(this.CU3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label lblEtiqueta;
    }
}
