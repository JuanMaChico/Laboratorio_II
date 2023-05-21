using System.Text;

namespace Biblioteca_de_clases
{
	public abstract class Persona
	{

		private string? apellido;
		private string? nombre;
		protected int dni;

		protected Persona(int dni)
		{
			this.dni = dni;
		}

		public string Apellido
		{
			get => apellido;
			set => apellido = value;
		}
		public string Nombre
		{
			get => nombre;
			set => nombre =  value ;
		}

		public abstract string Informacion { get; }

		protected virtual string MostrarDatos()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append(dni);
			retorno.Append(apellido);
			retorno.Append(nombre);
			return retorno.ToString();
		}

		public static bool operator ==(Persona personaA, Persona personaB)
		{
			return personaA.dni == personaB.dni;
		}
		public static bool operator !=(Persona personaA, Persona personaB)
		{
			return !(personaA == personaB);
		}
		public override bool Equals(object? obj)
		{
			return obj is not null && obj is Persona && (Persona)obj == this;
		}

		public override int GetHashCode()
		{
			return this.dni.GetHashCode();
		}
	}

	public enum EMateria
	{
		Programacion,
		Laboratorio
	}


}