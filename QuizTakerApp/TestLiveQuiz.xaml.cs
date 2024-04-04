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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuizTakerApp
{
    /// <summary>
    /// Interaction logic for TestLiveQuiz.xaml
    /// </summary>
    public partial class TestLiveQuiz : Window
    {
        public Quiz SelectedQuiz { get; set; } // access to selected quiz

        public TestLiveQuiz(Quiz selectedQuiz)
        {
            InitializeComponent();
            SelectedQuiz = selectedQuiz;

            foreach (var question in SelectedQuiz.Questions)
            {
                // create a new instance of the TestControl
                TestControl questionControl = new TestControl(question);
                // add the controle to the stackpanel
                QuestionsContainer.Children.Add(questionControl);
                // get the test of the current question
                questionControl.QuestionText = question.QuestionText;
            }
        }
    }
}
