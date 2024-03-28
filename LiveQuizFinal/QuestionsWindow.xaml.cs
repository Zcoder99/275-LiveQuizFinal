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
        public QuestionsWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // open a page to create answers for the question 
        }


        private void btn_AddQuestion_Click(object sender, RoutedEventArgs e)
        {
            // get text from text box save to db
            // display in the 
        }
        private void btn_SaveToQuiz_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
