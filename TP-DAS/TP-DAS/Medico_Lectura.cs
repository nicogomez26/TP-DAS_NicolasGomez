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
    public partial class Medico_Lectura : Form
    {
        BE.Usuario uLogueado;
        BLL.Medico medicoBll = new BLL.Medico();
        public Medico_Lectura(BE.Usuario uLogueado)
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

        private void Medico_Lectura_Load(object sender, EventArgs e)
        {
            VerGrilla();

            button1.Click += button1_Click;
            volverBtn.Click += volverBtn_Click;
            expMedBtn.Click += expMedBtn_Click;
        }

        public void VerGrilla()
        {

            grilla.Grid.DataSource = null;
            grilla.Grid.DataSource = medicoBll.ListarMedico();

        }

        private void expMedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivos XML (*.xml)|*.xml";
                sfd.FileName = "Medicos.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    BLL.Medico medicoBll = new BLL.Medico();
                    medicoBll.ExportarMedicosXML(sfd.FileName);

                    MessageBox.Show("Médicos exportados correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int iDMedico = Convert.ToInt32(IdMedico.Text);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Archivos XML (*.xml)|*.xml";
                sfd.FileName = "TurnosMedico.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    medicoBll.ExportarTurnosXML(sfd.FileName, iDMedico);
                    MessageBox.Show("XML exportado correctamente", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
