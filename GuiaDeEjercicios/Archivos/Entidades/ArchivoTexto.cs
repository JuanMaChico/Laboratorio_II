using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class ArchivoTexto : IArchivos<string>
	{
		public void Escribir(string dato, string path)
		{
			try
			{
				using(StreamWriter streamWriter = new StreamWriter(path))
				{
					streamWriter.WriteLine(dato);
				}
			}
			catch(Exception)
			{
				throw;
			}
		}

		/// <summary>
		/// Metodo de lectura de texto plano
		/// </summary>
		/// <param name="path">Ruta de acceso al archivo con extencion</param>
		/// <returns>Leer retornara un string con los datos del archivo</returns>
		public string Leer(string path)
		{
			string returnAux = string.Empty;
			try
			{
				if(File.Exists(path))
				{
					using(StreamReader streamReader = new StreamReader(path))
					{
						while(!streamReader.EndOfStream)
						{
							returnAux += $"{streamReader.ReadLine()}\n";
						}
					}
				}
			}
			catch(Exception)
			{
				throw;
			}
			return returnAux;
		}
	}
}
