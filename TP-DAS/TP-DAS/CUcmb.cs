using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_DAS
{
    public partial class CUcmb : UserControl
    {


        public CUcmb()
        {
            InitializeComponent();
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public string[] Items
        {
            get
            {
                string[] items = new string[cmb.Items.Count];
                cmb.Items.CopyTo(items, 0);
                return items;
            }
            set
            {
                cmb.Items.Clear();
                if (value != null)
                    cmb.Items.AddRange(value);
            }
        }

        public string SelectedItem
        {
            get { return cmb.SelectedItem?.ToString() ?? ""; }
            set { cmb.SelectedItem = value; }
        }
        protected void SetearColor(Color color)
        {
            lblEtiqueta.ForeColor = color;
        }




        public string Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }



        public virtual bool Validar()
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(this.SelectedItem))
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
            // Podés agregar lógica adicional si necesitás
        }

        private void CU3_Load(object sender, EventArgs e)
        {
        }
    }
}
