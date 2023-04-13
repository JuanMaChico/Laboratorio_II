/*
 * Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el
 * valor máximo, el valor mínimo y el promedio.
 */
Console.WriteLine("-----------Ejecicio 1-------------");
Console.Write("Ingrese 5 números separados por espacios: ");
int[] numeros = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int maximo = numeros.Max();
int minimo = numeros.Min();
double promedio = numeros.Average();

Console.WriteLine("El número máximo es: {0}", maximo);
Console.WriteLine("El número mínimo es: {0}", minimo);
Console.WriteLine("El promedio es: {0}", promedio);

Console.ReadLine();
