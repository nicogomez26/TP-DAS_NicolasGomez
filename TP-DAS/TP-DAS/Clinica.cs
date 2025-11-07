using System;
using System.Windows.Forms;

namespace TP_DAS
{
    public partial class Clinica : Form   // ← o UserControl si es un control
    {
        public Clinica()
        {
            InitializeComponent();
        }

        private void Clinica_Load(object sender, EventArgs e)
        {

        }

        private void irPacientesBtn_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();

            paciente.Show();
            
            this.Hide();
        }

        private void irMedicosBtn_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();

            medico.Show();

            this.Hide();
        }

        private void irObSocBtn_Click(object sender, EventArgs e)
        {
            Obra_Social OS = new Obra_Social();

            OS.Show();

            this.Hide();
        }

        private void irTurnosBtn_Click(object sender, EventArgs e)
        {
            Turno turno = new Turno();

            turno.Show();

            this.Hide();
        }

        private void irEspecialidadesBtn_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad();

            especialidad.Show();

            this.Hide();    
        }
    }
}
