using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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
    public sealed partial class PokedexPage : Page
    {
        List<Pokemon> ipokemons;
        public PokedexPage()
        {
            this.InitializeComponent();
            loadPokemons();
        }

        private void loadPokemons()
        {
            List<Pokemon> infoPokemons = new List<Pokemon>() { new Pokemon { nombre = "Psyduck", localizacionImagen = "/Assets/Psyduck.png"},
                new Pokemon { nombre = "Porygon", localizacionImagen = "/Assets/Porygon.png"} };

            ipokemons = infoPokemons;
            //Pokemon p1 = new Pokemon();
            //p1.nombre = "Psyduck";
            //p1.localizacionImagen = "/Assets/Psyduck.png";
            //ipokemons.Add(p1);

            //Pokemon p2 = new Pokemon();
            //p2.nombre = "Porygon";
            //p2.localizacionImagen = "/Assets/Porygon.png";
            //ipokemons.Add(p2);

            //ipokemons.Add(new Pokemon { nombre = "Psyduck", localizacionImagen = "/Assets/Psyduck.png" });
            //ipokemons.Add(new Pokemon { nombre = "Porygon", localizacionImagen = "/Assets/Porygon.png" });

            gvPokedex.ItemsSource = ipokemons;
        }

        private void gvPokedex_ItemClick(object sender, ItemClickEventArgs e)
        {
            Pokemon p = e.ClickedItem as Pokemon;

            if (p != null)
            {
                //mp.pokemonSelected(p.nombre.ToString());
                switch (p.nombre.ToString())
                {
                    case "Porygon":
                        fmMain.Navigate(typeof(infoPokemon), "Porygon");
                        break;

                    case "Psyduck":
                        fmMain.Navigate(typeof(infoPokemon), "Psyduck");
                        break;
                }
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e != null)
            {
                string str = e.Parameter as string;
                if (str == "Psyduck")
                {
                    ipokemons.Add(new Pokemon { nombre = "Psyduck", localizacionImagen = "/Assets/Psyduck.png" });

                    //Pokemon p1 = new Pokemon();
                    //p1.nombre = "Psyduck";
                    //p1.localizacionImagen = "/Assets/Psyduck.png";
                    //ipokemons.Add(p1);
                }
                else if (str == "Porygon")
                {
                    ipokemons.Add(new Pokemon { nombre = "Porygon", localizacionImagen = "/Assets/Porygon.png" });
                }
            }
        }

    }
}
