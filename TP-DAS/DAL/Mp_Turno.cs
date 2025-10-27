using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_Turno
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Turno turno)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[3];
            parametro[1] = new SqlParameter("@fecha", turno.Fecha);
            parametro[2] = new SqlParameter("@ID_Medico", turno.Id_Medico);
            parametro[3] = new SqlParameter("@ID_Paciente", turno.Id_Paciente);

            fa = acc.Escribir("crearTurno", parametro);

            return fa;
        }

        public int Editar(BE.Turno turno)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[3];
            parametro[1] = new SqlParameter("@fecha", turno.Fecha);
            parametro[2] = new SqlParameter("@ID_Medico", turno.Id_Medico);
            parametro[3] = new SqlParameter("@ID_Paciente", turno.Id_Paciente);

            fa = acc.Escribir("editarTurno", parametro);

            return fa;
        }

        public int Eliminar(BE.Turno turno)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[0];
            parametro[0] = new SqlParameter("@ID", turno.Id);

            fa = acc.Escribir("eliminarTurno", parametro);

            return fa;
        }

        public List<BE.Turno> Listar()
        {
            List<BE.Turno> turnos = new List<BE.Turno>();
            DataTable tabla = acc.Leer("listarTurnos", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Turno turno = new BE.Turno();
                turno.Id = int.Parse(dr["ID"].ToString());
                turno.Fecha = DateTime.Parse(dr["fecha"].ToString());
                turno.Id_Medico = int.Parse(dr["ID_Medico"].ToString());
                turno.Id_Paciente = int.Parse(dr["ID_Paciente"].ToString());

                turnos.Add(turno);

            }
            return turnos;
        }
    }
}
