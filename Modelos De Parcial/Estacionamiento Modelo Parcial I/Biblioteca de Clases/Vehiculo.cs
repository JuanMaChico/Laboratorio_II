namespace Biblioteca_de_Clases
{
	public abstract class Vehiculo
	{
		private DateTime horaEgreso;
		private DateTime horaIngreso;
		private string patente;

		protected Vehiculo(string patente, DateTime horaIngreso)
		{
			this.horaIngreso = horaIngreso;
			Patente = patente;
		}

		//Propiedades abstractas de solo lectura.
		public abstract double CostoEstadia
		{
			get;
		}
		public abstract string Descripcion
		{
			get;
		}

		public DateTime HoraEgreso
		{
			get
			{
				return horaEgreso;
			}
			set
			{
				if( value > HoraIngreso )
				{
					horaEgreso = value;
				}
			}
		}

		public DateTime HoraIngreso
		{
			get => horaIngreso;
			set => horaIngreso = value;
		}

		public string Patente
		{
			get
			{
				return patente;
			}
			set
			{
				if( ValidarPatente(value) )
				{
					this.patente = value;
				}
			}
		}

		protected double CargoDeEstacionamiento()
		{
			TimeSpan diferencia = this.HoraEgreso - this.HoraIngreso;
			return diferencia.TotalHours;
		}

		protected string MostrarDatos()
		{
			return $"Patente:{this.Patente} - Hora de Ingreso: {this.HoraIngreso}";
		}

		private bool ValidarPatente(string patente)
		{
			if( patente.Length > 6 && patente.Length <= 7 )
			{
				return true;
			}
			return false;
		}

		public static bool operator ==(Vehiculo v1, Vehiculo v2)
		{
			return v1.patente == v2.patente;
		}
		public static bool operator !=(Vehiculo v1, Vehiculo v2)
		{
			return !( v1 == v2 );
		}

		public override bool Equals(object? obj)
		{
			return obj is not null && ( ( Vehiculo )obj ).Patente == this.Patente;
		}
		public enum EVehiculos
		{
			Automovil,
			Moto
		}

	}



}