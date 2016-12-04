using System;
using System.Text;

namespace Lab1_ChM_UI
{
	public static class Localization
	{
		public static string LocalEq13(double A, double B){
			StringBuilder sb = new StringBuilder ();

			sb.AppendLine ("Проміжки локалізації рівняння №13");

			double a = B;
			double b = B;

			while (a > A) {
				b = a;
				do {
					a -= 0.1;
					if(a < A) break;
				} while(Equations.Eq13 (a) * Equations.Eq13 (b) >= 0);

				if(a < A) break;
				b = a + 0.1;

				sb.AppendFormat ("[{0:F};{1:F}]\n", a, b);
			}

			return sb.ToString ();
		}

		public static string LocalEq28(double A, double B){
			StringBuilder sb = new StringBuilder ();

			sb.AppendLine ("Проміжки локалізації рівняння №28");

			double a = B;
			double b = B;

			while (a > A) {
				b = a;
				do {
					a -= 0.1;
					if(a < A) break;
				} while(Equations.Eq28 (a) * Equations.Eq28 (b) >= 0);

				if(a < A) break;
				b = a + 0.1;

				sb.AppendFormat ("[{0:F};{1:F}]\n", a, b);
			}

			return sb.ToString ();
		}

		public static string LocalPolinom(double A, double B){
			StringBuilder sb = new StringBuilder ();

			sb.AppendLine ("Проміжки локалізації полінома:");

			double a = B;
			double b = B;

			while (a > A) {
				b = a;
				do {
					a -= 0.1;
					if(a < A) break;
				} while(Equations.Polinom (a) * Equations.Polinom (b) >= 0);

				if(a < A) break;
				b = a + 0.1;

				sb.AppendFormat ("[{0:F};{1:F}]\n", a, b);
			}

			return sb.ToString ();
		}
	}
}

