using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DAS
{
    public partial class CUEmail : CU1
    {
        public CUEmail()
        {
            InitializeComponent();
        }

        public override bool Validar()
        {

            bool ok = base.Validar();

            if (ok)
            {
                Regex re = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

                if (!re.IsMatch(this.Texto))
                {
                    ok = false;
                    SetearColor(Color.Red);
                    MessageBox.Show("Ingresar un correo válido");
                }
                else
                {
                    SetearColor(Color.Green);
                }
            }

            return ok;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 3);
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            // 
            // CUEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "CUEmail";
            this.Size = new System.Drawing.Size(338, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
