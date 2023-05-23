using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
	public class Hamburguesa : Comida
	{
		private static double costoBase;
		private bool esDoble;

		static Hamburguesa()
		{
			costoBase = 1500;
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
			return this + ingredientes;
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
			return esDoble ? "Hamburguesa – Doble" : "Hamburguesa – Simple";
		}

		protected override string MostrarDatos()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append(base.MostrarDatos());
			retorno.Append(this.ToString());
			return retorno.ToString();
		}


	}
}
