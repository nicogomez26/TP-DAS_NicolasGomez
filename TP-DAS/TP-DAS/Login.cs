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


            try
            {
                BE.Usuario u = usuarioBll.Login(cuEmail1.Texto, cuPass1.Texto);

                if (u != null && u.Bloqueado)
                {
                    MessageBox.Show(
                        "El usuario fue bloqueado por 3 intentos fallidos. Contactese con el Administrador",
                        "Usuario bloqueado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                    );
                    return;
                }
                if (u == null)
                {
                    MessageBox.Show("Email o contraseña incorrectos", "Login fallido",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                


                Clinica clinica = new Clinica(u);
                clinica.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString());
                return;
            }
        
        }
        public string CalcularSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            servicios.verificarEstado(this);
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
