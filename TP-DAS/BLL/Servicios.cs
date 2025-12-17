using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ServiceProcess;
using System.Windows.Forms;

namespace BLL
{
    public class Servicios
    {
        public bool SqlServerActivo()
        {
            try
            {
                ServiceController sc = new ServiceController("MSSQLSERVER");
                return sc.Status == ServiceControllerStatus.Running;
            }
            catch
            {
                return false;
            }
        }
        public void verificarEstado(Form f)
        {
            if (!SqlServerActivo())
            {
                MessageBox.Show(
                    "El servicio de SQL Server no está iniciado.\nInícielo para continuar.",
                    "Error de servicio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                f.Close();
                return;
            }
        }
    }
}

