using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JSON_POKEMON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
             
            AllPokemonAPI pokemonAPI;
            using (var client = new HttpClient())
            {
                string allPokeUrl = @"https://pokeapi.co/api/v2/pokemon?offset=20&limit=20";

                string json = client.GetStringAsync(allPokeUrl).Result;

                pokemonAPI = JsonConvert.DeserializeObject<AllPokemonAPI>(json);
            }

            foreach (var Pokie in pokemonAPI.results)
            {
                cboPokies.Items.Add(Pokie);
            }


            using (var Sprites = new HttpClient()) ;
            {
                string url = @"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/back/1.png";

                string json = Sprite.GetStringAsync(Sprite).Result;

              Sprite  = JsonConvert.DeserializeObject<Sprite>(json);

            }
        }
    }
}
