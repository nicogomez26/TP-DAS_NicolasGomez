using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Turno
    {
        Mp_Turno mapper = new Mp_Turno();


        public int AgregarTurno(BE.Turno turno)
        {

            int fa = 0;

            fa = mapper.Agregar(turno);

            return fa;

        }

        public int EditarTurno(BE.Turno turno)
        {
            int fa = 0;

            fa = mapper.Editar(turno);

            return fa;
        }

        public int EliminarTurno(BE.Turno turno)
        {
            int fa = 0;

            fa = mapper.Eliminar(turno);

            return fa;
        }

        public List<BE.Turno> ListarTurno()
        {
            List<BE.Turno> turnos = mapper.Listar();
            return turnos;
        }



    }
}
