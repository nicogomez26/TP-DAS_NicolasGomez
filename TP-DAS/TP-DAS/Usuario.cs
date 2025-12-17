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
    public partial class Usuario : Form
    {
        BE.Usuario uLogueado = new BE.Usuario();
        BLL.Usuario usuarioBll = new BLL.Usuario();
        BE.Usuario usuario = new BE.Usuario();
        public Usuario(BE.Usuario uLogueado)
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

        private void Usuario_Load(object sender, EventArgs e)
        {
            VerGrilla();
            logueadoTxt.Text = uLogueado.Nombre;
            cUcmb1.CargarItems(new Dictionary<int, string>
                {
                    { 0, "Lectura" },
                    { 1, "Escritura" }
                });

            agrPacBtn.Click +=  agrPacBtn_Click;
            editPacBtn.Click += editPacBtn_Click;
            elimPacBtn.Click += elimPacBtn_Click;
            expXMLBtn.Click += expXMLBtn_Click;
            volverBtn.Click += volverBtn_Click;
            desbloquearBtn.Click += desbloquearBtn_Click;
        }

        private void agrPacBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                usuario = new BE.Usuario();

                usuario.Nombre = cU11.Texto;
                usuario.Email = cuEmail1.Texto;
                usuario.Pass = cuPass1.Texto;
                usuario.Privilegios = cUcmb1.SelectedValue;

                fa = usuarioBll.AgregarUsuario(usuario);

                if (fa != 0)
                {
                    MessageBox.Show("Se agregó el usuario");
                    VerGrilla();
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }

        }

        public void VerGrilla()
        {
            grilla.CellClick += grilla_CellClick;
            grilla.Grid.DataSource = null;
            grilla.Grid.DataSource = usuarioBll.ListarUsuarios();
        }

        private void editPacBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                usuario = new BE.Usuario();

                usuario.Id = int.Parse(idUser.Text);
                usuario.Nombre = cU11.Texto;
                usuario.Email = cuEmail1.Texto;
                usuario.Pass = cuPass1.Texto;
                usuario.Privilegios = cUcmb1.SelectedValue;

                fa = usuarioBll.EditarUsuario(usuario);

                if (fa != 0)
                {
                    MessageBox.Show("Se editó el usuario");
                    VerGrilla();
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }

        private void elimPacBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                usuario = new BE.Usuario();

                usuario.Id = int.Parse(idUser.Text);

                fa = usuarioBll.EliminarUsuario(usuario);

                if (fa != 0)
                {
                    MessageBox.Show("Se eliminó el usuario");
                    VerGrilla();
                }
                else
                {
                    MessageBox.Show("Error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }
        }

        BE.Usuario tmp;
        private void grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= grilla.Grid.Rows.Count)
                    return;

                var fila = grilla.Grid.Rows[e.RowIndex];
                if (fila == null || fila.DataBoundItem == null)
                    return;

                tmp = (BE.Usuario)grilla.Grid.Rows[e.RowIndex].DataBoundItem;

                idUser.Text = tmp.Id.ToString();

                cU11.Texto = tmp.Nombre;
                cuEmail1.Texto = tmp.Email;
                cuPass1.Texto = tmp.Pass;
                cUcmb1.SelectedItem = tmp.Privilegios.ToString(); ////REVISAR
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void desbloquearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tmp == null)
                {
                    MessageBox.Show("Seleccione un usuario de la grilla");
                    return;
                }

                usuarioBll.DesbloquearUsuario(tmp);
                MessageBox.Show(tmp.Id.ToString());


                MessageBox.Show($"Usuario '{tmp.Nombre}' desbloqueado correctamente.");

                VerGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desbloquear usuario: " + ex.Message);
            }
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void expXMLBtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void desbloquearBtn_Load(object sender, EventArgs e)
        {

        }

        private void expXMLBtn_Load(object sender, EventArgs e)
        {

        }
    }
}
