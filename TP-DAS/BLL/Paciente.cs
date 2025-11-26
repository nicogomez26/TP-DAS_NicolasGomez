using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Paciente
    {
        Mp_Paciente mapper = new Mp_Paciente();


        public int AgregarPaciente(BE.Paciente paciente) {

            int fa = 0;

            fa = mapper.Agregar(paciente);

            return fa;

        }

        public int EditarPaciente(BE.Paciente paciente)
        {
            int fa = 0;

            fa = mapper.Editar(paciente);

            return fa;
        }

        public int EliminarPaciente(BE.Paciente paciente)
        {
            int fa = 0;

            fa = mapper.Eliminar(paciente);

            return fa;
        }

        public List<BE.Paciente> ListarPaciente()
        {
            List<BE.Paciente> pacientes = mapper.Listar();
            return pacientes;
        }

        public void ExportarTurnosXML(string ruta, int id)
        {
            DataTable dt = mapper.ExportarXML(id);

            DataSet ds = new DataSet();

            ds.Tables.Add(dt.Copy());

            ds.WriteXml(ruta);

        }
    }
}
