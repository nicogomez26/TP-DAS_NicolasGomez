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
    public class Acceso
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


        public void Conectar()
        {
            cn.ConnectionString = @"Data Source=.;Initial Catalog=Clinica;Integrated Security=True";
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
            cn.Dispose();
        }
        SqlTransaction tr;
        public void IniciarTransaccion()
        {
            Conectar();
            tr = cn.BeginTransaction();
        }

        public void ConfirmarTransaccion()
        {
            tr.Commit();
            Desconectar();
        }


        public void CancelarTransaccion()
        {
            tr.Rollback();
            Desconectar();
        }

        public int Escribir(string sp, SqlParameter[] parametro) { 
        
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
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;

            if (parametro != null) {
                cmd.ExecuteReader();
            }
            
            adaptador.SelectCommand = cmd;
            adaptador.Fill(dt);

            Desconectar();

            return dt;

        }




    }
}
