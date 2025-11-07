using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_DAS
{
    public partial class CUDate : UserControl
    {


        public CUDate()
        {
            InitializeComponent();

            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(90);
        }


        public string Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }

        public DateTime Valor
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }

        protected void SetearColor(Color color)
        {
            lblEtiqueta.ForeColor = color;
        }

        public DateTime Minimo
        {
            get { return dateTimePicker1.MinDate; }
            set { dateTimePicker1.MinDate = value; }
        }

        public DateTime Maximo
        {
            get { return dateTimePicker1.MaxDate; }
            set { dateTimePicker1.MaxDate = value; }
        }

        public virtual bool Validar()
        {
            bool ok = true;
            if (Valor < Minimo || Valor > Maximo)
            {
                ok = false;
                SetearColor(Color.Red);
            }
            else
            {
                SetearColor(Color.Green);
            }

            return ok;
        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CU3_Load(object sender, EventArgs e)
        {
        }
    }
}
