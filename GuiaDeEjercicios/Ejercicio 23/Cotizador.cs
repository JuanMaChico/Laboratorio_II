using Billetes;
using FontAwesome.Sharp;

namespace Ejercicio_23
{
	public partial class Cotizador : Form
	{

		private Euro e;
		private Dolar d;
		private Pesos p;

		public Cotizador()
		{
			InitializeComponent();
		}

		private void txtCotzEuro_Enter(object sender, EventArgs e)
		{
			double numero = 0;
			double.TryParse(this.txtCotzEuro.Text, out numero);
			Euro.SetCotizacion(numero);
		}

		private void txtCotzDolar_Enter(object sender, EventArgs e)
		{
			double numero = 0;
			double.TryParse(this.txtCotzEuro.Text, out numero);
			Dolar.SetCotizacion(numero);
		}

		private void txtCotzPeso_Enter(object sender, EventArgs e)
		{
			double numero = 0;
			double.TryParse(this.txtCotzEuro.Text, out numero);
			Dolar.SetCotizacion(numero);
		}

		/// <summary>
		/// Valida que solo ingrese numeros
		/// </summary>
		private void Cotizador_KeyPress(object sender, KeyPressEventArgs e)
		{
			if( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' )
			{
				e.Handled = true;
			}

			if( e.KeyChar == '.' && ( sender as TextBox ).Text.IndexOf('.') > -1 )
			{
				e.Handled = true;
			}
		}

		private void txtEuros_Leave(object sender, EventArgs e)
		{
			double numero = 0;
			double.TryParse(this.txtEuros.Text, out numero);
			this.e = numero;

		}

		private void txtDolares_Leave(object sender, EventArgs e)
		{
			double numero = 0;
			double.TryParse(this.txtDolares.Text, out numero);
			this.d = numero;
		}

		private void txtPesos_Leave(object sender, EventArgs e)
		{
			double numero = 0;
			double.TryParse(this.txtPesos.Text, out numero);
			this.d = numero;
		}

		private void btnConvertEuros_Click(object sender, EventArgs e)
		{

		}

		private void btnLockCotizacion_Click(object sender, EventArgs e)
		{
			if( btnLockCotizacion.IconChar == IconChar.LockOpen )
			{
				btnLockCotizacion.IconChar = IconChar.Lock;
			}
			else
			{
				btnLockCotizacion.IconChar = IconChar.LockOpen;
			}
		}
	}
}