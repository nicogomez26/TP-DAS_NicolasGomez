using System;
using System.Windows.Forms;
using TP_DAS;

namespace GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 👇 Abrí el formulario principal
            try
            {
                Application.Run(new Login());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar la aplicación: " + ex.Message);
            }

        }
    }
}
