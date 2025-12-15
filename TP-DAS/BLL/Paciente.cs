using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        public void ExportarTurnosPacienteXML(int idPaciente, string ruta)
        {
            if (idPaciente <= 0)
                throw new Exception("Paciente inválido");

            if (string.IsNullOrWhiteSpace(ruta))
                throw new Exception("Ruta inválida");

            string xml = mapper.ExportarTurnosPacienteXML(idPaciente);

            if (string.IsNullOrWhiteSpace(xml))
                throw new Exception("No se generó el XML");

            System.IO.File.WriteAllText(ruta, xml, System.Text.Encoding.UTF8);
        }

        public void ExportarPacientesXML(string ruta)
        {
            string xml = mapper.ExportarPacientesXML();

            if (string.IsNullOrWhiteSpace(xml))
                throw new Exception("No se generó el XML de pacientes");

            File.WriteAllText(ruta, xml, Encoding.UTF8);
        }

    }
}
