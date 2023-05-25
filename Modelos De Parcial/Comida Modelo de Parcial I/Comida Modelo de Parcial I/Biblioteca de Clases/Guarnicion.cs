using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public class Guarnicion : Comida
	{
		
		private ETipo tipo;

		public Guarnicion() : base(ETipo.PAPAS_FRITAS.ToString())
		{
			tipo = ETipo.PAPAS_FRITAS;
		}

		public Guarnicion(ETipo t): this()
		{
			this.tipo = t;
		}

		protected override string AgregarIngredientes(EIngredientes ingredientes)
		{
			StringBuilder retorno = new StringBuilder();
			retorno.AppendLine(this + ingredientes);
			retorno.AppendLine("a su Guarnicion");
			return retorno.ToString();
		}

		protected override double CalcularCostos()
		{
			double costo = ( int )this.tipo;
			foreach( EIngredientes i in this.ingredientes )
			{
				costo = costo + ( costo * ( int )i );
			}
			return costo;
		}

		protected override string MostrarDatos()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append(base.MostrarDatos());
			retorno.Append(this.ToString());
			return retorno.ToString();
		}

		public static bool operator ==(Guarnicion guarnicion, EIngredientes ingrediente)
		{
            foreach (EIngredientes i in guarnicion.ingredientes)
            {
				switch( i )
				{
					case EIngredientes.PANCETA:
					case EIngredientes.QUESO:
					case EIngredientes.ADHERESO:
						return true;
				}
            }
			return false;
        }
		public static bool operator !=(Guarnicion guarnicion, EIngredientes ingrediente)
		{
			return !(guarnicion == ingrediente);
		}

		public override string ToString()
		{
			return $"Guarnicion de tipo {this.tipo}";
		}

		public static explicit operator Guarnicion(ETipo tipo )
		{
			return new Guarnicion(tipo) ;
		}


		public enum ETipo
		{
			PAPAS_FRITAS   = 1000,
			ENSALADA_RUSA  = 750,
			ENSALADA_MIXTA = 500,
		}

	}
}
