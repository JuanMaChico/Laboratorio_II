using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public class Estacionamiento
	{
		private int capacidadEstacionamiento;
		private Estacionamiento estacionamiento;
		private List <Vehiculo> listadoVehiculos;
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
			
		}

		public Estacionamiento GetEstacionamiento(string nombre, int capacidad)
		{

		}

		public string informarSalida(Vehiculo vehiculo)
		{

		}

		public static bool operator ==(Estacionamiento e, Vehiculo v)
		{
		}
		public static bool operator !=(Estacionamiento e, Vehiculo v)
		{
		}
		public static bool operator +(Estacionamiento e, Vehiculo v)
		{
		}
		public static bool operator -(Estacionamiento e, Vehiculo v)
		{
		}








	}
}
