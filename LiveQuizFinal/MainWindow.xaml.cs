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
        
        Quiz quiz = new Quiz();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // check for empty txtbox
            if(txt_QuizName.Text == "")
            {
                MessageBox.Show("Please fill in the text box to create a quiz.");
            }
            else
            {
                quiz.QuizName = txt_QuizName.Text;
                // next step sent name of quiz to data base.
                
                // open Question Window
                QuestionsWindow questionsWindow = new QuestionsWindow();
                questionsWindow.Show();
            }

        }
    }
}
