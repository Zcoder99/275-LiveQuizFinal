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
using SqlServerLibrary;

namespace LiveQuizFinal
{
    /// <summary>
    /// Interaction logic for AnswersWindow.xaml
    /// </summary>
    public partial class AnswersWindow : Window
    {
        private int questionId; // Store reference to the quiz

        public AnswersWindow(int questionId) 
        {
            InitializeComponent();
            this.questionId = questionId; // Assign the passed quiz object to the local variable
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtAnswer.Text == "") // Check if the answer text is empty
            {
                MessageBox.Show("Please enter a question");
                return;
            }

            string answerText = txtAnswer.Text; // Get the answer text

            Answer.SaveToAnswersList(answerText, questionId); // Save the answer to the database

            MessageBox.Show("Answer added to the question"); // Provide feedback to the user

            txtAnswer.Text = ""; // Clear the text box
        }
    }
}
