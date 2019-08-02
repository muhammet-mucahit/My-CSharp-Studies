/// <summary>
/// Bir matrisi sabit sayiyla çarpan kod.
/// </summary>

namespace MultiplicationMatrixWithFixedNumber
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

		// Bir matrisi sabit sayiyla carpan fonksiyon. (operator)
		public static Matrix operator*(Matrix mat, int num)
		{
			Matrix temp = new Matrix(mat.row, mat.column);

			for (int i = 0; i < mat.row; i++) {
				for (int j = 0; j < mat.column; j++) {
					temp.list [i, j] = mat.list [i, j] * num;
				}
			}

			return temp;
		}
	};

	class MainClass
	{
		public static void Main (string[] args)
		{
			Matrix first = new Matrix (2, 2);
			Matrix second;
			int num;			// Matrisimizi bu sayiyla carpacagiz.

			Console.WriteLine ("Please enter the first matrix:");
			first.read ();		// Ilk matrisi kullanicidan aliyoruz.
			Console.WriteLine ("\nPlease enter the number that you want to multiple with matrix:");
			num = int.Parse (Console.ReadLine ());

			// Birinci matrisi sabit sayiyla carpip ikinci matrise atiyoruz.
			second = first * num;

			// Sonucu ekrana bastiriyoruz eger iki matris toplanamiyorsa ekrana cikan matris 0 matris olacaktir.
			Console.WriteLine ("\nResult: ");
			second.print ();
		}
	}
}
