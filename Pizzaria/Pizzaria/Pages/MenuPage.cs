using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Pizzaria.Pages
{
	public class MenuPage : TabbedPage  
	{
		public MenuPage ()
		{
            Title = "Menu";
            Children.Add(new InicialPage()
            {
                Title = "Inicio"
            });
            Children.Add(new Sabores()
            {
                Title = "Sabores"
            });
            Children.Add(new MapaPage()
            {
                Title = "Mapa"
            });
        }
	}
}
