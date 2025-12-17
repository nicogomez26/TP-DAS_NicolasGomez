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

            irPacientesBtn.Click += irPacientesBtn_Click;
            irMedicosBtn.Click += irMedicosBtn_Click;
            irTurnosBtn.Click += irTurnosBtn_Click;
            irEspecialidadesBtn.Click += irEspecialidadesBtn_Click;
            irObSocBtn.Click += irObSocBtn_Click;
            irUsuariosBtn.Click += irUsuariosBtn_Click;
            cerrarSesionBtn.Click += cerrarSesionBtn_Click;
        }

        private void irPacientesBtn_Click(object sender, EventArgs e)
        {
            if (uLogueado.Privilegios == 1)
            {
                Paciente paciente = new Paciente(uLogueado);

                paciente.Show();

                this.Hide();
            }

            else
            {
                Paciente_Lectura pacienteLectura = new Paciente_Lectura(uLogueado);

                pacienteLectura.Show();

                this.Hide();
            }

        }
        private void cerrarSesionBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Close();


        }
        private void irMedicosBtn_Click(object sender, EventArgs e)
        {
            if (uLogueado.Privilegios == 1)
            {
                Medico medico = new Medico(uLogueado);

                medico.Show();

                this.Hide();
            }

            else
            {
                Medico_Lectura medicoLectura = new Medico_Lectura(uLogueado);

                medicoLectura.Show();

                this.Hide();
            }
        }

        private void irObSocBtn_Click(object sender, EventArgs e)
        {
            if (uLogueado.Privilegios == 1)
            {
                Obra_Social obraSocial = new Obra_Social(uLogueado);

                obraSocial.Show();

                this.Hide();
            }

            else
            {
                ObraSocial_Lectura obraSocialLectura = new ObraSocial_Lectura(uLogueado);

                obraSocialLectura.Show();

                this.Hide();
            }
        }

        private void irTurnosBtn_Click(object sender, EventArgs e)
        {
            if (uLogueado.Privilegios == 1)
            {
                Turno turno = new Turno(uLogueado);

                turno.Show();

                this.Hide();
            }

            else
            {
                Turno_Lectura turnoLectura = new Turno_Lectura(uLogueado);

                turnoLectura.Show();

                this.Hide();
            }
        }

        private void irEspecialidadesBtn_Click(object sender, EventArgs e)
        {
            if (uLogueado.Privilegios == 1)
            {
                Especialidad especialidad = new Especialidad(uLogueado);

                especialidad.Show();

                this.Hide();
            }

            else
            {
                Especialidad_Lectura especialidadLectura = new Especialidad_Lectura(uLogueado);

                especialidadLectura.Show();

                this.Hide();
            }
        }

        private void irUsuariosBtn_Click(object sender, EventArgs e)
        {
            if (uLogueado.Privilegios == 1)
            {
                Usuario usuario = new Usuario(uLogueado);

                usuario.Show();

                this.Hide();
            }

            else
            {
                Usuario_Lectura usuarioLectura = new Usuario_Lectura(uLogueado);

                usuarioLectura.Show();

                this.Hide();
                /*Usuario usuario = new Usuario(uLogueado);

                usuario.Show();

                this.Hide();*/
            }
        }
    }
}
