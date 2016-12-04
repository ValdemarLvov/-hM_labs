using System;
using System.Text;

namespace Lab1_ChM_UI
{
	public static class MPI
	{
		static double a, y, l, q, E, xk, xk1;
		static StringBuilder sb = new StringBuilder();

		static public void InitValues(double A, double B, double e){
			a = Equations.Eq13Derivative1 (A);
			y = Equations.Eq13Derivative1 (B);

			if (Math.Abs(a) > Math.Abs(y)) {
				double tmp = a;
				a = y;
				y = tmp;
			}

			l = 2 / (a + y);
			//q = (y - a) / (y + a);
			E = e;

			Random rnd = new Random ();
			xk = rnd.NextDouble () * (B - A) + A;
			xk1 = xk;

			sb.Clear ();
			sb.AppendFormat ("Проміжок:\t\t\t[{0};{1}]\n", A, B);
			sb.AppendFormat ("Початкова точка:\t{0:F8}\n", xk);
			sb.AppendLine ("------------------------------");
		}

		static void NextX_Fi(){
			sb.AppendFormat ("{0:F8}\n", xk);
			xk1 = xk - l * Equations.Eq13 (xk);
		}

		static bool Stop(){
			return (Math.Abs (xk1 - xk) < E);
		}

		static public string FindRoot(){
			do {
				xk = xk1;
				NextX_Fi ();
			} while (!Stop ());
			sb.AppendFormat ("----------\n{0:F8}", xk1);
			return sb.ToString ();
		}
	}
}

