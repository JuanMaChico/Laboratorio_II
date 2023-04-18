/*
    Generar un nuevo proyecto del tipo Console Application. Construir tres clases dentro de un
    namespace llamado Billetes: Pesos, Euro y Dólar.
    a. Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí
    con total normalidad como si fueran tipos numéricos, teniendo presente que 1 Euro
    equivale a 1,08 dólares y 1 dólar equivale a 66 pesos.
    b. El atributo cotizRespectoDolar y el método GetCotizacion son estáticos.
    c. Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los
    distintos tipos de datos.
    d. Colocar dentro del Main el código necesario para probar todos los métodos.
    e. Los constructores estáticos le darán una cotización respecto del dólar por defecto a las
    clases.
    f. Los comparadores == compararan cantidades.
    g. Para operar dos tipos de monedas, se deberá convertir todo a una y luego realizar lo pedido.
    Por ejemplo, si quiero sumar Dólar y Euro, deberé convertir el Euro a Dólar y luego
    sumarlos.
    h. Reutilizar el código. Sólo realizar las conversiones dentro de los operadores para dicho uso.
 */

using Billetes;


Console.WriteLine("--- Tengo ---");

Dolar dolar = new Dolar(100);
Console.WriteLine($"Dolar: {dolar.GetCantidad()}");

Pesos pesos = new Pesos(100);
Console.WriteLine($"Pesos: {pesos.GetCantidad()}");

Euro euros = new Euro(100);
Console.WriteLine($"Euros: {euros.GetCantidad()}");

Console.WriteLine("--- ----- ---");

// 100 dolares a pesos: 21638
Pesos pesos2 = ( Pesos ) dolar;
Console.WriteLine($"de dolar a pesos: ${pesos2.GetCantidad().ToString("N2")}");
// 100 pesos a dolar
Dolar dolar1 = ( Dolar ) pesos;
Console.WriteLine($"de pesos a dolar: ${dolar1.GetCantidad().ToString("N2")}");

//100 pesos a Euros
Euro euro1 = ( Euro ) pesos;
Console.WriteLine($"de pesos a euro: ${euro1.GetCantidad().ToString("N2")}");
//euro a pesos
Pesos pesos3 = ( Pesos )euros;
Console.WriteLine($"de euros a Pesos: ${pesos3.GetCantidad().ToString("N2")}");

//euro a dolar
Dolar dolar3 = ( Dolar )euros;
Console.WriteLine($"de euro a dolar: ${dolar3.GetCantidad().ToString("N2")}");

Euro euro3 = ( Euro )dolar;
Console.WriteLine($"de dolar a Euro: ${euro3.GetCantidad().ToString("N2")}");




