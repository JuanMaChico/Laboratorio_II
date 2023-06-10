using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class ArchivoSerializado<T> : IArchivos<T> where T : class
	{
		private IArchivos<T>.ETipoArchivo tipo;



	}
}
