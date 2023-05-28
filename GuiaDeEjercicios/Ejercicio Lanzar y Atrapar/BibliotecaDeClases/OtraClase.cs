using BibliotecaDeClases.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public class OtraClase
	{
		public void MetodoDeOtraClase()
		{
			try 
			{
				new MiClase(200);
			} 
			catch (Exception ex) 
			{
				throw new MiException("Mi Excepcion en OtraClase", ex);
			}
			
		}
	}
}
