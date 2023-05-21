using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public class EquipoFutbol: Equipo
	{
		private bool jugadoresEstrella;

		public EquipoFutbol(string nombre): base(nombre)
		{
			this.jugadoresEstrella = false;
		}

		public EquipoFutbol(string nombre, bool jugadoresEstrella) : this(nombre)
		{
			this.jugadoresEstrella = jugadoresEstrella;
		}

		public override int GetDificultad()
		{
			return 0;
		}

		protected new string MostrarDatos()
		{
			return "";
		}

		public override string ToString()
		{
			return base.MostrarDatos();
		}

	}
}
