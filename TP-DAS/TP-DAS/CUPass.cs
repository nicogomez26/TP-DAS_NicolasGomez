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
    public partial class CUPass : CU1
    {
        /*public CUPass()
        {
            InitializeComponent();
        }*/

        public override bool Validar()
        {

            bool ok = base.Validar();

            if (ok)
            {
                Regex re = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&.#_-]).{8,16}$");

                if (!re.IsMatch(this.Texto))
                {
                    ok = false;
                    SetearColor(Color.Red);
                    MessageBox.Show("Ingresar una contraseña válido");
                }
                else
                {
                    SetearColor(Color.Green);
                }
            }

            return ok;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 3);
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            // 
            // CUPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "CUPass";
            this.Size = new System.Drawing.Size(362, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
