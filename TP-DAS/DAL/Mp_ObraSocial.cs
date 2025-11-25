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
    public class Mp_ObraSocial
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.ObraSocial obraSocial)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                SqlParameter[] parametro = new SqlParameter[1];
                parametro[0] = new SqlParameter("@Nombre", obraSocial.Nombre);

                fa = acc.Escribir("crearObraSocial", parametro);

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

        public int Editar(BE.ObraSocial obraSocial)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                SqlParameter[] parametro = new SqlParameter[2];
                parametro[0] = new SqlParameter("@ID", obraSocial.Id);
                parametro[1] = new SqlParameter("@Nombre", obraSocial.Nombre);

                fa = acc.Escribir("editarObraSocial", parametro);

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

        public int Eliminar(BE.ObraSocial obraSocial)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                SqlParameter[] parametro = new SqlParameter[1];
                parametro[0] = new SqlParameter("@ID", obraSocial.Id);

                fa = acc.Escribir("eliminarObraSocial", parametro);

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

        public List<BE.ObraSocial> Listar()
        {
            


            try
            {
                acc.IniciarTransaccion();

                List<BE.ObraSocial> obrasSociales = new List<BE.ObraSocial>();
                DataTable tabla = acc.Leer("listarObrasSociales", null);
                foreach (DataRow dr in tabla.Rows)
                {
                    BE.ObraSocial obraSocial = new BE.ObraSocial();
                    obraSocial.Id = int.Parse(dr["ID"].ToString());
                    obraSocial.Nombre = dr["nombre"].ToString();


                    obrasSociales.Add(obraSocial);

                }
                acc.ConfirmarTransaccion();

                return obrasSociales;
            }
            catch (Exception ex)
            {
                acc.CancelarTransaccion();

                MessageBox.Show(ex.Message.ToString());

                return null;
            }
        }
    }
}
