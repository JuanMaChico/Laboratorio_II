using System.Text;

namespace Biblioteca_de_Clases
{
	/// <summary>
	/// Clase Abstracta Comida
	/// </summary>
	public abstract class Comida
	{

		#region Atributos
		private string nombre;
		protected List<EIngredientes> ingredientes;
		#endregion

		#region Constructores
		protected Comida(string nombre) : this(nombre, new List<EIngredientes>())
		{
		}

		protected Comida(string nombre, List<EIngredientes> ingredientes)
		{
			this.nombre = nombre;
			this.ingredientes = ingredientes;
		}
		#endregion

		#region Porpiedades
		public virtual double Costos
		{
			get => this.CalcularCostos();
		}
		public virtual string Descripcion
		{
			get => this.MostrarDatos();
		}
		public string Nombre
		{
			get => nombre;
			set => this.nombre = value;
		}
		#endregion

		#region Metodos_abastractos

		/// <summary>
		/// Implementacion Obligatoria para las clases derivadas
		/// </summary>
		protected abstract string AgregarIngredientes(EIngredientes ingredientes);

		protected abstract double CalcularCostos();

		#endregion

		protected virtual string MostrarDatos()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append($"\nNombre: {this.Nombre}");
			retorno.Append($"\nCosto: {this.Costos}");
			retorno.Append($"\n-Ingredientes-\n");
			foreach( EIngredientes i in this.ingredientes )
			{
				retorno.Append($"\n-{i}");
			}
			return retorno.ToString();
		}

		#region sobrecargas

		public static bool operator ==(Comida c, EIngredientes ingrediente)
		{

			//return c.ingredientes.Exists(e => e == ingrediente);

			foreach( EIngredientes i in c.ingredientes )
			{
				if( i == ingrediente )
				{
					return true;
				}
			}
			return false;
		}

		public static bool operator !=(Comida c, EIngredientes ingrediente)
		{
			return !( c == ingrediente );
		}

		public static string operator +(Comida c, EIngredientes ingrediente)
		{
			//if( c != ingrediente )
			//{
			//	c.ingredientes.Add(ingrediente);
			//	return $"Se agrego {ingrediente}";
			//}
			//return $"No se pudo agregar {ingrediente}";
			return c.AgregarIngredientes( ingrediente );
		}

		#endregion

		#region overrides

		public override bool Equals(object? obj)
		{
			if( obj != null && obj is Comida )
			{
				Comida c = ( Comida )obj;
				return c.Nombre == this.Nombre;
			}
			return false;

			//return obj is not null && obj is Comida && ((Comida)obj).Nombre == this.Nombre;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		#endregion

		#region Enumerado
		/// <summary>
		/// Ingredientes
		/// </summary>
		public enum EIngredientes
		{
			ADHERESO,
			QUESO = 10,
			CEBOLLA = 8,
			LECHUGA = 7,
			TOMATE = 9,
			JAMON = 12,
			HUEVO = 13,
			PANCETA = 15
		}
		#endregion
	}
}
