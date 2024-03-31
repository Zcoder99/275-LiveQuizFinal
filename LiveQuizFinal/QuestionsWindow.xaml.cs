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

            // Check if a radio button is checked
            if (Rdo_Btn_TorF.IsChecked == false && Rdo_Btn_MultiChoice.IsChecked == false)
            {
                MessageBox.Show("Please select a question type");
                return;
            }
            // Determine question type based on radio button selection
            bool isTrueFalse = Rdo_Btn_TorF.IsChecked == true;
            bool isMultipleChoice = Rdo_Btn_MultiChoice.IsChecked == true;

            // Set question properties based on radio button selection
            string questionText = txt_Question.Text;        

            Question.SaveToQuestionsList(questionText, quiz.Id, isTrueFalse, isMultipleChoice);

            // Provide feedback to the user
            MessageBox.Show("Question added to the quiz");
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

