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
    public partial class Especialidad : Form
    {
        BE.Usuario uLogueado;
        public Especialidad(BE.Usuario usuario)
        {
            InitializeComponent();
            this.uLogueado = usuario;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica(uLogueado);

            clinica.Show();

            this.Hide();
        }


        BLL.Especialidad especialidadBLL = new BLL.Especialidad();
        BE.Especialidad especialidad = new BE.Especialidad();


        public void VerGrilla()
        {

            grilla.Grid.DataSource = null;
            grilla.Grid.DataSource = especialidadBLL.ListarEspecialidades();

        }




        private void agrEspBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                especialidad = new BE.Especialidad();

                especialidad.Nombre = cU11.Texto;

                fa = especialidadBLL.AgregarEspecialidad(especialidad);

                if (fa != 0)
                {
                    MessageBox.Show("Se agregó");
                    VerGrilla();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void editEspBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                especialidad = new BE.Especialidad();

                especialidad.Id = int.Parse(IdEsp.Text);
                especialidad.Nombre = cU11.Texto;

                fa = especialidadBLL.EditarEspecialidad(especialidad);

                if (fa != 0)
                {
                    MessageBox.Show("Se editó");
                    VerGrilla();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Especialidad_Load(object sender, EventArgs e)
        {
            VerGrilla();

            agrEspBtn.Click += agrEspBtn_Click;
            editEspBtn.Click += editEspBtn_Click;
            elimEspBtn.Click += elimEspBtn_Click;
        }

        private void elimEspBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                especialidad = new BE.Especialidad();
                especialidad.Id = int.Parse(IdEsp.Text);

                fa = especialidadBLL.EliminarEspecialidad(especialidad);

                if (fa != 0)
                {
                    MessageBox.Show("Se eliminó");
                    VerGrilla();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        BE.Especialidad tmp;
        private void grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= grilla.Grid.Rows.Count)
                    return;

                var fila = grilla.Grid.Rows[e.RowIndex];
                if (fila == null || fila.DataBoundItem == null)
                    return;

                tmp = (BE.Especialidad)grilla.Grid.Rows[e.RowIndex].DataBoundItem;

                IdEsp.Text = tmp.Id.ToString();

                cU11.Texto = tmp.Nombre.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
