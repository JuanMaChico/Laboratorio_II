/*
    Realizar una clase llamada Validación que posea un método estático llamado Validar, que posea la siguiente firma: 
    bool Validar(int valor, int min, int max):
    valor: dato a validar
    min y max: rango en el cual deberá estar la variable valor.
    Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
    Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
    Nota: Utilizar variables escalares, NO utilizar vectores.
 */
using Ejercicio_11;

Console.WriteLine("------------- Ejecicio 11 -------------");

int numero;
bool esNumeroValido;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("---- Numero ingresado {0} ----", i + 1);
    do
    {
        Console.Write("Ingrese un número: ");
        string entrada = Console.ReadLine();

        esNumeroValido = int.TryParse(entrada, out numero);

        if (!esNumeroValido)
        {
            Console.WriteLine("El número ingresado es inválido. Debe ser un número");
        }
    } while (!esNumeroValido);

    if (Validacion.Validar(numero, -100, 100))
    {
        Console.WriteLine("El numero es valido");
    }
    else
    {
        Console.WriteLine("El numero no es valido");
    }



}









