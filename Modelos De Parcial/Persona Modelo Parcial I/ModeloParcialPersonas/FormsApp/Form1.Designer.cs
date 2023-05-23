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
			lstAlumnosCreados = new ListBox();
			lstAlumnosInscriptosLaboratorio = new ListBox();
			lstAlumnosInscriptosProgramacion = new ListBox();
			grpAsignaMateria = new GroupBox();
			cmbMaterias = new ComboBox();
			label4 = new Label();
			btnAsignarMateria = new Button();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			grpAltaAlumno.SuspendLayout();
			grpAsignaMateria.SuspendLayout();
			SuspendLayout();
			// 
			// btnCrearAlumno
			// 
			btnCrearAlumno.Location = new Point(134, 87);
			btnCrearAlumno.Name = "btnCrearAlumno";
			btnCrearAlumno.Size = new Size(139, 27);
			btnCrearAlumno.TabIndex = 0;
			btnCrearAlumno.Text = "Crear Alumno";
			btnCrearAlumno.UseVisualStyleBackColor = true;
			btnCrearAlumno.Click += btnCrearAlumno_Click;
			// 
			// lblDni
			// 
			lblDni.AutoSize = true;
			lblDni.Location = new Point(53, 24);
			lblDni.Name = "lblDni";
			lblDni.Size = new Size(40, 17);
			lblDni.TabIndex = 1;
			lblDni.Text = "dni:";
			// 
			// lblApellido
			// 
			lblApellido.AutoSize = true;
			lblApellido.Location = new Point(160, 24);
			lblApellido.Name = "lblApellido";
			lblApellido.Size = new Size(80, 17);
			lblApellido.TabIndex = 2;
			lblApellido.Text = "Apellido:";
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Location = new Point(296, 24);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(64, 17);
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
			grpAltaAlumno.Location = new Point(166, 14);
			grpAltaAlumno.Name = "grpAltaAlumno";
			grpAltaAlumno.Size = new Size(415, 134);
			grpAltaAlumno.TabIndex = 4;
			grpAltaAlumno.TabStop = false;
			grpAltaAlumno.Text = "Alta Alumno";
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(265, 45);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(114, 25);
			txtNombre.TabIndex = 2;
			// 
			// txtApellido
			// 
			txtApellido.Location = new Point(144, 45);
			txtApellido.Name = "txtApellido";
			txtApellido.Size = new Size(114, 25);
			txtApellido.TabIndex = 1;
			// 
			// txtDni
			// 
			txtDni.Location = new Point(23, 45);
			txtDni.Name = "txtDni";
			txtDni.Size = new Size(114, 25);
			txtDni.TabIndex = 0;
			// 
			// lstAlumnosCreados
			// 
			lstAlumnosCreados.FormattingEnabled = true;
			lstAlumnosCreados.ItemHeight = 17;
			lstAlumnosCreados.Location = new Point(14, 218);
			lstAlumnosCreados.Name = "lstAlumnosCreados";
			lstAlumnosCreados.Size = new Size(172, 208);
			lstAlumnosCreados.TabIndex = 5;
			// 
			// lstAlumnosInscriptosLaboratorio
			// 
			lstAlumnosInscriptosLaboratorio.FormattingEnabled = true;
			lstAlumnosInscriptosLaboratorio.ItemHeight = 17;
			lstAlumnosInscriptosLaboratorio.Location = new Point(551, 218);
			lstAlumnosInscriptosLaboratorio.Name = "lstAlumnosInscriptosLaboratorio";
			lstAlumnosInscriptosLaboratorio.Size = new Size(172, 208);
			lstAlumnosInscriptosLaboratorio.TabIndex = 6;
			// 
			// lstAlumnosInscriptosProgramacion
			// 
			lstAlumnosInscriptosProgramacion.FormattingEnabled = true;
			lstAlumnosInscriptosProgramacion.ItemHeight = 17;
			lstAlumnosInscriptosProgramacion.Location = new Point(371, 218);
			lstAlumnosInscriptosProgramacion.Name = "lstAlumnosInscriptosProgramacion";
			lstAlumnosInscriptosProgramacion.Size = new Size(172, 208);
			lstAlumnosInscriptosProgramacion.TabIndex = 7;
			// 
			// grpAsignaMateria
			// 
			grpAsignaMateria.Controls.Add(cmbMaterias);
			grpAsignaMateria.Controls.Add(label4);
			grpAsignaMateria.Controls.Add(btnAsignarMateria);
			grpAsignaMateria.Location = new Point(193, 218);
			grpAsignaMateria.Name = "grpAsignaMateria";
			grpAsignaMateria.Size = new Size(171, 208);
			grpAsignaMateria.TabIndex = 5;
			grpAsignaMateria.TabStop = false;
			grpAsignaMateria.Text = "Asignar Materia";
			// 
			// cmbMaterias
			// 
			cmbMaterias.FormattingEnabled = true;
			cmbMaterias.Location = new Point(7, 67);
			cmbMaterias.Name = "cmbMaterias";
			cmbMaterias.Size = new Size(157, 25);
			cmbMaterias.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(48, 47);
			label4.Name = "label4";
			label4.Size = new Size(72, 17);
			label4.TabIndex = 1;
			label4.Text = "Materia:";
			// 
			// btnAsignarMateria
			// 
			btnAsignarMateria.Location = new Point(7, 124);
			btnAsignarMateria.Name = "btnAsignarMateria";
			btnAsignarMateria.Size = new Size(158, 56);
			btnAsignarMateria.TabIndex = 0;
			btnAsignarMateria.Text = "Asignar al alumno seleccionado";
			btnAsignarMateria.UseVisualStyleBackColor = true;
			btnAsignarMateria.Click += btnAsignarMateria_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(14, 198);
			label5.Name = "label5";
			label5.Size = new Size(128, 17);
			label5.TabIndex = 4;
			label5.Text = "Alumnos Creados";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(371, 198);
			label6.Name = "label6";
			label6.Size = new Size(144, 17);
			label6.TabIndex = 8;
			label6.Text = "Inscriptos Progra";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(551, 198);
			label7.Name = "label7";
			label7.Size = new Size(128, 17);
			label7.TabIndex = 9;
			label7.Text = "Inscriptos Labo";
			// 
			// FormAlumnos
			// 
			AutoScaleDimensions = new SizeF(8F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(737, 439);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(grpAsignaMateria);
			Controls.Add(lstAlumnosInscriptosProgramacion);
			Controls.Add(lstAlumnosInscriptosLaboratorio);
			Controls.Add(lstAlumnosCreados);
			Controls.Add(grpAltaAlumno);
			Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
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
		private ListBox lstAlumnosCreados;
		private ListBox lstAlumnosInscriptosLaboratorio;
		private ListBox lstAlumnosInscriptosProgramacion;
		private GroupBox grpAsignaMateria;
		private ComboBox cmbMaterias;
		private Label label4;
		private Button btnAsignarMateria;
		private Label label5;
		private Label label6;
		private Label label7;
	}
}