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
using SqlServerLibrary.QuizClasses;

namespace LiveQuizFinal
{
    /// <summary>
    /// Interaction logic for AnswersWindow.xaml
    /// </summary>
    public partial class AnswersWindow : Window
    {
        private Question question; // Store reference to the quiz

        public AnswersWindow(Question question)
        {
            InitializeComponent();
            this.question = question; // Assign the passed quiz object to the local variable
        }

        
    }
}
