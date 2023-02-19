using MatchGame.GameCode;
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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameInitializer gameInit;
        public MainWindow()
        {
            InitializeComponent();
            gameInit = new GameInitializer();
            this.displayEmojis(gameInit.SetUpGame());
        }

        private void displayEmojis(List<string> listofEmojis)
        {
            Random random = new Random();

            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(listofEmojis.Count);
                string nextEmoji = listofEmojis[index];
                textBlock.Text = nextEmoji;
                listofEmojis.RemoveAt(index);
            }
        }
    }
}
