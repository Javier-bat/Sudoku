using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{


	public class SolucionadorSudoku
	{
		public GrillaSudoku solucion;   // grilla solucion 
		int[] filasEnGrilla;                                //una fila de la grilla 
		bool[] list;                                  //Lista de resultados posibles
		GrillaSudoku[] final;                          //Solucion final
		int numSolns;                               //cantidad de soluciones posibles
		bool stop;                      //stop
		int recursiones;                       // numero de recursiones
		const int max = 1000;   //limite de recursiones


		public SolucionadorSudoku()
		{
			//inicializo 
			list = new bool[10];             
			filasEnGrilla = new int[9];
			final = new GrillaSudoku[2];
		}
		//se recorren las celdas para comprobar si esta resuelto
		//retorna verdadero si esta resuelto falso sino 
		public bool estaResuelto(GrillaSudoku grid)
		{
			bool result = true;                      
			int r, c;
			r = 0;
			while (result == true && r < 9)                   //chequeo todas las filas
			{
				c = 0;
				while (result == true && c < 9)            //chequeo todas las columnas
				{                //si uno esta vacio tiro falso 
					result = (result && grid.grilla[r, c] != 0);
					c++;
				}
				r++;
			}
			return result;
		}
		//devuelve el valor mas chico que puede ser insertado en una celda
		public int PrimerVerdadero()
		{
			int i = 1;
			int result = 0;
			while (result == 0 && i < 10)
			{
				if (list[i] == true) //cuando lo encuentra para
				{
					result = i;
				}
				i++;
			}
			return result;                       //retorna el resultado
		}
		/// pickeoUno elije un numero random para probar  si no da true lo incrementa hasta que encuentra un true
		//retorna entero para ser insertado en el sudoku 
		public int PickeoUno()
		{
			int i;
			int result = 0;
			Random r = new Random();
			if (PrimerVerdadero() != 0)                   //si da true el valor existe 
			{
				i = r.Next(1, 9); //valor del 0 al 8
				while (result == 0)
				{
					if (list[i] == true)     //si da true lo usa 
					{
						result = i;
					}
					else                  //sino lo incrementa
					{
						i++;
						if (i > 9)      //si llega al final empieza de nuevo 
						{
							i = 1;
						}
					}
				}
			}
			else
			{
				result = 0;// si no devuelve nunca true el puzle no puede ser resuelto
			}
			return result;
		}

		// chequea si el valor esta en la fila 
		public bool estaEnFila(GrillaSudoku grid, int fila, int valor)
		{
			bool result = false;
			for (int i = 0; i < 9; i++)                  
			{                         
				result = result || (Math.Abs(grid.grilla[fila, i]) == valor);
			}
			return result;
		}


		/// chequea si el valor esta en la columna

		public bool estaEnColumna(GrillaSudoku grilla, int col, int valor)
		{
			bool result = false;
			for (int i = 0; i < 9; i++)                
			{                         
				result = result || (Math.Abs(grilla.grilla[i, col]) == valor);
			}
			return result;
		}

		//determina y devuelve que tercio de la grilla se esta usando
		public int grupoDeNumeros(int rc)
		{
		
			int result;
			result = (int)(rc / 3); //trunca division
			return result;
		}
		
		//determina en que 3x3 esta
		//volores
		/// [0, 0]  [0, 1]  [0, 2]
		/// [1, 0]  [1, 1]  [1, 2]
		/// [2, 0]  [2, 1]  [2, 2]
		
		public bool estaEnEl3x3(GrillaSudoku g, int fila, int col, int valor)
		{
			int fMasChica;
			int cMasChica;
			fMasChica = 3 * grupoDeNumeros(fila);    //indice de la fila mas pequeña
			cMasChica = 3 * grupoDeNumeros(col);//indice de la columna mas pequeña
			bool result = false;
			for (int i = fMasChica; i < fMasChica + 3; i++) //chequea todas las filas en la subgrilla
			{
				for (int j = cMasChica; j < cMasChica + 3; j++)     //chekea todas las columnas en la subgrilla
				{           
					if (Math.Abs(g.grilla[i, j]) == valor)
					{
						result = true;
					}
				}
			}
			return result;
		}
	

		// retorna true si estaEnFila, estaEnColumna y estaEn3x3 return false
	
		public bool EsPosible(GrillaSudoku g, int fila, int col, int valor)
		{                     
			bool result;
			result = (!estaEnFila(g, fila, valor) && !estaEnColumna(g, col, valor) &&
				!estaEnEl3x3(g, fila, col, valor));
			return result;
		}
		
		public int ListaPosible(int row, int col, GrillaSudoku g)
		{
			int contador = 0;
			LimpiarLista();            
			for (int i = 1; i < 10; i++)         
			{
				if (EsPosible(g, row, col, i) == true)  
				{
					list[i] = true;
					contador++;
				}
				else                   
				{
					list[i] = false;
				}
			}
			return contador;
		}
		//rellenar 
		public void rellena(GrillaSudoku grid)
		{
			bool algunCambio = false;                    
			int numElegido;                          
			do            
			{
				algunCambio = false;
				for (int i = 0; i < 9; i++)         
				{
					for (int j = 0; j < 9; j++)  
					{
						if (grid.grilla[i, j] == 0)
						{      
							numElegido = ListaPosible(i, j, grid);
							if (numElegido == 1) 
							{
								grid.setearCeldaUsuario(i, j, PrimerVerdadero());
								
								algunCambio = (grid.grilla[i, j] != 0);
							}
						}
					}
				}
			} while (algunCambio == true && !estaResuelto(grid));
		}
//numero mas pequeño disponible entre las opciones
		public bool masPequeña(GrillaSudoku grilla, out int r, out int c,
			out int numElegido)
		{
			bool[] minList = new bool[10];
			int numCh, minR, minC, minimoNumeroElegido, i, j;
			bool mal, result;
			minimoNumeroElegido = 10;
			minR = 0;
			minC = 0;
			for (i = 1; i < 10; i++)              
			{
				minList[i] = false;
			}
			mal = false;
			i = 0;
			while (!mal && i < 9) 
			{
				j = 0;
				while (!mal && j < 9) 
				{
					if (grilla.grilla[i, j] == 0)
					{
						numCh = ListaPosible(i, j, grilla);   
						if (numCh == 0)    
						{
							mal = true;
						}
						else                           
						{
							if (numCh < minimoNumeroElegido)  
							{
								minimoNumeroElegido = numCh;          
								list.CopyTo(minList, 0);
								minR = i;          
								minC = j;          
							}
						}
					}
					j++;
				}
				i++;
			}
			if (mal || minimoNumeroElegido == 10)  
			{
				result = false;                    
				r = 0;
				c = 0;
				numElegido = 0;
			}
			else
			{
				result = true; 
				r = minR;
				c = minC;
				numElegido = minimoNumeroElegido;
				minList.CopyTo(list, 0);
			}
			return result;
		}
		//limpiar lista
		public void LimpiarLista()
		{
			for (int i = 0; i < 10; i++)
			{
				list[i] = false;
			}
		}
			//resolver grilla
		public bool resolverGrilla(GrillaSudoku g, bool chequearUnicidad)
		{
			GrillaSudoku grilla = new GrillaSudoku();
			grilla = (GrillaSudoku)g.Clone();                 
			int i, eleccion, r, c, numeroElegido;
			bool bien, got_one, resuelto, result;
			got_one = false;
			recursiones++;
			rellena(grilla);  
			if (estaResuelto(grilla))                       
			{
				if (numSolns > 0)               
				{
					stop = true;                  
					result = false;             
				}
				else                              
				{
					numSolns++;
					final[numSolns] = (GrillaSudoku)g.Clone(); 
					result = true;
					solucion = grilla;
				}
			}
			else                                            
			{
				if (!masPequeña(grilla, out r, out c, out numeroElegido))
				{
					result = false;                          
				}
				else                                 
				{
					i = 1;
					bien = false;
					got_one = false;
					while (!bien && i <= numeroElegido)
					{
						eleccion = PickeoUno();       
						list[eleccion] = false;      
						grilla.setearCeldaUsuario(r, c, eleccion);

						if (recursiones < max)
						{
							
							resuelto = (resolverGrilla(grilla, chequearUnicidad)); 
						}
						else
						{
							resuelto = false;
						}
						if (stop == true)
						{
							bien = true;
							got_one = true;
						}
						else
						{
							got_one = (got_one || resuelto);
							if (!chequearUnicidad) 
							{
								bien = got_one;       
							}
						}
						i++;
					}
					result = got_one;
				}
			}
			return result;
		}
	}
}