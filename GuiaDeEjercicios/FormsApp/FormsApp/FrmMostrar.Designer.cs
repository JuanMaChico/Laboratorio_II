﻿namespace FormsApp
{
	partial class FrmMostrar
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
			lblNombre = new Label();
			SuspendLayout();
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			lblNombre.Location = new Point(12, 25);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(123, 37);
			lblNombre.TabIndex = 0;
			lblNombre.Text = "Nombre";
			// 
			// FrmMostrar
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(389, 101);
			Controls.Add(lblNombre);
			Name = "FrmMostrar";
			Text = "FrmMostrar";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblNombre;
	}
}