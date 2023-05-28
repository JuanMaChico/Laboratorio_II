using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Exceptions
{
	public class UnaExeption : Exception
	{
		public UnaExeption(string? message) : base(message)
		{
		}

		public UnaExeption(string? message, Exception? innerException) : base(message, innerException)
		{
		}
	}
}
