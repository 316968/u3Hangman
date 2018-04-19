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

namespace u3Hangman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string word = "";
        int counter = 0;
        int timeswrong = 0;
        int length;
        public MainWindow()
        {
            InitializeComponent();
            System.IO.StreamReader streamReader = new System.IO.StreamReader("H:/hangman.txt");
            Random random = new Random();
            int rand = random.Next(0, 10);
            string rando = random.ToString();
            while(counter <= rand)
            {
                word = streamReader.ReadLine();
                counter++;
            }
            length = Convert.ToInt32(word.Length);
            for(int i = 0; i <= length; i++)
            {
                lblWord.Content = lblWord.Content + "_ ";
            }
        }
        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            word = txtInput.Text.ToLower();
            lblLetters.Text.Replace(word, "");
            // in the future... index of random, compare to input, and replace underscore with letter? 
            
        }
        public void replaceLbl(string x)
        {
            if (word == x)
            {
                for(int i = 0; i < length; i++)
                {
                    string addUnderscores = lblWord.Content.ToString().Remove(i * 2 + 2, 1);
                    addUnderscores = addUnderscores.Insert((i + 1) * 2, x);
                    lblWord.Content = addUnderscores;
                }
            }
            else
            {
                timeswrong++;
                head.Visibility = Visibility.Visible;
                if(timeswrong == 2)
                {
                    torso.Visibility = Visibility.Visible;
                }
                if(timeswrong == 3)
                {
                    leftArm.Visibility = Visibility.Visible;
                }
                if(timeswrong == 4)
                {
                    rightArm.Visibility = Visibility.Visible;
                }
                if(timeswrong == 5)
                {
                    leftLeg.Visibility = Visibility.Visible;
                }
                if(timeswrong == 6)
                {
                    rightLeg.Visibility = Visibility.Visible;
                }
                if(timeswrong == 7)
                {
                    MessageBox.Show("You lose!");
                    Environment.Exit(0);
                }
            }
        }       
    }
}
