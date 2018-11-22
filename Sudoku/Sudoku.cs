using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sudoku
{
	
	public class Sudoku
	{
		//las que se llenaran
		public int[,] mask;
		//solucion
		public int[,] solucion;
		//las que llenara el usuario
		public int[,] grillaUsuario;
		//public int[,] forma;
		//dificultad
		public Difficulty diff;
		public int[,] filas;
		public int[,] columnas;
		public int[,] grupos;
		//marcar el tiempo
		public int ticks;

		//Objeto de tipo sudoku
		public Sudoku(Difficulty diff)
		{
			mask = new int[9, 9];
			solucion = new int[9, 9];
			grillaUsuario = new int[9, 9];
			filas = new int[10, 10];
			columnas = new int[10, 10];
			grupos = new int[10, 10];

			ticks = 0;
			this.diff = diff;
		}


		//chekea si esta el sudoku resuelto
		//retorna verdadero si esta resuelta y falso si no 
		public static bool estaResuelto(int[,] grilla, int[,] forma)
		{
			int[,] fila = new int[9, 10];
			int[,] columna = new int[9, 10];
			int[,] grupo = new int[9, 10];

			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					if (grilla[i, j] == 0) return false;

					if (fila[i, grilla[i, j]] == 1 || columna[j, grilla[i, j]] == 1 || grupo[forma[i, j], grilla[i, j]] == 1)
					{
						return false;
					}

					if (fila[i, grilla[i, j]] == 0)
					{
						fila[i, grilla[i, j]] = 1;
					}
					if (columna[j, grilla[i, j]] == 0)
					{
						columna[j, grilla[i, j]] = 1;
					}
					if (grupo[forma[i, j], grilla[i, j]] == 0)
					{
						grupo[forma[i, j], grilla[i, j]] = 1;
					}
				}
			}
			return true;
		}
	}
}
