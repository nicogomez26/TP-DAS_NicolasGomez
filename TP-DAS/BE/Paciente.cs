using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Paciente : Persona
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private int id_ObraSocial;

		public int Id_ObraSocial
		{
			get { return id_ObraSocial; }
			set { id_ObraSocial = value; }
		}


	}
}
