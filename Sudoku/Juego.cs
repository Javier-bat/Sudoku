using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
	public enum Difficulty
	{
		Easy,
		Medium,
		Hard,
		devilmodSkere
	}
	public enum gameType
	{
		Standard
	}
	public partial class Juego : Form
	{
		private Color[,] ColorMap = new Color[9, 9];
		private ModoDeJuego modoDeJuego;
		private Sudoku sudoku;
		private int ticks = 0;

		public static int[,] CellMap;
		public static int LOCKED = 1;
		Difficulty dificultadElegida;

		public Juego(Difficulty dificultad)
		{
			InitializeComponent();
			this.CenterToScreen();
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.dificultadElegida = dificultad;
		
			startGame();
			if (dificultad ==Difficulty.devilmodSkere) {
				button1.Visible = false;
				buttonNewGame.Visible = false;
			}


		}
		public void setStandardTableView()
		{
			dataGridView1.RowCount = 9;
			dataGridView1.Rows[2].DividerHeight = 3;
			dataGridView1.Rows[5].DividerHeight = 3;
			for (int i = 0; i < 9; i++)
			{
				dataGridView1.Rows[i].Height = 50;
			}
			dataGridView1.Rows[2].Height = 50;
			dataGridView1.Rows[5].Height = 50;
			dataGridView1.Columns[2].DividerWidth = 6;
			dataGridView1.Columns[5].DividerWidth = 6;
			dataGridView1.Columns[2].Width = 50;
			dataGridView1.Columns[5].Width = 50;
		}
		/// <summary>
		/// Takes the value from the currently selected cell
		/// and highlights every occurrence of the same number in the grid
		/// </summary>
		public void highlightSelectedNumber()
		{
			var selected = dataGridView1.SelectedCells[0];
			int value = -1;


			if (int.TryParse(selected.Value.ToString(), out value) && value != 0)
			{
				for (int i = 0; i < 9; i++)
				{
					for (int j = 0; j < 9; j++)
					{
						int val = -1;

						if (int.TryParse(dataGridView1.Rows[i].Cells[j].Value.ToString(), out val) && val == value)
						{
							dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
						}
						else
						{
							dataGridView1.Rows[i].Cells[j].Style.BackColor = ColorMap[i, j];
						}
					}
				}
			}
		}
		/// <summary>
		/// Clears the highlighted cells.
		/// This is used when the newly selected cell has a different value from the previous or
		/// when the game is paused.
		/// </summary>
		public void clearHighlight()
		{
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
				}
			}
		}
		private void startGame()
		{
			this.Text += " "+dificultadElegida;
			modoDeJuego = null;
			
			sudoku = null;
			gameType type;
		
				setStandardTableView();
				type = gameType.Standard;

			Difficulty level = dificultadElegida;
	
		

			
			dataGridView1.Focus();
			dataGridView1.ClearSelection();
			clearHighlight();

			setGrid(type, level);

			ticks = sudoku.ticks;
			timer1.Start();
		}
		public void setGrid(gameType type, Difficulty level)
		{

			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					dataGridView1.Rows[i].Cells[j].Value = "";
				}
			}
			if (modoDeJuego != null || type == gameType.Standard)
			{
				if (modoDeJuego == null)
				{
					
					modoDeJuego = new ModoDeJuego(level);
					sudoku = modoDeJuego;
				}
				for (int i = 0; i < 9; i++)
				{
					for (int j = 0; j < 9; j++)
					{
						if (modoDeJuego.mask[i, j] != 0)
							dataGridView1.Rows[i].Cells[j].Value = modoDeJuego.mask[i, j];
						ColorMap[i, j] = Color.White;
					}
				}
				//this.Text += " - Standard " + (standard.diff == Difficulty.Easy ? "(easy) " : (standard.diff == Difficulty.Medium ? "(medium)" : "(hard)"));
			}
		
			LockCellMap();
		}
		public void LockCellMap()
		{
			CellMap = new int[9, 9];
			CellMap.Initialize();


			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					if (dataGridView1.Rows[i].Cells[j].Value != "")
					{
						CellMap[i, j] = LOCKED;
						dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#FFA1A1");
					}
					else
					{
						dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#61D465");
					}
				}
			}
		}
		private void Juego_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}
		private void textBox1_KeyPressed(object sender, KeyPressEventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void numericUpDown1_Click(object sender, EventArgs e)
		{
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (modoDeJuego == null) return;
			else highlightSelectedNumber();
		}

		private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (e.Control is DataGridViewTextBoxEditingControl)
			{
				DataGridViewTextBoxEditingControl tb = e.Control as DataGridViewTextBoxEditingControl;
				tb.KeyDown -= dataGridView1_KeyDown;
				tb.KeyDown += new KeyEventHandler(dataGridView1_KeyDown);
			}
		}
		public void ColorearAVerde()
		{
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
					//dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor = Color.LightGray;
					dataGridView1.Rows[i].Cells[j].Style.SelectionBackColor = Color.LightGreen;
					dataGridView1.Rows[i].Cells[j].Style.SelectionForeColor = Color.Black;
				}
			}
		}
		private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (modoDeJuego == null)
			{
				System.Media.SystemSounds.Asterisk.Play();
				return;
			}
			if (dataGridView1.SelectedCells.Count > 0)
			{
				var selected = dataGridView1.SelectedCells[0];
				int sel_i = selected.RowIndex;
				int sel_j = selected.ColumnIndex;
				if (CellMap[sel_i, sel_j] == LOCKED)
				{
					if (!(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
					{
						System.Media.SystemSounds.Asterisk.Play();
					}

					return;
				}
				if (!(e.KeyValue >= 49 && e.KeyValue <= 57 || e.KeyValue >= 97 && e.KeyValue <= 105))
				{
					if (e.KeyValue == 27 || e.KeyValue == 8 || e.KeyValue == 46)   // Same as e.KeyCode == Keys.Enter  etc.
					{
						selected.Value = "";
						if (modoDeJuego != null)
						{
							modoDeJuego.grillaUsuario[selected.RowIndex, selected.ColumnIndex] = 0;
						}
					
					}
					else if (!(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
					{
						System.Media.SystemSounds.Asterisk.Play();
					}
				}
				else
				{
					int value = -1;
					if (e.KeyValue >= 49 && e.KeyValue <= 57)
					{
						selected.Value = e.KeyValue - 48;
						value = e.KeyValue - 48;

					}
					else
					{
						selected.Value = e.KeyValue - 96;
						value = e.KeyValue - 96;
					}

					if (modoDeJuego != null)
						modoDeJuego.grillaUsuario[sel_i, sel_j] = value;
					

					highlightSelectedNumber();

				}

			}

			if ((modoDeJuego != null && Sudoku.estaResuelto(modoDeJuego.grillaUsuario, ModoDeJuego.esquema)))
			{


				timer1.Stop();
				ColorearAVerde();
				MessageBox.Show("FELICITACIONES ! NIVEL : "+dificultadElegida+" SUPERADO");

			
				modoDeJuego = null;

				sudoku = null;
			}

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			Form1 f1 = new Form1();
			f1.Show();

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			ticks++;
			if (sudoku != null)
			{
				sudoku.ticks++;

				Tiempo.Text = (new TimeSpan(sudoku.ticks * 1000000)).ToString();
			}
		}

		private void Juego_FormClosed(object sender, FormClosedEventArgs e)
		{

			



		}

		private void Juego_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}

		private void Tiempo_Click(object sender, EventArgs e)
		{

		}

		private void buttonNewGame_Click(object sender, EventArgs e)
		{
			buttonNewGame.Visible = false;
			buttonEasy.Visible = true;
			buttonMedium.Visible = true;
			buttonHard.Visible = true;
			
		}

		private void buttonEasy_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego(Difficulty.Easy);
			this.Hide();
			frm.Show();

		}

		private void buttonMedium_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego(Difficulty.Medium);
			this.Hide();
			frm.Show();
		}

		private void buttonHard_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego(Difficulty.Hard);
			this.Hide();
			frm.Show();
		}
	}
	}

