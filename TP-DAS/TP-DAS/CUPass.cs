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
        public CUPass()
        {
            InitializeComponent();
            textBox1.UseSystemPasswordChar = true;
        }

        private void verPassBtn_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.UseSystemPasswordChar = false;
            verPassBtn.BackgroundImage = Properties.Resources.verPass;
            verPassBtn.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void verPassBtn_MouseUp(object sender, MouseEventArgs e)
        {
            textBox1.UseSystemPasswordChar = true;
            verPassBtn.BackgroundImage = Properties.Resources.ocultarPass;
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
            this.verPassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 3);
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            // 
            // verPassBtn
            // 
            this.verPassBtn.BackgroundImage = global::TP_DAS.Properties.Resources.ocultarPass;
            this.verPassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.verPassBtn.Location = new System.Drawing.Point(339, 1);
            this.verPassBtn.Name = "verPassBtn";
            this.verPassBtn.Size = new System.Drawing.Size(30, 22);
            this.verPassBtn.TabIndex = 4;
            this.verPassBtn.UseVisualStyleBackColor = true;
            // 
            // CUPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.verPassBtn);
            this.Name = "CUPass";
            this.Size = new System.Drawing.Size(402, 33);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.verPassBtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
