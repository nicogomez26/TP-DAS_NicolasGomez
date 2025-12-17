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
    public partial class Obra_Social : Form
    {
        BE.Usuario uLogueado;
        public Obra_Social(BE.Usuario usuario)
        {
            uLogueado = usuario;
            InitializeComponent();
        }


        BLL.ObraSocial ObraSocBll= new BLL.ObraSocial();
        BE.ObraSocial ObraSoc = new BE.ObraSocial();


        public void VerGrilla()
        {
            grilla.CellClick += grilla_CellClick;
            grilla.Grid.DataSource = null;
            grilla.Grid.DataSource = ObraSocBll.ListarObraSociales();

        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica(uLogueado);

            clinica.Show();
            this.Hide();
        }


        private void volverBtn_Click_1(object sender, EventArgs e)
        {
            Clinica clinica = new Clinica(uLogueado);

            clinica.Show();

            this.Hide();
        }

        private void Obra_Social_Load(object sender, EventArgs e)
        {
            VerGrilla();

            agrOSBtn.Click += agrOSBtn_Click;
            editOSBtn.Click += editOSBtn_Click;
            elimOSBtn.Click += elimOSBtn_Click;
            volverBtn.Click += volverBtn_Click;
        }

        private void agrOSBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                ObraSoc = new BE.ObraSocial();

                ObraSoc.Nombre = cU11.Texto;

                fa = ObraSocBll.AgregarObraSocial(ObraSoc);

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

        private void editOSBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                ObraSoc = new BE.ObraSocial();

                ObraSoc.Id = int.Parse(idObraSocial.Text);
                ObraSoc.Nombre = cU11.Texto;

                fa = ObraSocBll.EditarObraSocial(ObraSoc);

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

        private void elimOSBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int fa = 0;

                ObraSoc = new BE.ObraSocial();
                ObraSoc.Id = int.Parse(idObraSocial.Text);

                fa = ObraSocBll.EliminarObraSocial(ObraSoc);

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
        BE.ObraSocial tmp; 
        private void grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= grilla.Grid.Rows.Count)
                    return;

                var fila = grilla.Grid.Rows[e.RowIndex];
                if (fila == null || fila.DataBoundItem == null)
                    return;

                tmp = (BE.ObraSocial)grilla.Grid.Rows[e.RowIndex].DataBoundItem;

                idObraSocial.Text = tmp.Id.ToString();

                cU11.Texto = tmp.Nombre.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
    }
}
