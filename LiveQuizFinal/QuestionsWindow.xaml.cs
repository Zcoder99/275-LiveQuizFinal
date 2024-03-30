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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LiveQuizFinal
{
    /// <summary>
    /// Interaction logic for QuestionsWindow.xaml
    /// </summary>
    public partial class QuestionsWindow : Window
    {
        private Quiz quiz;// Store reference to the quiz
        public QuestionsWindow(Quiz quiz)
        {
            InitializeComponent();
            this.quiz = quiz; // Assign the passed quiz object to the local variable
        }

        private void btn_AddQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (txt_Question.Text == "")
            {
                MessageBox.Show("Please enter a question");
                return;
            }
            else
            {
                string questionText = txt_Question.Text;

                // passing the quiz id instead of the quiz object
                new Question().SaveToQuestionsList(questionText, quiz.Id); 
               
                // provide feedback to the user
                MessageBox.Show("Question added to the quiz");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // open a page to create answers for the question 
            Question question = new Question();
            AnswersWindow answersWindow = new AnswersWindow(question);
            answersWindow.Show();
        }

    }
}
