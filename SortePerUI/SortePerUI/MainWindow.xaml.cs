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

namespace SortePerUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game game;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartBTN_Click(object sender, RoutedEventArgs e)
        {
            StartBTN.Visibility = Visibility.Hidden;
            playersLBL.Visibility = Visibility.Hidden;
            comboBox.Visibility = Visibility.Hidden;
            nicknameLBL.Visibility = Visibility.Hidden;
            nicknameTXT.Visibility = Visibility.Hidden;

            game = new Game();

            SetUpPlayers(game);

            SetUpCards(game);
        }
        private void SetUpPlayers(Game game)
        {
            int numbersOfPlayers = Convert.ToInt32(comboBox.Text);
            string playerName = nicknameTXT.Text;
            if (playerName == string.Empty)
            {
                playerName = "Player 1";
            }

            game.AddPlayer(playerName);
            game.AddPlayer("Player 2");
            playerOneLBL.Content = game.Players[0].Name;
            playerTwoLBL.Content = game.Players[1].Name;
            playerOneLBL.Visibility = Visibility.Visible;
            playerTwoLBL.Visibility = Visibility.Visible;

            if (numbersOfPlayers >= 3)
            {
                game.AddPlayer("Player 3");
                playerTreeLBL.Content = game.Players[2].Name;
                playerTreeLBL.Visibility = Visibility.Visible;
            }
            if (numbersOfPlayers == 4)
            {
                game.AddPlayer("Player 4");
                playerFourLBL.Content = game.Players[3].Name;
                playerFourLBL.Visibility = Visibility.Visible;
            }
        }
        private void SetUpCards(Game game)
        {
            game.AddCards();
            game.ShuffleCards();

            game.DealCards(game.Players.Count);

            RenderCards(game);
        }
        private void RenderCards(Game game)
        {
            ClearPlayingCards();

            for (int p = 0; p < game.Players.Count; p++)
            {
                for (int i = 0; i < game.Players[p].Hand.Count; i++)
                {
                    Image img = CreateCardImage(game.Players[p].Hand[i], game.Players[0]);

                    switch (p)
                    {
                        case 0:
                            playerOneSP.Children.Add(img);
                            break;
                        case 1:
                            playerTwoSP.Children.Add(img);
                            break;
                        case 2:
                            playerTreeSP.Children.Add(img);
                            break;
                        case 3:
                            playerFourSP.Children.Add(img);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void ClearPlayingCards()
        {

        }

        private Image CreateCardImage(Card card, Player player)
        {
            Image Card = new Image
            {
                Height = 114, MinWidth = 75
            };


            if (card.Owner != player)
            {
                Card.Name = "Back";
                Card.Source = CardDal.GetimageSource("Back");
            }
            else if (card.Number == 0)
            {
                Card.Source = CardDal.GetimageSource("BlackPeter");
            }
            else
            {
                Card.Source = CardDal.GetimageSource(card.Number.ToString() + card.Variation.ToString());
            }

            Card.MouseEnter += CardMouseEnter;
            Card.MouseLeave += CardMouseLeave;
            Card.MouseLeftButtonDown += CardMouseClick;

            return Card;
        }

        private void CardMouseClick(object sender, MouseButtonEventArgs e)
        {
            Image img = (Image)sender;
            img.MouseEnter -= CardMouseEnter;
            img.MouseLeave -= CardMouseLeave;
            if (img.Name != "Back")
            {
                img.Margin = new Thickness { Bottom = 40 };
            }
            else
            {
                img.Margin = new Thickness { Top = 40 };
            }
        }

        private void CardMouseLeave(object sender, MouseEventArgs e)
        {
            Image img = (Image)sender;
            if (img.Name != "Back")
            {
                img.Margin = new Thickness { Bottom = 0 };
            }
            else
            {
                img.Margin = new Thickness { Top = 0 };
            }
        }

        private void CardMouseEnter(object sender, MouseEventArgs e)
        {
            Image img = (Image)sender;
            if (img.Name != "Back")
            {
                img.Margin = new Thickness { Bottom = 20 };
            }
            else
            {
                img.Margin = new Thickness { Top = 20 };
            }
        }
    }
}
