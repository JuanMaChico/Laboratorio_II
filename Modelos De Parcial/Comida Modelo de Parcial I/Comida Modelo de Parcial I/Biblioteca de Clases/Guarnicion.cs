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

		public Guarnicion(ETipo t)
		{
			tipo = t;
		}

		protected override string AgregarIngredientes(EIngredientes ingredientes)
		{
			throw new NotImplementedException();
		}

		protected override double CalcularCostos()
		{
			throw new NotImplementedException();
		}

		protected override string MostrarDatos()
		{
			return "";
		}

		public enum ETipo
		{
			PAPAS_FRITAS   = 1000,
			ENSALADA_RUSA  = 750,
			ENSALADA_MIXTA = 500,
		}

	}
}
