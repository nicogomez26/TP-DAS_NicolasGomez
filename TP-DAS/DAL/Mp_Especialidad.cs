using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class Mp_Especialidad
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Especialidad especialidad)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                SqlParameter[] parametro = new SqlParameter[1];
                parametro[0] = new SqlParameter("@Nombre", especialidad.Nombre);

                fa = acc.Escribir("crearEspecialidad", parametro);

                acc.ConfirmarTransaccion();

                return fa;
            }
            catch (Exception ex)
            {
                acc.CancelarTransaccion();

                MessageBox.Show(ex.Message.ToString());

                return -1;
            }
            
        }

        public int Editar(BE.Especialidad especialidad)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                SqlParameter[] parametro = new SqlParameter[2];
                parametro[0] = new SqlParameter("@ID", especialidad.Id);
                parametro[1] = new SqlParameter("@Nombre", especialidad.Nombre);

                fa = acc.Escribir("editarEspecialidad", parametro);

                acc.ConfirmarTransaccion();

                return fa;
            }
            catch (Exception ex)
            {
                acc.CancelarTransaccion();

                MessageBox.Show(ex.Message.ToString());

                return -1;
            }
            
        }

        public int Eliminar(BE.Especialidad especialidad)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                SqlParameter[] parametro = new SqlParameter[1];
                parametro[0] = new SqlParameter("@ID", especialidad.Id);

                fa = acc.Escribir("eliminarEspecialidad", parametro);

                acc.ConfirmarTransaccion();

                return fa;
            }
            catch (Exception ex)
            {
                acc.CancelarTransaccion();

                MessageBox.Show(ex.Message.ToString());

                return -1;
            }
            
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
