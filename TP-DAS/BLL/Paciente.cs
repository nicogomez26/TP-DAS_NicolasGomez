using DAL;
using System;
using System.Collections.Generic;
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

        public int EliminarPersona(BE.Paciente paciente)
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
    }
}
