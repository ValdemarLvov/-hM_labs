using System;

namespace Lab1_ChM_UI
{
	static public class Equations
	{
		#region Equation 13

		static public double Eq13(double x) {
			return Math.Pow (x, 2) - 5 * Math.PI * Math.Sin(x) - 2 * x + 
			Math.PI * Math.Log10 (13 * Math.PI);
			
		}

		static public double Eq13Derivative1(double x) {
			return 2 * x - 5 * Math.PI * Math.Cos (x) - 2;
		}

		static public double Eq13Derivative2(double x) {
			return 5 * Math.PI * Math.Sin (x) + 2;
		}
			

		static public double Eq13Furier(double x){
			return Eq13 (x) * Eq13Derivative2 (x);
		}

		#endregion

		#region Equation 28

		public static double Eq28(double x){
			return 5 + Math.Pow (x, 7) * Math.Sin (x) -
			Math.Pow (x, 13) * Math.Cos (x) * Math.Sqrt (Math.PI - Math.Cos (Math.Pow (x, 3)));
		}

		public static double Eq28Derivative1(double x){
			return Math.Pow (x, 6) * Math.Sin (x) *
			(Math.Pow (x, 7) * Math.Sqrt (Math.PI - Math.Cos (Math.Pow (x, 3))) + 7) +
			Math.Cos (x) * (Math.Pow (x, 7) - (3 * Math.Pow (x, 15) * Math.Sin (Math.Pow (x, 3))) /
			(2 * Math.Sqrt (Math.PI - Math.Cos (Math.Pow (x, 3)))) -
			13 * Math.Pow (x, 12) * Math.Sqrt (Math.PI - Math.Cos (Math.Pow (x, 3))));
		}

		public static double Eq28Derivative2(double x){
			return 0;
		}

		#endregion

		#region Polinom
		// Значення полінома в точці х
		static public double Polinom(double x) {
			double res = 0;
			double[] coef = Coef ();
			for (int i = 0; i < coef.Length; i++) {
				res += coef [i] * Math.Pow (x, i);
			}

			return res;
		}

		// Значення першої похідної в точці х
		static public double PolinomDerivative1(double x){
			double[] coef = new double[] { 
				//-14, 426, -855, -2356, 2475, -1544, -638
				-638,-1544,2475,-2356, -855,426,-14	};
			double f = 0;
			for (int i = 0; i < coef.Length; i++) {
				f += coef [i] * Math.Pow (x, i);
			}
			return f;
		}

		// Значення другої похідної в точці х
		/*static public double PolinomDerivative2(double x){
			double[] coef = new double[] { 
				-2, 71, -171, -589, 825, 772, -638, -3
			};
			double f = 0;
			for (int i = 0; i < coef.Length; i++) {
				f += 2 * coef [i] * Math.Pow (x, i);
			}
			return f;
		}*/

		// Коефіцієнти полінома
		static public double[] Coef(){
			return new double[] {
				//-2, 71, -171, -589, 825, 772, -638, -3
				-3,-638,772,825,-589,-171,71,-2
			};
		}

		// Умова Фур'є
		/*
		static public double PolinomFourier(double x){
			return Polinom (x) * PolinomDerivative2 (x);
		}*/
		#endregion
	}
}

