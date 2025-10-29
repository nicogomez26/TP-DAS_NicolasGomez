using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DAS
{
    public partial class CU3 : CU1
    {
        /*public CU2()
        {
            InitializeComponent();
        }*/

        public override bool Validar()
        {

            bool ok = base.Validar();

            if (ok)
            {
                int numero;
                ok = int.TryParse(this.Texto, out numero);
                if (!ok)
                {

                    this.SetearColor(System.Drawing.Color.Red);
                    base.textBox1.openTooltip("error");
                }
                else { this.SetearColor(System.Drawing.Color.Green); }
            }

            return ok;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // CU3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CU3";
            this.Load += new System.EventHandler(this.CU3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public int value()
        {
            return base.textBox1.GetInt();
        }


        private void CU3_Load(object sender, EventArgs e)
        {

        }
    }
}
