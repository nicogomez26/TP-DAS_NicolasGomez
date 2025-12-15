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
    public partial class Especialidad_Lectura : Form
    {
        BE.Usuario uLogueado;
        BLL.Especialidad especialidadBll = new BLL.Especialidad();

        public Especialidad_Lectura(BE.Usuario uLogueado)
        {
            InitializeComponent();
            this.uLogueado = uLogueado;
        }

        private void Especialidad_Lectura_Load(object sender, EventArgs e)
        {
            VerGrilla();
        }
        public void VerGrilla()
        {

            grilla.DataSource = null;
            grilla.DataSource = especialidadBll.ListarEspecialidades();

        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica(uLogueado);

            clinica.Show();

            this.Hide();
        }
    }
}
