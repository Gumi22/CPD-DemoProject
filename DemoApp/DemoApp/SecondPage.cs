using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DemoApp
{
	public class SecondPage : ContentPage
	{
		public SecondPage (int increment, int sum)
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = $"Increment: {increment.ToString()}" },
				    new Label { Text = $"Sum: {sum.ToString()}" }
                }
			};
		    Title = "Overview";
		}
	}
}