using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_Especialidad
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Especialidad especialidad)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@Nombre", especialidad.Nombre);

            fa = acc.Escribir("crearEspecialidad", parametro);   

            return fa;
        }

        public int Editar(BE.Especialidad especialidad)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[1];
            parametro[1] = new SqlParameter("@Nombre", especialidad.Nombre);

            fa = acc.Escribir("editarEspecialidad", parametro);

            return fa;
        }

        public int Eliminar(BE.Especialidad especialidad)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[0];
            parametro[0] = new SqlParameter("@ID", especialidad.Id);

            fa = acc.Escribir("eliminarEspecialidad", parametro);

            return fa;
        }

        public List<BE.Especialidad> Listar()
        {
            List<BE.Especialidad> especialidades = new List<BE.Especialidad>();
            DataTable tabla = acc.Leer("listarEspecialidades", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Especialidad especialidad = new BE.Especialidad();
                especialidad.Id = int.Parse(dr["ID"].ToString());
                especialidad.Nombre = dr["Nombre"].ToString();

                especialidades.Add(especialidad);

            }
            return especialidades;
        }

    }
}
