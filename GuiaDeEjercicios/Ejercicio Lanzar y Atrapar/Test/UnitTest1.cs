using BibliotecaDeClases;
using BibliotecaDeClases.Exceptions;

namespace Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		[ExpectedException(typeof(MiException))]
		public void TestOtraClaseMetodo()
		{
			OtraClase ot = new OtraClase();
			ot.MetodoDeOtraClase();
		}


		[TestMethod]
		[ExpectedException(typeof(UnaExeption))]
		public void TestMiMetodo()
		{
			new MiClase(200);
		}
	}
}