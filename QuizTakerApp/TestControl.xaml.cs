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
using SqlServerLibrary;
using SqlServerLibrary.Context;

namespace QuizTakerApp
{
    /// <summary>
    /// Interaction logic for TestControle.xaml
    /// </summary>
    public partial class TestControl : UserControl
    {
        private Question question;

        public int QuestionId { get; set; }
        public string QuestionText
        {
            get { return QuestionTxtBolck.Text; }
            set { QuestionTxtBolck.Text = value; }
        }
        public TestControl(Question Question)
        {
            InitializeComponent();
            this.question = Question;
            // set the question text
            QuestionTxtBolck.Text = question.QuestionText;

            // Check if the question is multiple choice or True/False
            // Check if the question is multiple choice or True/False          
            if (question.IsMultipleChoice)
            { 
                // if multiple choice == 0 skip this generation of radio buttons
                
                // loop through the answers and add them to the radio buttons
                foreach (var answer in question.Answers)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Content = answer.AnswerText;
                    radioButton.GroupName = "Answers";
                    AnswersStackPanel.Children.Add(radioButton);
                }
            }else if (question.IsTrueFalse)
            {
                // Generate 2 radio buttons for True/False
                RadioButton rb_True = new RadioButton();
                RadioButton rb_False = new RadioButton();
                // Set the content of the radio buttons
                rb_True.Content = "True";
                rb_False.Content = "False";                
            }          
        }

        private void Button_Click(object sender, RoutedEventArgs e) 
        {
            // save the answer in a var and check if it is correct

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }


        // use then include in linq query to get the quiz and Questions and answers


    }
}
