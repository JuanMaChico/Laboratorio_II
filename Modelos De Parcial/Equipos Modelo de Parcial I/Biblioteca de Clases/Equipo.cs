using System.Text;

namespace Biblioteca_de_Clases
{
	public abstract class Equipo
	{
		//Atributos de la clase
		protected string nombre;
		protected int partidosPerdidos;
		protected int partidosGanados;
		protected int partidosJugados;
		protected int partidosEmpatados;
		protected int puntuacion;

		//Propiedades de Acceso
		public string Nombre
		{

			get => nombre;
		}
		public int Puntuacion
		{
			get
			{
				return puntuacion;
			}
			set
			{
				this.puntuacion = value;
			}
		}
		public string Tipo
		{
			get => this.GetType().ToString();
		}
		public int PE
		{

			get
			{
				return this.partidosEmpatados;
			}
			set
			{
				this.partidosEmpatados = value;
			}
		}
		public int PG
		{

			get
			{
				return this.partidosGanados;
			}
			set
			{
				this.partidosGanados = value;
			}
		}
		public int PJ
		{

			get
			{
				return this.partidosJugados;
			}
			set
			{
				this.partidosJugados = value;
			}
		}
		public int PP
		{

			get
			{
				return this.partidosPerdidos;
			}
			set
			{
				this.partidosEmpatados = value;
			}
		}

		protected Equipo(string nombre)
		{
			this.nombre = nombre;
		}

		public override bool Equals(object? obj)
		{
			return obj is not null && obj.GetType() == this.GetType();
		}
		public static bool operator ==(Equipo a, Equipo b)
		{
			return a.Equals(b);
		}
		public static bool operator !=(Equipo a, Equipo b)
		{
			return !( a.Equals(b) );
		}

		protected string MostrarDatos()
		{
			StringBuilder retorno = new StringBuilder(this.GetType().ToString());
			return retorno.ToString();
		}

		public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
		{
			//Se evalua que se pueda jugar el partido
			if( equipoA == equipoB )
			{
				//Incrementamos la cantidad de partidos jugados
				equipoA.PJ = equipoA.PJ + 1;
				equipoB.PJ = equipoB.PJ + 1;

				//Verificamos quien tiene mas dificultar por ende quien gana
				if( equipoA.GetDificultad() > equipoB.GetDificultad() )
				{
					equipoA.Puntuacion = equipoA.Puntuacion + 3;
				}
				else if( equipoA.GetDificultad() < equipoB.GetDificultad() )
				{
					equipoB.Puntuacion = equipoB.Puntuacion + 3;
				}
				else if( equipoA.GetDificultad() == equipoB.GetDificultad() )
				{
					equipoA.Puntuacion = equipoA.Puntuacion + 1;
					equipoB.Puntuacion = equipoB.Puntuacion + 1;
				}
			}
			return false;

		}
		public abstract int GetDificultad();





	}
}
