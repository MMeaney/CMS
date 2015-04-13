// MyApp.cs
using System;
using System.Windows; // the root WPF namespace

namespace MyFirsAvalonApp {
	class MyApp {
		[STAThread]
		static void Main(  ) {
			// the WPF message box
			MessageBox.Show("Hello, Avalon");
		}
	}
}	
