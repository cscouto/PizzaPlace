using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Pizzaria.Pages
{
	public class InicialPage : ContentPage
	{
		public InicialPage ()
		{
            //cria button
            var telefone = new Button()
            {
                Text = "(45) 9921-2536"
            };
            //abre a chamada onClick
            telefone.Clicked += (sender, e) => Device.OpenUri(new Uri("tel:4599212536"));

            //criando a tela
            Content = new ContentView()
            {

                Content = new StackLayout
                {
                    Children =
                    {
                        //Adicionando uma logo
                        new Image
                        {
                            Aspect = Aspect.AspectFit,
                            Source = Device.OnPlatform(
                                //IOS
                                ImageSource.FromFile("pizza.png"),
                                //ANDROID
                                ImageSource.FromFile("pizza.png"),
                                //WINDOWSPHONE
                                ImageSource.FromFile("Assets/pizza.png")
                                )
                        },
                        //adcionando o botao na tela
                        telefone
                    }

                },
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
		}
	}
}
