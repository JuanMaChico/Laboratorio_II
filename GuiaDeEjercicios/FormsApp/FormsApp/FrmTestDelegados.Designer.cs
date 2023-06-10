namespace FormsApp
{
	partial class FrmTestDelegados
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnActualizar = new Button();
			textBox1 = new TextBox();
			lblNombre = new Label();
			SuspendLayout();
			// 
			// btnActualizar
			// 
			btnActualizar.Location = new Point(12, 69);
			btnActualizar.Name = "btnActualizar";
			btnActualizar.Size = new Size(309, 59);
			btnActualizar.TabIndex = 0;
			btnActualizar.Text = "Actualizar";
			btnActualizar.UseVisualStyleBackColor = true;
			btnActualizar.Click += btnActualizar_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 40);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(309, 23);
			textBox1.TabIndex = 1;
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Location = new Point(12, 9);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(51, 15);
			lblNombre.TabIndex = 2;
			lblNombre.Text = "Nombre";
			// 
			// FrmTestDelegados
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(333, 140);
			Controls.Add(lblNombre);
			Controls.Add(textBox1);
			Controls.Add(btnActualizar);
			Name = "FrmTestDelegados";
			Text = "FrmTestDelegados";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnActualizar;
		private TextBox textBox1;
		private Label lblNombre;
	}
}