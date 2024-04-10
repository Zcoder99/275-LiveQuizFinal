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

namespace QuizTakerApp
{
    /// <summary>
    /// Interaction logic for QuizScoreControle.xaml
    /// </summary>
    public partial class QuizScoreControle : UserControl
    {
        public int Score{ get; set; }        
        public QuizScoreControle()
        {
            InitializeComponent();         
        }
        
        public void UpdateScoreDisplay(TestLiveQuiz liveQuiz)
        {
            //Count the number of questions in the quiz
            int totalQuestions = liveQuiz.SelectedQuiz.Questions.Count;
            ScoreTxtBlock.Text = $"You scored {TestLiveQuiz.totalCorrectAnswers} out of {totalQuestions}"; // Update the score text
        }

        private void tst_Click(object sender, RoutedEventArgs e)
        {
            ScoreTxtBlock.Text = $"You scored {TestLiveQuiz.totalCorrectAnswers} out of "; // Update the score text
        }
    }
}
