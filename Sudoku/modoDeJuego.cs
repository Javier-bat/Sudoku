using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
	
	public class ModoDeJuego : Sudoku
	{
		/// grillaSudoku, solucionadorSudoku y generarSudoki 
		/// son usados para armar la primera grilla 
		//esta clase inicializa un modo de juego determinado (el estandar en este caso)
		private GrillaSudoku grillaSudoku;
		private SolucionadorSudoku solucionadorSudoku;
		private generarSudoku generadorSudoku;
		public static int[,] esquema = new int[,]{{0,0,0,1,1,1,2,2,2},
												  {0,0,0,1,1,1,2,2,2},
												  {0,0,0,1,1,1,2,2,2},
												  {3,3,3,4,4,4,5,5,5},
												  {3,3,3,4,4,4,5,5,5},
									    		 	{3,3,3,4,4,4,5,5,5},
											    	{6,6,6,7,7,7,8,8,8},
													{6,6,6,7,7,7,8,8,8},
													{6,6,6,7,7,7,8,8,8}};


		//retorna modo de juego estndar
		public ModoDeJuego(Difficulty diff) : base(diff)
		{
			
			grillaSudoku = new GrillaSudoku();
			solucionadorSudoku = new SolucionadorSudoku();
			generadorSudoku = new generarSudoku(diff);

			generadorSudoku.InicializarGrilla();

			base.solucion = generadorSudoku.GrillaSolucion.grilla;
			base.mask = generadorSudoku.PermaGrilla.grilla;
			grillaUsuario.Initialize();
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					mask[i, j] = -mask[i, j];
					grillaUsuario[i, j] = mask[i, j];
				}
			}
		}

	}
}
