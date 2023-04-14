using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Realizar una clase llamada Validación que posea un método estático llamado Validar, que posea la siguiente firma: 
    bool Validar(int valor, int min, int max):
    valor: dato a validar
    min y max: rango en el cual deberá estar la variable valor.
    Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
    Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
    Nota: Utilizar variables escalares, NO utilizar vectores.
 */
namespace Ejercicio_11
{
    public static class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }
    }
}
