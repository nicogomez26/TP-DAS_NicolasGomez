using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_Medico
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Medico medico)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[6];
            parametro[0] = new SqlParameter("@dni", medico.Dni);
            parametro[1] = new SqlParameter("@nombre", medico.Nombre);
            parametro[2] = new SqlParameter("@apellido", medico.Apellido);
            parametro[3] = new SqlParameter("@edad", medico.Edad);
            parametro[4] = new SqlParameter("@sexo", medico.Sexo);
            parametro[5] = new SqlParameter("@id_Especialidad", medico.Id_Especialidad);


            fa = acc.Escribir("crearMedico", parametro);

            return fa;
        }

        public int Editar(BE.Medico medico)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[6];
            parametro[0] = new SqlParameter("@dni", medico.Dni);
            parametro[1] = new SqlParameter("@nombre", medico.Nombre);
            parametro[2] = new SqlParameter("@apellido", medico.Apellido);
            parametro[3] = new SqlParameter("@edad", medico.Edad);
            parametro[4] = new SqlParameter("@sexo", medico.Sexo);
            parametro[5] = new SqlParameter("@id_Especialidad", medico.Id_Especialidad);



            fa = acc.Escribir("editarMedico", parametro);

            return fa;
        }

        public int Eliminar(BE.Medico medico)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[0];
            parametro[0] = new SqlParameter("@ID", medico.Id);

            fa = acc.Escribir("eliminarMedico", parametro);

            return fa;
        }

        public List<BE.Medico> Listar()
        {
            List<BE.Medico> medicos = new List<BE.Medico>();
            DataTable tabla = acc.Leer("listarMedicos", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Medico medico = new BE.Medico();
                medico.Id = int.Parse(dr["ID"].ToString());
                medico.Dni = int.Parse(dr["dni"].ToString());
                medico.Nombre = dr["nombre"].ToString();
                medico.Apellido = dr["apellido"].ToString();
                medico.Edad = int.Parse(dr["edad"].ToString());
                medico.Sexo = dr["sexo"].ToString();
                medico.Id_Especialidad= int.Parse(dr["ID_Especialidad"].ToString());

                medicos.Add(medico);

            }
            return medicos;
        }



    }
}
