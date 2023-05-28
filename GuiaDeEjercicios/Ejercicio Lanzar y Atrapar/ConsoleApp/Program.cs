using BibliotecaDeClases;

namespace ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Lanzar y Atrapar - Ejercicio de exeptions");



			try 
			{
				OtraClase ot = new OtraClase();
				ot.MetodoDeOtraClase();
			}
			catch (Exception ex) 
			{
                Console.WriteLine(ex.Message);
                while (ex.InnerException != null)
				{
					ex = ex.InnerException;
                    Console.WriteLine(ex.Message);
                }
			}



		}
	}
}