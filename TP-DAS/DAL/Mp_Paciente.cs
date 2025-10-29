﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Mp_Paciente
    {
        Acceso acc = new Acceso();

        public int Agregar(BE.Paciente paciente)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[7];
            parametro[0] = new SqlParameter("@id", DBNull.Value);
            parametro[1] = new SqlParameter("@dni", paciente.Dni);
            parametro[2] = new SqlParameter("@nombre", paciente.Nombre);
            parametro[3] = new SqlParameter("@apellido", paciente.Apellido);
            parametro[4] = new SqlParameter("@edad", paciente.Edad);
            parametro[5] = new SqlParameter("@sexo", paciente.Sexo);
            parametro[6] = new SqlParameter("@id_ObraSocial", paciente.Id_ObraSocial);

            fa = acc.Escribir("crearPaciente", parametro);

            return fa;
        }

        public int Editar(BE.Paciente paciente)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[6];
            parametro[1] = new SqlParameter("@dni", paciente.Dni);
            parametro[2] = new SqlParameter("@nombre", paciente.Nombre);
            parametro[3] = new SqlParameter("@apellido", paciente.Apellido);
            parametro[4] = new SqlParameter("@edad", paciente.Edad);
            parametro[5] = new SqlParameter("@sexo", paciente.Sexo);
            parametro[6] = new SqlParameter("@id_ObraSocial", paciente.Id_ObraSocial);

            fa = acc.Escribir("editarPaciente", parametro);

            return fa;
        }

        public int Eliminar(BE.Paciente paciente)
        {
            int fa = 0;

            SqlParameter[] parametro = new SqlParameter[0];
            parametro[0] = new SqlParameter("@ID", paciente.Id);

            fa = acc.Escribir("eliminarPaciente", parametro);

            return fa;
        }

        public List<BE.Paciente> Listar()
        {
            List<BE.Paciente> pacientes = new List<BE.Paciente>();
            DataTable tabla = acc.Leer("listarPacientes", null);
            foreach (DataRow dr in tabla.Rows)
            {
                BE.Paciente paciente = new BE.Paciente();
                paciente.Id = int.Parse(dr["ID"].ToString());
                paciente.Dni = int.Parse(dr["dni"].ToString());
                paciente.Nombre = dr["nombre"].ToString();
                paciente.Apellido = dr["apellido"].ToString();
                paciente.Edad = int.Parse(dr["edad"].ToString());
                paciente.Sexo = dr["sexo"].ToString();
                paciente.Id_ObraSocial = int.Parse(dr["ID_ObraSocial"].ToString());

                pacientes.Add(paciente);

            }
            return pacientes;
        }
    }
}
