namespace TestProject
{
	[TestClass]
	public class UnitTest
	{
		[TestMethod]
		[DataRow(1)]
		public void TestDecimalARomano(int value)
		{
			//Arrange Preparacion del entorno (Given)
			int numero = 1;
			string esperado = "I";

			//Act - Invocacion del metodo a probar (When)
			string resultado = Conversor.ConvertirARomano(numero);

			//Assert (Then)
			Assert.AreEqual(resultado, esperado);
		}
	}
}