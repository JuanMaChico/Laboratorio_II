using System.Text;

namespace Biblioteca_de_Clases
{
	public class Hamburguesa : Comida
	{
		private static double costoBase;
		private bool esDoble;

		static Hamburguesa()
		{
			Hamburguesa.costoBase = 1500;
		}

		public Hamburguesa(string nombre) : base(nombre)
		{

		}

		public Hamburguesa(string nombre, bool esDoble) : this(nombre)
		{
			this.esDoble = esDoble;
		}

		protected override string AgregarIngredientes(EIngredientes ingredientes)
		{
			//StringBuilder retorno = new StringBuilder();
			//retorno.AppendLine(this + ingredientes);
			//retorno.AppendLine("a su Hamburguesa");

			//return retorno.ToString();

			if(this != ingredientes )
			{
				base.ingredientes.Add(ingredientes);
				return $"Se agrego {ingredientes} a su hamburguesa";
			}
			return $"No se pudo agregar {ingredientes} a su hamburguesa";

		}

		protected override double CalcularCostos()
		{
			double costo = costoBase;
			if( esDoble )
			{
				costo = costo + 500;
			}
			foreach( EIngredientes i in this.ingredientes )
			{
				costo = costo + ( costo * ( int )i );
			}
			return costo;
		}

		public override string ToString()
		{
			return $"Hamburguesa {(this.esDoble ? "Doble" : "Simple")}";
		}

		protected override string MostrarDatos()
		{
			//StringBuilder retorno = new StringBuilder();
			//retorno.Append(base.MostrarDatos());
			//retorno.Append(this.ToString());
			//return retorno.ToString();

			return $"{this.ToString()}\n{base.MostrarDatos()}";

		}


	}
}
