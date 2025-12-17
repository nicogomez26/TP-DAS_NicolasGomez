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
    public partial class Cambio_de_Contrasena : Form
    {
        BLL.Usuario usuarioBll = new BLL.Usuario();

        public Cambio_de_Contrasena()
        {
            InitializeComponent();
        }

        private void cambiarPassBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string passActual = cuPassAct.Texto;
                string passNueva1 = cuPassNew1.Texto;
                string passNueva2 = cuPassNew2.Texto;

                
               if (passNueva1 != passNueva2)
                {
                    MessageBox.Show("Las nuevas contraseñas no coinciden.");
                    return;
                }

               string email = cuEmail1.Texto;

                BE.Usuario usuario = usuarioBll.Login(email, passActual);
                if (usuario == null)
                {
                    MessageBox.Show("Contraseña actual incorrecta.");
                    return;
                }

                usuario.Pass = passNueva1;

                usuarioBll.CambiarPassword(usuario);

                MessageBox.Show("Contraseña actualizada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la contraseña: " + ex.Message);
            }
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiarPassBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void Cambio_de_Contrasena_Load(object sender, EventArgs e)
        {
            cambiarPassBtn.Click += cambiarPassBtn_Click;
            cancelarBtn.Click += cancelarBtn_Click;
        }
    }
}
