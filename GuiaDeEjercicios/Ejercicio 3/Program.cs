/*
 * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
 * por consola.
 * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
 */
Console.WriteLine("------------- Ejecicio 3 -------------");

Console.Write("Ingrese un número: ");
int limite = int.Parse(Console.ReadLine());

Console.WriteLine("Números primos hasta {0}:", limite);

for (int numero = 2; numero <= limite; numero++)
{
    bool esPrimo = true;

    for (int divisor = 2; divisor <= Math.Sqrt(numero); divisor++)
    {
        if (numero % divisor == 0)
        {
            esPrimo = false;
            break;
        }
    }

    if (esPrimo)
    {
        Console.Write("{0} ", numero);
    }
}

Console.ReadLine();