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
using static System.Net.Mime.MediaTypeNames;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameInitializer gameInit;
        private int matchesFound;
        private GameTimer gameTimer;

        TextBlock lastTextBlockClicked;
        bool findingMatch = false;
        public MainWindow()
        {
            InitializeComponent();
            gameInit = new GameInitializer();
            this.displayEmojis(gameInit.SetUpGame());
            gameTimer = new GameTimer();
            matchesFound = 0;
            this.timerTextBlockUpdateDisplay();
        }

        private void displayEmojis(List<string> listofEmojis)
        {
            Random random = new Random();

            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                if(textBlock.Name != "timeTextBlock") {
                    textBlock.Visibility = Visibility.Visible;
                    int index = random.Next(listofEmojis.Count);
                    string nextEmoji = listofEmojis[index];
                    textBlock.Text = nextEmoji;
                    listofEmojis.RemoveAt(index);
                }
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                lastTextBlockClicked = textBlock;
                findingMatch = true;
                this.timerTextBlockUpdateDisplay();

            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
                this.timerTextBlockUpdateDisplay();
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
                this.timerTextBlockUpdateDisplay();
            }

        }

        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(matchesFound == 8)
            {
                this.displayEmojis(gameInit.SetUpGame());
            }
        }

        private void timerTextBlockUpdateDisplay()
        {
            int timerSecondsElapsed = gameTimer.getTimerTick();
            timeTextBlock.Text = (timerSecondsElapsed / 10F).ToString("0.0s");
            if(matchesFound == 8)
            {
                gameTimer.stopTimer("Stop timer");
                timeTextBlock.Text = timeTextBlock.Text + " - Play again?";
            }
        }

  
    }
}
