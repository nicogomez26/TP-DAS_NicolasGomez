using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TP_DAS
{
    public partial class CU3 : UserControl
    {
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();


        public CU3()
        {
            InitializeComponent();
        }

        public void Conectar()
        {
            cn.ConnectionString = @"Data Source=.;Initial Catalog=Clinica;Integrated Security=True";
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
            cn.Dispose();
        }

            
        public void cargarDatos(string sp, string displayMember, string valueMember, SqlParameter[] parametros = null)
        {
            try
            {
                DataTable dt = new DataTable();

                Conectar();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;

                if (parametros != null)
                {
                    cmd.Parameters.AddRange(parametros);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd); 
                da.Fill(dt);

                Desconectar();

                cmb.DataSource = dt;
                cmb.DisplayMember = displayMember;
                cmb.ValueMember = valueMember;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la obra social: " + ex.Message);
            }
        }


        public int ValorSeleccionado
        {
            get {
                return (int)cmb.SelectedValue;
            }
        }

        public string TextoSeleccionado
        {
            get
            {
                return cmb.Text;
            }
        }

        /*public ComboBox Combo => cmb;*/

        public string Etiqueta
        {
            get { return lblEtiqueta.Text; }
            set { lblEtiqueta.Text = value; }
        }



        public List<string> Items
        {
            set
            {
                cmb.Items.Clear();
                cmb.Items.AddRange(value.ToArray());
            }
        }

       /* public string ValorSeleccionado
        {
            get { return cmb.SelectedItem?.ToString(); }
            set { cmb.SelectedItem = value; }
        }*/


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
