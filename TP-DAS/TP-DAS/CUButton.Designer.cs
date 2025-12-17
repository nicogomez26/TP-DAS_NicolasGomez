using System.Windows.Forms;

namespace TP_DAS
{
    partial class CUButton
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(245, 37);
            this.btn.TabIndex = 0;
            this.btn.Text = "CUButton";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Dock = DockStyle.Fill; // <-- hace que el botón llene todo el CU
            this.btn.Text = "CUButton";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // CUButton
            // 
            this.Controls.Add(this.btn);
            this.Name = "CUButton";
            this.Size = new System.Drawing.Size(248, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}
