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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        BLL.Paciente pacienteBll = new BLL.Paciente();
        BE.Paciente paciente= new BE.Paciente();
        private void Paciente_Load(object sender, EventArgs e)
        {
            try
            {
                grilla.AllowUserToAddRows = false;
                cU32.cargarDatos("listarObrasSociales", "Nombre", "ID");
                cUcmb1.Items = new string[] { "Femenino", "Masculino" };
                VerGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el formulario: " + ex.Message);
            }
        }
        private void editPacBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                paciente = new BE.Paciente();

                paciente.Id = int.Parse(idPaciente.Text);
                paciente.Dni = int.Parse(cU21.Texto);
                paciente.Nombre = cU11.Texto;
                paciente.Apellido = cU12.Texto;
                paciente.Edad = int.Parse(cU22.Texto);
                paciente.Sexo = cUcmb1.SelectedItem;
                paciente.Id_ObraSocial = cU32.ValorSeleccionado;

                fa = pacienteBll.EditarPaciente(paciente);

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
        private void agrPacBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                paciente = new BE.Paciente();

                paciente.Dni = int.Parse(cU21.Texto);
                paciente.Nombre = cU11.Texto;
                paciente.Apellido = cU12.Texto;
                paciente.Edad = int.Parse(cU22.Texto);
                paciente.Sexo = cUcmb1.SelectedItem;
                paciente.Id_ObraSocial = cU32.ValorSeleccionado;

                fa = pacienteBll.AgregarPaciente(paciente);

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
        public void VerGrilla()
        {

            grilla.DataSource = null;
            grilla.DataSource = pacienteBll.ListarPaciente();
            grilla.ClearSelection();

        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica();

            clinica.Show();
            this.Hide();
        }

        private void elimPacBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (grilla.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un paciente para eliminar.");
                    return;
                }

                int id = Convert.ToInt32(grilla.SelectedRows[0].Cells["Id"].Value);

                BE.Paciente pac = new BE.Paciente();
                pac.Id = id;

                int fa = pacienteBll.EliminarPaciente(pac);

                /*
                                int fa = 0;

                                paciente = new BE.Paciente();
                                paciente.Id = int.Parse(idPaciente.Text);
                */
/*                fa = pacienteBll.EliminarPaciente(paciente);
*/
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

                MessageBox.Show(ex.ToString());
            }
        }

 /*       private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/

        BE.Paciente tmp;

        private void grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= grilla.Rows.Count)
                    return;

                var fila = grilla.Rows[e.RowIndex];
                if (fila == null || fila.DataBoundItem == null)
                    return;

                tmp = (BE.Paciente)grilla.Rows[e.RowIndex].DataBoundItem;

                idPaciente.Text = tmp.Id.ToString();

                cU21.Texto = tmp.Dni.ToString();
                cU11.Texto = tmp.Nombre;
                cU12.Texto = tmp.Apellido;
                cU22.Texto = tmp.Edad.ToString();
                cUcmb1.SelectedItem = tmp.Sexo;

                cU32.ValorSeleccionado = tmp.Id_ObraSocial;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
    }
    }

