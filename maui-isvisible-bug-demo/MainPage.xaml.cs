using System;
using Microsoft.Maui.Controls;

namespace maui_isvisible_bug_demo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BindingContext = new MainViewModel();
		}
	}
}
