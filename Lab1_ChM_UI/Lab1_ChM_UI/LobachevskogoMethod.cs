using System;
using System.Text;

namespace Lab1_ChM_UI
{
	static public class LobachevskogoMethod
	{
		/*
		 * a[] - масив коефіцієнтів (a[0] = a0, a[1] = a1 ...)
		 * x[] - масив коренів рівняння
		 * sign[] - масив знаків коренів рівняння (щоб можна було відновити знаки коренів 
		 * після квадрування)
		 * p - к-сть квадрувань
		*/
		static public double[] a, x, sign;
		static public int p = 0;

		/*
		 * Оскільки клас є статичним, ініціалізуємо всі статичні поля.
		 * Стандартною точністю приймаємо 0.0000001, за завданням лабораторної роботи
		*/
		static LobachevskogoMethod ()
		{
			a = Equations.Coef ();
			sign = new double[a.Length];
			x = new double[a.Length];
		}

		/*		  
		 * Повертає рядок, у якому вказано: кількість проведених квадрувань, 
		 * коефіцієнти рівняння на даний момент (змінюються з кожним 
		 * кроком квадрування), знайдені корені, а також повідомлення
		 * чи справдився критерій зупинки квадрування.
		 * 
		 * e - точність, що необхідна для перевірки критерію зупинки
		*/
		static public string GetString (double e)
		{
			StringBuilder sb = new StringBuilder();
			double R = 1.0 + (825.0 / 2.0);
			double r = 1.0 / (1.0 + (85.0 / 3.0));
			sb.AppendFormat ("[{0:F1}; {1:F4}]\n", R, r);
			sb.AppendFormat ("[-{1:F4}; -{0:F1}]\n", R, r);

			sb.AppendFormat ("Квадрування: {0}\n", LobachevskogoMethod.p);

			sb.AppendLine ("Коефіцієнти:");
			for (int i = a.Length - 1; i >= 0; i--) {
				sb.AppendFormat ("a{0}\t=\t{1}\n", i, a [i]);
			}
			sb.AppendLine ("---------------");

			sb.AppendLine ("Корені:");
			FindRoots ();
			for (int i = 1; i < x.Length; i++) {
				sb.AppendFormat ("x{0}\t=\t{1:F8}\n", i, sign[i]*x [i]);
			}
			sb.AppendLine ("---------------------------------------------");

			sb.AppendLine (Stop (e));

			return sb.ToString ();
		}

		/*
		 * Шукає корені після р квадрувань
		*/
		static void FindRoots(){
			int n = a.Length - 1;
			for (int i = 1; i <= n; i++) {

				x [i] = (-1) * a [n - i] / a [n - i + 1];

				if(p == 0) sign [i] = x [i] > 0 ? 1 : -1;

				x [i] = Math.Pow (Math.Abs(x [i]), (double)(1 / Math.Pow (2, p)));
			}
		}


		/*
		 * Змінює значення коефіцієнтів рівняння - a[] за формулою
		*/
		static public void Kvadruvannya(){
			double[] b = new double[a.Length];
			int n = a.Length - 1;
			double sum = 0;
			// Перший та останній коефіцієнти розраховуються інакше, ніж всі інші 
			b [0] = Math.Pow (a [0], 2);
			for (int k = 1; k < n; k++) {
				b [k] = Math.Pow (a [k], 2);
				sum = 0;
				for (int j = 1; j <= n - k; j++) {
					// Якщо справджуються наступні умови, то цей доданок = 0
					if (k - j < 0 || k + j > n) {
						continue;
					}
					sum += 2 * Math.Pow (-1, j) * a [k - j] * a [k + j];
				}
				b [k] += sum;
			}
			b [n] = Math.Pow (a [n], 2);

			p++;
			a = b;
		}


		static public string Stop(double E){
			double[] b = a;
			double res = 0;
			Kvadruvannya ();

			//Норма Евклида
			for (int i = 0; i < a.Length; i++) {
				res += Math.Pow ((1 - a [i] / Math.Pow (b [i], 2)), 2);
			}

			res = Math.Sqrt (res);

			a = b;
			p--;
			return string.Format("{0:F8} ? {1:F8}", res, E);
		}

		static public void Reset(){
			a = Equations.Coef();
			p = 0;
		}
	}
}

