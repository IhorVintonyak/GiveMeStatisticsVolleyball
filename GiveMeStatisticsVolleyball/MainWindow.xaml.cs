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
        Player currentPlayer = new Player("Arnold", 1);
        int currentPosition = 0;
        string currentAction = "serve";
        bool currentPoint = false;
        bool currentError= false;


        public MainWindow()
        {

            Player player1 = new Player("Arnold", 1);
            Player player2 = new Player("Dave", 2);
            Player player3 = new Player("Rave", 3);
            Player player4 = new Player("Bob", 4);
            Player player5 = new Player("Simon", 5);
            Player player6 = new Player("Nive", 6);


            Player[] team = { player1, player2, player3, player4, player5, player6 };
            
            InitializeComponent();

        }

        private void btnError_Click(object sender, RoutedEventArgs e)
        {
            currentPoint = false;
            currentError = true;
            action(currentPlayer, currentAction, currentPoint, currentError);

        }

        private void btnMade_Click(object sender, RoutedEventArgs e)
        {
            currentPoint = false;
            currentError = false;
            action(currentPlayer, currentAction, currentPoint, currentError);
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            currentPoint = true;
            currentError = false;
            action(currentPlayer, currentAction, currentPoint, currentError);
        }




        void action(Player player, string action ,bool boolPoint, bool boolError)
        {
            switch (action)
            {
                case "serve":
                    player.doServe(boolPoint,boolError);
                    break;
                case "dig":
                    player.doDig(boolPoint, boolError);
                    break;
                case "set":
                    player.doSet(boolPoint, boolError);
                    break;
                case "spike":
                    player.doSpike(boolPoint, boolError);
                    break;
                case "block":
                    player.doBlock(boolPoint, boolError);
                    break;
            }
            textOutput.Text = player.Name + " - "+ currentPosition + " - " + action + " - " + pointResult(boolPoint, boolError);

        }

        string pointResult(bool boolPoint, bool boolError)
        {
            string result;
            if (boolPoint)
            {
                result = "point";
            }else if (boolError)
            {
                result = "error";
            }
            else
            {
                result = "made";
            }
            return result;
        }

        private void btnPlayer_Click(int content)
        {
            switch (content)
            {
                case 1:
                    btnСurrentPlayer.Content = 1;
                    currentPosition = 1;
                    break;
                case 2:
                    btnСurrentPlayer.Content = 2;
                    currentPosition = 2;
                    break;
                case 3:
                    btnСurrentPlayer.Content = 3;
                    currentPosition = 3;
                    break;
                case 4:
                    btnСurrentPlayer.Content = 4;
                    currentPosition = 4;    
                    break;
                case 5:
                    btnСurrentPlayer.Content = 5;
                    currentPosition = 5;
                    break; 
                case 6:
                    btnСurrentPlayer.Content = 6;
                    currentPosition = 6;
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

    }

}
