using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP_DAS
{
    public partial class CUButton : CUBase
    {
        private Button btn;

        public CUButton()
        {
            InitializeComponent();
            AplicarEstiloBase();

            btn.Click += (s, e) => Click?.Invoke(this, e);
        }

        public new event EventHandler Click;

        public string Texto { get => btn.Text; set => btn.Text = value; }
        public Color ColorFondo { get => btn.BackColor; set => btn.BackColor = value; }
        public Color ColorTexto { get => btn.ForeColor; set => btn.ForeColor = value; }

        private string nombreBoton;
        public string NombreBoton
        {
            get => nombreBoton;
            set
            {
                nombreBoton = value;
                btn.Name = value;
            }
        }

    }


}
