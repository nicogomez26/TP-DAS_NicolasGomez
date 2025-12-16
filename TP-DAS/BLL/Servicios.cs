using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ServiceProcess;

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
    }
}

