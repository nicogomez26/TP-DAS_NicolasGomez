using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace DAL
{
    public class Mp_Usuario
    {
        Acceso acc = Acceso.Instancia;

        public int Agregar(BE.Usuario usuario)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                string passHash = acc.CalcularSHA256(usuario.Pass);

                SqlParameter[] parametro = new SqlParameter[4];
                parametro[0] = new SqlParameter("@nombre", usuario.Nombre);
                parametro[1] = new SqlParameter("@email", usuario.Email);
                parametro[2] = new SqlParameter("@pass", passHash);
                parametro[3] = new SqlParameter("@privilegio", usuario.Privilegios);

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
        public string CalcularSHA256(string texto)
        {
            return acc.CalcularSHA256(texto);
        }
        public List<BE.Usuario> Listar()
        {
            try
            {

                List<BE.Usuario> usuarios = new List<BE.Usuario>();

                DataTable tabla = acc.Leer("listarUsuario", null);
                foreach (DataRow dr in tabla.Rows)
                {
                    BE.Usuario usuario = new BE.Usuario();

                        usuario.Id = int.Parse(dr["ID"].ToString());
                        usuario.Nombre = dr["nombre"].ToString();
                        usuario.Email = dr["email"].ToString();
                        usuario.Privilegios = int.Parse(dr["privilegios"].ToString());
                        usuario.Bloqueado = dr["Bloqueado"] != DBNull.Value && (bool)dr["Bloqueado"];

                    usuarios.Add(usuario);
                }


                return usuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return null;
            }
        }

        /*public DataTable ExportarXML()
        {
            return acc.Leer("listarUsuarios", null);

        }*/

        public BE.Usuario Login(string email, string pass)
        {
            try
            {
                string passHash = acc.CalcularSHA256(pass);

                SqlParameter[] parametro = new SqlParameter[2];
                parametro[0] = new SqlParameter("@email", email);
                parametro[1] = new SqlParameter("@pass", passHash);

                DataTable tabla = acc.Leer("loginUsuario", parametro);

                if (tabla.Rows.Count == 1)
                {
                    DataRow dr = tabla.Rows[0];

                    BE.Usuario usuario = new BE.Usuario() {

                        Id = int.Parse(dr["ID"].ToString()),
                        Nombre = dr["nombre"].ToString(),
                        Email = dr["email"].ToString(),
                        Privilegios = int.Parse(dr["privilegios"].ToString()),
                        Bloqueado = dr["Bloqueado"] != DBNull.Value && (bool)dr["Bloqueado"]
                    };

                    return usuario;
                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public int BloquearUsuario(BE.Usuario usuario, bool bloqueado)
        {
            try
            {
                acc.IniciarTransaccion();

                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("@id", usuario.Id);
                parametros[1] = new SqlParameter("@bloqueado", bloqueado);

                int fa = acc.Escribir("bloquearUsuario", parametros);

                acc.ConfirmarTransaccion();

                return fa;
            }
            catch (Exception ex)
            {
                acc.CancelarTransaccion();
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public void CambiarPassword(BE.Usuario usuario)
        {
            try
            {
                string passHash = CalcularSHA256(usuario.Pass);

                SqlParameter[] parametros = new SqlParameter[2];
                parametros[0] = new SqlParameter("@id", usuario.Id);
                parametros[1] = new SqlParameter("@pass", passHash);

                acc.Escribir("cambiarPasswordUsuario", parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error DAL al cambiar contraseña: " + ex.Message);
                throw;
            }
        }

        public string ExportarUsuariosXML()
        {
            return acc.LeerXML("listarUsuariosXML");
        }

    }
}
