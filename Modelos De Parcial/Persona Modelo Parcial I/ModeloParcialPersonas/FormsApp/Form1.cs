using BibliotecaDeClases;

namespace FormsApp
{
	public partial class FormAlumnos : Form
	{

		private Persona alumno;
		private Persona profesorProgra;
		private Curso cursoProgramacion;
		private Persona profesorLabo;
		private Curso cursoLaboratorio;



		public FormAlumnos()
		{
			InitializeComponent();

			profesorLabo = new Profesor(99000123, "profesorLabo@email.com", EMateria.Laboratorio);
			profesorProgra = new Profesor(99000123, "profesorProgra@email.com", EMateria.Programacion);
			cursoProgramacion = new Curso(( Profesor )profesorProgra);
			cursoLaboratorio = new Curso(( Profesor )profesorLabo);
		}

		private void FormAlumnos_Load(object sender, EventArgs e)
		{
			this.cmbMaterias.DataSource = Enum.GetValues(typeof(EMateria));
		}
	}
}