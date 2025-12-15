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
        private void loginBtn_Click(object sender, EventArgs e)
        {

/*            BE.Usuario u = usuarioBll.Login(cuEmail1.Texto,cuPass1.Texto);
*/            BE.Usuario u = new BE.Usuario();

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

        }

        private void cambioPassBtn_Click(object sender, EventArgs e)
        {
            Cambio_de_Contrasena cambioPass = new Cambio_de_Contrasena();

            cambioPass.ShowDialog();
        }
    }
}
