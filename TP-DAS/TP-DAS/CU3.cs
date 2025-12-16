using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TP_DAS
{
    public partial class CU3 : UserControl
    {

        public CU3()
        {
            InitializeComponent();
        }

        public void CargarDatos(object dataSource, string displayMember, string valueMember)
        {
            cmb.DataSource = null;
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
            cmb.DataSource = dataSource;
        }



        public int ValorSeleccionado
        {
            get { return (int)cmb.SelectedValue; }
            set { cmb.SelectedValue = value; }
        }

        public string TextoSeleccionado
        {
            get
            {
                return cmb.Text;
            }
            set => cmb.SelectedValue = value;

        }


        public string Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }


        public virtual bool Validar()
        {
            bool ok = cmb.SelectedIndex >= 0;

            if (!ok)
            {
                cmb.BackColor = System.Drawing.Color.LightCoral;
                ToolTip tt = new ToolTip();
                tt.Show("Debe seleccionar una opción", cmb, 0, cmb.Height, 2000);
            }
            else
            {
                cmb.BackColor = System.Drawing.Color.White;
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
