using System;
using Xamarin.Forms;

namespace Actividad3
{
	public class App
	{
		
		public static Page GetMainPage ()
		{ 
			return new ContentPage { 
				Content = new Label {
					Text = "Hola, Formas!",
					VerticalOptions = LayoutOptions.End  ,
					HorizontalOptions = LayoutOptions.StartAndExpand   ,
					TextColor = Color.Green,
					BackgroundColor = Color.Yellow 
				},
			};

		}
	}
}

