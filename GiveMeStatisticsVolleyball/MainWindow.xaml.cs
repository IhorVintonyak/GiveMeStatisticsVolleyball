using GiveMeStatisticsVolleyball.Class;
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
using System.Printing;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata;

namespace GiveMeStatisticsVolleyball
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player currentPlayer;
        string currentAction = "SERVE";
        string currentResult = "MADE";


        public MainWindow()
        {
 

            InitializeComponent();

            Player player1 = new Player("Arnold", 1);
            Player player2 = new Player("Dave", 2);
            Player player3 = new Player("Rave", 3);
            Player player4 = new Player("Bob", 4);
            Player player5 = new Player("Simon", 5);
            Player player6 = new Player("Nive", 6);


            

            /*
            player1.doServe(false, false);
            player2.doBlock(false, false);
            player3.doDig(false, false);
            player1.doSet(false, false);
            player2.doSpike(true, false);

            player1.doServe(false, false);
            player2.doBlock(false, false);
            player3.doDig(false, true);

            player2.doServe(false, false);
            player3.doBlock(false, false);
            player1.doDig(false, false);
            player3.doSet(false, false);
            player2.doSpike(false, true);

            player1.doServe(false, false);
            player2.doBlock(false, false);
            player1.doDig(false, false);
            player3.doSet(false, false);
            player1.doSpike(true, false);

            player3.doServe(false, true);

            player1.doServe(false, false);
            player2.doBlock(false, false);
            player1.doDig(false, false);
            player3.doSet(false, false);
            player2.doSpike(false, false);
            player3.doBlock(false, false);
            player2.doDig(false, false);
            player3.doSet(false, false);
            player3.doSpike(true, false);
            */
        }


        private void btnPlayer_Click(int content)
        {
            switch (content)
            {
                case 1:
                    btnСurrentPlayer.Content = 1;
                    break;
                case 2:
                    btnСurrentPlayer.Content = 2;
                    break;
                case 3:
                    btnСurrentPlayer.Content = 3;
                    break;
                case 4:
                    btnСurrentPlayer.Content = 4;
                    break;
                case 5:
                    btnСurrentPlayer.Content = 5;
                    break; 
                case 6:
                    btnСurrentPlayer.Content = 6;
                    break;
            }

        }

        private void btnPlayer1_Click(object sender, RoutedEventArgs e)
        {
            btnPlayer_Click(1);
        }

        private void btnPlayer2_Click(object sender, RoutedEventArgs e)
        {
            btnPlayer_Click(2);
        }
        private void btnPlayer3_Click(object sender, RoutedEventArgs e)
        {
            btnPlayer_Click(3);
        }

        private void btnPlayer4_Click(object sender, RoutedEventArgs e)
        {
            btnPlayer_Click(4);
        }

        private void btnPlayer5_Click(object sender, RoutedEventArgs e)
        {
            btnPlayer_Click(5);
        }


        private void btnPlayer6_Click(object sender, RoutedEventArgs e)
        {
            btnPlayer_Click(6);
        }

        private void btnServe_Click(object sender, RoutedEventArgs e)
        {
            currentAction = "serve";
        }

        private void btnDig_Click(object sender, RoutedEventArgs e)
        {
            currentAction = "dig";
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            currentAction = "set";
        }

        private void btnSpike_Click(object sender, RoutedEventArgs e)
        {
            currentAction = "spike";
        }

        private void btnBlock_Click(object sender, RoutedEventArgs e)
        {
            currentAction = "block";
        }

        private void btnError_Click(object sender, RoutedEventArgs e)
        {
            currentResult = "error";
        }

        private void btnMade_Click(object sender, RoutedEventArgs e)
        {
            currentResult = "made";
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            currentResult = "point";
        }
        void chooseAction(string action, string result)
        {
            switch (action)
            {
                case "serve":
                    btnСurrentPlayer.Content = 1;
                    break;
                case "dig":
                    btnСurrentPlayer.Content = 2;
                    break;
                case "set":
                    btnСurrentPlayer.Content = 3;
                    break;
                case "spike":
                    btnСurrentPlayer.Content = 4;
                    break;
                case "block":
                    btnСurrentPlayer.Content = 5;
                    break;
            }
        }

        void chooseResult() { 
        }
    }

}
