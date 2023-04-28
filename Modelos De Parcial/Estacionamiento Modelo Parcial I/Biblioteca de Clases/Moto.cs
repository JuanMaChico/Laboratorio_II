using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_de_Clases;

namespace Biblioteca_de_Clases
{
	public class Moto : Vehiculo
	{
		private ETipo tipo;
		private static double valorHora;

		public override double CostoEstadia
		{
			get => this.CargoDeEstacionamiento();
		}
		public override string Descripcion
		{
			get
			{
				return this.tipo.ToString();
			}
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

		protected new double CargoDeEstacionamiento()
		{
			return base.CargoDeEstacionamiento() * valorHora;
		}

		protected string MostrarDatos()
		{
			return $"****MOTO*****\n-{Patente}";
		}

		static Moto()
		{
			ValorHora = 100;
		}
		public Moto(string patente, DateTime horaIngreso, ETipo tipo) : base(patente, horaIngreso)
		{

		}

		public override string ToString()
		{
			return MostrarDatos();
		}
		public enum ETipo
		{
			Ciclomotor,
			Scooter,
			Sport
		}
	}

}
