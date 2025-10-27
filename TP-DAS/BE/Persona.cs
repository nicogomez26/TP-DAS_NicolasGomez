using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Persona
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private int dni;

		public int Dni
		{
			get { return dni; }
			set { dni = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}


		private int edad;

		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}

		private string sexo;

		public string Sexo
		{
			get { return sexo; }
			set { sexo = value; }
		}

	}
}
