namespace Sudoku
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonEasy = new System.Windows.Forms.Button();
			this.buttonMedium = new System.Windows.Forms.Button();
			this.buttonHard = new System.Windows.Forms.Button();
			this.labelDificultad = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(199, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 55);
			this.label1.TabIndex = 0;
			this.label1.Text = "SUDOKU";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(221, 259);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(182, 42);
			this.button1.TabIndex = 1;
			this.button1.Text = "New game";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(221, 325);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(182, 42);
			this.button2.TabIndex = 2;
			this.button2.Text = "Credits";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// buttonEasy
			// 
			this.buttonEasy.Location = new System.Drawing.Point(221, 194);
			this.buttonEasy.Name = "buttonEasy";
			this.buttonEasy.Size = new System.Drawing.Size(180, 42);
			this.buttonEasy.TabIndex = 3;
			this.buttonEasy.Text = "Easy";
			this.buttonEasy.UseVisualStyleBackColor = true;
			this.buttonEasy.Visible = false;
			this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
			// 
			// buttonMedium
			// 
			this.buttonMedium.Location = new System.Drawing.Point(223, 259);
			this.buttonMedium.Name = "buttonMedium";
			this.buttonMedium.Size = new System.Drawing.Size(180, 42);
			this.buttonMedium.TabIndex = 4;
			this.buttonMedium.Text = "Medium";
			this.buttonMedium.UseVisualStyleBackColor = true;
			this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
			// 
			// buttonHard
			// 
			this.buttonHard.Location = new System.Drawing.Point(223, 325);
			this.buttonHard.Name = "buttonHard";
			this.buttonHard.Size = new System.Drawing.Size(178, 42);
			this.buttonHard.TabIndex = 5;
			this.buttonHard.Text = "Hard";
			this.buttonHard.UseVisualStyleBackColor = true;
			this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
			// 
			// labelDificultad
			// 
			this.labelDificultad.AutoSize = true;
			this.labelDificultad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDificultad.Location = new System.Drawing.Point(218, 163);
			this.labelDificultad.Name = "labelDificultad";
			this.labelDificultad.Size = new System.Drawing.Size(138, 17);
			this.labelDificultad.TabIndex = 6;
			this.labelDificultad.Text = "Choose difficulty: ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 450);
			this.Controls.Add(this.labelDificultad);
			this.Controls.Add(this.buttonHard);
			this.Controls.Add(this.buttonMedium);
			this.Controls.Add(this.buttonEasy);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonEasy;
		private System.Windows.Forms.Button buttonMedium;
		private System.Windows.Forms.Button buttonHard;
		private System.Windows.Forms.Label labelDificultad;
	}
}

