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
using SqlServerLibrary.QuizClasses;

namespace LiveQuizFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {                      
            if (txt_QuizName.Text == "")// check for empty txtbox
            {
                MessageBox.Show("Please fill in the text box to create a quiz.");
                return;
            }
            else
            {
                Quiz quiz = new Quiz();
                // save the quiz name to the database
                quiz.QuizName = txt_QuizName.Text;
                quiz.CreateDate = DateTime.Now; // get the date it was created
                quiz.SaveToDatabase(quiz);

                // Open QuestionsWindow and pass the quiz object
                QuestionsWindow questionsWindow = new QuestionsWindow(quiz);
                questionsWindow.Owner = this;
                questionsWindow.Show();
            }

        }
    }
}
