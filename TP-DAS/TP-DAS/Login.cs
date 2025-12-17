using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TP_DAS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BLL.Usuario usuarioBll = new BLL.Usuario();
        BLL.Servicios servicios = new BLL.Servicios();

        private void loginBtn_Click(object sender, EventArgs e)
        {

            BE.Usuario u = new BE.Usuario();

            Clinica clinica = new Clinica(u);
            clinica.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BE.Usuario Usuario = new BE.Usuario();
            Usuario u = new Usuario(Usuario);

            u.Show();

            this.Hide();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            if (!servicios.SqlServerActivo())
            {
                MessageBox.Show(
                    "El servicio de SQL Server no está iniciado.\nInícielo para continuar.",
                    "Error de servicio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                this.Close();
                return;
            }
            loginBtn.Click += loginBtn_Click;
            cambioPassBtn.Click += cambioPassBtn_Click;

        }


        private void cambioPassBtn_Click(object sender, EventArgs e)
        {
            Cambio_de_Contrasena cambioPass = new Cambio_de_Contrasena();

            cambioPass.ShowDialog();
        }

        private void cambioPassBtn_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Load(object sender, EventArgs e)
        {

        }
    }
}
