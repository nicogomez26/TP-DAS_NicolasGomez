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
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
        }

        BLL.Medico medicoBll = new BLL.Medico();
        BE.Medico medico = new BE.Medico();

        private void Medico_Load(object sender, EventArgs e)
        {
            try
            {
                cU32.cargarDatos("listarEspecialidades", "Nombre", "ID");
                cUcmb1.Items = new string[] { "Femenino", "Masculino" };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el formulario: " + ex.Message);
            }
        }


        public void VerGrilla()
        {

            grilla.DataSource = null;
            grilla.DataSource = medicoBll.ListarMedico();

        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica();

            clinica.Show();
            this.Hide();
        }

        private void agrMedBtn_Click(object sender, EventArgs e)
        {

            try
            {
                int fa = 0;

                medico = new BE.Medico();

                medico.Dni = int.Parse(cU21.Texto);
                medico.Nombre = cU11.Texto;
                medico.Apellido = cU12.Texto;
                medico.Edad = int.Parse(cU22.Texto);
                medico.Sexo = cUcmb1.SelectedItem;
                medico.Id_Especialidad = cU32.ValorSeleccionado;

                fa = medicoBll.AgregarMedico(medico);

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

        private void volverBtn_Click_1(object sender, EventArgs e)
        {
            Medico medico = new Medico();

            medico.Show();

            this.Hide();
        }
    }
}
