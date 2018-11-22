using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
	
	public class GrillaSudoku : ICloneable
	{
		//grilla 
		public int[,] grilla;
		//numero de limite 
		private const int Max = 9;

		//creo grilla
		public GrillaSudoku()
		{
			grilla = new int[9, 9];
		}

		//establece las celdas
		public int inicializarCeldas(int filaA, int columnB, int valor)
		{
			int correcto = 0;
			bool validIndex = false;
			bool validNueva = false;

			//confirma una ubicacion validad
			if (filaA >= 0 && filaA < 9 && columnB >= 0 && columnB < 9)
			{
				validIndex = true;
			}

			//rango de las celdas
			if (valor >= -9 && valor <= 9)
			{
				validNueva = true;
			}

			// si todo es valido procedo
			if (validIndex && validNueva)
			{
				grilla[filaA, columnB] = valor;
				correcto = 1;
			}
			else
			{
				correcto = 0;
			}

			return (correcto);
		}

		
		//tambien establece celda pero valida que este dentro del rango 
		
		public int setearCeldaUsuario(int filaA, int columnB, int valor)
		{
			int correcto = 0;
			bool validIndex = false;
			bool validNueva = false;
			bool puedeRemplazarse = false;

			if (filaA >= 0 && filaA < 9 && columnB >= 0 && columnB < 9)
			{
				validIndex = true; //confirma localizacion vailida 
			}

			// vonfirma que el rango sea de 0 a 9 
			if (valor >= 0 && valor <= 9)
			{
				validNueva = true;
			}

			// confirma que el valor es ramplazable 
			if (grilla[filaA, columnB] >= 0)
			{
				puedeRemplazarse = true;
			}

			if (validIndex && validNueva && puedeRemplazarse)
			{
				grilla[filaA, columnB] = valor;
				correcto = 1;
			}
			else
			{
				correcto = 0;
			}

			return correcto;
		}


		/// Se asegura que no sea editable
		public void Termina()
		{
			for (var i = 0; i < Max; i++)
			{
				for (var j = 0; j < Max; j++)
				{
					grilla[i, j] = Math.Abs(grilla[i, j]) * -1;
				}
			}
		}

		//clona objeto interfaz clone
		public object Clone()
		{
			//abilito el clonado
			GrillaSudoku p = new GrillaSudoku();
			for (int i = 0; i < Max; i++)
			{
				for (int j = 0; j < Max; j++)
				{
					p.inicializarCeldas(i, j, grilla[i, j]);
				}
			}
			return p;
		}

		public bool estaEnBlanco()
		{
			var estaEnBlanco = true;
			for (var i = 0; i < Max; i++)
			{
				for (var j = 0; j < Max; j++)
				{
					if (grilla[i, j] != 0)
					{
						estaEnBlanco = false;
					}
				}
			}

			return estaEnBlanco;
		}
	}

}