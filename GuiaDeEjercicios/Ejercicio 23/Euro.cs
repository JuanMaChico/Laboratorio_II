using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
	public class Euro
	{
		private double cantidad;
		private static double cotizRespectoDolar;

		/// <summary>
		/// Constructor Static
		/// </summary>
		#region Constructores
		static Euro()
		{
			cotizRespectoDolar = 0.91;
		}
		/// <summary>
		/// Constructor publico
		/// </summary>
		/// <param name="cantidad">Cantidad de Euros</param>
		public Euro(double cantidad)
		{
			this.cantidad = cantidad;
		}
		/// <summary>
		/// Constructor Publico
		/// </summary>
		/// <param name="cantidad">Cantidad de Euros</param>
		/// <param name="cotizacion">Cotizacion respecto al dolar</param>
		public Euro(double cantidad, double cotizacion) : this(cantidad)
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

		public static implicit operator Euro(double d)
		{
			return new Euro(d);
		}

		public static explicit operator Dolar(Euro e)
		{
			return new Dolar(e.cantidad / Euro.GetCotizacion());
		}

		public static explicit operator Pesos(Euro e)
		{
			return ( Pesos )( ( Dolar )e );
		}

		public static bool operator ==(Euro e1, Euro e2)
		{
			return e1.cantidad == e2.cantidad;
		}

		public static bool operator !=(Euro e1, Euro e2)
		{
			return !( e1 == e2 );
		}

		public static bool operator ==(Euro e, Dolar d)
		{
			return d == ( Dolar )e;
		}

		public static bool operator !=(Euro e, Dolar d)
		{
			return !( e == d );
		}

		public static bool operator ==(Euro e, Pesos p)
		{
			return e == ( Euro )p;
		}

		public static bool operator !=(Euro e, Pesos p)
		{
			return !( e == p );
		}

		public static Euro operator +(Euro e, Dolar d)
		{
			return new Euro(e.GetCantidad() + ( ( Euro )d ).GetCantidad());
		}

		public static Euro operator +(Euro e, Pesos p)
		{
			return new Euro(e.GetCantidad() + ( ( Euro )p ).GetCantidad());
		}

		public static Euro operator -(Euro e, Dolar d)
		{
			return new Euro(d.GetCantidad() - ( ( Euro )d ).GetCantidad());
		}

		public static Euro operator -(Euro e, Pesos p)
		{
			return new Euro(e.GetCantidad() - ( ( Euro )p ).GetCantidad());
		}

	}
}
