namespace Ejercicio_30
{
	public class AutoF1
	{
		//Atributos
		private string escuderia;
		private short numero;
		private short vueltasRestantes;
		private short cantidadCombustible;
		private bool enCompetencia;

		public AutoF1(string escuderia, short numero)
		{
			this.escuderia = escuderia;
			this.numero = numero;
			this.EnCompetencia = false;
			this.CantidadCombustible = 0;
			this.VueltasRestantes = 0;
		}

		public short VueltasRestantes
		{
			get => vueltasRestantes;
			set => vueltasRestantes = value;
		}
		public short CantidadCombustible
		{
			get => cantidadCombustible;
			set => cantidadCombustible = value;
		}
		public bool EnCompetencia
		{
			get => enCompetencia;
			set => enCompetencia =  value ;
		}

		public string MostarDatos()
		{
			return $"{escuderia} {cantidadCombustible} {enCompetencia}";
		}

		public static bool operator ==(AutoF1 a, AutoF1 b)
		{
			return ( a.numero == b.numero && a.numero == b.numero );
		}
		public static bool operator !=(AutoF1 a, AutoF1 b)
		{
			return !(a == b);
		}

	}
}