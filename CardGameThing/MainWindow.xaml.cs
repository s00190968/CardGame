using System;
using System.Collections.Generic;
using System.Linq;
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

namespace CardGameThing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Deck ultraAwesomeDeck;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ultraAwesomeDeck = new Deck("Ultra awesome Deck");
            deckNameTxBl.Text = ultraAwesomeDeck.Name;

            //card rarities:  Normal = 0, Rare=1, SuperRare=2, UltraRare=3
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "123456", Card.Rarity.SuperRare, "A very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Red Eyes Black Dragon", 7, "123154", Card.Rarity.Rare, "Another dragon"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Dark Magician", 8, "4465564", Card.Rarity.SuperRare, "Old stuffy magician."));
            ultraAwesomeDeck.AddCard(new MonsterCard("Dark Magician Girl", 8, "149851", Card.Rarity.Rare, "Apprentice magician"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "165465", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "1515", Card.Rarity.Rare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "1494512", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "1514114", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Obnoxious Guard", 4, "9816554", Card.Rarity.Normal, "Very obnoxious guard. seriosuly grates on your nerves."));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "514445", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "1415612", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "1716515", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "184426", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "4915625", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "1441654", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "179645", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "1716651", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "184652", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));
            ultraAwesomeDeck.AddCard(new MonsterCard("Blue Eyes White Dragon", 8, "1498684", Card.Rarity.SuperRare, "a very nice blue eyes white dragon. Also has a jet form"));

            updateCardList();
        }

        private void shuffleBtn_Click(object sender, RoutedEventArgs e)
        {
            ultraAwesomeDeck.Suffle();
            updateCardList();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            Card c = cardListLbx.SelectedItem as Card;
            ultraAwesomeDeck.RemoveCard(c);
            updateCardList();
        }

        public void updateCardList()
        {
            cardListLbx.ItemsSource = null;
            cardListLbx.ItemsSource = ultraAwesomeDeck.Cards;
        }
    }
}
