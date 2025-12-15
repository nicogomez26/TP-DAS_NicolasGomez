using BE;
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
    public class Medico
    {
        Mp_Medico  mapper = new Mp_Medico();


        public int AgregarMedico(BE.Medico medico)
        {

            int fa = 0;

            fa = mapper.Agregar(medico);

            return fa;

        }

        public int EditarMedico(BE.Medico medico)
        {
            int fa = 0;

            fa = mapper.Editar(medico);

            return fa;
        }

        public int EliminarMedico(BE.Medico medico)
        {
            int fa = 0;

            fa = mapper.Eliminar(medico);

            return fa;
        }

        public List<BE.Medico> ListarMedico()
        {
            List<BE.Medico> medicos = mapper.Listar();
            return medicos;
        }

        public void ExportarTurnosXML(string ruta, int id)
        {
            if (id <= 0)
                throw new Exception("Médico inválido");

            string xml = mapper.ExportarTurnosMedicoXML(id);

            if (string.IsNullOrWhiteSpace(xml))
                throw new Exception("El médico no posee turnos");

            File.WriteAllText(ruta, xml, Encoding.UTF8);

        }

        public void ExportarMedicosXML(string ruta)
        {
            string xml = mapper.ExportarMedicosXML();

            if (string.IsNullOrWhiteSpace(xml))
                throw new Exception("No se generó el XML de médicos");

            File.WriteAllText(ruta, xml, Encoding.UTF8);
        }
    }
}
