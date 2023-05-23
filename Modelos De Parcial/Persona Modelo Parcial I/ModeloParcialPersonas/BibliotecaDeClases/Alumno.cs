using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public class Alumno : Persona
	{

		private string legajo;
		private Dictionary<EMateria, List<int>> materiasAsignadas;


		#region Constructores
		private Alumno(int dni) : base(dni)
		{
			this.materiasAsignadas = new Dictionary<EMateria, List<int>>();
		}

		public Alumno(int dni, string legajo): this (dni)
		{
			this.legajo = legajo;
		}
		#endregion

		public override string Informacion
		{
			get => $"{this.ToString()}";
		}

		public static implicit operator Alumno(string dni)
		{
			int dniIngresado = 0;
			int.TryParse(dni, out dniIngresado);

			Alumno alumno = new Alumno(dniIngresado);
			alumno.legajo = alumno.GetHashCode().ToString();

			return alumno;
		}

		protected override string MostrarDatos()
		{
			StringBuilder retorno = new StringBuilder();
			retorno.Append(this.ToString());
			retorno.AppendLine(base.MostrarDatos());
			retorno.AppendLine("Materias asignadas:");

			foreach( EMateria materia in materiasAsignadas.Keys )
			{
				retorno.AppendLine($"{materia}:");

				List<int> notas = this[materia]; //indexador
				if( notas != null )
				{
					foreach( int nota in notas )
					{
						retorno.AppendLine($"- {nota}");
					}
				}
			}
			return retorno.ToString();
		}

		public bool RendirExamen(EMateria materia)
		{
			if( !materiasAsignadas.ContainsKey(materia) )
			{
				return false;
			}
			else
			{
				Random random = new Random();
				int nota = random.Next(1, 10);
				materiasAsignadas[materia].Add(nota);
				return true;
			}

		}

		public static bool operator ==(Alumno alumno, EMateria materia)
		{
			return alumno.materiasAsignadas.ContainsKey(materia);
		}

		public static bool operator !=(Alumno alumno, EMateria materia)
		{
			return !( alumno == materia );
		}

		public static bool operator +(Alumno alumno, EMateria materia)
		{
			if( alumno == materia )
			{
				return false;
			}
			else
			{
				alumno.materiasAsignadas[materia] = new List<int>();
				return true;
			}
		}

		public override string ToString()
		{
			return $"Alumno - {this.legajo}";
		}



		public List<int> this[EMateria materia]
		{
			get
			{
				if( materiasAsignadas.ContainsKey(materia) ) //this == materia; utilizar la sobrecarga
				{
					return materiasAsignadas[materia]; // this.materiasAsignadas[materia];
				}
				else
				{
					return null;
				}
			}
		}



	}
}
