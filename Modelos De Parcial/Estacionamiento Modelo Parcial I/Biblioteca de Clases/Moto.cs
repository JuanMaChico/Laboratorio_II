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
		private double valorHora;

		public double CostoEstadia
		{
			get
			{
				return 0;
			}
		}
		public string Descripcion
		{
			get
			{
				return " ";
			}
		}
		public double ValorHora
		{
			set
			{
				this.valorHora = value;
			}
		}

		protected double CargoDeEstacionamiento()
		{
			return 0;
		}

		protected string MostrarDatos()
		{
			return " ";
		}

		private Moto()
		{

		}
		public Moto(string patente, DateTime horaIngreso, ETipo tipo)
		{

		}

		public override string ToString()
		{
			return tipo.ToString();
		}
	}

	public enum ETipo
	{
		Ciclomotor,
		Scooter,
		Sport
	}
}
