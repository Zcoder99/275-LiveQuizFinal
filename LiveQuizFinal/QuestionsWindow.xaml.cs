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

        private void Btn_Accept_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateQuestion())
                return;                       

            // Set question properties based on radio button selection
            string questionText = txtbox_Question.Text;

            // Determine question type based on radio button selection
            bool isTrueFalse = Rdo_Btn_TorF.IsChecked == true;
            bool isMultipleChoice = Rdo_Btn_MultiChoice.IsChecked == true;

            // Save the question to the database
            int questionId = Question.SaveToQuestionsList(questionText, quiz.Id, isTrueFalse, isMultipleChoice);

            if (questionId != -1) // Check if the question was added to the database
            {               
                txtbox_Question.Text = "";           
                
                OpenAnswersWindow(questionId); // Open the AnswersWindow

                lst_Questions.Items.Add(questionText);
            }
            else
            {
                MessageBox.Show("Error adding question to the quiz");
            }
        }
        // Open the dialog box
        private void btn_TestAddQuestion_Click(object sender, RoutedEventArgs e)
        {
            btn_Accept.IsEnabled = true;
        }

        // Close the dialog box
        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            diolog_ListQuestions.IsOpen = false;
        }

        // Validate the question
        private bool ValidateQuestion()
        {
            if (string.IsNullOrWhiteSpace(txtbox_Question.Text))
            {
                MessageBox.Show("Please enter a question");
                return false;
            }

            if (Rdo_Btn_TorF.IsChecked == false && Rdo_Btn_MultiChoice.IsChecked == false)
            {
                MessageBox.Show("Please select a question type");
                return false;
            }
            return true;
        }

        // Open the AnswersWindow
        private void OpenAnswersWindow(int questionId)
        {
            AnswersWindow answersWindow = new AnswersWindow(questionId);
            answersWindow.Owner = this;
            answersWindow.Show();
        }
    }
}

