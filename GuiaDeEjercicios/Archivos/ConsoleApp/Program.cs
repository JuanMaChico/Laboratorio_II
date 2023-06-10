using Entidades;
using System.IO;
using System.Text.Json;


//Personas p1 = new Personas("Juan", "Chico");
//Personas p2 = new Personas("sasha", "Chieeeco");
//Personas p3 = new Personas("carlos", "Chidddco");
//Personas p4 = new Personas("diva", "Chaaico");
//Personas p5 = new Personas("queto", "asd");


//List<Personas> personas = new List<Personas>();

//personas.Add(p1);
//personas.Add(p2);
//personas.Add(p3);
//personas.Add(p4);
//personas.Add(p5);

string ruta = AppDomain.CurrentDomain.BaseDirectory + "personas.txt";

//string ruta = Environment.CurrentDirectory + "personas.json";

//string ruta = Directory.GetCurrentDirectory() + "personas.json";

//string ruta = Directory.GetCurrentDirectory() + "personas.txt";


//using(StreamWriter streamWriter = new StreamWriter(ruta))
//{
//	streamWriter.WriteLine("Hola Mundo");
//}

//string jsonData = JsonSerializer.Serialize(personas);

//Console.WriteLine(jsonData);

//using(StreamWriter writer = new StreamWriter(ruta))
//{
//	writer.Write(jsonData);
//}

//Console.WriteLine("__________________________________________");


//using(StreamReader reader = new StreamReader(ruta))
//{
//	string jsonContent = reader.ReadToEnd();

//	List<Personas> ls = JsonSerializer.Deserialize<List<Personas>>(jsonContent);


//	foreach(Personas persona in ls)
//	{
//		Console.WriteLine(persona.Nombre);
//	}

//}


ArchivoTexto archivo = new ArchivoTexto();

archivo.Escribir("Hola Mundo",ruta);

Console.WriteLine(archivo.Leer(ruta)); 




Console.ReadKey();