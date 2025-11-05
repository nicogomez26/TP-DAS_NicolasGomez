using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Medico : Persona
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}


		private int id_Especialidad;

		public int Id_Especialidad
		{
			get { return id_Especialidad; }
			set { id_Especialidad = value; }
		}

	}
}
