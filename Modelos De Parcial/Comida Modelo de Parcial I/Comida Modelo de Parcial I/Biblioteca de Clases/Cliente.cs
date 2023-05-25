using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				foreach( Comida c in this.menu )
				{
					costo = costo + c.Costos;
				}
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
			return (Cliente)dni;
		}

		public Comida? BuscarComida(Comida comida)
		{
			foreach( Comida c in this.menu )
			{
                if (c.Nombre == comida.Nombre)
                {
					return c;
                }
            }
			return null;
		}

		public static string ImprimirTicket(Cliente cliente)
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append($"Cliente: { cliente.dni}");
            foreach (Comida c in cliente.menu)
            {
				retorno.Append($"{c.Descripcion}");
            }
			retorno.Append($"{cliente.TotalAPagar}");
            return retorno.ToString();
		}

		public static Cliente operator +(Cliente cliente,Comida comida )
		{
			cliente.menu.Add(comida);
			return cliente;
		}

		public static bool operator ==(Comida comida, Cliente cliente)
		{
            foreach (Comida c in cliente.menu)
            {
                if(c.Nombre == comida.Nombre )
				{
					return true;
				}
            }
			return false;
        }
		public static bool operator !=(Comida comida, Cliente cliente)
		{
			return !( comida == cliente );
		}

		public static explicit operator Cliente(int dni)
		{
			return new Cliente(dni);
		}

	}
}
