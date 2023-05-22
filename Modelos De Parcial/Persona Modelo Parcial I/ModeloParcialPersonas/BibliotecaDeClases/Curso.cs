using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public class Curso
	{

		private List<Persona> alumnos;
		private EMateria materia;
		private Persona profesor;

		public Curso(Profesor profesor)
		{
			this.materia = profesor.Materia;
			this.profesor = profesor;
			alumnos = new List<Persona>();
		}
		public List<Persona> Alumnos
		{
			get => alumnos;
		}

		public Profesor Profesor
		{
			get => ( Profesor )profesor;

			set => this.profesor = value;
		}

		public static void EvaluarAlumnos(Curso curso)
		{
			foreach( Alumno alumno in curso.Alumnos )
			{
				alumno.RendirExamen(curso.materia);
			}
		}

		public string InscribirAlumno(Alumno alumno)
		{
			string mensaje;

			//forma correcta es esta, mal la logica de arriba y no agregaba la materia al alumno
			//operador + en alumno chequea que no haya sido inscripto
			if( this != alumno && ( alumno + this.materia ) )
			{
				this.alumnos.Add(alumno);
				mensaje = $"Se inscribio al alumno a la materia {this.materia}\n{alumno.Informacion}";
			}
			else
			{
				mensaje = $"Ya inscripto o no se pudo inscribir el alumno a la materia {this.materia}";
			}
			return mensaje;
		}

		public static string MostrarInformacionDelCurso(Curso curso)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(curso.ToString());
			sb.AppendLine($"Profesor: {curso.Profesor}");
			sb.AppendLine($"Lista de alumnos:");

			foreach( Alumno alumno in curso.alumnos )
			{
				sb.AppendLine(alumno.Informacion);
			}

			return sb.ToString();
		}

		public static bool operator ==(Curso curso, Alumno alumno)
		{
			bool returnAux = false;

			foreach( Alumno a in curso.Alumnos )
			{
				if( a == alumno )
				{
					returnAux = true;
					break;
				}
			}

			return returnAux;
		}
		public static bool operator !=(Curso curso, Alumno alumno)
		{
			return !( curso == alumno );
		}

		public override string ToString()
		{
			return $"Curso de - {this.materia}";
		}

	}
}
