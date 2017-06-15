using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Pizzaria.Pages
{
	public class Sabores : BasePage
	{
		public Sabores ()
		{
            Title = "Sabores";
          
            //cria uma listview
            var Lista = new ListView();

            //define a source
            Lista.ItemsSource = new[]
            {
                "Calabresa",
                "Mussarela",
                "Bacon",
                "Portuguesa",
                "Quatro Queijos"
            };

            //Define o click
            Lista.ItemTapped += (sender, e) =>
             {
                 DisplayAlert("sabor", (string)((ListView)sender).SelectedItem, "OK");
                 ((ListView)sender).SelectedItem = null;
             };

            Content = Lista;
		}
	}
}
