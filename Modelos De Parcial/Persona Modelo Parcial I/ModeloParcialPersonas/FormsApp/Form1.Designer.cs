namespace FormsApp
{
	partial class FormAlumnos
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
			btnCrearAlumno = new Button();
			lblDni = new Label();
			lblApellido = new Label();
			lblNombre = new Label();
			grpAltaAlumno = new GroupBox();
			txtNombre = new TextBox();
			txtApellido = new TextBox();
			txtDni = new TextBox();
			lstAlumnoCreados = new ListBox();
			lstAlumnosInscriptosLaboratorio = new ListBox();
			lstAlumnosInscriptosProgramacion = new ListBox();
			grpAsignaMateria = new GroupBox();
			cmbMaterias = new ComboBox();
			label4 = new Label();
			button2 = new Button();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			grpAltaAlumno.SuspendLayout();
			grpAsignaMateria.SuspendLayout();
			SuspendLayout();
			// 
			// btnCrearAlumno
			// 
			btnCrearAlumno.Location = new Point(117, 82);
			btnCrearAlumno.Name = "btnCrearAlumno";
			btnCrearAlumno.Size = new Size(122, 25);
			btnCrearAlumno.TabIndex = 0;
			btnCrearAlumno.Text = "Crear Alumno";
			btnCrearAlumno.UseVisualStyleBackColor = true;
			// 
			// lblDni
			// 
			lblDni.AutoSize = true;
			lblDni.Location = new Point(46, 23);
			lblDni.Name = "lblDni";
			lblDni.Size = new Size(35, 16);
			lblDni.TabIndex = 1;
			lblDni.Text = "dni:";
			// 
			// lblApellido
			// 
			lblApellido.AutoSize = true;
			lblApellido.Location = new Point(140, 23);
			lblApellido.Name = "lblApellido";
			lblApellido.Size = new Size(70, 16);
			lblApellido.TabIndex = 2;
			lblApellido.Text = "Apellido:";
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Location = new Point(259, 23);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(56, 16);
			lblNombre.TabIndex = 3;
			lblNombre.Text = "Nombre:";
			// 
			// grpAltaAlumno
			// 
			grpAltaAlumno.Controls.Add(lblDni);
			grpAltaAlumno.Controls.Add(lblNombre);
			grpAltaAlumno.Controls.Add(txtNombre);
			grpAltaAlumno.Controls.Add(lblApellido);
			grpAltaAlumno.Controls.Add(txtApellido);
			grpAltaAlumno.Controls.Add(txtDni);
			grpAltaAlumno.Controls.Add(btnCrearAlumno);
			grpAltaAlumno.Location = new Point(145, 13);
			grpAltaAlumno.Name = "grpAltaAlumno";
			grpAltaAlumno.Size = new Size(363, 126);
			grpAltaAlumno.TabIndex = 4;
			grpAltaAlumno.TabStop = false;
			grpAltaAlumno.Text = "Alta Alumno";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(232, 42);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(100, 23);
			txtNombre.TabIndex = 2;
			// 
			// txtApellido
			// 
			txtApellido.Location = new Point(126, 42);
			txtApellido.Name = "txtApellido";
			txtApellido.Size = new Size(100, 23);
			txtApellido.TabIndex = 1;
			// 
			// txtDni
			// 
			txtDni.Location = new Point(20, 42);
			txtDni.Name = "txtDni";
			txtDni.Size = new Size(100, 23);
			txtDni.TabIndex = 0;
			// 
			// lstAlumnoCreados
			// 
			lstAlumnoCreados.FormattingEnabled = true;
			lstAlumnoCreados.ItemHeight = 16;
			lstAlumnoCreados.Location = new Point(12, 205);
			lstAlumnoCreados.Name = "lstAlumnoCreados";
			lstAlumnoCreados.Size = new Size(151, 196);
			lstAlumnoCreados.TabIndex = 5;
			// 
			// lstAlumnosInscriptosLaboratorio
			// 
			lstAlumnosInscriptosLaboratorio.FormattingEnabled = true;
			lstAlumnosInscriptosLaboratorio.ItemHeight = 16;
			lstAlumnosInscriptosLaboratorio.Location = new Point(325, 205);
			lstAlumnosInscriptosLaboratorio.Name = "lstAlumnosInscriptosLaboratorio";
			lstAlumnosInscriptosLaboratorio.Size = new Size(151, 196);
			lstAlumnosInscriptosLaboratorio.TabIndex = 6;
			// 
			// lstAlumnosInscriptosProgramacion
			// 
			lstAlumnosInscriptosProgramacion.FormattingEnabled = true;
			lstAlumnosInscriptosProgramacion.ItemHeight = 16;
			lstAlumnosInscriptosProgramacion.Location = new Point(482, 205);
			lstAlumnosInscriptosProgramacion.Name = "lstAlumnosInscriptosProgramacion";
			lstAlumnosInscriptosProgramacion.Size = new Size(151, 196);
			lstAlumnosInscriptosProgramacion.TabIndex = 7;
			// 
			// grpAsignaMateria
			// 
			grpAsignaMateria.Controls.Add(cmbMaterias);
			grpAsignaMateria.Controls.Add(label4);
			grpAsignaMateria.Controls.Add(button2);
			grpAsignaMateria.Location = new Point(169, 205);
			grpAsignaMateria.Name = "grpAsignaMateria";
			grpAsignaMateria.Size = new Size(150, 196);
			grpAsignaMateria.TabIndex = 5;
			grpAsignaMateria.TabStop = false;
			grpAsignaMateria.Text = "Asignar Materia";
			// 
			// cmbMaterias
			// 
			cmbMaterias.FormattingEnabled = true;
			cmbMaterias.Location = new Point(6, 63);
			cmbMaterias.Name = "cmbMaterias";
			cmbMaterias.Size = new Size(138, 24);
			cmbMaterias.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(42, 44);
			label4.Name = "label4";
			label4.Size = new Size(63, 16);
			label4.TabIndex = 1;
			label4.Text = "Materia:";
			// 
			// button2
			// 
			button2.Location = new Point(6, 117);
			button2.Name = "button2";
			button2.Size = new Size(138, 53);
			button2.TabIndex = 0;
			button2.Text = "Asignar al alumno seleccionado";
			button2.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 186);
			label5.Name = "label5";
			label5.Size = new Size(112, 16);
			label5.TabIndex = 4;
			label5.Text = "Alumnos Creados";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(325, 186);
			label6.Name = "label6";
			label6.Size = new Size(126, 16);
			label6.TabIndex = 8;
			label6.Text = "Inscriptos Progra";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(482, 186);
			label7.Name = "label7";
			label7.Size = new Size(112, 16);
			label7.TabIndex = 9;
			label7.Text = "Inscriptos Labo";
			// 
			// FormAlumnos
			// 
			AutoScaleDimensions = new SizeF(7F, 16F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(645, 413);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(grpAsignaMateria);
			Controls.Add(lstAlumnosInscriptosProgramacion);
			Controls.Add(lstAlumnosInscriptosLaboratorio);
			Controls.Add(lstAlumnoCreados);
			Controls.Add(grpAltaAlumno);
			Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
			MaximizeBox = false;
			MdiChildrenMinimizedAnchorBottom = false;
			MinimizeBox = false;
			Name = "FormAlumnos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Alumnos";
			Load += FormAlumnos_Load;
			grpAltaAlumno.ResumeLayout(false);
			grpAltaAlumno.PerformLayout();
			grpAsignaMateria.ResumeLayout(false);
			grpAsignaMateria.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCrearAlumno;
		private Label lblDni;
		private Label lblApellido;
		private Label lblNombre;
		private GroupBox grpAltaAlumno;
		private TextBox txtNombre;
		private TextBox txtApellido;
		private TextBox txtDni;
		private ListBox lstAlumnoCreados;
		private ListBox lstAlumnosInscriptosLaboratorio;
		private ListBox lstAlumnosInscriptosProgramacion;
		private GroupBox grpAsignaMateria;
		private ComboBox cmbMaterias;
		private Label label4;
		private Button button2;
		private Label label5;
		private Label label6;
		private Label label7;
	}
}