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
		public Form1()
		{
			InitializeComponent();
			buttonEasy.Visible = false;
			buttonMedium.Visible = false;
			buttonHard.Visible = false;
			labelDificultad.Visible = false;
			this.CenterToScreen();
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
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			

			
		}

		private void buttonEasy_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego();
			frm.Show();
			this.Hide();
		}

		private void buttonMedium_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego();
			frm.Show();
			this.Hide();
		}

		private void buttonHard_Click(object sender, EventArgs e)
		{
			Juego frm = new Juego();
			frm.Show();
			this.Hide();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
