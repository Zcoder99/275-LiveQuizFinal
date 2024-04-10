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
       
        //private int correctAnswerCount; // Track count of correct answers
        public event EventHandler AnswerCorrect;
        private Question question;
        //public int QuestionId { get; set; }
        public TestControl(Question Question)
        {
            InitializeComponent();
            this.question = Question;
            // set the question text
            QuestionTxtBolck.Text = question.QuestionText;

            AddRadioBtns();
        }

        public string QuestionText
        {
            get { return QuestionTxtBolck.Text; }
            set { QuestionTxtBolck.Text = value; }
        }       

        private void AddRadioBtns()
        {
            // Check if the question is multiple choice or True/False  
            if (question.IsMultipleChoice)
            {
                // loop through the answers and add them to the radio buttons
                foreach (var answer in question.Answers)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Content = answer.AnswerText;
                    radioButton.GroupName = "Answers";
                    radioButton.Foreground = Brushes.White;
                    radioButton.Click += RB_answerCorrect_Event;
                    AnswersStackPanel.Children.Add(radioButton);
                }
            }
            else if (question.IsTrueFalse)
            {
                // Generate 2 radio buttons for True/False
                RadioButton rb_True = new RadioButton();
                RadioButton rb_False = new RadioButton();
                // Set the content of the radio buttons
                rb_True.Content = "True";
                rb_False.Content = "False";
                // Set the group name of the radio buttons
                rb_True.GroupName = "Answers";
                rb_False.GroupName = "Answers";
                rb_True.Foreground = Brushes.White;
                rb_False.Foreground = Brushes.White;
                // Add event handlers to the radio buttons
                rb_False.Click += Rb_False_Click;
                rb_True.Click += Rb_True_Click;
                // Add the radio buttons to the stack panel
                AnswersStackPanel.Children.Add(rb_True);
                AnswersStackPanel.Children.Add(rb_False);
            }
        }

        private void Rb_True_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string selectedAnswerText = radioButton.Content.ToString();
            Answer selectedAnswer = question.Answers.FirstOrDefault(a => a.AnswerText == selectedAnswerText);
            if(selectedAnswer.CorrectAnswer)
            {
               TestLiveQuiz.totalCorrectAnswers++;
            }
            
        }

        private void Rb_False_Click(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string selectedAnswerText = radioButton.Content.ToString();
            Answer selectedAnswer = question.Answers.FirstOrDefault(a => a.AnswerText == selectedAnswerText);
            if (selectedAnswer.CorrectAnswer)
            {
                TestLiveQuiz.totalCorrectAnswers++;
            }
        }

        
        private void RB_answerCorrect_Event(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string selectedAnswerText = radioButton.Content.ToString();
            Answer selectedAnswer = question.Answers.FirstOrDefault(a => a.AnswerText == selectedAnswerText);
            if (selectedAnswer.CorrectAnswer)
            {
                TestLiveQuiz.totalCorrectAnswers++;
            }
        }
    }
}
