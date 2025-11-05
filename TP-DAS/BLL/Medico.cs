using DAL;
using System;
using System.Collections.Generic;
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
    }
}
