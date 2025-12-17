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
        private Button verPassBtn;
        public CUPass()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
        }

        private void verPassBtn_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
            verPassBtn.BackgroundImage = Properties.Resources.verPass1;
            verPassBtn.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void verPassBtn_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            verPassBtn.BackgroundImage = Properties.Resources.ocultarPass2;
            verPassBtn.BackgroundImageLayout = ImageLayout.Zoom;
        }


        public override bool Validar()
        {

            bool ok = base.Validar();

            if (ok)
            {
                Regex re = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&.#_-]).{8,16}$");

                if (!re.IsMatch(this.Texto))
                {
                    ok = false;
/*                    SetearColor(Color.Red);
*/                    MessageBox.Show("Ingresar una contraseña válido");
                }
                else
                {
/*                    SetearColor(Color.Green);
*/                }
            }

            return ok;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.verPassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEtiqueta.ForeColor = System.Drawing.Color.Black;
            this.lblEtiqueta.Size = new System.Drawing.Size(40, 15);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(197)))), ((int)(((byte)(222)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.Size = new System.Drawing.Size(239, 18);
            // 
            // verPassBtn
            // 
            this.verPassBtn.BackColor = System.Drawing.Color.Transparent;
            this.verPassBtn.BackgroundImage = global::TP_DAS.Properties.Resources.ocultarPass2;
            this.verPassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verPassBtn.FlatAppearance.BorderSize = 0;
            this.verPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verPassBtn.Location = new System.Drawing.Point(317, 3);
            this.verPassBtn.Name = "verPassBtn";
            this.verPassBtn.Size = new System.Drawing.Size(38, 27);
            this.verPassBtn.TabIndex = 4;
            this.verPassBtn.UseVisualStyleBackColor = false;
            this.verPassBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.verPassBtn_MouseDown);
            this.verPassBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.verPassBtn_MouseUp);
            // 
            // CUPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.verPassBtn);
            this.Name = "CUPass";
            this.Size = new System.Drawing.Size(402, 33);
            this.Controls.SetChildIndex(this.verPassBtn, 0);
            this.Controls.SetChildIndex(this.lblEtiqueta, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
