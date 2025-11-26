using BE;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP_DAS
{
    public partial class Clinica : Form
    {
        BE.Usuario uLogueado;
        public Clinica(BE.Usuario usuarioLogueado)
        {
            InitializeComponent();
            this.uLogueado = usuarioLogueado;
        }

        private void Clinica_Load(object sender, EventArgs e)
        {
            logueadoTxt.Text = uLogueado.Nombre;

        }

        private void irPacientesBtn_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente(uLogueado);

            paciente.Show();
            
            this.Hide();
        }

        private void irMedicosBtn_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico(uLogueado);

            medico.Show();

            this.Hide();
        }

        private void irObSocBtn_Click(object sender, EventArgs e)
        {
            Obra_Social OS = new Obra_Social(uLogueado);

            OS.Show();

            this.Hide();
        }

        private void irTurnosBtn_Click(object sender, EventArgs e)
        {
            Turno turno = new Turno(uLogueado);

            turno.Show();

            this.Hide();
        }

        private void irEspecialidadesBtn_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad(uLogueado);

            especialidad.Show();

            this.Hide();    
        }

        private void irUsuariosBtn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(uLogueado);

            usuario.Show();

            this.Hide();
        }
    }
}
