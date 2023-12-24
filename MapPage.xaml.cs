using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPOkemonAdrianUtrilla
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MapPage : Page
    {
        public MapPage()
        {
            this.InitializeComponent();
            loadMap();
        }

        private void loadMap()
        {
            BasicGeoposition ini = new BasicGeoposition()
            {
                Latitude = 40.4169473,
                Longitude = -3.7035285
            };

            MapControl.SetLocation(worlMap, new Geopoint(ini));
            MapControl.SetNormalizedAnchorPoint(worlMap, new Point(0.5, 0.5));

            Geopoint zona = new Geopoint(ini);
            worlMap.Center = zona;
            worlMap.ZoomLevel = 17;

            Random random = new Random();
            int num = random.Next(1, 6);
            for(int i = 0; i < num; i++)
            {
                double rLatidud = random.NextDouble() * 0.001;
                double rLongitud = random.NextDouble() * 0.001;
                BasicGeoposition pokemonLocation = new BasicGeoposition
                {
                    Latitude = 40.4169473 + rLatidud,
                    Longitude = -3.7035285 + rLongitud
                };

                if (random.Next(2) == 0) {
                    MapIcon pokemonIcon = new MapIcon
                    {
                        Location = new Geopoint(pokemonLocation),
                        NormalizedAnchorPoint = new Point(0.5, 1.0),
                        Title = "Psyduck",
                
                    };

                    worlMap.MapElements.Add(pokemonIcon);
                }
                else
                {
                    MapIcon pokemonIcon = new MapIcon
                    {
                        Location = new Geopoint(pokemonLocation),
                        NormalizedAnchorPoint = new Point(0.5, 1.0),
                        Title = "Porygon",

                    };

                    worlMap.MapElements.Add(pokemonIcon);
                }
            }

            worlMap.MapElementClick += MapControl_MapElementClick;
        }

        private void MapControl_MapElementClick(MapControl sender, MapElementClickEventArgs args)
        {
            string strPsy = "Psyduck";
            string strPor = "Porygon";

            if (args.MapElements.FirstOrDefault() is MapIcon clickedIcon)
            {

                if (clickedIcon.Title.ToString() == strPsy)
                {
                    fmMain.Navigate(typeof(CapturaPage), strPsy);
                }
                else if (clickedIcon.Title.ToString() == strPor)
                {
                    fmMain.Navigate(typeof(CapturaPage), strPor);
                }

            }
        }

    }
}
