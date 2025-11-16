using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_ObraSocial
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.ObraSocial obraSocial)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@Nombre", obraSocial.Nombre);

            fa = acc.Escribir("crearObraSocial", parametro);

            return fa;
        }

        public int Editar(BE.ObraSocial obraSocial)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[2];
            parametro[0] = new SqlParameter("@ID", obraSocial.Id);
            parametro[1] = new SqlParameter("@Nombre", obraSocial.Nombre);

            fa = acc.Escribir("editarObraSocial", parametro);

            return fa;
        }

        public int Eliminar(BE.ObraSocial obraSocial)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@ID", obraSocial.Id);

            fa = acc.Escribir("eliminarObraSocial", parametro);

            return fa;
        }

        public List<BE.ObraSocial> Listar()
        {
            List<BE.ObraSocial> obrasSociales = new List<BE.ObraSocial>();
            DataTable tabla = acc.Leer("listarObrasSociales", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.ObraSocial obraSocial = new BE.ObraSocial();
                obraSocial.Id = int.Parse(dr["ID"].ToString());
                obraSocial.Nombre = dr["nombre"].ToString();


                obrasSociales.Add(obraSocial);

            }
            return obrasSociales;
        }
    }
}
