namespace FormsApp
{
	public partial class FrmPrincipal : Form
	{

		private FrmMostrar frmMostrar;
		private FrmTestDelegados frmtestDelegados;

		public FrmPrincipal()
		{
			InitializeComponent();
		}

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{
			this.frmMostrar = new FrmMostrar();
			frmMostrar.MdiParent = this;

			this.frmtestDelegados = new FrmTestDelegados(this.frmMostrar.ActualizarNombre);
			frmtestDelegados.MdiParent = this;

		}

		private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.frmtestDelegados.Show();
			this.mostrarToolStripMenuItem.Enabled = true;
		}

		private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.frmMostrar.Show();
		}
	}
}