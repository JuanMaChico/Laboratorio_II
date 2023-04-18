/*
    16. Crear la clase Alumno de acuerdo al siguiente diagrama:

    Alumno
    Class
      Campos
        nota1       :byte
        nota2       :byte
        notaFinal   :float
        apellido    :string
        legajo      :int
        nombre      :string
      Metodos
        CalcularFinal():void
        Estudiar(byte notaUno, byte notaDos): void
        Mostrar():string

    a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle
    nombre, apellido y legajo a cada uno de ellos.

    b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.

    c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
    iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
    el método de instancia Next de la clase Random.

    d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
    mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda &quot;Alumno
    desaprobado&quot;.
 */

using Ejercicio_16;

Alumno alumno1 = new Alumno("Juan", "Chico", 2032);
Alumno alumno2 = new Alumno("Carlos", "Lospalluto", 2034);
Alumno alumno3 = new Alumno("Facundo", "Chico", 2035);

alumno1.CalcularFinal();
alumno2.CalcularFinal();
alumno3.CalcularFinal();


Console.WriteLine(alumno1.Mostrar());
Console.WriteLine("-------------------------------------");
Console.WriteLine(alumno2.Mostrar());
Console.WriteLine("-------------------------------------");
Console.WriteLine(alumno3.Mostrar());