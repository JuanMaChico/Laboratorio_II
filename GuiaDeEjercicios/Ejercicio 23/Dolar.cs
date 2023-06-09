﻿using System.Runtime.CompilerServices;

namespace Billetes
{
	public class Dolar
	{
		private double cantidad;
		private static double cotizRespectoDolar;

		#region Constructores
		static Dolar()
		{
			cotizRespectoDolar = 1;
		}
		public Dolar(double cantidad)
		{
			this.cantidad = cantidad;
		}

		public Dolar(double cantidad, double cotizacion) : this(cantidad)
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

		public static explicit operator Euro(Dolar d)
		{
			return new Euro(d.cantidad * Euro.GetCotizacion());
		}

		public static explicit operator Pesos(Dolar d)
		{
			return new Pesos(d.cantidad * Pesos.GetCotizacion());
		}

		public static implicit operator Dolar(double d)
		{
			return new Dolar(d);
		}

		public static bool operator ==(Dolar d1, Dolar d2)
		{
			return d1.cantidad == d2.cantidad;
		}

		public static bool operator !=(Dolar d, Dolar d2)
		{
			return !( d == d2 );
		}

		public static bool operator ==(Dolar d, Euro e)
		{
			return d == ( Dolar )e;
		}

		public static bool operator !=(Dolar d, Euro e)
		{
			return !( d == e );
		}

		public static bool operator ==(Dolar d, Pesos p)
		{
			return d == ( Dolar )p;
		}

		public static bool operator !=(Dolar d, Pesos p)
		{
			return !( d == p );
		}

		public static Dolar operator +(Dolar d, Euro e)
		{
			return new Dolar(d.GetCantidad() + ( ( Dolar )e ).GetCantidad());
		}

		public static Dolar operator +(Dolar d, Pesos p)
		{
			return new Dolar(d.GetCantidad() + ( ( Dolar )p ).GetCantidad());
		}

		public static Dolar operator -(Dolar d, Euro e)
		{
			return new Dolar(d.GetCantidad() - ( ( Dolar )e ).GetCantidad());
		}

		public static Dolar operator -(Dolar d, Pesos p)
		{
			return new Dolar(d.GetCantidad() - ( ( Dolar )p ).GetCantidad());
		}
	}
}
