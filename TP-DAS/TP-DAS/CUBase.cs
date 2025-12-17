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
    public partial class CUBase : UserControl
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            AplicarEstiloBase();
        }
        Color FondoGeneral = Color.FromArgb(245, 245, 245); // gris clarito
        Color TextoNormal = Color.Black;

        Color AzulBoton = Color.FromArgb(0, 120, 215);   // azul claro
        Color CelesteInput = Color.FromArgb(140, 197, 222); // celeste clarito
        Color CelesteGrid = Color.FromArgb(220, 240, 250);
        Color CelesteHeader = Color.FromArgb(200, 230, 245);

        Color Fondo = Color.FromArgb(213, 226, 232);
        protected virtual void AplicarEstiloBase()
        {
            this.BackColor = Fondo;

            AplicarEstiloControles(this);
        }

        
        private void AplicarEstiloControles(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                // LABEL
                if (c is Label lbl)
                {
                    lbl.ForeColor = TextoNormal;
                    lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }

                // TEXTBOX
                else if (c is TextBox txt)
                {
                    txt.BorderStyle = BorderStyle.None;
                    txt.BackColor = CelesteInput;
                    txt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    /*txt.Margin = new Padding(2); // espacio exterior
                    txt.Padding = new Padding(5, 3, 5, 3); // espacio interior*/

                }

                // COMBOBOX
                else if (c is ComboBox cmb)
                {
                    cmb.FlatStyle = FlatStyle.Flat;
                    cmb.BackColor = CelesteInput;
                    cmb.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    cmb.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                // DATEPICKER
                else if (c is DateTimePicker dtp)
                {
                    dtp.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    dtp.Format = DateTimePickerFormat.Short;
                }

                // BUTTON
                else if (c is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = AzulBoton;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                }

                // DATAGRIDVIEW
                else if (c is DataGridView dgv)
                {
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.BackgroundColor = CelesteGrid;
                    dgv.EnableHeadersVisualStyles = false;

                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 230, 245);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

                    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    dgv.RowHeadersVisible = false;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }

                if (c.HasChildren)
                    AplicarEstiloControles(c);
            }
        }

        protected void MarcarError(Label lbl)
        {
            lbl.ForeColor = Color.IndianRed;
        }

        protected void MarcarOk(Label lbl)
        {
            lbl.ForeColor = Color.SeaGreen;
        }

        protected void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CUBase
            // 
            this.Name = "CUBase";
            this.ResumeLayout(false);

        }
    }
}
