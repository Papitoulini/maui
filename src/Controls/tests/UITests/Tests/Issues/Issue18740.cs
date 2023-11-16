﻿using NUnit.Framework;
using UITest.Appium;
using UITest.Core;

namespace Microsoft.Maui.AppiumTests.Issues
{
	public class Issue18740 : _IssuesUITest
	{
		public Issue18740(TestDevice device)
			: base(device)
		{ }

		public override string Issue => "Virtual keyboard appears with focus on Entry";

		[Test]
		public void Issue18740Test()
		{
			this.IgnoreIfPlatforms(new TestDevice[] { TestDevice.iOS, TestDevice.Mac, TestDevice.Windows });

			App.WaitForElement("WaitForStubControl");

			// 1.Make sure keyboard starts out closed.
			App.DismissKeyboard();

			// 2. Focus the Entry.
			App.EnterText("TestEntry", "test");
			App.Click("TestEntry");

			// 3. Verify that the virtual keyboard appears.
			Assert.IsTrue(App.IsKeyboardShown());

			// Repeat the steps 2 and 3 with Editor and SearchBar

			App.DismissKeyboard();
			App.EnterText("TestEditor", "test");
			App.Click("TestEditor");
			Assert.IsTrue(App.IsKeyboardShown());

			App.DismissKeyboard();
			App.EnterText("TestSearchBar", "test");
			App.Click("TestSearchBar");
			Assert.IsTrue(App.IsKeyboardShown());
		}
	}
}
