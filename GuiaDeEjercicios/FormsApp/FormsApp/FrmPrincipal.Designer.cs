﻿namespace FormsApp
{
	partial class FrmPrincipal
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
			menuInicio = new MenuStrip();
			altaToolStripMenuItem = new ToolStripMenuItem();
			testDelegadosToolStripMenuItem = new ToolStripMenuItem();
			mostrarToolStripMenuItem = new ToolStripMenuItem();
			menuInicio.SuspendLayout();
			SuspendLayout();
			// 
			// menuInicio
			// 
			menuInicio.Items.AddRange(new ToolStripItem[] { altaToolStripMenuItem, mostrarToolStripMenuItem });
			menuInicio.Location = new Point(0, 0);
			menuInicio.Name = "menuInicio";
			menuInicio.Size = new Size(599, 24);
			menuInicio.TabIndex = 1;
			menuInicio.Text = "menuInicio";
			// 
			// altaToolStripMenuItem
			// 
			altaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testDelegadosToolStripMenuItem });
			altaToolStripMenuItem.Name = "altaToolStripMenuItem";
			altaToolStripMenuItem.Size = new Size(40, 20);
			altaToolStripMenuItem.Text = "Alta";
			// 
			// testDelegadosToolStripMenuItem
			// 
			testDelegadosToolStripMenuItem.Name = "testDelegadosToolStripMenuItem";
			testDelegadosToolStripMenuItem.Size = new Size(152, 22);
			testDelegadosToolStripMenuItem.Text = "Test Delegados";
			testDelegadosToolStripMenuItem.Click += testDelegadosToolStripMenuItem_Click;
			// 
			// mostrarToolStripMenuItem
			// 
			mostrarToolStripMenuItem.Enabled = false;
			mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
			mostrarToolStripMenuItem.Size = new Size(60, 20);
			mostrarToolStripMenuItem.Text = "Mostrar";
			mostrarToolStripMenuItem.Click += mostrarToolStripMenuItem_Click;
			// 
			// FrmPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(599, 366);
			Controls.Add(menuInicio);
			IsMdiContainer = true;
			MainMenuStrip = menuInicio;
			Name = "FrmPrincipal";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "FrmPrincipal";
			Load += FrmPrincipal_Load;
			menuInicio.ResumeLayout(false);
			menuInicio.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuInicio;
		private ToolStripMenuItem altaToolStripMenuItem;
		private ToolStripMenuItem testDelegadosToolStripMenuItem;
		private ToolStripMenuItem mostrarToolStripMenuItem;
	}
}