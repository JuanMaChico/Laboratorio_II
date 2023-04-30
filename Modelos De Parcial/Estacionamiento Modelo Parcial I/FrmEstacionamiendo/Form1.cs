using Biblioteca_de_Clases;
using System.Diagnostics;

namespace FrmEstacionamiendo
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
			this.estacionamiento = Estacionamiento.GetEstacionamiento("JMC Estacionamiento", 20);
			this.txtNombreEstacionamiento.Text = this.estacionamiento.Nombre;

		}

		private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if( this.cmbTipoVehiculo.SelectedItem.ToString() == Vehiculo.EVehiculos.Automovil.ToString() )
			{
				this.lblTipoMoto.Visible = false;
				this.cmbTipoMoto.Visible = false;
				this.cmbTipoMoto.Enabled = false;

				this.lblMarca.Visible = true;
				this.txtMarca.Visible = true;
			}
			else if( this.cmbTipoVehiculo.SelectedItem.ToString() == Vehiculo.EVehiculos.Moto.ToString() )
			{
				this.lblTipoMoto.Visible = true;
				this.cmbTipoMoto.Visible = true;
				this.cmbTipoMoto.Enabled = true;
				this.lblMarca.Visible = false;
				this.txtMarca.Visible = false;
				this.txtMarca.Enabled = false;
			}
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			Vehiculo vehiculo;
			if( ( Vehiculo.EVehiculos )this.cmbTipoVehiculo.SelectedItem == Vehiculo.EVehiculos.Automovil )
			{
				vehiculo = new Automovil(this.txtPatente.Text, DateTime.Now, this.txtMarca.Text);
			}
			else
			{
				vehiculo = new
				Moto(this.txtPatente.Text, DateTime.Now, ( Moto.ETipo )this.cmbTipoMoto.SelectedItem)
				;
			}
			if( this.estacionamiento + vehiculo )
			{
				this.lstVehiculos.Items.Add(vehiculo);
				MessageBox.Show(vehiculo.ToString(), "Ingreso al Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private void lstVehiculos_DoubleClick(object sender, EventArgs e)
		{
			if( this.estacionamiento - ( Vehiculo )this.lstVehiculos.SelectedItem )
			{
				MessageBox.Show(Estacionamiento.InformarSalida(( Vehiculo )this.lstVehiculos.SelectedItem), "Ingreso al Estacionamiento", MessageBoxButtons.OK,MessageBoxIcon.Information);
				this.lstVehiculos.Items.Remove(( Vehiculo )this.lstVehiculos.SelectedItem);
			}
		}
	}
}