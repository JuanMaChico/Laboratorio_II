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
		protected Comida(string nombre)
		{
			this.nombre = nombre;
		}

		protected Comida(string nombre, List<EIngredientes> ingredientes) : this (nombre)
		{
			this.ingredientes = ingredientes;

		}
		#endregion

		#region Porpiedades
		public double Costos
		{ 
			get => this.CalcularCostos(); 
		}		
		public string Descripcion
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
			retorno.Append($"Nombre: {this.Nombre}");
			retorno.Append($"Costo: {this.Costos}");
			retorno.Append($" - Ingredientes - ");
            foreach (EIngredientes i in this.ingredientes)
            {
				retorno.Append(i);
            }
            return retorno.ToString();
		}

		#region sobrecargas

		public static bool operator ==(Comida c, EIngredientes ingrediente)
		{
            foreach (EIngredientes i in c.ingredientes)
            {
                if (i == ingrediente)
                {
					return true;
                }
            }
            return false;
		}

		public static bool operator !=(Comida c, EIngredientes ingrediente)
		{
			return !(c == ingrediente);
		}

		public static string operator +(Comida c, EIngredientes ingrediente)
		{
			if(c != ingrediente )
			{
				c.ingredientes.Add( ingrediente );
				return $"Se agrego {ingrediente} a su hamburguesa";
			}
			return $"No se pudo agregar {ingrediente} a su hamburguesa";
		}

		#endregion

		#region overrides

		public override bool Equals(object? obj)
		{
			if(obj != null && obj is Comida)
			{
				Comida c = (Comida)obj;
				return c.Nombre == this.Nombre;
			}
			return false;
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