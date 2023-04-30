namespace ModeloDeParcialEstacionamiento
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
			label3 =  new Label() ;
			comboBox1 =  new ComboBox() ;
			comboBox2 =  new ComboBox() ;
			textBox1 =  new TextBox() ;
			textBox2 =  new TextBox() ;
			button1 =  new Button() ;
			ltsVehiculo =  new ListBox() ;
			textBox3 =  new TextBox() ;
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize =  true ;
			label1.Font =  new Font("JetBrains Mono NL SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point) ;
			label1.Location =  new Point(27, 17) ;
			label1.Name =  "label1" ;
			label1.Size =  new Size(112, 17) ;
			label1.TabIndex =  0 ;
			label1.Text =  "Tipo Vehiculo" ;
			// 
			// label2
			// 
			label2.AutoSize =  true ;
			label2.Font =  new Font("JetBrains Mono NL SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point) ;
			label2.Location =  new Point(27, 50) ;
			label2.Name =  "label2" ;
			label2.Size =  new Size(64, 17) ;
			label2.TabIndex =  1 ;
			label2.Text =  "Patente" ;
			// 
			// label3
			// 
			label3.AutoSize =  true ;
			label3.Font =  new Font("JetBrains Mono NL SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point) ;
			label3.Location =  new Point(27, 83) ;
			label3.Name =  "label3" ;
			label3.Size =  new Size(80, 17) ;
			label3.TabIndex =  2 ;
			label3.Text =  "Tipo Moto" ;
			// 
			// comboBox1
			// 
			comboBox1.Font =  new Font("JetBrains Mono NL SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point) ;
			comboBox1.FormattingEnabled =  true ;
			comboBox1.Location =  new Point(145, 14) ;
			comboBox1.Name =  "comboBox1" ;
			comboBox1.Size =  new Size(138, 25) ;
			comboBox1.TabIndex =  3 ;
			// 
			// comboBox2
			// 
			comboBox2.Font =  new Font("JetBrains Mono NL SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point) ;
			comboBox2.FormattingEnabled =  true ;
			comboBox2.Location =  new Point(145, 79) ;
			comboBox2.Name =  "comboBox2" ;
			comboBox2.Size =  new Size(138, 25) ;
			comboBox2.TabIndex =  4 ;
			// 
			// textBox1
			// 
			textBox1.Font =  new Font("JetBrains Mono NL SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point) ;
			textBox1.Location =  new Point(145, 46) ;
			textBox1.Name =  "textBox1" ;
			textBox1.Size =  new Size(138, 25) ;
			textBox1.TabIndex =  5 ;
			// 
			// textBox2
			// 
			textBox2.Font =  new Font("JetBrains Mono NL SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point) ;
			textBox2.Location =  new Point(291, 79) ;
			textBox2.Name =  "textBox2" ;
			textBox2.Size =  new Size(126, 25) ;
			textBox2.TabIndex =  6 ;
			// 
			// button1
			// 
			button1.Font =  new Font("JetBrains Mono NL SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point) ;
			button1.Location =  new Point(27, 223) ;
			button1.Name =  "button1" ;
			button1.Size =  new Size(375, 97) ;
			button1.TabIndex =  7 ;
			button1.Text =  "Agregar Vehiculo" ;
			button1.UseVisualStyleBackColor =  true ;
			// 
			// ltsVehiculo
			// 
			ltsVehiculo.BackColor =  Color.FromArgb(      192  ,       255  ,       192  ) ;
			ltsVehiculo.Font =  new Font("JetBrains Mono NL SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point) ;
			ltsVehiculo.FormattingEnabled =  true ;
			ltsVehiculo.ItemHeight =  17 ;
			ltsVehiculo.Location =  new Point(423, 61) ;
			ltsVehiculo.Name =  "ltsVehiculo" ;
			ltsVehiculo.Size =  new Size(410, 259) ;
			ltsVehiculo.TabIndex =  8 ;
			// 
			// textBox3
			// 
			textBox3.BackColor =  Color.FromArgb(      192  ,       255  ,       192  ) ;
			textBox3.Font =  new Font("JetBrains Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point) ;
			textBox3.Location =  new Point(423, 12) ;
			textBox3.Name =  "textBox3" ;
			textBox3.Size =  new Size(410, 43) ;
			textBox3.TabIndex =  9 ;
			// 
			// FrmEstacionamiento
			// 
			AutoScaleDimensions =  new SizeF(8F, 17F) ;
			AutoScaleMode =  AutoScaleMode.Font ;
			BackColor =  SystemColors.ActiveCaption ;
			ClientSize =  new Size(845, 326) ;
			Controls.Add(textBox3);
			Controls.Add(ltsVehiculo);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(comboBox2);
			Controls.Add(comboBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Font =  new Font("JetBrains Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point) ;
			FormBorderStyle =  FormBorderStyle.FixedSingle ;
			MaximizeBox =  false ;
			MdiChildrenMinimizedAnchorBottom =  false ;
			MinimizeBox =  false ;
			Name =  "FrmEstacionamiento" ;
			StartPosition =  FormStartPosition.CenterScreen ;
			Text =  "Estacionamiendo" ;
			Load +=  FrmEstacionamiento_Load ;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private TextBox textBox1;
		private TextBox textBox2;
		private Button button1;
		private ListBox ltsVehiculo;
		private TextBox textBox3;
	}
}