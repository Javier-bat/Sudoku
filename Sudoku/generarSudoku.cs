using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
	
	public class generarSudoku
	{
		private SolucionadorSudoku solucionadorSudoku;
		public GrillaSudoku PermaGrilla;
		public GrillaSudoku GrillaSolucion;
		private Difficulty dificultad;

		//contructor
		public generarSudoku(Difficulty dificultad)
		{
			solucionadorSudoku = new SolucionadorSudoku();
			this.dificultad = dificultad;
		}
	//devuelve grilla resuelta
		public GrillaSudoku InicializarGrilla()
		{
			//rellena aleatoreamente primera fila y columna 
			GrillaSudoku tempGrilla = new GrillaSudoku { };       //grilla temporaria
			int fila = 0;                                    
			int col = 0;                                    
			int nuevoVal;                                     //valor para poner dentro de grilla
															
			List<int> setValor = new List<int>(Enumerable.Range(-9, 9));   //rango de numeros

			List<int> setValor2 = new List<int>();          
			Random rnd = new Random();                      //numero random
			int numRandom = 0;                             
			numRandom = rnd.Next(0, 8);                         
			nuevoVal = setValor[numRandom];
			tempGrilla.inicializarCeldas(fila, col, nuevoVal);
			setValor.Remove(nuevoVal);                        
			for (fila = 1; fila < 9; fila++)
			{
			
				numRandom = rnd.Next(0, setValor.Count);
				nuevoVal = setValor[numRandom];
				setValor2.Add(nuevoVal);
				setValor.Remove(nuevoVal);
				tempGrilla.inicializarCeldas(fila, col, nuevoVal);
			}
			fila = 0;                                             
			for (col = 1; col < 3; col++)
			{                                       
				numRandom = rnd.Next(0, setValor2.Count);
				nuevoVal = setValor2[numRandom];
				while ((nuevoVal == tempGrilla.grilla[1, 0] || (nuevoVal == tempGrilla.grilla[2, 0])))
				{
					numRandom = rnd.Next(0, setValor2.Count);
					nuevoVal = setValor2[numRandom];
				}
				setValor2.Remove(nuevoVal);
				tempGrilla.inicializarCeldas(fila, col, nuevoVal);
			}
			for (col = 3; col < 9; col++)
			{                                                
				numRandom = rnd.Next(0, setValor2.Count);
				nuevoVal = setValor2[numRandom];
				setValor2.Remove(nuevoVal);
				tempGrilla.inicializarCeldas(fila, col, nuevoVal);
			}
			do
			{
				solucionadorSudoku = new SolucionadorSudoku();
				solucionadorSudoku.resolverGrilla((GrillaSudoku)tempGrilla.Clone(), false); 
				GrillaSolucion = solucionadorSudoku.solucion;
			} while (GrillaSolucion == null || GrillaSolucion.estaEnBlanco());
			PermaGrilla = borrarCuadros(GrillaSolucion);     
			return PermaGrilla;         
		}

		


//toma el sudoku resuelto y le saca algunos numeros
		public GrillaSudoku borrarCuadros(GrillaSudoku grillaResuelta)
		{                          
			GrillaSudoku grillaTemporal;
			GrillaSudoku guardarCopia;

			bool unico = true;          
			int totalDeNumSacados = 0;                        
			int intentos = 0;                
			int espaciosEnBlancoDeseados;            //cantidad de espacios en blanco deseados
			int simetria = 0;                                   
			grillaTemporal = (GrillaSudoku)grillaResuelta.Clone();
			
			Random rnd = new Random();         

			switch (dificultad)           //cantidad de espacios en blancos deseados segun dificultad
			{
				case Difficulty.Easy: //easy 
					espaciosEnBlancoDeseados = 10;
					break;
				case Difficulty.Medium: //medium 
					espaciosEnBlancoDeseados = 25;
					break;
				case Difficulty.Hard: //hard 
					espaciosEnBlancoDeseados = 40;
					break;
				default: 
					espaciosEnBlancoDeseados = 60;
					break;
			}

			simetria = rnd.Next(0, 2);                   //selecciona simetria random 
			do
			{          
				guardarCopia = (GrillaSudoku)grillaTemporal.Clone();    
				grillaTemporal = borrarAzar(grillaTemporal, simetria, ref totalDeNumSacados);
				//borra 1 o 2 cuadros depende simetria
				solucionadorSudoku = new SolucionadorSudoku();
				unico = solucionadorSudoku.resolverGrilla((GrillaSudoku)grillaTemporal.Clone(), true);       
				if (!unico)
				{
					grillaTemporal = (GrillaSudoku)guardarCopia.Clone();
					intentos++;
				}
			} while ((totalDeNumSacados < espaciosEnBlancoDeseados) && (intentos < 1000));
			grillaResuelta = grillaTemporal;
			grillaResuelta.Termina();
			return grillaResuelta;
		}

		
		/// borra cuadros al azar
	
		public GrillaSudoku borrarAzar(GrillaSudoku grillaTemporal, int simetria, ref int cantidadDeBorrados)
		{
			
			Random rnd = new Random(); //genero num random 
			int fila = rnd.Next(0, 8); //selecciono fila random
			int column = rnd.Next(0, 8); //y columna
			while (grillaTemporal.grilla[fila, column] == 0) // no borro lo que ya este borrado
			{
				fila = rnd.Next(0, 8);
				column = rnd.Next(0, 8);
			}
			grillaTemporal.inicializarCeldas(fila, column, 0); 
			cantidadDeBorrados++; //incremento la contador
			switch (simetria)
			{
				
				case 0: //vertical
					if (grillaTemporal.grilla[fila, 8 - column] != 0) 
						cantidadDeBorrados++; 
					grillaTemporal.inicializarCeldas(fila, 8 - column, 0); 
					break;
				case 1: //horizontal
					if (grillaTemporal.grilla[8 - fila, column] != 0)
						cantidadDeBorrados++;
					grillaTemporal.inicializarCeldas(8 - fila, column, 0);
					break;
				case 2: //diagonal 
					if (grillaTemporal.grilla[column, fila] != 0)
						cantidadDeBorrados++;
					grillaTemporal.inicializarCeldas(column, fila, 0);
					break;
				default: //diagonal
					if (grillaTemporal.grilla[fila, 8 - column] != 0)
						cantidadDeBorrados++;
					grillaTemporal.inicializarCeldas(column, fila, 0);
					break;
			}
			return grillaTemporal;
		}

	}
}
