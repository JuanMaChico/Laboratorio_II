using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_clases
{
	public class Curso
	{

		private List<Persona> alumnos;
		private EMateria materia;
		private Persona profesor;

		public Curso(EMateria materia , Profesor profesor)
		{

		}

		public void EvaluarAlumnos(Curso curso)
		{
			
		}

		public string InscribirAlumno(Alumno alumno)
		{
		
		}

		public string MostrarInformacionDelCurso(Curso curso)
		{
		
		}

		public static bool operator ==(Curso curso ,Alumno alumno)
		{
			return true;
		}
		public static bool operator !=(Curso curso ,Alumno alumno)
		{
			return !true;
		}


		public List<Persona> Alumnos
		{
			get;
		}

		public Profesor Profesor
		{
			get; set; 
		}


		public override string ToString()
		{
			return base.ToString();
		}

	}
}
