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
        public static int Score { get; set; }
        public QuizScoreControle()
        {
            InitializeComponent();
            Score = 0;
            UpdateScoreDisplay();
        }
        
        public void UpdateScoreDisplay()
        {
            ScoreTxtBlock.Text = $"You scored {Score} out of "; // Update the score text
        }
    }
}
