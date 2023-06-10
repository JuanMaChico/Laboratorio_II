using Entidades;
using System.Configuration;

namespace Clase15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GestorDB.InsertEmpleado(new Empleado(1234, "Alejandro", "Bongioanni", 2));
            //List<Empleado> listaEmpleados = GestorDB.GetEmpleados();
            //foreach (Empleado emp in listaEmpleados)
            //{
            //    Console.WriteLine(emp.Nombre);
            //}
            //Console.WriteLine(GestorDB.GetUnEmpleado(2).Apellido);

            Console.WriteLine(ConfigurationManager.AppSettings["saludo"]);
            Console.WriteLine(ConfigurationManager.ConnectionStrings["miConection"]);
            Console.WriteLine(Properties.Resources.cadenaDeConexion);
            Console.ReadKey();
        }
    }
}