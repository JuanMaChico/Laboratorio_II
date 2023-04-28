using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	internal class Automovil : Vehiculo
	{
		private string marca;
		private static double valorHora;

		public double CostoEstadia
		{
			get => CostoEstadia;
		}
		public double Descripcion
		{
			get => Descripcion;
		}
		public double ValorHora
		{
			set => valorHora = value;
		}

		static Automovil()
		{
			valorHora = 120;
		}
		public Automovil(string patente, DateTime horaIngreso, string marca) : base(horaIngreso, patente) 
		{
			this.marca = marca;
		}

		protected double CargoDeEstacionamiento()
		{
			return 0;
		}

		protected string MostrarDatos()
		{
			return "";
		}

		public override string ToString()
		{
			return "";
		}




	}
}
