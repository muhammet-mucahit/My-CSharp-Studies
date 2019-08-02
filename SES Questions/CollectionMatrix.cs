using System;

/// <summary>
/// İki matrisi toplayan kod.
/// </summary>

namespace CollectionMatrix
{
	// Matris sinifimiz.
	public class Matrix
	{
		// Matrisimizin icindeki sayilari tutacak dizimiz, satir sayimiz ve sutun sayimiz.
		int[,] list;
		int row;
		int column;

		// Default constructor and normal constructor
		public Matrix(int rw = 2 , int col = 2 )
		{
			row = rw;
			column = col;
			list = new int[rw, col];
		}

		// Copy constructor
		public Matrix(Matrix mat)
		{
			row = mat.row;
			column = mat.column;
			list = new int[row, column];

			for(int i = 0; i < row; i++) {
				for (int j = 0; j < column; j++) {
					list [i, j] = mat.list [i, j];
				}
			}
		}

		// Matrisin icini dolduran fonksiyon.
		public void read()
		{
			for (int i = 0; i < row; i++) {
				for (int j = 0; j < column; j++) {
					Console.Write ("Matrix[{0},{1}]: ", i, j);
					list [i, j] = int.Parse (Console.ReadLine ());
				}
			}
		}

		// Matrisi ekrana yazdiran fonksiyon.
		public void print()
		{
			for (int i = 0; i < row; i++) {
				for (int j = 0; j < column; j++) {
					Console.Write (list [i, j] + " ");
				}
				Console.WriteLine ();
			}
		}

		// Iki matrisi toplayan fonksiyon.
		public static Matrix operator+(Matrix mat1, Matrix mat2)
		{
			Matrix temp = new Matrix(mat1.row, mat2.column);

			if(mat1.column == mat2.column && mat1.row == mat2.row) {

				for (int i = 0; i < mat1.row; i++) {
					for (int j = 0; j < mat1.column; j++) {
						temp.list [i, j] = mat1.list [i, j] + mat2.list [i, j];
					}
				}

				return temp;
			}

			return temp;
		}
	};

	class MainClass
	{
		public static void Main (string[] args)
		{
			Matrix first = new Matrix (2, 2);
			Matrix second = new Matrix (2, 3);
			Matrix third;

			Console.WriteLine ("Please enter the first matrix:");
			first.read ();		// Ilk matrisi kullanicidan aliyoruz.
			Console.WriteLine ("\nPlease enter the second matrix:");
			second.read ();		// Ikinci matrisi kullanicidan aliyoruz.

			// Birinci ve ikinci matrisi toplayip ucuncu matrise atiyoruz.
			third = first + second;

			// Sonucu ekrana bastiriyoruz eger iki matris toplanamiyorsa ekrana cikan matris 0 matris olacaktir.
			Console.WriteLine ("\nResult: ");
			third.print ();
		}
	}
}
