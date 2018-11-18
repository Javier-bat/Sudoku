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
	public partial class Juego : Form
	{
		public Juego()
		{
			InitializeComponent();
			this.CenterToScreen();
			this.MaximizeBox = false;
			this.MinimizeBox = false;
		}

		private void Juego_Load(object sender, EventArgs e)
		{

		}
	}
}
