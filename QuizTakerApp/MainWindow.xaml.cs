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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizTakerApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Quiz> Quizzes { get; set; }
        QuiznessLayer quiznessLayer = new QuiznessLayer();
        public MainWindow()
        {
            InitializeComponent();
            
            Quizzes = new List<Quiz>();

            // Call GetQuizNames and display them in lstQuizList listbox
            foreach (var quiz in quiznessLayer.GetQuizWithQuestionsAndAnswers())
            {
                //lstQuizList.Items.Add(quiz);
                Quizzes.Add(quiz);

            }
            lstQuizList.ItemsSource = Quizzes;

            
            //foreach (var quiz in quizzes)
            //{
            //    var quizItem = new TreeViewItem();
            //    quizItem.Header = quiz.QuizName;
            //    foreach (var question in quiz.Questions)
            //    {
            //        var questionItem = new TreeViewItem();
            //        questionItem.Header = question.QuestionText;
            //        foreach (var answer in question.Answers)
            //        {
            //            var answerItem = new TreeViewItem();
            //            answerItem.Header = answer.AnswerText;
            //            questionItem.Items.Add(answerItem);
            //        }
            //        quizItem.Items.Add(questionItem);
            //    }
            //    treeView.Items.Add(quizItem);
            //}
        }

        private void lstQuizList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Quiz quiz = (Quiz)lstQuizList.SelectedItem;
            TestLiveQuiz testLiveQuiz = new TestLiveQuiz(quiz);
            testLiveQuiz.Show();

        }

       
    }
}
