using System;
using Gtk;

namespace Lab1_ChM_UI
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}

		public void funcTest(){
			
		}
	}
}
