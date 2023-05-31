using System.Text;

namespace Biblioteca_de_Clases
{
	public class Cliente
	{
		private int dni;
		private List<Comida> menu;

		private double TotalAPagar
		{
			get
			{
				double costo = 0;
				this.menu.ForEach(c => costo += c.Costos);
				return costo;
			}
		}

		private Cliente(int dni)
		{
			this.dni = dni;
			this.menu = new List<Comida>();
        }

		public static Cliente GetCliente(int dni)
		{
			return dni;
		}

		public Comida? BuscarComida(Comida comida)
		{
			return this.menu.Find(c => c.Equals(comida));
		}

		public static string ImprimirTicket(Cliente cliente)
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append($"Cliente: {cliente.dni}");
			foreach( Comida c in cliente.menu )
			{
				retorno.AppendLine($"{c.Descripcion}");
			}
			retorno.Append($"{cliente.TotalAPagar}");
			return retorno.ToString();
		}

		public static Cliente operator +(Cliente cliente, Comida comida)
		{
			cliente.menu.Add(comida);
			return cliente;
		}

		public static bool operator ==(Cliente cliente, Comida comida)
		{
			foreach( Comida c in cliente.menu )
			{
				if( c.Nombre == comida.Nombre )
				{
					return true;
				}
			}
			return false;
		}
		public static bool operator !=(Cliente cliente, Comida comida)
		{
			return !( cliente == comida );
		}

		public static implicit operator Cliente(int dni)
		{
			return new Cliente(dni);
		}

	}
}
