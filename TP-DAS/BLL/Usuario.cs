using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        Mp_Usuario mapper = new Mp_Usuario();


        public int AgregarUsuario(BE.Usuario usuario)
        {

            int fa = 0;

            fa = mapper.Agregar(usuario);

            return fa;

        }

        public int EditarTurno(BE.Usuario usuario)
        {
            int fa = 0;

            fa = mapper.Editar(usuario);

            return fa;
        }

        public int EliminarTurno(BE.Usuario usuario)
        {
            int fa = 0;

            fa = mapper.Eliminar(usuario);

            return fa;
        }

        public List<BE.Usuario> ListarTurno()
        {
            List<BE.Usuario> usuarios = mapper.Listar();
            return usuarios;
        }

        public void ExportarTurnosXML(string ruta)
        {
            DataTable dt = mapper.ExportarXML();

            DataSet ds = new DataSet();

            ds.Tables.Add(dt.Copy());

            ds.WriteXml(ruta);

        }
    }
}
