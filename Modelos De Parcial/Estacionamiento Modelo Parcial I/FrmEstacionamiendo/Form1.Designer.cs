namespace FrmEstacionamiendo
{
	partial class FrmEstacionamiento
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
			label1 =  new Label() ;
			label2 =  new Label() ;
			lblTipoMoto =  new Label() ;
			cmbTipoVehiculo =  new ComboBox() ;
			cmbTipoMoto =  new ComboBox() ;
			txtPatente =  new TextBox() ;
			btnAgregar =  new Button() ;
			txtNombreEstacionamiento =  new TextBox() ;
			lstVehiculos =  new ListBox() ;
			txtMarca =  new TextBox() ;
			lblMarca =  new Label() ;
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize =  true ;
			label1.Location =  new Point(6, 27) ;
			label1.Name =  "label1" ;
			label1.Size =  new Size(78, 15) ;
			label1.TabIndex =  0 ;
			label1.Text =  "Tipo Vehiculo" ;
			// 
			// label2
			// 
			label2.AutoSize =  true ;
			label2.Location =  new Point(6, 66) ;
			label2.Name =  "label2" ;
			label2.Size =  new Size(47, 15) ;
			label2.TabIndex =  1 ;
			label2.Text =  "Patente" ;
			// 
			// lblTipoMoto
			// 
			lblTipoMoto.AutoSize =  true ;
			lblTipoMoto.Location =  new Point(6, 105) ;
			lblTipoMoto.Name =  "lblTipoMoto" ;
			lblTipoMoto.Size =  new Size(62, 15) ;
			lblTipoMoto.TabIndex =  2 ;
			lblTipoMoto.Text =  "Tipo Moto" ;
			// 
			// cmbTipoVehiculo
			// 
			cmbTipoVehiculo.DropDownStyle =  ComboBoxStyle.DropDownList ;
			cmbTipoVehiculo.FormattingEnabled =  true ;
			cmbTipoVehiculo.Location =  new Point(90, 24) ;
			cmbTipoVehiculo.Name =  "cmbTipoVehiculo" ;
			cmbTipoVehiculo.Size =  new Size(121, 23) ;
			cmbTipoVehiculo.TabIndex =  3 ;
			cmbTipoVehiculo.SelectedIndexChanged +=  cmbTipoVehiculo_SelectedIndexChanged ;
			// 
			// cmbTipoMoto
			// 
			cmbTipoMoto.DropDownStyle =  ComboBoxStyle.DropDownList ;
			cmbTipoMoto.FormattingEnabled =  true ;
			cmbTipoMoto.Location =  new Point(90, 102) ;
			cmbTipoMoto.Name =  "cmbTipoMoto" ;
			cmbTipoMoto.Size =  new Size(121, 23) ;
			cmbTipoMoto.TabIndex =  4 ;
			// 
			// txtPatente
			// 
			txtPatente.Location =  new Point(90, 63) ;
			txtPatente.MaxLength =  7 ;
			txtPatente.Name =  "txtPatente" ;
			txtPatente.Size =  new Size(121, 23) ;
			txtPatente.TabIndex =  5 ;
			// 
			// btnAgregar
			// 
			btnAgregar.BackColor =  SystemColors.ActiveCaption ;
			btnAgregar.Location =  new Point(90, 151) ;
			btnAgregar.Name =  "btnAgregar" ;
			btnAgregar.Size =  new Size(121, 37) ;
			btnAgregar.TabIndex =  6 ;
			btnAgregar.Text =  "Agregar Vehiculo" ;
			btnAgregar.UseVisualStyleBackColor =  false ;
			btnAgregar.Click +=  btnAgregar_Click ;
			// 
			// txtNombreEstacionamiento
			// 
			txtNombreEstacionamiento.BackColor =  Color.FromArgb(      192  ,       255  ,       192  ) ;
			txtNombreEstacionamiento.Location =  new Point(231, 24) ;
			txtNombreEstacionamiento.Name =  "txtNombreEstacionamiento" ;
			txtNombreEstacionamiento.ReadOnly =  true ;
			txtNombreEstacionamiento.Size =  new Size(253, 23) ;
			txtNombreEstacionamiento.TabIndex =  7 ;
			// 
			// lstVehiculos
			// 
			lstVehiculos.BackColor =  Color.FromArgb(      192  ,       255  ,       192  ) ;
			lstVehiculos.FormattingEnabled =  true ;
			lstVehiculos.ItemHeight =  15 ;
			lstVehiculos.Location =  new Point(231, 94) ;
			lstVehiculos.Name =  "lstVehiculos" ;
			lstVehiculos.Size =  new Size(253, 94) ;
			lstVehiculos.TabIndex =  8 ;
			lstVehiculos.DoubleClick +=  lstVehiculos_DoubleClick ;
			// 
			// txtMarca
			// 
			txtMarca.Location =  new Point(90, 102) ;
			txtMarca.Name =  "txtMarca" ;
			txtMarca.Size =  new Size(121, 23) ;
			txtMarca.TabIndex =  9 ;
			// 
			// lblMarca
			// 
			lblMarca.AutoSize =  true ;
			lblMarca.Location =  new Point(6, 105) ;
			lblMarca.Name =  "lblMarca" ;
			lblMarca.Size =  new Size(40, 15) ;
			lblMarca.TabIndex =  10 ;
			lblMarca.Text =  "Marca" ;
			lblMarca.TextAlign =  ContentAlignment.BottomCenter ;
			// 
			// FrmEstacionamiento
			// 
			AutoScaleDimensions =  new SizeF(7F, 15F) ;
			AutoScaleMode =  AutoScaleMode.Font ;
			BackColor =  SystemColors.ActiveCaption ;
			ClientSize =  new Size(496, 204) ;
			Controls.Add(lblMarca);
			Controls.Add(txtMarca);
			Controls.Add(lstVehiculos);
			Controls.Add(txtNombreEstacionamiento);
			Controls.Add(btnAgregar);
			Controls.Add(txtPatente);
			Controls.Add(cmbTipoMoto);
			Controls.Add(cmbTipoVehiculo);
			Controls.Add(lblTipoMoto);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle =  FormBorderStyle.FixedSingle ;
			MaximizeBox =  false ;
			MdiChildrenMinimizedAnchorBottom =  false ;
			MinimizeBox =  false ;
			Name =  "FrmEstacionamiento" ;
			StartPosition =  FormStartPosition.CenterScreen ;
			Text =  "Estacionamiento JMC" ;
			Load +=  FrmEstacionamiento_Load ;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label lblTipoMoto;
		private ComboBox cmbTipoVehiculo;
		private ComboBox cmbTipoMoto;
		private TextBox txtPatente;
		private Button btnAgregar;
		private TextBox txtNombreEstacionamiento;
		private ListBox lstVehiculos;
		private TextBox txtMarca;
		private Label lblMarca;
	}
}