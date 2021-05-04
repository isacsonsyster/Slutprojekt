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
        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        int qnum = 0;

        int i;

        int score;

        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();

        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if(senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if(qnum < 0)
            {
                qnum = 0;
            }
            else
            {
                qnum++;
            }
            scoreText.Content = "Answered correctly " + score + "/" + questionNumbers.Count;

            NextQuestion();
        }

        private void RestartGame()
        {
            score = 0;
            qnum = -1;
            i = 0;
            StartGame();

        }

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

            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.White;
            }

            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Question 1 ";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    break;

                case 2:

                    txtQuestion.Text = "Question 2 ";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    break;

                case 3:

                    txtQuestion.Text = "Question 3 ";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4 Correct";

                    ans4.Tag = "1";

                    break;

                case 4:

                    txtQuestion.Text = "Question 4 ";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3 Correct";
                    ans4.Content = "Answer 4";

                    ans3.Tag = "1";

                    break;

                case 5:

                    txtQuestion.Text = "Question 5 ";

                    ans1.Content = "Answer 1 Correct";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans1.Tag = "1";

                    break;

                case 6:

                    txtQuestion.Text = "Question 6 ";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3 Correct";
                    ans4.Content = "Answer 4";

                    ans3.Tag = "1";

                    break;

                case 7:

                    txtQuestion.Text = "Question 7 ";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    break;

                case 8:

                    txtQuestion.Text = "Question 8 ";

                    ans1.Content = "Answer 1 Correct";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3";
                    ans4.Content = "Answer 4";

                    ans3.Tag = "1";

                    break;

                case 9:

                    txtQuestion.Text = "Question 9 ";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2 Correct";
                    ans3.Content = "Answer 3 ";
                    ans4.Content = "Answer 4";

                    ans2.Tag = "1";

                    break;

                case 10:

                    txtQuestion.Text = "Question 10 ";

                    ans1.Content = "Answer 1";
                    ans2.Content = "Answer 2";
                    ans3.Content = "Answer 3 ";
                    ans4.Content = "Answer 4 Correct";

                    ans4.Tag = "1";

                    break;

            }
        }

        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;

            questionOrder.Content = null;

            for(int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();

            }

        }
    }
}
