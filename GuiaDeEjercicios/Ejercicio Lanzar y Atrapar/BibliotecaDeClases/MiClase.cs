using BibliotecaDeClases.Exceptions;

namespace BibliotecaDeClases
{
	public class MiClase
	{


		public MiClase()
		{
			try
			{
				MiMetodo();
			}
			catch(DivideByZeroException ex)
			{
				throw ex;
			}
		}

		public MiClase(int id)
		{
			try
			{
				new MiClase();
			}
			catch(DivideByZeroException ex)
			{
				throw new UnaExeption("Una Exeption", ex);
			}
		}

		public static void MiMetodo()
		{
			throw new DivideByZeroException("Exception de mi metodo");
		}


	}
}