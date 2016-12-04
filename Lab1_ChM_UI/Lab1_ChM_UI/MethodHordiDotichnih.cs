using System;
using System.Text;

namespace Lab1_ChM_UI
{
	public static class MethodHord
	{
		static double  a, b, E, c;
		static StringBuilder sb = new StringBuilder();


		static public string FindRootHord(double A, double B, double e){
			sb.Clear ();
			E = e;
			if (Equations.Eq13Derivative2 (A) * Equations.Eq13 (A) > 0) {
				a = A;
				b = B;

			} else {
				a = B;
				b = A;
			}

			sb.AppendFormat ("Проміжок:\t\t\t[{0};{1}]\n", A, B);
			sb.AppendLine ("------------------------------");

			double prev_b = 0;

			while(Math.Abs(Equations.Eq13 (b)-Equations.Eq13 (prev_b)) > E){
				c = b - (Equations.Eq13 (b) * (a - b)) / (Equations.Eq13 (a) - Equations.Eq13 (b));
				sb.AppendFormat ("{0:F10}\n", c);
				prev_b = b;
				b = c;
			}
			sb.AppendFormat ("----------\n{0:F8}", c);
				return sb.ToString();	
		}

		static public string FindRootDotichnih(double x, double e)
		{
			sb.Clear ();
			double xk1, xk, E = e;
			xk = x;
			xk1 =  xk - Equations.Polinom(xk) / Equations.PolinomDerivative1(xk);
			sb.AppendFormat("1){0:F10}\n", xk1);
			//Math.Abs (xk1 - xk) > E;
			int i= 2;
			do {
				xk = xk1;
				xk1 = xk - Equations.Polinom (xk) / Equations.PolinomDerivative1 (xk);
				sb.AppendFormat ("{0}) {1:F10}             Разность = {2:F10}\n", i, xk1, Math.Abs (xk1 - xk));
				i++;
			} while(Math.Abs (xk1 - xk) > E);
			return sb.ToString();	
		}

		static public string FindRootHodrDotichnih(double A, double B, double e){
			sb.Clear ();
			E = e;
			a = A;
			b = B;
			double c_hord, c_dot;

			sb.AppendFormat ("Проміжок:\t\t\t[{0};{1}]\n", A, B);
			sb.AppendLine ("------------------------------");

			c_hord = a - (Equations.Eq28 (a) * (b - a)) / (Equations.Eq28 (b) - Equations.Eq28 (a));
			a = c_hord;
			sb.AppendFormat ("{0:F10}", c_hord);

			c_dot = b - Equations.Eq28(b) / Equations.Eq28Derivative1(b);
			b = c_dot;
			sb.AppendFormat (" {0:F10}\n", c_dot);
			//sb.AppendFormat ("Разность:{0:F10}\n\n", Math.Abs( c_hord - c_dot));
			//sb.AppendFormat ("[{0:F10};{1:F10}]\n",a,b );
			//int i = 0; 

			while(Math.Abs(b-a) > E){
				//hord
				c_hord = b - (Equations.Eq28 (b) * (a - b)) / (Equations.Eq28 (a) - Equations.Eq28 (b));
				sb.AppendFormat ("{0:F10} ", c_hord);
				b = c_hord;
				//dotichnih
				c_dot = a - Equations.Eq28(a) / Equations.Eq28Derivative1(a);
				a = c_dot;
				sb.AppendFormat ("{0:F10}\n", c_dot);
				//sb.AppendFormat ("[{0:F10};{1:F10}]\n",a,b );
				//sb.AppendFormat ("Разность:{0:F10}\n", Math.Abs( c_hord - c_dot));

				//i++;
			}
			c = c_dot;
			sb.AppendFormat ("----------\n{0:F8}", c);
			return sb.ToString();	
		}
	}
}
