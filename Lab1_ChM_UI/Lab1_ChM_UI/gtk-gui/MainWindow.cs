
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HPaned hpaned4;
	
	private global::Gtk.VBox vbox5;
	
	private global::Gtk.VBox vbox10;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Label label2;
	
	private global::Gtk.Button button1;
	
	private global::Gtk.HBox hbox18;
	
	private global::Gtk.Button button8;
	
	private global::Gtk.Button button5;
	
	private global::Gtk.HBox hbox17;
	
	private global::Gtk.Label label23;
	
	private global::Gtk.HBox hbox19;
	
	private global::Gtk.VBox vbox12;
	
	private global::Gtk.Label label32;
	
	private global::Gtk.Button button6;
	
	private global::Gtk.VBox vbox11;
	
	private global::Gtk.HBox hbox20;
	
	private global::Gtk.Label label24;
	
	private global::Gtk.Entry entry4;
	
	private global::Gtk.HBox hbox21;
	
	private global::Gtk.Label label5;
	
	private global::Gtk.Label label6;
	
	private global::Gtk.HBox hbox22;
	
	private global::Gtk.Entry entry3;
	
	private global::Gtk.HBox hbox6;
	
	private global::Gtk.VBox vbox6;
	
	private global::Gtk.Label label9;
	
	private global::Gtk.Label label22;
	
	private global::Gtk.Button button3;
	
	private global::Gtk.VBox vbox7;
	
	private global::Gtk.HBox hbox7;
	
	private global::Gtk.Label label11;
	
	private global::Gtk.Entry entry20;
	
	private global::Gtk.Label label12;
	
	private global::Gtk.Entry entry21;
	
	private global::Gtk.HBox hbox9;
	
	private global::Gtk.Label label13;
	
	private global::Gtk.Entry entry22;
	
	private global::Gtk.HBox hbox10;
	
	private global::Gtk.VBox vbox8;
	
	private global::Gtk.Label label19;
	
	private global::Gtk.Label label31;
	
	private global::Gtk.Button button4;
	
	private global::Gtk.VBox vbox9;
	
	private global::Gtk.HBox hbox11;
	
	private global::Gtk.Label label14;
	
	private global::Gtk.Entry entry17;
	
	private global::Gtk.Label label15;
	
	private global::Gtk.Entry entry18;
	
	private global::Gtk.HBox hbox13;
	
	private global::Gtk.Label label16;
	
	private global::Gtk.Entry entry19;
	
	private global::Gtk.HBox hbox14;
	
	private global::Gtk.HBox hbox2;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.Label label21;
	
	private global::Gtk.Button button2;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.HBox hbox3;
	
	private global::Gtk.Label label25;
	
	private global::Gtk.Entry entry14;
	
	private global::Gtk.HBox hbox4;
	
	private global::Gtk.Label label29;
	
	private global::Gtk.Entry entry15;
	
	private global::Gtk.HBox hbox5;
	
	private global::Gtk.Label label30;
	
	private global::Gtk.Entry entry16;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.Label label1;
	
	private global::Gtk.ScrolledWindow scrolledwindow1;
	
	private global::Gtk.TextView textview1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.WidthRequest = 1000;
		this.HeightRequest = 650;
		this.CanDefault = true;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Чисельні методи. Лабораторна робота №1");
		this.Icon = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./icon.ico"));
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		this.AllowGrow = false;
		this.DefaultWidth = 1000;
		this.DefaultHeight = 600;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hpaned4 = new global::Gtk.HPaned ();
		this.hpaned4.CanFocus = true;
		this.hpaned4.Name = "hpaned4";
		this.hpaned4.Position = 562;
		// Container child hpaned4.Gtk.Paned+PanedChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		this.vbox5.BorderWidth = ((uint)(6));
		// Container child vbox5.Gtk.Box+BoxChild
		this.vbox10 = new global::Gtk.VBox ();
		this.vbox10.Name = "vbox10";
		this.vbox10.Spacing = 6;
		this.vbox10.BorderWidth = ((uint)(18));
		// Container child vbox10.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Метод Лобачевського");
		this.hbox1.Add (this.label2);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label2]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button ();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString ("Теорема Вієта/Скинути квадрування");
		this.hbox1.Add (this.button1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button1]));
		w2.PackType = ((global::Gtk.PackType)(1));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.vbox10.Add (this.hbox1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hbox1]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.hbox18 = new global::Gtk.HBox ();
		this.hbox18.Name = "hbox18";
		this.hbox18.Spacing = 6;
		// Container child hbox18.Gtk.Box+BoxChild
		this.button8 = new global::Gtk.Button ();
		this.button8.CanFocus = true;
		this.button8.Name = "button8";
		this.button8.UseUnderline = true;
		this.button8.Label = global::Mono.Unix.Catalog.GetString ("-2x^7 + 71x^6 -171x^5 - 589x^4 + 825x^3 +772x^2 - 638x - 3");
		this.hbox18.Add (this.button8);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox18 [this.button8]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox18.Gtk.Box+BoxChild
		this.button5 = new global::Gtk.Button ();
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString ("Квадрувати");
		this.hbox18.Add (this.button5);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox18 [this.button5]));
		w5.PackType = ((global::Gtk.PackType)(1));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox10.Add (this.hbox18);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hbox18]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.hbox17 = new global::Gtk.HBox ();
		this.hbox17.Name = "hbox17";
		this.hbox17.Spacing = 6;
		// Container child hbox17.Gtk.Box+BoxChild
		this.label23 = new global::Gtk.Label ();
		this.label23.Name = "label23";
		this.label23.LabelProp = global::Mono.Unix.Catalog.GetString ("Уточнення");
		this.hbox17.Add (this.label23);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox17 [this.label23]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox10.Add (this.hbox17);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hbox17]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox10.Gtk.Box+BoxChild
		this.hbox19 = new global::Gtk.HBox ();
		this.hbox19.Name = "hbox19";
		this.hbox19.Spacing = 6;
		// Container child hbox19.Gtk.Box+BoxChild
		this.vbox12 = new global::Gtk.VBox ();
		this.vbox12.Name = "vbox12";
		this.vbox12.Spacing = 6;
		// Container child vbox12.Gtk.Box+BoxChild
		this.label32 = new global::Gtk.Label ();
		this.label32.Name = "label32";
		this.label32.LabelProp = global::Mono.Unix.Catalog.GetString ("Метод дотичних");
		this.vbox12.Add (this.label32);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.label32]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox12.Gtk.Box+BoxChild
		this.button6 = new global::Gtk.Button ();
		this.button6.WidthRequest = 230;
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = global::Mono.Unix.Catalog.GetString ("Знайти корінь");
		this.vbox12.Add (this.button6);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox12 [this.button6]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		this.hbox19.Add (this.vbox12);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox19 [this.vbox12]));
		w11.Position = 0;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbox19.Gtk.Box+BoxChild
		this.vbox11 = new global::Gtk.VBox ();
		this.vbox11.Name = "vbox11";
		this.vbox11.Spacing = 6;
		// Container child vbox11.Gtk.Box+BoxChild
		this.hbox20 = new global::Gtk.HBox ();
		this.hbox20.Name = "hbox20";
		this.hbox20.Spacing = 6;
		// Container child hbox20.Gtk.Box+BoxChild
		this.label24 = new global::Gtk.Label ();
		this.label24.Name = "label24";
		this.label24.LabelProp = global::Mono.Unix.Catalog.GetString ("x0:");
		this.hbox20.Add (this.label24);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox20 [this.label24]));
		w12.Position = 0;
		w12.Expand = false;
		w12.Fill = false;
		// Container child hbox20.Gtk.Box+BoxChild
		this.entry4 = new global::Gtk.Entry ();
		this.entry4.CanFocus = true;
		this.entry4.Name = "entry4";
		this.entry4.Text = global::Mono.Unix.Catalog.GetString ("0,0000001");
		this.entry4.IsEditable = true;
		this.entry4.InvisibleChar = '•';
		this.hbox20.Add (this.entry4);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox20 [this.entry4]));
		w13.Position = 1;
		this.vbox11.Add (this.hbox20);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.hbox20]));
		w14.Position = 0;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox11.Gtk.Box+BoxChild
		this.hbox21 = new global::Gtk.HBox ();
		this.hbox21.Name = "hbox21";
		this.hbox21.Spacing = 6;
		// Container child hbox21.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("E:");
		this.hbox21.Add (this.label5);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox21 [this.label5]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbox21.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.hbox21.Add (this.label6);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox21 [this.label6]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		this.vbox11.Add (this.hbox21);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.hbox21]));
		w17.Position = 1;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox11.Gtk.Box+BoxChild
		this.hbox22 = new global::Gtk.HBox ();
		this.hbox22.Name = "hbox22";
		this.hbox22.Spacing = 6;
		// Container child hbox22.Gtk.Box+BoxChild
		this.entry3 = new global::Gtk.Entry ();
		this.entry3.CanFocus = true;
		this.entry3.Name = "entry3";
		this.entry3.Text = global::Mono.Unix.Catalog.GetString ("0,0000001");
		this.entry3.IsEditable = true;
		this.entry3.InvisibleChar = '•';
		this.hbox22.Add (this.entry3);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox22 [this.entry3]));
		w18.Position = 0;
		this.vbox11.Add (this.hbox22);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox11 [this.hbox22]));
		w19.Position = 2;
		w19.Expand = false;
		w19.Fill = false;
		this.hbox19.Add (this.vbox11);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox19 [this.vbox11]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		this.vbox10.Add (this.hbox19);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox10 [this.hbox19]));
		w21.Position = 3;
		w21.Expand = false;
		w21.Fill = false;
		this.vbox5.Add (this.vbox10);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.vbox10]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		this.hbox6.BorderWidth = ((uint)(18));
		// Container child hbox6.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.Xalign = 0F;
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Метод хорд");
		this.vbox6.Add (this.label9);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.label9]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.label22 = new global::Gtk.Label ();
		this.label22.Name = "label22";
		this.label22.LabelProp = global::Mono.Unix.Catalog.GetString ("x^2 +pi*log10(13*pi)-5*pi*sinx-2*x");
		this.label22.Wrap = true;
		this.vbox6.Add (this.label22);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.label22]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.button3 = new global::Gtk.Button ();
		this.button3.WidthRequest = 230;
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString ("Знайти корінь");
		this.vbox6.Add (this.button3);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.button3]));
		w25.Position = 2;
		w25.Expand = false;
		w25.Fill = false;
		this.hbox6.Add (this.vbox6);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.vbox6]));
		w26.Position = 0;
		w26.Expand = false;
		w26.Fill = false;
		// Container child hbox6.Gtk.Box+BoxChild
		this.vbox7 = new global::Gtk.VBox ();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("a:");
		this.hbox7.Add (this.label11);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label11]));
		w27.Position = 0;
		w27.Expand = false;
		w27.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.entry20 = new global::Gtk.Entry ();
		this.entry20.CanFocus = true;
		this.entry20.Name = "entry20";
		this.entry20.Text = global::Mono.Unix.Catalog.GetString ("0");
		this.entry20.IsEditable = true;
		this.entry20.HasFrame = false;
		this.entry20.InvisibleChar = '•';
		this.hbox7.Add (this.entry20);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.entry20]));
		w28.Position = 1;
		// Container child hbox7.Gtk.Box+BoxChild
		this.label12 = new global::Gtk.Label ();
		this.label12.Name = "label12";
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("b:");
		this.hbox7.Add (this.label12);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label12]));
		w29.Position = 2;
		w29.Expand = false;
		w29.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.entry21 = new global::Gtk.Entry ();
		this.entry21.CanFocus = true;
		this.entry21.Name = "entry21";
		this.entry21.Text = global::Mono.Unix.Catalog.GetString ("0,5");
		this.entry21.IsEditable = true;
		this.entry21.HasFrame = false;
		this.entry21.InvisibleChar = '•';
		this.hbox7.Add (this.entry21);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.entry21]));
		w30.Position = 3;
		this.vbox7.Add (this.hbox7);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox7]));
		w31.Position = 0;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.hbox9 = new global::Gtk.HBox ();
		this.hbox9.Name = "hbox9";
		this.hbox9.Spacing = 6;
		// Container child hbox9.Gtk.Box+BoxChild
		this.label13 = new global::Gtk.Label ();
		this.label13.Name = "label13";
		this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("E:");
		this.hbox9.Add (this.label13);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.label13]));
		w32.Position = 0;
		w32.Expand = false;
		w32.Fill = false;
		// Container child hbox9.Gtk.Box+BoxChild
		this.entry22 = new global::Gtk.Entry ();
		this.entry22.CanFocus = true;
		this.entry22.Name = "entry22";
		this.entry22.Text = global::Mono.Unix.Catalog.GetString ("0,0000001");
		this.entry22.IsEditable = true;
		this.entry22.HasFrame = false;
		this.entry22.InvisibleChar = '•';
		this.hbox9.Add (this.entry22);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.entry22]));
		w33.Position = 1;
		this.vbox7.Add (this.hbox9);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox9]));
		w34.Position = 1;
		w34.Expand = false;
		w34.Fill = false;
		this.hbox6.Add (this.vbox7);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.vbox7]));
		w35.Position = 1;
		this.vbox5.Add (this.hbox6);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox6]));
		w36.Position = 1;
		w36.Expand = false;
		w36.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox ();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		this.hbox10.BorderWidth = ((uint)(18));
		// Container child hbox10.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox ();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.label19 = new global::Gtk.Label ();
		this.label19.Name = "label19";
		this.label19.Xalign = 0F;
		this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("Метод хорд-дотичних");
		this.vbox8.Add (this.label19);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.label19]));
		w37.Position = 0;
		w37.Expand = false;
		w37.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.label31 = new global::Gtk.Label ();
		this.label31.Name = "label31";
		this.label31.LabelProp = global::Mono.Unix.Catalog.GetString ("5+7x^7sinx-x^13cosx sqrt(Pi-cosx^3)");
		this.label31.Wrap = true;
		this.vbox8.Add (this.label31);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.label31]));
		w38.Position = 1;
		w38.Expand = false;
		w38.Fill = false;
		// Container child vbox8.Gtk.Box+BoxChild
		this.button4 = new global::Gtk.Button ();
		this.button4.WidthRequest = 230;
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString ("Знайти корінь");
		this.vbox8.Add (this.button4);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.button4]));
		w39.Position = 2;
		w39.Expand = false;
		w39.Fill = false;
		this.hbox10.Add (this.vbox8);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.vbox8]));
		w40.Position = 0;
		w40.Expand = false;
		w40.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.vbox9 = new global::Gtk.VBox ();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.hbox11 = new global::Gtk.HBox ();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 6;
		// Container child hbox11.Gtk.Box+BoxChild
		this.label14 = new global::Gtk.Label ();
		this.label14.Name = "label14";
		this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("a:");
		this.hbox11.Add (this.label14);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.label14]));
		w41.Position = 0;
		w41.Expand = false;
		w41.Fill = false;
		// Container child hbox11.Gtk.Box+BoxChild
		this.entry17 = new global::Gtk.Entry ();
		this.entry17.CanFocus = true;
		this.entry17.Name = "entry17";
		this.entry17.Text = global::Mono.Unix.Catalog.GetString ("0,5");
		this.entry17.IsEditable = true;
		this.entry17.HasFrame = false;
		this.entry17.InvisibleChar = '•';
		this.hbox11.Add (this.entry17);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.entry17]));
		w42.Position = 1;
		// Container child hbox11.Gtk.Box+BoxChild
		this.label15 = new global::Gtk.Label ();
		this.label15.Name = "label15";
		this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("b:");
		this.hbox11.Add (this.label15);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.label15]));
		w43.Position = 2;
		w43.Expand = false;
		w43.Fill = false;
		// Container child hbox11.Gtk.Box+BoxChild
		this.entry18 = new global::Gtk.Entry ();
		this.entry18.CanFocus = true;
		this.entry18.Name = "entry18";
		this.entry18.Text = global::Mono.Unix.Catalog.GetString ("1,5");
		this.entry18.IsEditable = true;
		this.entry18.HasFrame = false;
		this.entry18.InvisibleChar = '•';
		this.hbox11.Add (this.entry18);
		global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.entry18]));
		w44.Position = 3;
		this.vbox9.Add (this.hbox11);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox11]));
		w45.Position = 0;
		w45.Expand = false;
		w45.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.hbox13 = new global::Gtk.HBox ();
		this.hbox13.Name = "hbox13";
		this.hbox13.Spacing = 6;
		// Container child hbox13.Gtk.Box+BoxChild
		this.label16 = new global::Gtk.Label ();
		this.label16.Name = "label16";
		this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("E:");
		this.hbox13.Add (this.label16);
		global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.label16]));
		w46.Position = 0;
		w46.Expand = false;
		w46.Fill = false;
		// Container child hbox13.Gtk.Box+BoxChild
		this.entry19 = new global::Gtk.Entry ();
		this.entry19.CanFocus = true;
		this.entry19.Name = "entry19";
		this.entry19.Text = global::Mono.Unix.Catalog.GetString ("0,0000001");
		this.entry19.IsEditable = true;
		this.entry19.HasFrame = false;
		this.entry19.InvisibleChar = '•';
		this.hbox13.Add (this.entry19);
		global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.entry19]));
		w47.Position = 1;
		this.vbox9.Add (this.hbox13);
		global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox13]));
		w48.Position = 1;
		w48.Expand = false;
		w48.Fill = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.hbox14 = new global::Gtk.HBox ();
		this.hbox14.Name = "hbox14";
		this.hbox14.Spacing = 6;
		this.vbox9.Add (this.hbox14);
		global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox9 [this.hbox14]));
		w49.Position = 2;
		this.hbox10.Add (this.vbox9);
		global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.vbox9]));
		w50.Position = 1;
		this.vbox5.Add (this.hbox10);
		global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox10]));
		w51.Position = 2;
		w51.Expand = false;
		w51.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.Xalign = 0F;
		this.label4.Yalign = 0F;
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Метод простих ітерацій");
		this.vbox2.Add (this.label4);
		global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label4]));
		w52.Position = 0;
		w52.Expand = false;
		w52.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label21 = new global::Gtk.Label ();
		this.label21.Name = "label21";
		this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("x^2 +pi*log10(13*pi)-5*pi*sinx-2*x");
		this.label21.Wrap = true;
		this.vbox2.Add (this.label21);
		global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label21]));
		w53.Position = 1;
		w53.Expand = false;
		w53.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("Знайти корінь");
		this.vbox2.Add (this.button2);
		global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.button2]));
		w54.Position = 2;
		w54.Expand = false;
		w54.Fill = false;
		this.hbox2.Add (this.vbox2);
		global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox2]));
		w55.Position = 0;
		w55.Expand = false;
		w55.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label25 = new global::Gtk.Label ();
		this.label25.Name = "label25";
		this.label25.LabelProp = global::Mono.Unix.Catalog.GetString ("a:");
		this.hbox3.Add (this.label25);
		global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label25]));
		w56.Position = 0;
		w56.Expand = false;
		w56.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.entry14 = new global::Gtk.Entry ();
		this.entry14.CanFocus = true;
		this.entry14.Name = "entry14";
		this.entry14.Text = global::Mono.Unix.Catalog.GetString ("2");
		this.entry14.IsEditable = true;
		this.entry14.HasFrame = false;
		this.entry14.InvisibleChar = '•';
		this.hbox3.Add (this.entry14);
		global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entry14]));
		w57.Position = 1;
		this.vbox3.Add (this.hbox3);
		global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
		w58.Position = 0;
		w58.Expand = false;
		w58.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.label29 = new global::Gtk.Label ();
		this.label29.Name = "label29";
		this.label29.LabelProp = global::Mono.Unix.Catalog.GetString ("b:");
		this.hbox4.Add (this.label29);
		global::Gtk.Box.BoxChild w59 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label29]));
		w59.Position = 0;
		w59.Expand = false;
		w59.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.entry15 = new global::Gtk.Entry ();
		this.entry15.CanFocus = true;
		this.entry15.Name = "entry15";
		this.entry15.Text = global::Mono.Unix.Catalog.GetString ("2,5");
		this.entry15.IsEditable = true;
		this.entry15.HasFrame = false;
		this.entry15.InvisibleChar = '•';
		this.hbox4.Add (this.entry15);
		global::Gtk.Box.BoxChild w60 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entry15]));
		w60.Position = 1;
		this.vbox3.Add (this.hbox4);
		global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox4]));
		w61.Position = 1;
		w61.Expand = false;
		w61.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label30 = new global::Gtk.Label ();
		this.label30.Name = "label30";
		this.label30.LabelProp = global::Mono.Unix.Catalog.GetString ("E:");
		this.hbox5.Add (this.label30);
		global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label30]));
		w62.Position = 0;
		w62.Expand = false;
		w62.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.entry16 = new global::Gtk.Entry ();
		this.entry16.CanFocus = true;
		this.entry16.Name = "entry16";
		this.entry16.Text = global::Mono.Unix.Catalog.GetString ("0,0000001");
		this.entry16.IsEditable = true;
		this.entry16.HasFrame = false;
		this.entry16.InvisibleChar = '•';
		this.hbox5.Add (this.entry16);
		global::Gtk.Box.BoxChild w63 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.entry16]));
		w63.Position = 1;
		this.vbox3.Add (this.hbox5);
		global::Gtk.Box.BoxChild w64 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox5]));
		w64.Position = 2;
		w64.Expand = false;
		w64.Fill = false;
		this.hbox2.Add (this.vbox3);
		global::Gtk.Box.BoxChild w65 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox3]));
		w65.Position = 1;
		this.vbox5.Add (this.hbox2);
		global::Gtk.Box.BoxChild w66 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox2]));
		w66.Position = 3;
		w66.Expand = false;
		w66.Fill = false;
		this.hpaned4.Add (this.vbox5);
		global::Gtk.Paned.PanedChild w67 = ((global::Gtk.Paned.PanedChild)(this.hpaned4 [this.vbox5]));
		w67.Resize = false;
		// Container child hpaned4.Gtk.Paned+PanedChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.Xalign = 0F;
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Проміжні результати:");
		this.vbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w68 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
		w68.Position = 0;
		w68.Expand = false;
		w68.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView ();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.textview1.Editable = false;
		this.textview1.CursorVisible = false;
		this.scrolledwindow1.Add (this.textview1);
		this.vbox1.Add (this.scrolledwindow1);
		global::Gtk.Box.BoxChild w70 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.scrolledwindow1]));
		w70.Position = 1;
		this.hpaned4.Add (this.vbox1);
		this.Add (this.hpaned4);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler (this.ResetBtnClicked);
		this.button5.Clicked += new global::System.EventHandler (this.LobachevskyBtnClicked);
		this.button6.Clicked += new global::System.EventHandler (this.AdvancedLobachevskyBtnClicked);
		this.button3.Clicked += new global::System.EventHandler (this.HordButClicked);
		this.button4.Clicked += new global::System.EventHandler (this.OnButton4Clicked);
		this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
	}
}
