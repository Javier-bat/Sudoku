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
	public partial class Form1 : Form
	{
		private int contador = 0;
		public Form1()
		{
			InitializeComponent();
			buttonEasy.Visible = false;
			buttonMedium.Visible = false;
			buttonHard.Visible = false;
			labelDificultad.Visible = false;
			this.CenterToScreen();
			this.Text = "MENU DE THE BEST JUEGO";
			this.MaximizeBox = false;
			this.MinimizeBox = false;


		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			button2.Visible = false;
			button1.Visible = false;
			buttonEasy.Visible = true;
			buttonMedium.Visible = true;
			buttonHard.Visible = true;
			labelDificultad.Visible = true;
			
			

			
		}

		private void buttonEasy_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego(Difficulty.Easy);
			frm.Show();
			this.Hide();
		}

		private void buttonMedium_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego(Difficulty.Medium);
			frm.Show();
			this.Hide();
		}

		private void buttonHard_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego(Difficulty.Hard);
			frm.Show();
			this.Hide();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
		
		}

		private void button1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '6')
			{
				contador++;
				if (contador==3) { 
					contador = 0;

					button2.Visible = false;
					button1.Visible = false;
					pictureBox2.Visible = true;
					labelDificultad.Visible = true;
					evilButton.Visible = true;
					pictureBox3.Visible = true;

				}
			}
		}

		private void evilButton_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego(Difficulty.devilmodSkere);
			frm.Show();
			this.Hide();
		}
	}
}
