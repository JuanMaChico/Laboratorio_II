namespace FrmMostrar
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void ActualizarNombre(string value)
		{
			this.lblNombre.Text = value;
		}

	}
}