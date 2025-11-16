using BE;
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
    public class Mp_Usuario
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Usuario usuario)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                SqlParameter[] parametro = new SqlParameter[4];
                parametro[0] = new SqlParameter("@nombre", usuario.Nombre);
                parametro[1] = new SqlParameter("@email", usuario.Email);
                parametro[2] = new SqlParameter("@pass", usuario.Pass);
                parametro[2] = new SqlParameter("@privilegio", usuario.Privilegios);

                fa = acc.Escribir("crearUsuario", parametro);

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

        public int Editar(BE.Usuario usuario)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();


                SqlParameter[] parametro = new SqlParameter[4];
                parametro[0] = new SqlParameter("@ID", usuario.Id);
                parametro[1] = new SqlParameter("@nombre", usuario.Nombre);
                parametro[2] = new SqlParameter("@email", usuario.Email);
                parametro[3] = new SqlParameter("@pass", usuario.Pass);
                parametro[4] = new SqlParameter("@privilegio", usuario.Privilegios);

                fa = acc.Escribir("editarUsuario", parametro);

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

        public int Eliminar(BE.Usuario usuario)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                SqlParameter[] parametro = new SqlParameter[1];
                parametro[0] = new SqlParameter("@ID", usuario.Id);

                fa = acc.Escribir("eliminarUsuario", parametro);

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

        public List<BE.Usuario> Listar()
        {
            List<BE.Usuario> usuarios = new List<BE.Usuario>();
            DataTable tabla = acc.Leer("listarUsuarios", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Usuario usuario = new BE.Usuario();
                usuario.Id = int.Parse(dr["ID"].ToString());
                usuario.Nombre = dr["nombre"].ToString();
                usuario.Email = dr["email"].ToString();
                usuario.Pass = (dr["pass"].ToString());
                usuario.Privilegios = int.Parse(dr["privilegios"].ToString());

                usuarios.Add(usuario);

            }
            return usuarios;
        }

        public DataTable ExportarXML()
        {
            return acc.Leer("listarUsuarios", null);

        }
    }
}
