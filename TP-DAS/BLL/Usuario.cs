using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace BLL
{
    public class Usuario
    {
        Mp_Usuario mapper = new Mp_Usuario();

        private Dictionary<string, int> intentosLogin = new Dictionary<string, int>();
        private int MAX_INTENTOS = 5;

        public int AgregarUsuario(BE.Usuario usuario)
        {
            return mapper.Agregar(usuario);
        }

        public int EditarUsuario(BE.Usuario usuario)
        {
            return mapper.Editar(usuario);
        }

        public int EliminarUsuario(BE.Usuario usuario)
        {
            return mapper.Eliminar(usuario);
        }

        public List<BE.Usuario> ListarUsuarios()
        {
            return mapper.Listar();
        }


        public BE.Usuario Login(string email, string pass)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(pass))
            {
                return null;
            }

            string key = email;

            BE.Usuario usuario = mapper.Login(email, pass);


            if (usuario == null)
            {
                if (!intentosLogin.ContainsKey(key))
                    intentosLogin[key] = 0;

                intentosLogin[key]++;

                if (intentosLogin[key] >= MAX_INTENTOS)
                {
                    mapper.BloquearUsuario(new BE.Usuario { Email = email }, true);
                }

                return null;
            }


            if (usuario.Bloqueado)
            {
                return new BE.Usuario { Bloqueado = true };
            }

            if (intentosLogin.ContainsKey(key))
                intentosLogin[key] = 0;

            return usuario;
        }

        public int DesbloquearUsuario(BE.Usuario usuario)
        {
            return mapper.BloquearUsuario(usuario, false);
        }

        public int BloquearUsuario(BE.Usuario usuario)
        {
            return mapper.BloquearUsuario(usuario, true);
        }

        public void CambiarPassword(BE.Usuario usuario)
        {
            if (usuario == null || string.IsNullOrWhiteSpace(usuario.Pass))
                throw new ArgumentException("Contraseña inválida");

            mapper.CambiarPassword(usuario);
        }
        public void ExportarUsuariosXML(string ruta)
        {
            string xml = mapper.ExportarUsuariosXML();

            if (string.IsNullOrWhiteSpace(xml))
                throw new Exception("No se generó el XML de usuarios");

            File.WriteAllText(ruta, xml, Encoding.UTF8);
        }

    }
}
