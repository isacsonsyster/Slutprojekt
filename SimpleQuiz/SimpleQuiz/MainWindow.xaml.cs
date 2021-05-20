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

namespace SimpleQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //show the questionsorder 
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        //variabler
        int qnum = 0;

        int i;

        int score;

        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();

        }

        //this method check if the answer is correct, if it is correct it adds one on the total score. 
        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if(senderButton.Tag.ToString() == "1") //the value of the button with the correct answer is 1. So if the button value is 1, it adds 1 point on the score
            {
                score++;
            }

            if(qnum < 0) //the current question number. 
            {
                qnum = 0;
            }
            else
            {
                qnum++;
            }
            scoreText.Content = "Answered correctly " + score + "/" + questionNumbers.Count; //writes out the score. 

            NextQuestion();
        }

        //this method restarts the game. It resets all values. 
        private void RestartGame() 
        {
            score = 0;
            qnum = -1;
            i = 0;
            StartGame();

        }

        //this method goes to the next question. 
        private void NextQuestion()
        {
            if (qnum < questionNumbers.Count)
            {
                i = questionNumbers[qnum];
            }
            else
            {
                RestartGame();
            }

            //sets the button value to zero 
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.White;
            }
            //The questions
            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Vad heter Ester i efternamn? ";

                    ans1.Content = "Isacson";
                    ans2.Content = "Larsson";
                    ans3.Content = "Karlsson";
                    ans4.Content = "Svensson";

                    ans1.Tag = "1"; //sets answer 1 to the correct one. 

                    break;

                case 2:

                    txtQuestion.Text = "Vilken är Esters favoritfärg?";

                    ans1.Content = "Blå";
                    ans2.Content = "Gul";
                    ans3.Content = "Grön";
                    ans4.Content = "Röd";

                    ans2.Tag = "1";

                    break;

                case 3:

                    txtQuestion.Text = "När fyller Ester år?";

                    ans1.Content = "21 Oktober";
                    ans2.Content = "17 Januari";
                    ans3.Content = "3 Aug";
                    ans4.Content = "1 Juli";

                    ans4.Tag = "1";

                    break;

                case 4:

                    txtQuestion.Text = "Vad vill Ester utbilda sig till?";

                    ans1.Content = "Civilingengör";
                    ans2.Content = "Läkare";
                    ans3.Content = "Psykoterapeut";
                    ans4.Content = "Musiklärare";

                    ans3.Tag = "1";

                    break;

                case 5:

                    txtQuestion.Text = "Var är Ester född";

                    ans1.Content = "Uppsala";
                    ans2.Content = "Göteborg";
                    ans3.Content = "Mölndal";
                    ans4.Content = "Örebro";

                    ans1.Tag = "1";

                    break;

                case 6:

                    txtQuestion.Text = "Vilken sport har Ester inte gått i? ";

                    ans1.Content = "Ju Jutsu";
                    ans2.Content = "Ballet";
                    ans3.Content = "Handboll";
                    ans4.Content = "Drill";

                    ans3.Tag = "1";

                    break;

                case 7:

                    txtQuestion.Text = "Vilket instrument kan Ester inte spela?";

                    ans1.Content = "Piano";
                    ans2.Content = "Fiol";
                    ans3.Content = "Gitarr";
                    ans4.Content = "Ukulele";

                    ans2.Tag = "1";

                    break;

                case 8:

                    txtQuestion.Text = "Hur många systrar har Ester?";

                    ans1.Content = "3";
                    ans2.Content = "2";
                    ans3.Content = "1";
                    ans4.Content = "4";

                    ans1.Tag = "1";

                    break;

                case 9:

                    txtQuestion.Text = "Vad heter Ester i mellannamn?";

                    ans1.Content = "Felicia Virginia";
                    ans2.Content = "Christina Maria";
                    ans3.Content = "Annica Benedikta";
                    ans4.Content = "Hulda Carolina";

                    ans4.Tag = "1";

                    break;

                case 10:

                    txtQuestion.Text = "Vilket är Esters favoritämne?";

                    ans1.Content = "Idrott";
                    ans2.Content = "Matte";
                    ans3.Content = "Kemi";
                    ans4.Content = "Svenska";

                    ans4.Tag = "1";

                    break;

            }
        }

        //This method starts the game
        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList; //randomize the order of the questions

            questionOrder.Content = null;

            for(int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString(); //Counts which question you are on. 

            }

        }
    }
}
