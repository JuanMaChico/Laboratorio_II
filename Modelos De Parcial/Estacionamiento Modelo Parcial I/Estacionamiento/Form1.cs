using Biblioteca_de_Clases;
namespace ModeloDeParcialEstacionamiento
{
	public partial class FrmEstacionamiento : Form
	{

		private static Estacionamiento estacionamiento;

		public FrmEstacionamiento()
		{
			InitializeComponent();
		}


		private void FrmEstacionamiento_Load(object sender, EventArgs e)
		{
			this.cmbTipoVehiculo.DataSource = Enum.GetValues(typeof(Vehiculo.EVehiculos));
			this.cmbTipoMoto.DataSource = Enum.GetValues(typeof(Moto.ETipo));
			this.estacionamiento = Estacionamiento.GetEstacionamiento("Nombre del Alumno",20);
			this.txtNombreEstacionamiento.Text = this.estacionamiento.Nombre;
		}
	}
}