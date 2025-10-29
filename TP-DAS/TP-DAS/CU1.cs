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
    public partial class CU1 : UserControl
    {
        public CU1()
        {
            InitializeComponent();
        }
        public string Etiqueta
        {
            get { return lblEtiqueta.Text; } 
            set {lblEtiqueta.Text = value;}
        }

        public string Texto
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        protected void SetearColor(Color color)
        {
            lblEtiqueta.ForeColor = color;
        }

        public virtual bool Validar()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                ok = false;
                SetearColor(Color.Red);
                //textBox1.openTooltip(".......");
            }
            else
            {
                SetearColor(Color.Green);
            }
            return ok;
        }
        private void CU1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
