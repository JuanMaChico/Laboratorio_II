namespace Entidades
{
	public class Personas
	{
		private string nombre;
		private string apellido;

		public string Nombre
		{
			get => nombre;
			set => nombre = value;
		}
		public string Apellido
		{
			get => apellido;
			set => apellido = value;
		}

		public Personas(string nombre, string apellido)
		{
			this.Nombre = nombre;
			this.Apellido = apellido;
		}
	}
}