using System;
using Microsoft.Maui.Controls;

namespace maui_isvisible_bug_demo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		bool ShowTestLabel = true;

		private void OnShowLabelClicked(object sender, EventArgs e)
		{
			ShowTestLabel = !ShowTestLabel;
			ShowHide.IsVisible = ShowTestLabel;
		}
	}
}
