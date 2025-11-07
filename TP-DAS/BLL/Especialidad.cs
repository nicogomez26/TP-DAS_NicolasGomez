using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Especialidad
    {
        Mp_Especialidad mapper = new Mp_Especialidad();


        public int AgregarEspecialidad(BE.Especialidad especialidad)
        {

            int fa = 0;

            fa = mapper.Agregar(especialidad);

            return fa;

        }

        public int EditarEspecialidad(BE.Especialidad especialidad)
        {
            int fa = 0;

            fa = mapper.Editar(especialidad);

            return fa;
        }

        public int EliminarEspecialidad(BE.Especialidad especialidad)
        {
            int fa = 0;

            fa = mapper.Eliminar(especialidad);

            return fa;
        }

        public List<BE.Especialidad> ListarEspecialidades()
        {
            List<BE.Especialidad> especialidades = mapper.Listar();
            return especialidades;
        }
    }
}
