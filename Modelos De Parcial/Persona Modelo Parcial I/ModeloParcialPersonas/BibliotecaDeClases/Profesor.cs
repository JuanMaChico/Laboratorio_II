using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
	public class Profesor : Persona
	{
		private string? email;
		private EMateria materiaAsignada;

		public Profesor(int dni) : base(dni)
		{

		}

		public Profesor(int dni, string email) : this(dni)
		{
			this.email = email;
		}

		public Profesor(int dni, string email, EMateria materiaAsignada) : this(dni, email)
		{

		}

		protected override string MostrarDatos()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(this.ToString());
			sb.AppendLine(base.MostrarDatos());
			sb.AppendLine($"Email: {this.email}");

			return sb.ToString();
		}

		public override string Informacion
		{
			get => $"Profesor: \n {this.MostrarDatos()}";
		}

		public EMateria Materia
		{
			get;
			set;
		}

		public override string ToString()
		{
			return $"Profesor -{this.materiaAsignada}";
		}
		public bool Evaluar(Alumno alumno)
		{
			if( alumno.RendirExamen(this.Materia) )
			{
				return true; //el alumno rindio la materia
			}
			else { return false; }
		}

	}
}
