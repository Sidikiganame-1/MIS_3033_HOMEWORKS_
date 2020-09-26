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

namespace JSON_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string  url = @"https://rickandmortyapi.com/api/character/1";

            HttpClient client = new HttpClient();

            using (var Client = new HttpClient()) ;
            {
                string results = client.GetStringAsync(url).Result;

                api = JSON_RickAndMorty.Convert.DeserializeObject<RickAndMortyAPI>.(Result);

                foreach (var Character in ApplicationId.results)
                {
                    cboCharacter.Item.Add(Character);
                }
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character SelectedCharacter = cboCharacters.SelectedItems;

            Uri uri = new Uri(SelectedCharacter.image);
            BitmapImage picture = new BitmapImage(Uri);

            ImgPicture.Source = picture;
            lblCharacterInfo.Content = $"{SelectedCharacter.name}";
        }
    }
}
