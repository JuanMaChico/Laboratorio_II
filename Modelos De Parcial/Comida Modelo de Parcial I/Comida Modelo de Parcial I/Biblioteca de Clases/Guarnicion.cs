using System.Text;

namespace Biblioteca_de_Clases
{
	public class Guarnicion : Comida
	{

		private ETipo tipo;

		public Guarnicion() : this(ETipo.PAPAS_FRITAS)
		{
		}

		public Guarnicion(ETipo t) : base(t.ToString())
		{
			this.tipo = t;
		}

		protected override string AgregarIngredientes(EIngredientes ingredientes)
		{
			if((Comida)this != ingredientes && this == ingredientes )
			{
				base.ingredientes.Add(ingredientes);
				return $"se agrego {ingredientes} a su guarnicion";
			}
			return $"no se pudo agregar {ingredientes} a su guarnicion";

		}

		protected override double CalcularCostos()
		{
			double costo = ( int )this.tipo;
			base.ingredientes.ForEach(ingredientes => costo += ( costo * ( int )ingredientes / 100 ));
			return costo;
		}

		protected override string MostrarDatos()
		{
			//StringBuilder retorno = new StringBuilder();
			//retorno.Append(base.MostrarDatos());
			//retorno.Append(this.ToString());
			//return retorno.ToString();

			return $"{this.ToString()}\n{base.MostrarDatos()}";

		}

		public static bool operator ==(Guarnicion guarnicion, EIngredientes ingrediente)
		{
			return ingrediente == EIngredientes.PANCETA || ingrediente == EIngredientes.QUESO || ingrediente == EIngredientes.ADHERESO;
		}
		public static bool operator !=(Guarnicion guarnicion, EIngredientes ingrediente)
		{
			return !( guarnicion == ingrediente );
		}

		public override string ToString()
		{
			return $"Guarnicion de tipo {this.tipo}";
		}

		public static explicit operator Guarnicion(ETipo tipo)
		{
			return new Guarnicion(tipo);
		}


		public enum ETipo
		{
			PAPAS_FRITAS = 1000,
			ENSALADA_RUSA = 750,
			ENSALADA_MIXTA = 500,
		}

	}
}
