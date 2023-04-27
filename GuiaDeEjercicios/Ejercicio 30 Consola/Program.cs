using Ejercicio_30;

Console.WriteLine("-----------Ejecicio 30-------------");

Competencia carrera = new Competencia(2,10);

AutoF1 a1 = new AutoF1("Fiat", 1);
AutoF1 a2 = new AutoF1("Ford", 2);
AutoF1 a3 = new AutoF1("Ford", 2);

Console.WriteLine(carrera+a1);
Console.WriteLine(carrera+a2);
Console.WriteLine(a1 == a2);
Console.WriteLine(a3 == a2);

Console.WriteLine(a1.MostarDatos());



Console.ReadKey();