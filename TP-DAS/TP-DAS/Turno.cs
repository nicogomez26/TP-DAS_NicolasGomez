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
    public partial class Turno : Form
    {
        public Turno()
        {
            InitializeComponent();
        }


        BLL.Turno turnoBll = new BLL.Turno();
        BE.Turno turno = new BE.Turno();

        private void agrTurBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                if (!cuDate1.Validar())
                {
                    MessageBox.Show("La fecha seleccionada no es válida.");
                    return;
                }


                turno = new BE.Turno();

                turno.Fecha = cuDate1.Valor;

                turno.Id_Paciente = cU32.ValorSeleccionado;
                turno.Id_Medico = cU31.ValorSeleccionado;


                fa = turnoBll.AgregarTurno(turno);

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
            grilla.DataSource = turnoBll.ListarTurno();

        }
        private void volverBtn_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica();

            clinica.Show();

            this.Hide();
        }

        private void cU32_Load(object sender, EventArgs e)
        {

        }

        private void Turno_Load(object sender, EventArgs e)
        {
            VerGrilla();
            cU32.cargarDatos("listarPacientes", "Nombre", "ID");
            cU31.cargarDatos("listarMedicos", "Nombre", "ID");
        }

        BE.Turno tmp;
        private void grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= grilla.Rows.Count)
                    return;

                var fila = grilla.Rows[e.RowIndex];
                if (fila == null || fila.DataBoundItem == null)
                    return;

                tmp = (BE.Turno)grilla.Rows[e.RowIndex].DataBoundItem;

                idTurno.Text = tmp.Id.ToString();

                cuDate1.Valor = tmp.Fecha;
                cU32.ValorSeleccionado = tmp.Id_Paciente;
                cU31.ValorSeleccionado = tmp.Id_Medico;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void elimTurBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                turno = new BE.Turno();
                turno.Id = int.Parse(idTurno.Text);

                fa = turnoBll.EliminarTurno(turno);

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

        private void editTurBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                if (!cuDate1.Validar())
                {
                    MessageBox.Show("La fecha seleccionada no es válida.");
                    return;
                }


                turno = new BE.Turno();

                turno.Id = int.Parse(idTurno.Text);

                turno.Fecha = cuDate1.Valor;
                turno.Id_Paciente = cU32.ValorSeleccionado;
                turno.Id_Medico = cU31.ValorSeleccionado;


                fa = turnoBll.EditarTurno(turno);

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
    }
}
