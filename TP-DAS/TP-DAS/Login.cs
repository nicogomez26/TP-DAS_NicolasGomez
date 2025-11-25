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
        private void loginBtn_Click(object sender, EventArgs e)
        {

            string hash = CalcularSHA256(cuPass1.Texto);
            MessageBox.Show(hash);
            BE.Usuario u = usuarioBll.Login(cuEmail1.Texto,cuPass1.Texto);
/*            MessageBox.Show("Email enviado: " + u.Email);
            MessageBox.Show("Pass enviado (hash): " + u.Pass);
            MessageBox.Show("Longitud hash: " + u.Pass.Length);*/


            if (u == null)
            {
                MessageBox.Show("Credenciales incorrectas");
                return;
            }

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
    }
}
