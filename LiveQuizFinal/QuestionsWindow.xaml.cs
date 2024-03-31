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
            if (txt_Question.Text == "") // Check if the question text is empty
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

            int questionId = Question.SaveToQuestionsList(questionText, quiz.Id, isTrueFalse, isMultipleChoice);

            if (questionId != -1) // Check if the question was added to the database
            {
                // Provide feedback to the user
                MessageBox.Show("Question added to the quiz");
                // Clear the text box
                txt_Question.Text = "";
                // if True or False is selected dont open the answer window
                if (isTrueFalse)
                {
                    // provide feedback to the user that t or f questions do not require answers
                    MessageBox.Show("True or False questions do not require answers");
                    return;
                }
                else if (isMultipleChoice)
                {
                    AnswersWindow answersWindow = new AnswersWindow(questionId); // Create a new instance of the AnswersWindow class
                    answersWindow.Show();
                }
            }
            else
            {
                MessageBox.Show("Error adding question to the quiz");
            }
        }

        
    }
}

