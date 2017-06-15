
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Pizzaria.Pages
{
    public class MapaPage : ContentPage
	{
        public MapaPage()
        {
            var posicao = new Position(-25.301161f, -54.114406f);

            //criando mapa nativo
            var mapa = new Map(MapSpan.FromCenterAndRadius(posicao, Distance.FromKilometers(0.3f)))
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            //criando marcador para posicao do restaurante
            mapa.Pins.Add(new Pin
            {
                Type = PinType.Place,
                Position = posicao,
                Label = "Pizzaria",
                Address = "Rua Pereireia, 423"
            });

            Content = new StackLayout
            {
                Children =
                {
                    mapa
                }
            };
        }
	}
}
