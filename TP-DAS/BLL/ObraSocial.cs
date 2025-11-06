using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ObraSocial
    {
        Mp_ObraSocial mapper = new Mp_ObraSocial();


        public int AgregarObraSocial(BE.ObraSocial obraSocial)
        {

            int fa = 0;

            fa = mapper.Agregar(obraSocial);

            return fa;

        }

        public int EditarObraSocial(BE.ObraSocial obraSocial)
        {
            int fa = 0;

            fa = mapper.Editar(obraSocial);

            return fa;
        }

        public int EliminarObraSocial(BE.ObraSocial obraSocial)
        {
            int fa = 0;

            fa = mapper.Eliminar(obraSocial);

            return fa;
        }

        public List<BE.ObraSocial> ListarObraSociales()
        {
            List<BE.ObraSocial> obraSociales = mapper.Listar();
            return obraSociales;
        }
    }
}
