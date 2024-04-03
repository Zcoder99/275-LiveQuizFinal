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
using SqlServerLibrary.Context;

namespace QuizTakerApp
{
    /// <summary>
    /// Interaction logic for TestControle.xaml
    /// </summary>
    public partial class TestControl : UserControl
    {
        public int QuestionId { get; set; }
        public TestControl()
        {
            InitializeComponent();
        }
        // use then include in linq query to get the quiz and Questions and answers


    }
}
