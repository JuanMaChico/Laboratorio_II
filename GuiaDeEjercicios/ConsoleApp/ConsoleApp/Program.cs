using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
	static async Task Main(string[] args)
	{
		// Crear una instancia de HttpClient
		using(HttpClient client = new HttpClient())
		{
			try
			{
				// Hacer la solicitud GET a la API
				HttpResponseMessage response = await client.GetAsync("https://rickandmortyapi.com/api");

				// Verificar el código de estado de la respuesta
				if(response.IsSuccessStatusCode)
				{
					// Leer el contenido de la respuesta
					string content = await response.Content.ReadAsStringAsync();
					Console.WriteLine(content);
				}
				else
				{
					Console.WriteLine("La solicitud no fue exitosa. Código de estado: " + response.StatusCode);
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine("Ocurrió un error: " + ex.Message);
			}
		}
	}
}
