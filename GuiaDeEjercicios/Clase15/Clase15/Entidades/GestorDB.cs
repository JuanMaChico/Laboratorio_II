using System.Data.SqlClient;

namespace Entidades
{
	public class GestorDB
	{
		static string stringConnection = "Server=.;Database=Clase 15;Trusted_Connection=True;";

		public static List<Empleado> GetEmpleados()
		{
			List<Empleado> empleados = new List<Empleado>();
			using(SqlConnection connection = new SqlConnection(stringConnection))
			{
				string sentencia = "SELECT * FROM EMPLEADOS";
				SqlCommand cmd = new SqlCommand(sentencia, connection);
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				//cmd.ExecuteNonQuery(); -> Para todas las sentencias que no sean de lectura
				while(reader.Read())
				{
					empleados.Add(new Empleado(reader.GetInt32(0), reader.GetString(1),
												reader.GetString(2), reader.GetInt32(3)));
				}
				return empleados;
			}
		}

		public static Empleado GetUnEmpleado(int id)
		{
			using(SqlConnection connection = new SqlConnection(stringConnection))
			{
				string sentencia = "SELECT * FROM EMPLEADOS WHERE ID = @id";
				SqlCommand cmd = new SqlCommand(sentencia, connection);
				cmd.Parameters.AddWithValue("id", id);
				connection.Open();
				SqlDataReader reader = cmd.ExecuteReader();
				//cmd.ExecuteNonQuery(); -> Para todas las sentencias que no sean de lectura
				while(reader.Read())
				{
					return new Empleado(reader.GetInt32(0), reader.GetString(1),
												reader.GetString(2), reader.GetInt32(3));
				}
				throw new Exception("No existe el empleado con ese ID");
			}
		}

		public static int InsertEmpleado(Empleado empleado)
		{
			using(SqlConnection connection = new SqlConnection(stringConnection))
			{
				string sentencia = "INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, ID_SECTOR) VALUES (@nombre, @apellido, @idSector)";
				SqlCommand cmd = new SqlCommand(sentencia, connection);
				cmd.Parameters.AddWithValue("nombre", empleado.Nombre);
				cmd.Parameters.AddWithValue("apellido", empleado.Apellido);
				cmd.Parameters.AddWithValue("idSector", empleado.IdSector);
				connection.Open();
				return cmd.ExecuteNonQuery(); //-> Para todas las sentencias que no sean de lectura
											  //throw new Exception("No existe el empleado con ese ID");

			}
		}


	}
}