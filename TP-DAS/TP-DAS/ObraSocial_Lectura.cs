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
    public partial class ObraSocial_Lectura : Form
    {
        BE.Usuario uLogueado;
        BLL.ObraSocial ObraSocBll = new BLL.ObraSocial();
        public ObraSocial_Lectura(BE.Usuario uLogueado)
        {
            InitializeComponent();
            this.uLogueado = uLogueado;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica(uLogueado);

            clinica.Show();
            this.Hide();
        }

        private void ObraSocial_Lectura_Load(object sender, EventArgs e)
        {
            VerGrilla();
        }
        public void VerGrilla()
        {

            grilla.DataSource = null;
            grilla.DataSource = ObraSocBll.ListarObraSociales();

        }
    }
}
