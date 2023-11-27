﻿using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace Controls.Sample.UITests
{
	class ScrollViewCoreGalleryPage : ContentPage
	{
		public ScrollViewCoreGalleryPage()
		{
			var descriptionLabel =
				   new Label { AutomationId = "WaitForStubControl", Text = "ScrollView Galleries", Margin = new Thickness(2) };

			Title = "ScrollView Galleries";

			Content = new ScrollView
			{
				Content = new StackLayout
				{
					Padding = new Thickness(2),
					Children =
					{
						descriptionLabel,
						// ScrollToYTwice (src\Compatibility\ControlGallery\src\UITests.Shared\Tests\ScrollViewUITests.cs)
						TestBuilder.NavButton("ScrollView ScrollTo", () =>
							new ScrollTo(), Navigation),
					}
				}
			};
		}
	}
}