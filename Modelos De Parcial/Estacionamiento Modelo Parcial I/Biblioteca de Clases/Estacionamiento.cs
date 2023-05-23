using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public class Estacionamiento
	{
		private int capacidadEstacionamiento;
		private static Estacionamiento? estacionamiento = null;
		private List<Vehiculo> listadoVehiculos;
		private string nombre;

		public List<Vehiculo> ListadoVehiculos
		{
			get => listadoVehiculos;
		}
		public string Nombre
		{
			get => nombre;
		}

		private Estacionamiento(string nombre, int capacidad)
		{
			this.listadoVehiculos = new List<Vehiculo>();
			this.nombre = nombre;
			this.capacidadEstacionamiento = capacidad;
		}

		public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
		{
			if( estacionamiento is null )
			{
				return new Estacionamiento(nombre, capacidad);
			}
			else
			{
				estacionamiento.capacidadEstacionamiento = capacidad;
				return estacionamiento;
			}
		}

		public static string InformarSalida(Vehiculo vehiculo)
		{
			return $"Estacionamiento: {estacionamiento?.Nombre}\n" +
				   $"Vehiculo: {vehiculo.Descripcion}\n" +
				   $"Salida: {vehiculo.HoraEgreso}\n" +
				   $"Cargos de Estacionamiento: {vehiculo.CostoEstadia}";
		}

		public static bool operator ==(Estacionamiento e, Vehiculo v)
		{
			bool retorno = false;
			e.listadoVehiculos.Find((vehiculo) => ( vehiculo == v ) ? retorno = true : retorno = false);
			return retorno;
		}
		public static bool operator !=(Estacionamiento e, Vehiculo v)
		{
			return !( e == v );
		}
		public static bool operator +(Estacionamiento e, Vehiculo v)
		{
			if( e != v && e.ListadoVehiculos.Count() < e.capacidadEstacionamiento )
			{
				e.ListadoVehiculos.Add(v);
				return true;
			}
			return false;
		}
		public static bool operator -(Estacionamiento e, Vehiculo v)
		{
			if( e == v )
			{
				v.HoraEgreso = DateTime.Now;
				e.listadoVehiculos.Remove(v);
				return true;
			}
			return false;
		}

		public override bool Equals(object? obj)
		{
			return obj is not null && obj is Estacionamiento && (Estacionamiento)obj == this;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return "Estacionamiento";
		}

	}
}
