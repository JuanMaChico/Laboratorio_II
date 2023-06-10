namespace FrmTestDelegados
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
			btnActualizar = new Button();
			txtNombre = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// btnActualizar
			// 
			btnActualizar.Location = new Point(11, 80);
			btnActualizar.Name = "btnActualizar";
			btnActualizar.Size = new Size(205, 60);
			btnActualizar.TabIndex = 0;
			btnActualizar.Text = "Actualizar";
			btnActualizar.UseVisualStyleBackColor = true;
			// 
			// txtNombre
			// 
			txtNombre.Location = new Point(11, 29);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(205, 23);
			txtNombre.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(11, 11);
			label1.Name = "label1";
			label1.Size = new Size(51, 15);
			label1.TabIndex = 2;
			label1.Text = "Nombre";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(228, 152);
			Controls.Add(label1);
			Controls.Add(txtNombre);
			Controls.Add(btnActualizar);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnActualizar;
		private TextBox txtNombre;
		private Label label1;
	}
}