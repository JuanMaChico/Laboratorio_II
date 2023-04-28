using Biblioteca_de_Clases;
namespace Estacionamientos
{
	public partial class FrmEstacionamiento : Form
	{

		private Estacionamiento estacionamiento;

		public FrmEstacionamiento()
		{
			InitializeComponent();
		}


		private void FrmEstacionamiento_Load(object sender, EventArgs e)
		{
			this.cmbTipoVehiculo.DataSource = Enum.GetValues(typeof(Vehiculo.EVehiculos));
			this.cmbTipoMoto.DataSource = Enum.GetValues(typeof(Moto.ETipo));
			this.estacionamineto = Estacionamiento.GetEstacionamiento("Nombre del Alumno",20);
			this.txtNombreEstacionamiento.Text = this.estacionamiento.Nombre;
		}
	}
}