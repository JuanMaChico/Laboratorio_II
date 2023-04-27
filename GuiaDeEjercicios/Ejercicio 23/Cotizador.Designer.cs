namespace Ejercicio_23
{
	partial class Cotizador
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
			if( disposing && ( components != null ) )
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizador));
			printPreviewDialog1 =  new PrintPreviewDialog() ;
			txtEuros =  new TextBox() ;
			txtDolares =  new TextBox() ;
			txtPesos =  new TextBox() ;
			txtResultPesosEuro =  new TextBox() ;
			txtResultDolarEuro =  new TextBox() ;
			txtResultEurosEuros =  new TextBox() ;
			txtResultPesosDolar =  new TextBox() ;
			txtResultDolarDolar =  new TextBox() ;
			txtResultEurosDolar =  new TextBox() ;
			txtResultPesosPesos =  new TextBox() ;
			txtResultDolarPesos =  new TextBox() ;
			txtResultEurosPesos =  new TextBox() ;
			txtCotzPeso =  new TextBox() ;
			txtCotzDolar =  new TextBox() ;
			txtCotzEuro =  new TextBox() ;
			lblEuro =  new Label() ;
			lblCotizacion =  new Label() ;
			lblPeso =  new Label() ;
			lblDolar =  new Label() ;
			label5 =  new Label() ;
			label6 =  new Label() ;
			label7 =  new Label() ;
			btnConvertEuros =  new Button() ;
			btnConvertDolares =  new Button() ;
			btnConvertPesos =  new Button() ;
			btnLockCotizacion =  new FontAwesome.Sharp.IconButton() ;
			SuspendLayout();
			// 
			// printPreviewDialog1
			// 
			printPreviewDialog1.AutoScrollMargin =  new Size(0, 0) ;
			printPreviewDialog1.AutoScrollMinSize =  new Size(0, 0) ;
			printPreviewDialog1.ClientSize =  new Size(400, 300) ;
			printPreviewDialog1.Enabled =  true ;
			printPreviewDialog1.Icon =  ( Icon ) resources.GetObject("printPreviewDialog1.Icon")  ;
			printPreviewDialog1.Name =  "printPreviewDialog1" ;
			printPreviewDialog1.Visible =  false ;
			// 
			// txtEuros
			// 
			txtEuros.Location =  new Point(63, 91) ;
			txtEuros.MaxLength =  12 ;
			txtEuros.Name =  "txtEuros" ;
			txtEuros.Size =  new Size(118, 23) ;
			txtEuros.TabIndex =  4 ;
			txtEuros.KeyPress +=  Cotizador_KeyPress ;
			txtEuros.Leave +=  txtEuros_Leave ;
			// 
			// txtDolares
			// 
			txtDolares.Location =  new Point(63, 122) ;
			txtDolares.MaxLength =  12 ;
			txtDolares.Name =  "txtDolares" ;
			txtDolares.Size =  new Size(118, 23) ;
			txtDolares.TabIndex =  5 ;
			txtDolares.KeyPress +=  Cotizador_KeyPress ;
			txtDolares.Leave +=  txtDolares_Leave ;
			// 
			// txtPesos
			// 
			txtPesos.Location =  new Point(63, 153) ;
			txtPesos.MaxLength =  12 ;
			txtPesos.Name =  "txtPesos" ;
			txtPesos.Size =  new Size(118, 23) ;
			txtPesos.TabIndex =  6 ;
			txtPesos.KeyPress +=  Cotizador_KeyPress ;
			txtPesos.Leave +=  txtPesos_Leave ;
			// 
			// txtResultPesosEuro
			// 
			txtResultPesosEuro.Location =  new Point(268, 154) ;
			txtResultPesosEuro.Name =  "txtResultPesosEuro" ;
			txtResultPesosEuro.ReadOnly =  true ;
			txtResultPesosEuro.Size =  new Size(118, 23) ;
			txtResultPesosEuro.TabIndex =  9 ;
			// 
			// txtResultDolarEuro
			// 
			txtResultDolarEuro.Location =  new Point(268, 123) ;
			txtResultDolarEuro.Name =  "txtResultDolarEuro" ;
			txtResultDolarEuro.ReadOnly =  true ;
			txtResultDolarEuro.Size =  new Size(118, 23) ;
			txtResultDolarEuro.TabIndex =  8 ;
			// 
			// txtResultEurosEuros
			// 
			txtResultEurosEuros.Location =  new Point(268, 92) ;
			txtResultEurosEuros.Name =  "txtResultEurosEuros" ;
			txtResultEurosEuros.ReadOnly =  true ;
			txtResultEurosEuros.Size =  new Size(118, 23) ;
			txtResultEurosEuros.TabIndex =  7 ;
			// 
			// txtResultPesosDolar
			// 
			txtResultPesosDolar.Location =  new Point(392, 154) ;
			txtResultPesosDolar.Name =  "txtResultPesosDolar" ;
			txtResultPesosDolar.ReadOnly =  true ;
			txtResultPesosDolar.Size =  new Size(118, 23) ;
			txtResultPesosDolar.TabIndex =  12 ;
			// 
			// txtResultDolarDolar
			// 
			txtResultDolarDolar.Location =  new Point(392, 123) ;
			txtResultDolarDolar.Name =  "txtResultDolarDolar" ;
			txtResultDolarDolar.ReadOnly =  true ;
			txtResultDolarDolar.Size =  new Size(118, 23) ;
			txtResultDolarDolar.TabIndex =  11 ;
			// 
			// txtResultEurosDolar
			// 
			txtResultEurosDolar.Location =  new Point(392, 92) ;
			txtResultEurosDolar.Name =  "txtResultEurosDolar" ;
			txtResultEurosDolar.ReadOnly =  true ;
			txtResultEurosDolar.Size =  new Size(118, 23) ;
			txtResultEurosDolar.TabIndex =  10 ;
			// 
			// txtResultPesosPesos
			// 
			txtResultPesosPesos.Location =  new Point(512, 154) ;
			txtResultPesosPesos.Name =  "txtResultPesosPesos" ;
			txtResultPesosPesos.ReadOnly =  true ;
			txtResultPesosPesos.Size =  new Size(118, 23) ;
			txtResultPesosPesos.TabIndex =  15 ;
			// 
			// txtResultDolarPesos
			// 
			txtResultDolarPesos.Location =  new Point(512, 123) ;
			txtResultDolarPesos.Name =  "txtResultDolarPesos" ;
			txtResultDolarPesos.ReadOnly =  true ;
			txtResultDolarPesos.Size =  new Size(118, 23) ;
			txtResultDolarPesos.TabIndex =  14 ;
			// 
			// txtResultEurosPesos
			// 
			txtResultEurosPesos.Location =  new Point(512, 92) ;
			txtResultEurosPesos.Name =  "txtResultEurosPesos" ;
			txtResultEurosPesos.ReadOnly =  true ;
			txtResultEurosPesos.Size =  new Size(118, 23) ;
			txtResultEurosPesos.TabIndex =  13 ;
			// 
			// txtCotzPeso
			// 
			txtCotzPeso.Location =  new Point(512, 30) ;
			txtCotzPeso.MaxLength =  12 ;
			txtCotzPeso.Name =  "txtCotzPeso" ;
			txtCotzPeso.Size =  new Size(118, 23) ;
			txtCotzPeso.TabIndex =  18 ;
			txtCotzPeso.Enter +=  txtCotzPeso_Enter ;
			txtCotzPeso.KeyPress +=  Cotizador_KeyPress ;
			// 
			// txtCotzDolar
			// 
			txtCotzDolar.Location =  new Point(392, 30) ;
			txtCotzDolar.MaxLength =  12 ;
			txtCotzDolar.Name =  "txtCotzDolar" ;
			txtCotzDolar.Size =  new Size(118, 23) ;
			txtCotzDolar.TabIndex =  17 ;
			txtCotzDolar.Enter +=  txtCotzDolar_Enter ;
			txtCotzDolar.KeyPress +=  Cotizador_KeyPress ;
			// 
			// txtCotzEuro
			// 
			txtCotzEuro.Location =  new Point(268, 30) ;
			txtCotzEuro.MaxLength =  12 ;
			txtCotzEuro.Name =  "txtCotzEuro" ;
			txtCotzEuro.Size =  new Size(118, 23) ;
			txtCotzEuro.TabIndex =  16 ;
			txtCotzEuro.Enter +=  txtCotzEuro_Enter ;
			txtCotzEuro.KeyPress +=  Cotizador_KeyPress ;
			// 
			// lblEuro
			// 
			lblEuro.AutoSize =  true ;
			lblEuro.Font =  new Font("JetBrains Mono ExtraBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point) ;
			lblEuro.Location =  new Point(2, 94) ;
			lblEuro.Name =  "lblEuro" ;
			lblEuro.Size =  new Size(50, 21) ;
			lblEuro.TabIndex =  19 ;
			lblEuro.Text =  "Euro" ;
			// 
			// lblCotizacion
			// 
			lblCotizacion.AutoSize =  true ;
			lblCotizacion.Font =  new Font("JetBrains Mono ExtraBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point) ;
			lblCotizacion.Location =  new Point(12, 32) ;
			lblCotizacion.Name =  "lblCotizacion" ;
			lblCotizacion.Size =  new Size(110, 21) ;
			lblCotizacion.TabIndex =  20 ;
			lblCotizacion.Text =  "Cotizacion" ;
			// 
			// lblPeso
			// 
			lblPeso.AutoSize =  true ;
			lblPeso.Font =  new Font("JetBrains Mono ExtraBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point) ;
			lblPeso.Location =  new Point(2, 155) ;
			lblPeso.Name =  "lblPeso" ;
			lblPeso.Size =  new Size(50, 21) ;
			lblPeso.TabIndex =  21 ;
			lblPeso.Text =  "Peso" ;
			// 
			// lblDolar
			// 
			lblDolar.AutoSize =  true ;
			lblDolar.Font =  new Font("JetBrains Mono ExtraBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point) ;
			lblDolar.Location =  new Point(2, 124) ;
			lblDolar.Name =  "lblDolar" ;
			lblDolar.Size =  new Size(60, 21) ;
			lblDolar.TabIndex =  22 ;
			lblDolar.Text =  "Dolar" ;
			// 
			// label5
			// 
			label5.AutoSize =  true ;
			label5.Font =  new Font("JetBrains Mono ExtraBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point) ;
			label5.Location =  new Point(301, 58) ;
			label5.Name =  "label5" ;
			label5.Size =  new Size(50, 21) ;
			label5.TabIndex =  23 ;
			label5.Text =  "Euro" ;
			// 
			// label6
			// 
			label6.AutoSize =  true ;
			label6.Font =  new Font("JetBrains Mono ExtraBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point) ;
			label6.Location =  new Point(418, 58) ;
			label6.Name =  "label6" ;
			label6.Size =  new Size(60, 21) ;
			label6.TabIndex =  24 ;
			label6.Text =  "Dolar" ;
			// 
			// label7
			// 
			label7.AutoSize =  true ;
			label7.Font =  new Font("JetBrains Mono ExtraBold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point) ;
			label7.Location =  new Point(550, 58) ;
			label7.Name =  "label7" ;
			label7.Size =  new Size(50, 21) ;
			label7.TabIndex =  25 ;
			label7.Text =  "Peso" ;
			// 
			// btnConvertEuros
			// 
			btnConvertEuros.Font =  new Font("JetBrains Mono SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point) ;
			btnConvertEuros.Location =  new Point(187, 91) ;
			btnConvertEuros.Name =  "btnConvertEuros" ;
			btnConvertEuros.Size =  new Size(75, 25) ;
			btnConvertEuros.TabIndex =  26 ;
			btnConvertEuros.Text =  "->" ;
			btnConvertEuros.UseVisualStyleBackColor =  true ;
			btnConvertEuros.Click +=  btnConvertEuros_Click ;
			// 
			// btnConvertDolares
			// 
			btnConvertDolares.Font =  new Font("JetBrains Mono SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point) ;
			btnConvertDolares.Location =  new Point(187, 121) ;
			btnConvertDolares.Name =  "btnConvertDolares" ;
			btnConvertDolares.Size =  new Size(75, 25) ;
			btnConvertDolares.TabIndex =  27 ;
			btnConvertDolares.Text =  "->" ;
			btnConvertDolares.UseVisualStyleBackColor =  true ;
			// 
			// btnConvertPesos
			// 
			btnConvertPesos.Font =  new Font("JetBrains Mono SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point) ;
			btnConvertPesos.Location =  new Point(187, 154) ;
			btnConvertPesos.Name =  "btnConvertPesos" ;
			btnConvertPesos.Size =  new Size(75, 25) ;
			btnConvertPesos.TabIndex =  28 ;
			btnConvertPesos.Text =  "->" ;
			btnConvertPesos.UseVisualStyleBackColor =  true ;
			// 
			// btnLockCotizacion
			// 
			btnLockCotizacion.IconChar =  FontAwesome.Sharp.IconChar.Lock ;
			btnLockCotizacion.IconColor =  Color.Black ;
			btnLockCotizacion.IconFont =  FontAwesome.Sharp.IconFont.Auto ;
			btnLockCotizacion.IconSize =  30 ;
			btnLockCotizacion.Location =  new Point(187, 21) ;
			btnLockCotizacion.Name =  "btnLockCotizacion" ;
			btnLockCotizacion.Size =  new Size(52, 47) ;
			btnLockCotizacion.TabIndex =  30 ;
			btnLockCotizacion.UseVisualStyleBackColor =  true ;
			btnLockCotizacion.Click +=  btnLockCotizacion_Click ;
			// 
			// Cotizador
			// 
			AutoScaleDimensions =  new SizeF(7F, 16F) ;
			AutoScaleMode =  AutoScaleMode.Font ;
			BackColor =  Color.LightGray ;
			ClientSize =  new Size(642, 192) ;
			Controls.Add(btnLockCotizacion);
			Controls.Add(btnConvertPesos);
			Controls.Add(btnConvertDolares);
			Controls.Add(btnConvertEuros);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(lblDolar);
			Controls.Add(lblPeso);
			Controls.Add(lblCotizacion);
			Controls.Add(lblEuro);
			Controls.Add(txtCotzPeso);
			Controls.Add(txtCotzDolar);
			Controls.Add(txtCotzEuro);
			Controls.Add(txtResultPesosPesos);
			Controls.Add(txtResultDolarPesos);
			Controls.Add(txtResultEurosPesos);
			Controls.Add(txtResultPesosDolar);
			Controls.Add(txtResultDolarDolar);
			Controls.Add(txtResultEurosDolar);
			Controls.Add(txtResultPesosEuro);
			Controls.Add(txtResultDolarEuro);
			Controls.Add(txtResultEurosEuros);
			Controls.Add(txtPesos);
			Controls.Add(txtDolares);
			Controls.Add(txtEuros);
			Font =  new Font("JetBrains Mono NL SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point) ;
			Icon =  ( Icon ) resources.GetObject("$this.Icon")  ;
			MaximizeBox =  false ;
			Name =  "Cotizador" ;
			Text =  "Cotizador" ;
			KeyPress +=  Cotizador_KeyPress ;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PrintPreviewDialog printPreviewDialog1;
		private TextBox txtEuros;
		private TextBox txtDolares;
		private TextBox txtPesos;
		private TextBox txtResultPesosEuro;
		private TextBox txtResultDolarEuro;
		private TextBox txtResultEurosEuros;
		private TextBox txtResultPesosDolar;
		private TextBox txtResultDolarDolar;
		private TextBox txtResultEurosDolar;
		private TextBox txtResultPesosPesos;
		private TextBox txtResultDolarPesos;
		private TextBox txtResultEurosPesos;
		private TextBox txtCotzPeso;
		private TextBox txtCotzDolar;
		private TextBox txtCotzEuro;
		private Label lblEuro;
		private Label lblCotizacion;
		private Label lblPeso;
		private Label lblDolar;
		private Label label5;
		private Label label6;
		private Label label7;
		private Button btnConvertEuros;
		private Button btnConvertDolares;
		private Button btnConvertPesos;
		private FontAwesome.Sharp.IconButton btnLockCotizacion;
	}
}