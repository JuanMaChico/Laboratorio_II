/*
 *  Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
 *  mayor que cero, caso contrario, mostrar el mensaje: &quot;ERROR. ¡Reingresar número!&quot;.
 *  Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
 */
Console.WriteLine("------------- Ejecicio 2 -------------");

int numero;
bool esNumeroValido;

do
{
    Console.Write("Ingrese un número mayor que cero: ");
    string entrada = Console.ReadLine();

    esNumeroValido = int.TryParse(entrada, out numero) && numero > 0;

    if (!esNumeroValido)
    {
        Console.WriteLine("El número ingresado es inválido. Debe ser un número entero mayor que cero.");
    }
} while (!esNumeroValido);

int cuadrado = numero * numero;
int cubo = numero * numero * numero;

Console.WriteLine("El cuadrado de {0} es: {1}", numero, cuadrado);
Console.WriteLine("El cubo de {0} es: {1}", numero, cubo);

Console.ReadLine();