namespace Sudoku
{
	partial class Juego
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
			if (disposing && (components != null))
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Tiempo = new System.Windows.Forms.Label();
			this.buttonNewGame = new System.Windows.Forms.Button();
			this.buttonEasy = new System.Windows.Forms.Button();
			this.buttonMedium = new System.Windows.Forms.Button();
			this.buttonHard = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ColumnHeadersVisible = false;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 20;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridView1.Size = new System.Drawing.Size(605, 563);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
			this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
			// 
			// Column1
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
			this.Column1.HeaderText = "Column1";
			this.Column1.MaxInputLength = 1;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column1.Width = 50;
			// 
			// Column2
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.Format = "N0";
			dataGridViewCellStyle3.NullValue = null;
			this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column2.HeaderText = "Column2";
			this.Column2.MaxInputLength = 1;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column2.Width = 50;
			// 
			// Column3
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.Format = "N0";
			dataGridViewCellStyle4.NullValue = null;
			this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
			this.Column3.HeaderText = "Column3";
			this.Column3.MaxInputLength = 1;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column3.Width = 50;
			// 
			// Column4
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
			this.Column4.HeaderText = "Column4";
			this.Column4.MaxInputLength = 1;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column4.Width = 50;
			// 
			// Column5
			// 
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
			this.Column5.HeaderText = "Column5";
			this.Column5.MaxInputLength = 1;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column5.Width = 50;
			// 
			// Column6
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Column6.DefaultCellStyle = dataGridViewCellStyle7;
			this.Column6.HeaderText = "Column6";
			this.Column6.MaxInputLength = 1;
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column6.Width = 50;
			// 
			// Column7
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.Format = "N0";
			dataGridViewCellStyle8.NullValue = null;
			this.Column7.DefaultCellStyle = dataGridViewCellStyle8;
			this.Column7.HeaderText = "Column7";
			this.Column7.MaxInputLength = 1;
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column7.Width = 50;
			// 
			// Column8
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.Format = "N0";
			dataGridViewCellStyle9.NullValue = null;
			this.Column8.DefaultCellStyle = dataGridViewCellStyle9;
			this.Column8.HeaderText = "Column8";
			this.Column8.MaxInputLength = 1;
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column8.Width = 50;
			// 
			// Column9
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.Format = "N0";
			dataGridViewCellStyle10.NullValue = null;
			this.Column9.DefaultCellStyle = dataGridViewCellStyle10;
			this.Column9.HeaderText = "Column9";
			this.Column9.MaxInputLength = 1;
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column9.Width = 50;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(628, 475);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 58);
			this.button1.TabIndex = 1;
			this.button1.Text = "Back";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Tiempo
			// 
			this.Tiempo.AutoSize = true;
			this.Tiempo.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Tiempo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Tiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
			this.Tiempo.Location = new System.Drawing.Point(628, 395);
			this.Tiempo.MaximumSize = new System.Drawing.Size(153, 37);
			this.Tiempo.Name = "Tiempo";
			this.Tiempo.Size = new System.Drawing.Size(143, 37);
			this.Tiempo.TabIndex = 2;
			this.Tiempo.Text = "00:00:00";
			this.Tiempo.Click += new System.EventHandler(this.Tiempo_Click);
			// 
			// buttonNewGame
			// 
			this.buttonNewGame.Location = new System.Drawing.Point(628, 61);
			this.buttonNewGame.Name = "buttonNewGame";
			this.buttonNewGame.Size = new System.Drawing.Size(143, 58);
			this.buttonNewGame.TabIndex = 3;
			this.buttonNewGame.Text = "New Game";
			this.buttonNewGame.UseVisualStyleBackColor = true;
			this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
			// 
			// buttonEasy
			// 
			this.buttonEasy.Location = new System.Drawing.Point(628, 60);
			this.buttonEasy.Name = "buttonEasy";
			this.buttonEasy.Size = new System.Drawing.Size(143, 58);
			this.buttonEasy.TabIndex = 4;
			this.buttonEasy.Text = "Easy";
			this.buttonEasy.UseVisualStyleBackColor = true;
			this.buttonEasy.Visible = false;
			this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
			// 
			// buttonMedium
			// 
			this.buttonMedium.Location = new System.Drawing.Point(628, 124);
			this.buttonMedium.Name = "buttonMedium";
			this.buttonMedium.Size = new System.Drawing.Size(143, 58);
			this.buttonMedium.TabIndex = 5;
			this.buttonMedium.Text = "Medium";
			this.buttonMedium.UseVisualStyleBackColor = true;
			this.buttonMedium.Visible = false;
			this.buttonMedium.Click += new System.EventHandler(this.buttonMedium_Click);
			// 
			// buttonHard
			// 
			this.buttonHard.Location = new System.Drawing.Point(628, 189);
			this.buttonHard.Name = "buttonHard";
			this.buttonHard.Size = new System.Drawing.Size(143, 58);
			this.buttonHard.TabIndex = 6;
			this.buttonHard.Text = "Hard";
			this.buttonHard.UseVisualStyleBackColor = true;
			this.buttonHard.Visible = false;
			this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
			// 
			// Juego
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 575);
			this.Controls.Add(this.buttonHard);
			this.Controls.Add(this.buttonMedium);
			this.Controls.Add(this.buttonEasy);
			this.Controls.Add(this.buttonNewGame);
			this.Controls.Add(this.Tiempo);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Juego";
			this.Text = "Juego";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Juego_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Juego_FormClosed);
			this.Load += new System.EventHandler(this.Juego_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label Tiempo;
		private System.Windows.Forms.Button buttonNewGame;
		private System.Windows.Forms.Button buttonEasy;
		private System.Windows.Forms.Button buttonMedium;
		private System.Windows.Forms.Button buttonHard;
	}
}