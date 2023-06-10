namespace Hilos
{
	public partial class Form1 : Form
	{

		CancellationTokenSource CancellationTokenSource;
		Task tarea;

		public Form1()
		{
			this.CancellationTokenSource = new CancellationTokenSource();
			CancellationToken token = CancellationTokenSource.Token;
			InitializeComponent();
		}
		private void btnIniciar_Click(object sender, EventArgs e)
		{
			this.CancellationTokenSource = new CancellationTokenSource();
			CancellationToken token = CancellationTokenSource.Token;
			this.tarea = Task.Run(() => this.IniciarRelog(this.CancellationTokenSource),token);
		}
		private void ActualizarHora(DateTime hora)
		{
			if(this.InvokeRequired)
			{
				this.BeginInvoke(()=> this.ActualizarHora(hora));
			}
			else
			{
				this.lblHoraActual.Text = $"{hora}";
			}
		}

		private void IniciarRelog(CancellationTokenSource cancellationTokenSource)
		{
			do
			{
				this.ActualizarHora(DateTime.Now);
				Thread.Sleep(1000);
			} while(true && !cancellationTokenSource.IsCancellationRequested);
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.CancellationTokenSource.Cancel();
		}
	}
}