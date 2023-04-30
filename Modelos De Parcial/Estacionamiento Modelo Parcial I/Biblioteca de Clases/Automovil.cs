using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public class Automovil : Vehiculo
	{
		private string marca;
		private static double valorHora;


		public override string Descripcion
		{
			get => this.marca;
		}
		public static double ValorHora
		{
			set 
			{
				if(value > 0 )
				{
					valorHora = value;
				}
			}
		}
		public override double CostoEstadia
		{
			get => this.CargoDeEstacionamiento();
		}

		static Automovil()
		{
			valorHora = 120;
		}
		public Automovil(string patente, DateTime horaIngreso, string marca) : base(patente, horaIngreso) 
		{
			this.marca = marca;
		}

		protected new double CargoDeEstacionamiento()
		{
			return base.CargoDeEstacionamiento() * valorHora;
		}

		protected new string MostrarDatos()
		{
			return $"****AUTOMOVIL***** - {Patente}";
		}

		public override string ToString()
		{
			return MostrarDatos();
		}




	}
}
