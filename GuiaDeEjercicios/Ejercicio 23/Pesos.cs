namespace Billetes
{
	public class Pesos
	{

		private double cantidad;
		private static double cotizRespectoDolar;

		#region Constructores
		static Pesos()
		{
			cotizRespectoDolar = 216.37;
		}
		public Pesos(double cantidad)
		{
			this.cantidad = cantidad;
		}

		public Pesos(double cantidad, double cotizacion) : this(cantidad)
		{
			cotizRespectoDolar = cotizacion;
		}
		#endregion

		/// <summary>
		/// Retorna la cantidad de la instancia
		/// </summary>
		/// <returns>double</returns>
		public double GetCantidad()
		{
			return this.cantidad;
		}
		/// <summary>
		/// Retorna la cotizacion respecto al dolar
		/// </summary>
		/// <returns>double</returns>
		public static double GetCotizacion()
		{
			return cotizRespectoDolar;
		}

		public static void SetCotizacion(double e)
		{
			cotizRespectoDolar = e;
		}

		public static explicit operator Dolar(Pesos d)
		{
			return new Dolar(d.cantidad / Pesos.GetCotizacion());
		}

		public static explicit operator Euro(Pesos d)
		{
			return ( Euro )( ( Dolar )d );
		}

		public static implicit operator Pesos(double d)
		{
			return new Pesos(d);
		}

		public static bool operator ==(Pesos p1, Pesos p2)
		{
			return p1.cantidad == p2.cantidad;
		}

		public static bool operator !=(Pesos p1, Pesos p2)
		{
			return !( p1 == p2 );
		}

		public static bool operator ==(Pesos p, Dolar d)
		{
			return d == ( Dolar )p;
		}

		public static bool operator !=(Pesos p, Dolar d)
		{
			return !( p == d );
		}

		public static bool operator ==(Pesos p, Euro e)
		{
			return p == ( Pesos )e;
		}

		public static bool operator !=(Pesos p, Euro e)
		{
			return !( p == e );
		}

		public static Pesos operator +(Pesos p, Dolar d)
		{
			return new Pesos(p.GetCantidad() + ( ( Pesos )d ).GetCantidad());
		}

		public static Pesos operator +(Pesos p, Euro e)
		{
			return new Pesos(p.GetCantidad() + ( ( Pesos )e ).GetCantidad());
		}

		public static Pesos operator -(Pesos p, Dolar d)
		{
			return new Pesos(p.GetCantidad() - ( ( Pesos )d ).GetCantidad());
		}

		public static Pesos operator -(Pesos p, Euro e)
		{
			return new Pesos(p.GetCantidad() - ( ( Pesos )e ).GetCantidad());
		}


	}
}
