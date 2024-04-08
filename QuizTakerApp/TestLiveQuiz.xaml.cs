using MaterialDesignThemes.Wpf.Transitions;
using SqlServerLibrary;
using SqlServerLibrary.QuizClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuizTakerApp
{
    /// <summary>
    /// Interaction logic for TestLiveQuiz.xaml
    /// </summary>
    public partial class TestLiveQuiz : Window
    {
        // Track the current test control index
        private int currentIndex = 0;
        public Quiz SelectedQuiz { get; set; } // access to selected quiz

        private int totalCorrectAnswers = 0; // track the number of correct answers

        public TestLiveQuiz(Quiz selectedQuiz)
        {
            InitializeComponent();
            SelectedQuiz = selectedQuiz; // set the selected quiz

            // loop through the questions in the selected quiz
            foreach (var question in SelectedQuiz.Questions)
            {                               
                // create a new instance of the TestControl
                TestControl questionControl = new TestControl(question);
                 
                var slide = new TransitionerSlide() // create a new instance of the TransitionerSlide
                {
                    Content = questionControl, // set the content of the slide to the TestControl                  
                };
               
                // get the test of the current question
                questionControl.QuestionText = question.QuestionText;

                // Subscribe to the AnswerCorrect event
                questionControl.AnswerCorrect += QuestionControl_AnswerCorrect;
                questionControl.CorrectAnswerCountChanged += (sender, count) => UpdateScore(count);
                // add the testcontrol to the first row of the grid
                Grid.SetRow(slide, 0);

                // Add the transitionerSlide to the transitioner                
                TransitionerControl.Items.Add(slide);
            }

            // new insctance of the QuizScoreControle
            QuizScoreControle quizScoreControle = new QuizScoreControle();

            // Add the QuizScoreControle to the First row of the grid
            Grid.SetRow(quizScoreControle, 0);

            var ScoreSlide = new TransitionerSlide()
            {
                Content = quizScoreControle
            };
            
            // add the score slide to always be the last slide
            TransitionerControl.Items.Add(ScoreSlide);

            // display the score slide last
            TransitionerControl.SelectedIndex = TransitionerControl.Items.Count - 1;

            // Display the first question
            TransitionerControl.SelectedIndex = 0;            
        }

        private void UpdateScore(int count)
        {
            totalCorrectAnswers = count;
            // Update the score in the QuizScoreControle
            QuizScoreControle.Score = totalCorrectAnswers;
        }

        // Event handler for the AnswerCorrect event
        private void QuestionControl_AnswerCorrect(object? sender, EventArgs e)
        {
            // Increment the correct answer count
            QuizScoreControle.Score++;
            UpdateScore(totalCorrectAnswers);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {                        
            // Check for previos TestControl instances
            if (currentIndex > 0)
            {
                TransitionerControl.SelectedIndex = --currentIndex;
            }
            else
            {
                // Display a message box to the user
                System.Windows.MessageBox.Show("you are at the start of the quiz");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Check if there are more TestControl instances available
            if (currentIndex < SelectedQuiz.Questions.Count - 1)
            {
                TransitionerControl.SelectedIndex = ++currentIndex;
            }
            else
            {
                // Display a message box to the user
                TransitionerControl.SelectedIndex = TransitionerControl.Items.Count - 1;
            }


        }
    }
}
