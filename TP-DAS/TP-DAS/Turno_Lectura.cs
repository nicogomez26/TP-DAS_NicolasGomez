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
    public partial class Turno_Lectura : Form
    {
        BE.Usuario uLogueado;
        BLL.Turno turnoBll = new BLL.Turno();
        public Turno_Lectura(BE.Usuario uLogueado)
        {
            InitializeComponent();
            this.uLogueado = uLogueado;
        }

        private void Turno_Lectura_Load(object sender, EventArgs e)
        {
            VerGrilla();
            expXMLBtn.Click += expXMLBtn_Click;
            volverBtn.Click += volverBtn_Click;

        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica(uLogueado);

            clinica.Show();

            this.Hide();
        }

        public void VerGrilla()
        {

            grilla.Grid.DataSource = null;
            grilla.Grid.DataSource = turnoBll.ListarTurno();

        }

        private void expXMLBtn_Click(object sender, EventArgs e)
        {

            SaveFileDialog SFD = new SaveFileDialog();

            SFD.Filter = "(*.xml)|*.xml";

            SFD.FileName = "Turnos.xml";


            try
            {
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    turnoBll.ExportarTurnosXML(SFD.FileName);
                    MessageBox.Show("XML exportado correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
