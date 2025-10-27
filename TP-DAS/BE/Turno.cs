using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Turno
    {

		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private DateTime fecha;

		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}


		private int id_Medico;

		public int Id_Medico
		{
			get { return id_Medico; }
			set { id_Medico = value; }
		}

		private int id_Paciente;

		public int Id_Paciente
		{
			get { return id_Paciente; }
			set { id_Paciente = value; }
		}


	}
}
