//Quinn Parker-Joyes
//April 23 2018
//Hangman Game
//User presses button to guess a word. To win, they must enter the correct word into the textbox.



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

namespace HangmanGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   // the string word is the random word selected
        string word = "";
        int counter = 0;
        // int timeswrong goes up when a guess is wrong
        int timeswrong = 0;
        // int timesright goes up when a guess is right. 
        int timesright = 0;
        int length;
        public MainWindow()
        {
            InitializeComponent();
            System.IO.StreamReader streamReader = new System.IO.StreamReader("H:/hangman.txt");
            Random random = new Random();
            int rando = random.Next(0, 10);
            while (counter <= rando)
            {   // selects random word
                word = streamReader.ReadLine();
                counter++;

            }

            // finds length of word
            length = Convert.ToInt32(word.Length);

            //creates underscores for the length of word
            for (int i = 0; i <= length; i++)
            {
                lblWord.Content = lblWord.Content + "_ ";
            }

        }
        //method for the right or wrong system
        public void lblReplace(string x)
        {
            if (word.Contains(x))
            {
                for (int i = 0; i < length; i++)
                {
                    if (word[i] == x[0])
                    {
                        string underscore = lblWord.Content.ToString().Remove(i * 2 + 2, 1);
                        underscore = underscore.Insert((i + 1) * 2, x);
                        lblWord.Content = underscore;
                        timesright++;

                    }
                }
            }
            else
            {   // body becomes visible as the wrong answers happen. game ends when timeswrong is 7, so the whole body is visible before the game is lost
                timeswrong++;
                if (timeswrong == 1)
                {
                    head.Visibility = Visibility.Visible;

                }
                if (timeswrong == 2)
                {
                    head.Visibility = Visibility.Visible;
                    torso.Visibility = Visibility.Visible;

                }
                if (timeswrong == 3)
                {
                    head.Visibility = Visibility.Visible;
                    torso.Visibility = Visibility.Visible;
                    leftArm.Visibility = Visibility.Visible;

                }
                if (timeswrong == 4)
                {
                    head.Visibility = Visibility.Visible;
                    torso.Visibility = Visibility.Visible;
                    leftArm.Visibility = Visibility.Visible;
                    rightArm.Visibility = Visibility.Visible;

                }
                if (timeswrong == 5)
                {
                    head.Visibility = Visibility.Visible;
                    torso.Visibility = Visibility.Visible;
                    leftArm.Visibility = Visibility.Visible;
                    rightArm.Visibility = Visibility.Visible;
                    leftLeg.Visibility = Visibility.Visible;

                }
                if (timeswrong == 6)
                {
                    head.Visibility = Visibility.Visible;
                    torso.Visibility = Visibility.Visible;
                    leftArm.Visibility = Visibility.Visible;
                    rightArm.Visibility = Visibility.Visible;
                    leftLeg.Visibility = Visibility.Visible;
                    rightLeg.Visibility = Visibility.Visible;

                }
                if (timeswrong == 7)
                {
                    MessageBox.Show("You lose!");
                    Environment.Exit(0);
                }
            }
            if(timesright == length)
            {
                MessageBox.Show("You win!");
                Environment.Exit(0);
            }
        }

        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            btnA.Visibility = Visibility.Hidden;
            lblReplace("a");
        }

        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            btnB.Visibility = Visibility.Hidden;
            lblReplace("b");
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            btnC.Visibility = Visibility.Hidden;
            lblReplace("c");
        }

        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            btnD.Visibility = Visibility.Hidden;
            lblReplace("d");
        }

        private void btnE_Click(object sender, RoutedEventArgs e)
        {
            btnE.Visibility = Visibility.Hidden;
            lblReplace("e");
        }

        private void btnF_Click(object sender, RoutedEventArgs e)
        {
            btnF.Visibility = Visibility.Hidden;
            lblReplace("f");
        }

        private void btnG_Click(object sender, RoutedEventArgs e)
        {
            btnG.Visibility = Visibility.Hidden;
            lblReplace("g");
        }

        private void btnH_Click(object sender, RoutedEventArgs e)
        {
            btnH.Visibility = Visibility.Hidden;
            lblReplace("h");
        }

        private void btnI_Click(object sender, RoutedEventArgs e)
        {
            btnI.Visibility = Visibility.Hidden;
            lblReplace("i");
        }

        private void btnJ_Click(object sender, RoutedEventArgs e)
        {
            btnJ.Visibility = Visibility.Hidden;
            lblReplace("j");
        }

        private void btnK_Click(object sender, RoutedEventArgs e)
        {
            btnK.Visibility = Visibility.Hidden;
            lblReplace("k");
        }

        private void btnL_Click(object sender, RoutedEventArgs e)
        {
            btnL.Visibility = Visibility.Hidden;
            lblReplace("l");
        }

        private void btnM_Click(object sender, RoutedEventArgs e)
        {
            btnM.Visibility = Visibility.Hidden;
            lblReplace("m");
        }

        private void btnN_Click(object sender, RoutedEventArgs e)
        {
            btnN.Visibility = Visibility.Hidden;
            lblReplace("n");
        }

        private void btnO_Click(object sender, RoutedEventArgs e)
        {
            btnO.Visibility = Visibility.Hidden;
            lblReplace("o");
        }

        private void btnP_Click(object sender, RoutedEventArgs e)
        {
            btnP.Visibility = Visibility.Hidden;
            lblReplace("p");
        }

        private void btnQ_Click(object sender, RoutedEventArgs e)
        {
            btnQ.Visibility = Visibility.Hidden;
            lblReplace("q");
        }

        private void btnR_Click(object sender, RoutedEventArgs e)
        {
            btnR.Visibility = Visibility.Hidden;
            lblReplace("r");
        }

        private void btnS_Click(object sender, RoutedEventArgs e)
        {
            btnS.Visibility = Visibility.Hidden;
            lblReplace("s");
        }

        private void btnT_Click(object sender, RoutedEventArgs e)
        {
            btnT.Visibility = Visibility.Hidden;
            lblReplace("t");
        }

        private void btnU_Click(object sender, RoutedEventArgs e)
        {
            btnU.Visibility = Visibility.Hidden;
            lblReplace("u");
        }

        private void btnV_Click(object sender, RoutedEventArgs e)
        {
            btnV.Visibility = Visibility.Hidden;
            lblReplace("v");
        }

        private void btnW_Click(object sender, RoutedEventArgs e)
        {
            btnW.Visibility = Visibility.Hidden;
            lblReplace("w");
        }

        private void btnX_Click(object sender, RoutedEventArgs e)
        {
            btnX.Visibility = Visibility.Hidden;
            lblReplace("x");
        }

        private void btnY_Click(object sender, RoutedEventArgs e)
        {
            btnY.Visibility = Visibility.Hidden;
            lblReplace("y");
        }

        private void btnZ_Click(object sender, RoutedEventArgs e)
        {
            btnZ.Visibility = Visibility.Hidden;
            lblReplace("z");
        }
        //user can enter the answer here to end the game.
        private void btnGuessFinal_Click(object sender, RoutedEventArgs e)
        {
            if (guessFinal.Text == word)
            {
                MessageBox.Show("You Won!");
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("You Lose!");
                Environment.Exit(0);
            }
        }
    }
}
