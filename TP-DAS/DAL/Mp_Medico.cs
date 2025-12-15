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
    public class Mp_Medico
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Medico medico)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                SqlParameter[] parametro = new SqlParameter[6];
                parametro[0] = new SqlParameter("@dni", medico.Dni);
                parametro[1] = new SqlParameter("@nombre", medico.Nombre);
                parametro[2] = new SqlParameter("@apellido", medico.Apellido);
                parametro[3] = new SqlParameter("@edad", medico.Edad);
                parametro[4] = new SqlParameter("@sexo", medico.Sexo);
                parametro[5] = new SqlParameter("@id_Especialidad", medico.Id_Especialidad);


                fa = acc.Escribir("crearMedico", parametro);

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

        public int Editar(BE.Medico medico)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                SqlParameter[] parametro = new SqlParameter[7];
                parametro[0] = new SqlParameter("@id", medico.Id);
                parametro[1] = new SqlParameter("@dni", medico.Dni);
                parametro[2] = new SqlParameter("@nombre", medico.Nombre);
                parametro[3] = new SqlParameter("@apellido", medico.Apellido);
                parametro[4] = new SqlParameter("@edad", medico.Edad);
                parametro[5] = new SqlParameter("@sexo", medico.Sexo);
                parametro[6] = new SqlParameter("@id_Especialidad", medico.Id_Especialidad);

                acc.ConfirmarTransaccion();

                fa = acc.Escribir("editarMedico", parametro);

                return fa;
            }
            catch (Exception ex)
            {
                acc.CancelarTransaccion();

                MessageBox.Show(ex.Message.ToString());

                return -1;
            }
            
        }

        public int Eliminar(BE.Medico medico)
        {
            try
            {
                int fa = 0;

                acc.IniciarTransaccion();

                SqlParameter[] parametro = new SqlParameter[1];
                parametro[0] = new SqlParameter("@ID", medico.Id);

                fa = acc.Escribir("eliminarMedico", parametro);

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

        public List<BE.Medico> Listar()
        {
            

            try
            {
                acc.IniciarTransaccion();

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
                    medico.Id_Especialidad = int.Parse(dr["ID_Especialidad"].ToString());

                    medicos.Add(medico);

                }
                acc.ConfirmarTransaccion();

                return medicos;
            }
            catch (Exception ex)
            {
                acc.CancelarTransaccion();

                MessageBox.Show(ex.Message.ToString());

                return null;
            }
        }

        public string ExportarTurnosMedicoXML(int idMedico)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@idMedico", idMedico)
            };

            return acc.LeerXML("listarTurnosXMedicoXML", parametros);
        }

        public string ExportarMedicosXML()
        {
            try
            {
                return acc.LeerXML("listarMedicosXML");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al exportar médicos en XML", ex);
            }
        }
    }
}
