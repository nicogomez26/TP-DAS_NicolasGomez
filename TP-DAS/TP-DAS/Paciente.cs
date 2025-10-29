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

        BLL.Paciente personaBll = new BLL.Paciente();
        BE.Paciente paciente= new BE.Paciente();
        private void Paciente_Load(object sender, EventArgs e)
        {
            try
            {
                cU32.cargarDatos("listarObrasSociales", "Nombre", "ID");
                cUcmb1.Items = new string[] { "Femenino", "Masculino" };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el formulario: " + ex.Message);
            }
        }

        private void agrPacBtn_Click(object sender, EventArgs e)
        {
            int fa = 0;

            paciente = new BE.Paciente();

            paciente.Dni = int.Parse(cU21.Texto);
            paciente.Nombre = cU11.Texto;
            paciente.Apellido = cU12.Texto;
            paciente.Edad = int.Parse(cU22.Texto);
            paciente.Sexo = cUcmb1.SelectedItem;
            paciente.Id_ObraSocial = cU32.ValorSeleccionado;

            fa = personaBll.AgregarPaciente(paciente);

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
             public void VerGrilla()
        {

            grilla.DataSource = null;
            grilla.DataSource = personaBll.ListarPaciente();

        }
    }
    }

