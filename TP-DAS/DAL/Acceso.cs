using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class Acceso
    {

        private static Acceso instancia;

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlTransaction tr;

        private Acceso()
        {
            cn.ConnectionString = @"Data Source=.;Initial Catalog=Clinica;Integrated Security=True";
        }

        public static Acceso Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new Acceso();

                return instancia;
            }
        }
        public void Conectar()
        {
            if (cn.State != ConnectionState.Open)
            {
                cn.Open();
            }
        }

        public void Desconectar()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
                cn.Dispose();
            }
        }
        public void IniciarTransaccion()
        {
            Conectar();
            tr = cn.BeginTransaction();
        }

        public void ConfirmarTransaccion()
        {
            tr?.Commit();
            tr = null;
            Desconectar();
        }


        public void CancelarTransaccion()
        {
            tr?.Rollback();
            tr = null;
            Desconectar();
        }

        public int Escribir(string sp, SqlParameter[] parametro)
        {

            int fa = 0;

            cmd.Connection = cn;
            cmd.Transaction = tr;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;

            if (parametro != null)
            {
                cmd.Parameters.AddRange(parametro);
                fa = cmd.ExecuteNonQuery();
            }
            else
            {
                fa = cmd.ExecuteNonQuery();
            }
            cmd.Parameters.Clear();

            return fa;
        }

        public DataTable Leer(string sp, SqlParameter[] parametro)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter adaptador = new SqlDataAdapter();

                Conectar();

            cmd.Connection = cn;
            if (tr != null)
                cmd.Transaction = tr;
            
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;

            if (parametro != null)
            {
                cmd.Parameters.AddRange(parametro);
            }

            adaptador.SelectCommand = cmd;
            adaptador.Fill(dt);

            if (tr == null)
                Desconectar();
            return dt;

        }

        public string CalcularSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }

        public string LeerXML(string sp)
        {
            if (cn.State != ConnectionState.Open)
                Conectar();

            cmd.Connection = cn;
            cmd.Transaction = tr;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;

            object result = cmd.ExecuteScalar();

            if (tr == null)
                Desconectar();

            return result != null ? result.ToString() : string.Empty;
        }


        public string LeerXML(string sp, SqlParameter[] parametros)
        {
            if (cn.State != ConnectionState.Open)
                Conectar();

            cmd.Connection = cn;
            cmd.Transaction = tr;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;

            if (parametros != null)
                cmd.Parameters.AddRange(parametros);

            object result = cmd.ExecuteScalar();

            cmd.Parameters.Clear();

            if (tr == null)
                Desconectar();

            return result != null ? result.ToString() : string.Empty;
        }

    }
}
