namespace Hilos
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnIniciar = new Button();
			btnCancelar = new Button();
			lblHora = new Label();
			lblHoraActual = new Label();
			SuspendLayout();
			// 
			// btnIniciar
			// 
			btnIniciar.Location = new Point(12, 109);
			btnIniciar.Name = "btnIniciar";
			btnIniciar.Size = new Size(144, 60);
			btnIniciar.TabIndex = 0;
			btnIniciar.Text = "Iniciar";
			btnIniciar.UseVisualStyleBackColor = true;
			btnIniciar.Click += btnIniciar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(162, 109);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(144, 60);
			btnCancelar.TabIndex = 1;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// lblHora
			// 
			lblHora.AutoSize = true;
			lblHora.Font = new Font("JetBrains Mono NL SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			lblHora.Location = new Point(4, 9);
			lblHora.Name = "lblHora";
			lblHora.Size = new Size(90, 27);
			lblHora.TabIndex = 2;
			lblHora.Text = "Hora: ";
			// 
			// lblHoraActual
			// 
			lblHoraActual.AutoSize = true;
			lblHoraActual.Font = new Font("JetBrains Mono NL SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			lblHoraActual.Location = new Point(12, 45);
			lblHoraActual.Name = "lblHoraActual";
			lblHoraActual.Size = new Size(0, 27);
			lblHoraActual.TabIndex = 3;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(316, 175);
			Controls.Add(lblHoraActual);
			Controls.Add(lblHora);
			Controls.Add(btnCancelar);
			Controls.Add(btnIniciar);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Hora";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnIniciar;
		private Button btnCancelar;
		private Label lblHora;
		private Label lblHoraActual;
	}
}