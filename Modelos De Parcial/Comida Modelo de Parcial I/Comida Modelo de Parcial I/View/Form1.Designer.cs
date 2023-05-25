namespace View
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
			txtDniCliente = new TextBox();
			lstHamburguesas = new ListBox();
			cmbGuarnicion = new ComboBox();
			cmbIngredientes = new ComboBox();
			grpIngredientes = new GroupBox();
			label4 = new Label();
			rdbGuarnicion = new RadioButton();
			btnAgregarIngrediente = new Button();
			rdbHamburguesa = new RadioButton();
			btnAgregarGuarnicion = new Button();
			label1 = new Label();
			rchTicket = new RichTextBox();
			label2 = new Label();
			label3 = new Label();
			grpIngredientes.SuspendLayout();
			SuspendLayout();
			// 
			// txtDniCliente
			// 
			txtDniCliente.Location = new Point(12, 37);
			txtDniCliente.Name = "txtDniCliente";
			txtDniCliente.Size = new Size(164, 23);
			txtDniCliente.TabIndex = 0;
			txtDniCliente.TextChanged += txtDniCliente_TextChanged;
			txtDniCliente.Leave += txtDniCliente_Leave;
			// 
			// lstHamburguesas
			// 
			lstHamburguesas.FormattingEnabled = true;
			lstHamburguesas.ItemHeight = 16;
			lstHamburguesas.Location = new Point(12, 100);
			lstHamburguesas.Name = "lstHamburguesas";
			lstHamburguesas.Size = new Size(221, 100);
			lstHamburguesas.TabIndex = 1;
			lstHamburguesas.DoubleClick += lstHamburguesas_DoubleClick;
			// 
			// cmbGuarnicion
			// 
			cmbGuarnicion.FormattingEnabled = true;
			cmbGuarnicion.Location = new Point(12, 244);
			cmbGuarnicion.Name = "cmbGuarnicion";
			cmbGuarnicion.Size = new Size(121, 24);
			cmbGuarnicion.TabIndex = 2;
			cmbGuarnicion.SelectedIndexChanged += cmbGuarnicion_SelectedIndexChanged;
			// 
			// cmbIngredientes
			// 
			cmbIngredientes.FormattingEnabled = true;
			cmbIngredientes.Location = new Point(18, 125);
			cmbIngredientes.Name = "cmbIngredientes";
			cmbIngredientes.Size = new Size(121, 24);
			cmbIngredientes.TabIndex = 3;
			// 
			// grpIngredientes
			// 
			grpIngredientes.Controls.Add(label4);
			grpIngredientes.Controls.Add(rdbGuarnicion);
			grpIngredientes.Controls.Add(btnAgregarIngrediente);
			grpIngredientes.Controls.Add(rdbHamburguesa);
			grpIngredientes.Controls.Add(cmbIngredientes);
			grpIngredientes.Location = new Point(239, 100);
			grpIngredientes.Name = "grpIngredientes";
			grpIngredientes.Size = new Size(192, 167);
			grpIngredientes.TabIndex = 4;
			grpIngredientes.TabStop = false;
			grpIngredientes.Text = "Ingredientes";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(18, 106);
			label4.Name = "label4";
			label4.Size = new Size(91, 16);
			label4.TabIndex = 11;
			label4.Text = "Ingredientes";
			// 
			// rdbGuarnicion
			// 
			rdbGuarnicion.AutoSize = true;
			rdbGuarnicion.Location = new Point(18, 70);
			rdbGuarnicion.Name = "rdbGuarnicion";
			rdbGuarnicion.Size = new Size(95, 20);
			rdbGuarnicion.TabIndex = 1;
			rdbGuarnicion.TabStop = true;
			rdbGuarnicion.Text = "Guarnicion";
			rdbGuarnicion.UseVisualStyleBackColor = true;
			// 
			// btnAgregarIngrediente
			// 
			btnAgregarIngrediente.Location = new Point(145, 124);
			btnAgregarIngrediente.Name = "btnAgregarIngrediente";
			btnAgregarIngrediente.Size = new Size(32, 25);
			btnAgregarIngrediente.TabIndex = 6;
			btnAgregarIngrediente.Text = "+";
			btnAgregarIngrediente.UseVisualStyleBackColor = true;
			btnAgregarIngrediente.Click += btnAgregarIngrediente_Click;
			// 
			// rdbHamburguesa
			// 
			rdbHamburguesa.AutoSize = true;
			rdbHamburguesa.Location = new Point(18, 43);
			rdbHamburguesa.Name = "rdbHamburguesa";
			rdbHamburguesa.Size = new Size(102, 20);
			rdbHamburguesa.TabIndex = 0;
			rdbHamburguesa.TabStop = true;
			rdbHamburguesa.Text = "Hamburguesa";
			rdbHamburguesa.UseVisualStyleBackColor = true;
			// 
			// btnAgregarGuarnicion
			// 
			btnAgregarGuarnicion.Location = new Point(151, 243);
			btnAgregarGuarnicion.Name = "btnAgregarGuarnicion";
			btnAgregarGuarnicion.Size = new Size(43, 25);
			btnAgregarGuarnicion.TabIndex = 5;
			btnAgregarGuarnicion.Text = "+";
			btnAgregarGuarnicion.UseVisualStyleBackColor = true;
			btnAgregarGuarnicion.Click += btnAgregarGuarnicion_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 18);
			label1.Name = "label1";
			label1.Size = new Size(35, 16);
			label1.TabIndex = 7;
			label1.Text = "Dni:";
			// 
			// rchTicket
			// 
			rchTicket.Location = new Point(12, 275);
			rchTicket.Name = "rchTicket";
			rchTicket.Size = new Size(454, 198);
			rchTicket.TabIndex = 8;
			rchTicket.Text = "";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 81);
			label2.Name = "label2";
			label2.Size = new Size(182, 16);
			label2.TabIndex = 9;
			label2.Text = "Seleccione su hamburguesa";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 225);
			label3.Name = "label3";
			label3.Size = new Size(175, 16);
			label3.TabIndex = 10;
			label3.Text = "Seleccione su guarnicion";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(478, 486);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(rchTicket);
			Controls.Add(label1);
			Controls.Add(btnAgregarGuarnicion);
			Controls.Add(grpIngredientes);
			Controls.Add(cmbGuarnicion);
			Controls.Add(lstHamburguesas);
			Controls.Add(txtDniCliente);
			Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "View";
			Load += Form1_Load;
			grpIngredientes.ResumeLayout(false);
			grpIngredientes.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtDniCliente;
		private ListBox lstHamburguesas;
		private ComboBox cmbGuarnicion;
		private ComboBox cmbIngredientes;
		private GroupBox grpIngredientes;
		private RadioButton rdbGuarnicion;
		private Button btnAgregarIngrediente;
		private RadioButton rdbHamburguesa;
		private Button btnAgregarGuarnicion;
		private Label label1;
		private RichTextBox rchTicket;
		private Label label2;
		private Label label3;
		private Label label4;
	}
}