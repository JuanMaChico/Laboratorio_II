using System.Runtime.CompilerServices;

namespace Ejercicio_30
{
	public class Competencia
	{
		private short cantidadCompetidores;
		private short cantidadVueltas;
		private List<AutoF1> competidores;



		private Competencia()
		{
			this.competidores = new List<AutoF1>();
		}

		public Competencia(short cantidadCompetidores, short cantidadVueltas): this()
		{
			this.cantidadCompetidores = cantidadCompetidores;
			this.cantidadVueltas = cantidadVueltas;
		}

		public string MostrarDatos()
		{
			return "";
		}
		/// <summary>
		/// Si el competidor existe en la lista
		/// </summary>
		/// <param name="c">Competencia</param>
		/// <param name="b">Auto</param>
		/// <returns>True si el auto se encuentra en la competencia</returns>
		public static bool operator ==(Competencia c, AutoF1 b)
		{
			bool retorno = false;
			c.competidores.Find((a) => ( a == b ) ? retorno = true : retorno = false);
			return retorno;
		}
		public static bool operator !=(Competencia c, AutoF1 b)
		{
			return !(c == b);
		}

		public static bool operator +(Competencia c, AutoF1 b)
		{
			if(c.competidores.Count() < c.cantidadCompetidores )
			{
				c.competidores.Add(b);
				b.EnCompetencia = true;
				b.VueltasRestantes = c.cantidadVueltas;
				int random = new Random().Next(15, 100);
				b.CantidadCombustible = ( short )random;
				return true;
			}
			return false;
		}
		public static bool operator -(Competencia c, AutoF1 b)
		{
			if(c == b )
			{
				c.competidores.Remove(b);
				return true;
			}
			return false;
		}



	}
}