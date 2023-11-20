﻿using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace Maui.Controls.Sample.Issues
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	[Issue(IssueTracker.Github, 18740, "Virtual keyboard appears with focus on Entry", PlatformAffected.Android)]
	public partial class Issue18740 : ContentPage
	{
		public Issue18740()
		{
			InitializeComponent();
		}
				
		void OnEntryButtonClicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Issue18740Entry());
		}

		void OnEditorButtonClicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Issue18740Editor());
		}

		void OnSearchBarButtonClicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Issue18740SearchBar());
		}
	}
}