using System;
using System.Text;
using System.Collections;
using Gtk;
using Lab1_ChM_UI;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void LobachevskyBtnClicked (object sender, EventArgs e)
	{
		double E = 0.001;

		try{
			E = Convert.ToDouble(entry3.Text);
		}catch(Exception ex){
			Console.WriteLine(ex.Message);
		}

		textview1.Buffer.Text = LobachevskogoMethod.GetString (E);

		LobachevskogoMethod.Kvadruvannya ();
	}

	protected void AdvancedLobachevskyBtnClicked (object sender, EventArgs e)
	{
		textview1.Buffer.Clear ();
		double x0, E;
		x0 = Convert.ToDouble (entry4.Text);
		E = Convert.ToDouble(entry3.Text);

		textview1.Buffer.Text = MethodHord.FindRootDotichnih (x0, E);

	}


	protected void ResetBtnClicked (object sender, EventArgs e)
	{
		LobachevskogoMethod.Reset ();
		LobachevskyBtnClicked (sender, e);
	}
	/*
	protected void LimitChangedLob (object sender, EventArgs e)
	{
		double a, b;
		a = Convert.ToDouble (entry1.Text);
		//b = Convert.ToDouble (entry2.Text);

		StringBuilder sb = new StringBuilder ();

		sb.AppendLine ("Перевірка умови Фур'є для границь проміжку локалізації:");
		sb.AppendFormat ("f(a)*f''(a)\t={0}\n", Equations.PolinomFourier (a));
		//sb.AppendFormat ("f(b)*f''(b)\t={0}\n", Equations.PolinomFourier (b));

		textview1.Buffer.Text = sb.ToString ();
	}

	protected void MPIBtnClicked (object sender, EventArgs e)
	{
		double a, b, E;
		a = Convert.ToDouble (entry14.Text);
		b = Convert.ToDouble (entry15.Text);
		E = Convert.ToDouble (entry16.Text);

		MPI.InitValues (a, b, E);
		textview1.Buffer.Text = MPI.FindRoot ();
	}



	protected void Local_Polinom_Clicked (object sender, EventArgs e){
		double a, b;
		a = Convert.ToDouble (entry1.Text);
		//b = Convert.ToDouble (entry2.Text);

		//textview1.Buffer.Text = Localization.LocalPolinom (a, b);
	}*/

	protected void HordButClicked (object sender, EventArgs e)
	{
		textview1.Buffer.Clear ();
		double a, b, E;
		a = Convert.ToDouble (entry20.Text);
		b = Convert.ToDouble (entry21.Text);
		E = Convert.ToDouble(entry22.Text);


		textview1.Buffer.Text = MethodHord.FindRootHord(a,b,E);

	}

	protected void OnButton4Clicked (object sender, EventArgs e)
	{
		textview1.Buffer.Clear ();
		double a, b, E;
		a = Convert.ToDouble (entry17.Text);
		b = Convert.ToDouble (entry18.Text);
		E = Convert.ToDouble(entry19.Text);


		textview1.Buffer.Text = MethodHord.FindRootHodrDotichnih(a,b,E);
	}

	protected void OnButton2Clicked (object sender, EventArgs e)
	{
		double a, b, E;
		a = Convert.ToDouble (entry14.Text);
		b = Convert.ToDouble (entry15.Text);
		E = Convert.ToDouble (entry16.Text);

		MPI.InitValues (a, b, E);
		textview1.Buffer.Text = MPI.FindRoot ();
	}
}