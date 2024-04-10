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
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using SqlServerLibrary;
using SqlServerLibrary.Context;
using SqlServerLibrary.QuizClasses;

namespace QuizTakerApp
{
    /// <summary>
    /// Interaction logic for TestControle.xaml
    /// </summary>
    public partial class TestControl : UserControl
    {              
        private readonly Question _question;
        
        public TestControl(Question Question)
        {
            InitializeComponent();
            _question = Question;
            QuestionText = _question.QuestionText; // Set the question text
            AddRadioBtns();
        }

        public string QuestionText
        {
            // Get and set the question text
            get => QuestionTxtBolck.Text;
            set => QuestionTxtBolck.Text = value;
        }

        private void AddRadioBtns()
        {
            // Retrieve the answers associated with the current question
            var answers = _question.Answers;
            if (answers == null) return;

            foreach (var answer in answers) // Loop through the answers
            {
                var radioButton = CreateRadioButton(answer.AnswerText); // Create a radio button for each answer
                AnswersStackPanel.Children.Add(radioButton); // Add the radio button to the stack panel
            }
        }       

        private RadioButton CreateRadioButton(string content)
        {
            var radioButton = new RadioButton
            {
                Content = content,
                GroupName = "Answers",
                Foreground = Brushes.White
            };
            radioButton.Click += RB_answerCorrect_Event;
            return radioButton;
        }
        
        private void RB_answerCorrect_Event(object sender, RoutedEventArgs e)
        {
            var radioButton = (RadioButton)sender;
            string selectedAnswerText = radioButton.Content.ToString();

            // Find the selected question from the quiz
            var quiznessLayer = new QuiznessLayer();
            var questionWithAnswers = quiznessLayer.GetQuizWithQuestionsAndAnswers()
                .SelectMany(q => q.Questions)
                .FirstOrDefault(q => q.Id == _question.Id);

            if (questionWithAnswers == null) return;

            // Retrieve the selected answer from the question's answers
            var selectedAnswer = questionWithAnswers.Answers.FirstOrDefault(a => a.AnswerText == selectedAnswerText);

            // Check if the selected answer is correct
            if (selectedAnswer != null && selectedAnswer.CorrectAnswer)
            {
                // Increment totalCorrectAnswers
                TestLiveQuiz.totalCorrectAnswers++;
            }
        }
    }
}
