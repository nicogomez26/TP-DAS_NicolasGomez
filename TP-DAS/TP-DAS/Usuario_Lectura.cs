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
    public partial class Usuario_Lectura : Form
    {
        BE.Usuario uLogueado;
        BLL.Usuario usuarioBll = new BLL.Usuario();
        public Usuario_Lectura(BE.Usuario uLogueado)
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

        private void Usuario_Lectura_Load(object sender, EventArgs e)
        {
            VerGrilla();
        }
        public void VerGrilla()
        {
            grilla.DataSource = null;
            grilla.DataSource = usuarioBll.ListarUsuarios();
        }

        private void expXMLBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML (*.xml)|*.xml";
            sfd.FileName = "Usuarios.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                usuarioBll.ExportarUsuariosXML(sfd.FileName);
                MessageBox.Show("Usuarios exportados correctamente");
            }
        }
    }
}
