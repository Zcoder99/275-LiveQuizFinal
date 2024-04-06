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
using MaterialDesignThemes.Wpf.Transitions;
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
                // loop through the answers and add them to the radio buttons
                foreach (var answer in question.Answers)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Content = answer.AnswerText;
                    radioButton.GroupName = "Answers";
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
                // Add the radio buttons to the stack panel
                AnswersStackPanel.Children.Add(rb_True);
                AnswersStackPanel.Children.Add(rb_False);
            }
        }
    }
}
