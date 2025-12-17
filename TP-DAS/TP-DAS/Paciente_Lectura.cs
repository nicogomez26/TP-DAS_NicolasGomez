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
    public partial class Paciente_Lectura : Form
    {
        BE.Usuario uLogueado;

        BLL.Paciente pacienteBll = new BLL.Paciente();
        public Paciente_Lectura(BE.Usuario uLogueado)
        {
            InitializeComponent();
            this.uLogueado = uLogueado;
        }

        private void Paciente_Lectura_Load(object sender, EventArgs e)
        {
            VerGrilla();
            button2.Click += button2_Click;
            expPacientesBtn.Click += expPacientesBtn_Click;
            volverBtn.Click += volverBtn_Click;
        }

        public void VerGrilla()
        {

            grilla.Grid.DataSource = null;
            grilla.Grid.DataSource = pacienteBll.ListarPaciente();
            grilla.Grid.ClearSelection();

        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica(uLogueado);

            clinica.Show();

            this.Hide();
        }
        BE.Paciente tmp;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Paciente bllPaciente = new BLL.Paciente();

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "XML (*.xml)|*.xml";
                sfd.FileName = "TurnosPaciente.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bllPaciente.ExportarTurnosPacienteXML(
                        tmp.Id,
                        sfd.FileName
                    );

                    MessageBox.Show("XML exportado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

        private void grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= grilla.Grid.Rows.Count)
                    return;

                var fila = grilla.Grid.Rows[e.RowIndex];
                if (fila == null || fila.DataBoundItem == null)
                    return;

                tmp = (BE.Paciente)grilla.Grid.Rows[e.RowIndex].DataBoundItem;

                idPaciente.Text = tmp.Id.ToString();

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void expPacientesBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivos XML (*.xml)|*.xml";
                sfd.FileName = "Pacientes.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    BLL.Paciente pacienteBll = new BLL.Paciente();
                    pacienteBll.ExportarPacientesXML(sfd.FileName);

                    MessageBox.Show("Pacientes exportados correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
