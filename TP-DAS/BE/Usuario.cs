using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private string pass;

		public string Pass
		{
			get { return pass; }
			set { pass = value; }
		}

		private int privilegios;

		public int Privilegios
		{
			get { return privilegios; }
			set { privilegios = value; }
		}
		
	}
}
