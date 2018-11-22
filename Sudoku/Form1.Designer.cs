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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonEasy = new System.Windows.Forms.Button();
			this.buttonMedium = new System.Windows.Forms.Button();
			this.buttonHard = new System.Windows.Forms.Button();
			this.labelDificultad = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.evilButton = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(305, 265);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(182, 42);
			this.button1.TabIndex = 1;
			this.button1.Text = "New game";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(305, 331);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(182, 42);
			this.button2.TabIndex = 2;
			this.button2.Text = "Credits";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// buttonEasy
			// 
			this.buttonEasy.Location = new System.Drawing.Point(303, 200);
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
			this.buttonMedium.Location = new System.Drawing.Point(303, 265);
			this.buttonMedium.Name = "buttonMedium";
			this.buttonMedium.Size = new System.Drawing.Size(180, 42);
			this.buttonMedium.TabIndex = 4;
			this.buttonMedium.Text = "Medium";
			this.buttonMedium.UseVisualStyleBackColor = true;
			this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
			// 
			// buttonHard
			// 
			this.buttonHard.Location = new System.Drawing.Point(303, 331);
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
			this.labelDificultad.Location = new System.Drawing.Point(300, 169);
			this.labelDificultad.Name = "labelDificultad";
			this.labelDificultad.Size = new System.Drawing.Size(138, 17);
			this.labelDificultad.TabIndex = 6;
			this.labelDificultad.Text = "Choose difficulty: ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = null;
			this.pictureBox1.Location = new System.Drawing.Point(94, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(658, 149);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// evilButton
			// 
			this.evilButton.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.evilButton.Location = new System.Drawing.Point(285, 200);
			this.evilButton.Name = "evilButton";
			this.evilButton.Size = new System.Drawing.Size(467, 238);
			this.evilButton.TabIndex = 8;
			this.evilButton.Text = "EVIL MODE SKEREEEEEE";
			this.evilButton.UseVisualStyleBackColor = true;
			this.evilButton.Visible = false;
			this.evilButton.Click += new System.EventHandler(this.evilButton_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(9, 185);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(273, 256);
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(94, 12);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(658, 148);
			this.pictureBox3.TabIndex = 10;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 450);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.evilButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelDificultad);
			this.Controls.Add(this.buttonHard);
			this.Controls.Add(this.buttonMedium);
			this.Controls.Add(this.buttonEasy);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonEasy;
		private System.Windows.Forms.Button buttonMedium;
		private System.Windows.Forms.Button buttonHard;
		private System.Windows.Forms.Label labelDificultad;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button evilButton;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}

